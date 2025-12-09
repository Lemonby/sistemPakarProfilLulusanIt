Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class ExpertSystemEngine
    ' Struktur data untuk menyimpan Rule
    Public Structure Rule
        Dim Code As String
        Dim Antecedent As String
        Dim Consequent As String
        Dim CFPakar As Double
    End Structure

    ' Menyimpan fakta dari user (Kode Fakta -> Nilai CF User)
    Private UserFacts As New Dictionary(Of String, Double)

    ' Menyimpan daftar Rules
    Private Rules As New List(Of Rule)

    ' 1. Load Rules dari Database
    Public Sub LoadRules()
        Rules.Clear()
        Using conn As MySqlConnection = GetConnection()
            Dim cmd As New MySqlCommand("SELECT * FROM tb_rules", conn)
            Using rd As MySqlDataReader = cmd.ExecuteReader()
                While rd.Read()
                    Rules.Add(New Rule With {
                        .Code = rd("kode_rule").ToString(),
                        .Antecedent = rd("antecedent").ToString(),
                        .Consequent = rd("consequent").ToString(),
                        .CFPakar = Convert.ToDouble(rd("cf_pakar"))
                    })
                End While
            End Using
        End Using
    End Sub

    ' 2. Set Jawaban User
    Public Sub SetUserFact(factCode As String, cfValue As Double)
        If UserFacts.ContainsKey(factCode) Then
            UserFacts(factCode) = cfValue
        Else
            UserFacts.Add(factCode, cfValue)
        End If
    End Sub

    ' 3. Proses Utama: INFERENSI
    Public Function RunInference() As Dictionary(Of String, Double)
        Dim profileCFs As New Dictionary(Of String, Double)

        For Each r In Rules
            ' Hitung CF Premis (Bagian IF)
            Dim cfPremise As Double = EvaluateAntecedent(r.Antecedent)

            ' Jika premis terpenuhi (CF > 0)
            If cfPremise > 0 Then
                ' Rumus: CF[H,E] = CF[E] * CF[Rule]
                Dim cfResult As Double = cfPremise * r.CFPakar

                ' Kombinasi CF (Sequential CF)
                ' CF_New = CF_Old + CF_Result * (1 - CF_Old)
                If profileCFs.ContainsKey(r.Consequent) Then
                    Dim cfOld As Double = profileCFs(r.Consequent)
                    profileCFs(r.Consequent) = cfOld + cfResult * (1 - cfOld)
                Else
                    profileCFs.Add(r.Consequent, cfResult)
                End If
            End If
        Next

        Return profileCFs
    End Function

    ' 4. Parser Logika (Mengubah string "(A OR B) AND C" menjadi nilai Double)
    Private Function EvaluateAntecedent(expression As String) As Double
        ' Bersihkan spasi berlebih
        Dim expr As String = expression.Trim()

        ' Langkah 1: Selesaikan tanda kurung () secara rekursif
        While expr.Contains("(")
            ' Regex untuk mengambil isi kurung terdalam
            Dim match As Match = Regex.Match(expr, "\(([^()]+)\)")
            If match.Success Then
                Dim innerResult As Double = EvaluateSimpleLogic(match.Groups(1).Value)
                ' Ganti (A OR B) dengan nilai hasilnya
                expr = expr.Replace(match.Value, innerResult.ToString(System.Globalization.CultureInfo.InvariantCulture))
            End If
        End While

        ' Langkah 2: Selesaikan sisa logika
        Return EvaluateSimpleLogic(expr)
    End Function

    ' Evaluasi logika sederhana tanpa kurung (Prioritas AND lalu OR)
    Private Function EvaluateSimpleLogic(simpleExpr As String) As Double
        ' Logika CF:
        ' A AND B => Min(A, B)
        ' A OR B  => Max(A, B)

        ' Pisahkan berdasarkan OR terlebih dahulu (karena AND harus dihitung duluan dalam hierarki eksekusi)
        ' Tapi dalam CF standard: Max(Min(group1), Min(group2))

        Dim orParts As String() = simpleExpr.Split(New String() {" OR "}, StringSplitOptions.RemoveEmptyEntries)
        Dim maxVal As Double = 0

        For Each part In orParts
            ' Di dalam setiap bagian OR, ada kemungkinan AND
            Dim andParts As String() = part.Split(New String() {" AND "}, StringSplitOptions.RemoveEmptyEntries)
            Dim minVal As Double = 1.0 ' Nilai awal min harus 1 (tertinggi)

            For Each subPart In andParts
                Dim factCode As String = subPart.Trim()
                Dim factVal As Double = 0

                ' Cek apakah ini angka hasil evaluasi sebelumnya atau kode fakta
                If IsNumeric(factCode) Then
                    factVal = Double.Parse(factCode, System.Globalization.CultureInfo.InvariantCulture)
                Else
                    ' Ambil nilai dari jawaban user
                    If UserFacts.ContainsKey(factCode) Then
                        factVal = UserFacts(factCode)
                    Else
                        factVal = 0 ' Default jika tidak dijawab
                    End If
                End If

                ' Logika AND = Min
                minVal = Math.Min(minVal, factVal)
            Next

            ' Logika OR = Max
            maxVal = Math.Max(maxVal, minVal)
        Next

        Return maxVal
    End Function
End Class
