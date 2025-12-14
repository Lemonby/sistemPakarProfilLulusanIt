Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class formSoal

    ' Konfigurasi Pagination
    Private CurrentPage As Integer = 1
    Private PageSize As Integer = 5
    Private TotalQuestions As Integer = 0
    Private TotalPages As Integer = 0

    ' Struktur Data Pertanyaan
    Private Structure QuestionItem
        Dim Code As String
        Dim Text As String
        Dim Category As String
    End Structure

    ' Struktur Data Pilihan Jawaban (Bobot)
    Private Structure ChoiceItem
        Dim Text As String
        Dim Value As Double
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Structure

    Private AllQuestions As New List(Of QuestionItem)
    Private AllChoices As New List(Of ChoiceItem)

    ' Dictionary untuk menyimpan jawaban sementara (KodeFakta -> NilaiCF)
    Private TempAnswers As New Dictionary(Of String, Double)

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReferenceData() ' Load pertanyaan & opsi jawaban
        LoadPage()          ' Tampilkan halaman 1
    End Sub

    ' 1. Load Data dari Database
    Private Sub LoadReferenceData()
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            ' A. Ambil Daftar Pertanyaan
            Dim cmdQ As New MySqlCommand("SELECT * FROM tb_fakta ORDER BY kodeFakta ASC", conn)
            Using rd As MySqlDataReader = cmdQ.ExecuteReader()
                AllQuestions.Clear()
                While rd.Read()
                    AllQuestions.Add(New QuestionItem With {
                        .Code = rd("kodeFakta").ToString(),
                        .Text = rd("pertanyaan").ToString(),
                        .Category = rd("kategori").ToString()
                    })
                End While
            End Using

            TotalQuestions = AllQuestions.Count
            TotalPages = Math.Ceiling(TotalQuestions / PageSize)

            ' B. Ambil Daftar Pilihan Jawaban (Bobot CF)
            Dim cmdC As New MySqlCommand("SELECT * FROM tb_bobot_cf ORDER BY nilaiCf ASC", conn)
            Using rd As MySqlDataReader = cmdC.ExecuteReader()
                AllChoices.Clear()
                While rd.Read()
                    AllChoices.Add(New ChoiceItem With {
                        .Text = rd("keterangan").ToString(),
                        .Value = Convert.ToDouble(rd("nilaiCf"))
                    })
                End While
            End Using
        End Using
    End Sub

    ' 2. Menampilkan Halaman Soal
    Private Sub LoadPage()
        PanelSoal.Controls.Clear() ' PanelSoal adalah FlowLayoutPanel atau Panel biasa di Form Designer
        PanelSoal.AutoScroll = True

        Dim startIndex As Integer = (CurrentPage - 1) * PageSize
        Dim endIndex As Integer = Math.Min(startIndex + PageSize - 1, TotalQuestions - 1)

        Dim yPos As Integer = 10

        For i As Integer = startIndex To endIndex
            Dim q As QuestionItem = AllQuestions(i)

            ' A. Label Pertanyaan
            Dim lbl As New Label With {
                .Text = $"{i + 1}. {q.Text}",
                .AutoSize = True,
                .MaximumSize = New Size(PanelSoal.Width - 40, 0),
                .Location = New Point(10, yPos),
                .Font = New Font("Segoe UI", 10, FontStyle.Regular)
            }
            PanelSoal.Controls.Add(lbl)
            yPos += lbl.Height + 5

            ' B. ComboBox Jawaban
            Dim cmb As New ComboBox With {
                .Name = "cmb_" & q.Code, ' Simpan kode fakta di nama control
                .Width = 200,
                .DropDownStyle = ComboBoxStyle.DropDownList,
                .Location = New Point(10, yPos),
                .Tag = q.Code
            }

            ' Isi ComboBox
            For Each choice In AllChoices
                cmb.Items.Add(choice)
            Next

            ' Cek apakah sudah pernah dijawab (untuk menjaga state saat back/next)
            If TempAnswers.ContainsKey(q.Code) Then
                ' Cari item yang nilai-nya sama
                For Each item As ChoiceItem In cmb.Items
                    If item.Value = TempAnswers(q.Code) Then
                        cmb.SelectedItem = item
                        Exit For
                    End If
                Next
            End If

            AddHandler cmb.SelectedIndexChanged, AddressOf SaveAnswerState
            PanelSoal.Controls.Add(cmb)
            yPos += 40
        Next

        ' Update Label Halaman
        LblPageInfo.Text = $"Halaman {CurrentPage} dari {TotalPages}"

        ' Atur Visibility Tombol
        BtnPrev.Enabled = (CurrentPage > 1)
        If CurrentPage = TotalPages Then
            BtnNext.Text = "SELESAI (SUBMIT)"
        Else
            BtnNext.Text = "LANJUT >>"
        End If
    End Sub

    ' 3. Event Simpan Jawaban Saat Dipilih
    Private Sub SaveAnswerState(sender As Object, e As EventArgs)
        Dim cmb As ComboBox = CType(sender, ComboBox)
        Dim factCode As String = cmb.Tag.ToString()

        If cmb.SelectedItem IsNot Nothing Then
            Dim selectedChoice As ChoiceItem = CType(cmb.SelectedItem, ChoiceItem)

            If TempAnswers.ContainsKey(factCode) Then
                TempAnswers(factCode) = selectedChoice.Value
            Else
                TempAnswers.Add(factCode, selectedChoice.Value)
            End If
        End If
    End Sub

    ' 4. Navigasi Next / Submit

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs)
        If CurrentPage > 1 Then
            CurrentPage -= 1
            LoadPage()
        End If
    End Sub

    Private Function ValidatePage() As Boolean
        ' Cek setiap ComboBox di panel
        For Each ctrl As Control In PanelSoal.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cmb As ComboBox = CType(ctrl, ComboBox)
                If cmb.SelectedIndex = -1 Then Return False
            End If
        Next
        Return True
    End Function

    ' 5. PROSES HASIL AKHIR
    Private Sub ProsesHasil()
        Dim engine As New ExpertSystemEngine()

        ' A. Load Rules
        engine.LoadRules()

        ' B. Masukkan Fakta User ke Engine
        For Each kvp In TempAnswers
            engine.SetUserFact(kvp.Key, kvp.Value)
        Next

        ' C. Jalankan Perhitungan
        Dim results As Dictionary(Of String, Double) = engine.RunInference()

        If results.Count = 0 Then
            MessageBox.Show("Mohon maaf, sistem tidak dapat menemukan profil yang cocok berdasarkan jawaban Anda.", "Hasil Kosong")
            Return
        End If

        ' D. Cari Nilai Tertinggi
        Dim bestProfileCode As String = ""
        Dim bestCF As Double = 0

        For Each res In results
            If res.Value > bestCF Then
                bestCF = res.Value
                bestProfileCode = res.Key
            End If
        Next

        ' E. Ambil Detail Profil dari DB
        Dim namaProfil As String = ""
        Dim deskripsi As String = ""

        Using conn As MySqlConnection = GetConnection()
            Dim cmd As New MySqlCommand("SELECT * FROM tb_profil WHERE kodeProfile=@code", conn)
            cmd.Parameters.AddWithValue("@code", bestProfileCode)
            Using rd As MySqlDataReader = cmd.ExecuteReader()
                If rd.Read() Then
                    namaProfil = rd("namaProfile").ToString()
                    deskripsi = rd("deskripsi").ToString()
                End If
            End Using

            ' F. Simpan ke Database (tb_konsultasi)
            Dim saveCmd As New MySqlCommand("INSERT INTO tb_konsultasi (userId, hasilKodeProfile, hasilNilaiCf) VALUES (@uid, @res, @cf)", conn)
            saveCmd.Parameters.AddWithValue("@uid", moduleKoneksi.CurrentUserID)
            saveCmd.Parameters.AddWithValue("@res", bestProfileCode)
            saveCmd.Parameters.AddWithValue("@cf", bestCF)
            saveCmd.ExecuteNonQuery()
        End Using

        ' G. Tampilkan Hasil
        Dim formHasil As New formHasil(namaProfil, bestCF, deskripsi)
        formHasil.ShowDialog()

        Me.Close()
    End Sub

    Private Sub PanelSoal_Paint(sender As Object, e As PaintEventArgs) Handles PanelSoal.Paint
        AutoScroll = True
    End Sub

    Private Sub BtnNext_Click_1(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' Validasi: Cek apakah semua soal di halaman ini sudah dijawab
        If Not ValidatePage() Then
            MessageBox.Show("Mohon isi semua jawaban di halaman ini sebelum melanjut.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CurrentPage < TotalPages Then
            CurrentPage += 1
            LoadPage()
        Else
            ' Jika halaman terakhir, Lakukan SUBMIT
            ProsesHasil()
        End If
    End Sub
End Class