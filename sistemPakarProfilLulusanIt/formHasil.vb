Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class formHasil

    'public property yang bakal dipake'
    Public Property profileName As String
    Public Property confidenceLv As Double  ' ✅ UBAH ke Double
    Public Property description As String

    ' Constructor dengan parameter
    Public Sub New(namaProfil As String, cf As Double, deskripsi As String)
        InitializeComponent()
        Me.profileName = namaProfil
        Me.confidenceLv = cf
        Me.description = deskripsi
    End Sub

    Private Sub formHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan data ke kontrol
        txbProfile.Text = profileName
        txbCf.Text = $"{(confidenceLv * 100).ToString("0.##")}%"
        rcDesc.Text = description

        ' Styling (opsional)
        Me.Text = "HASIL DIAGNOSA"
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' ========== METHOD EXPORT PDF ==========
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Try
            ' 1. Buat SaveFileDialog
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveDialog.Title = "Simpan Hasil Diagnosa"
            saveDialog.FileName = $"Hasil_Diagnosa_{profileName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' 2. Generate PDF
                GeneratePDF(saveDialog.FileName)

                ' 3. Konfirmasi
                Dim result As DialogResult = MessageBox.Show(
                    "PDF berhasil disimpan!" & vbCrLf & vbCrLf &
                    "Apakah Anda ingin membuka file sekarang?",
                    "Berhasil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    ' ✅ Fix untuk Windows
                    Process.Start(New ProcessStartInfo(saveDialog.FileName) With {
                        .UseShellExecute = True
                    })
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error saat membuat PDF: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace,
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GeneratePDF(filePath As String)
        ' Validasi input
        If String.IsNullOrEmpty(profileName) Then profileName = "Tidak Diketahui"
        If String.IsNullOrEmpty(description) Then description = "Tidak ada deskripsi"

        ' 1. Buat dokumen PDF
        Dim doc As New Document(PageSize.A4, 50, 50, 25, 25)

        ' 2. Buat PdfWriter
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))

        ' 3. Buka dokumen
        doc.Open()

        ' ========== STYLING ==========
        Dim fontTitle As Font = FontFactory.GetFont("Arial", 18, Font.Bold, BaseColor.DARK_GRAY)
        Dim fontHeader As Font = FontFactory.GetFont("Arial", 14, Font.Bold, BaseColor.BLACK)
        Dim fontNormal As Font = FontFactory.GetFont("Arial", 11, Font.Bold, BaseColor.BLACK)
        Dim fontBold As Font = FontFactory.GetFont("Arial", 11, Font.Bold, BaseColor.BLACK)

        ' ========== HEADER ==========
        Dim header As New Paragraph("SISTEM PAKAR PROFIL LULUSAN IT", fontTitle)
        header.Alignment = Element.ALIGN_CENTER
        header.SpacingAfter = 5
        doc.Add(header)

        Dim subHeader As New Paragraph("Hasil Diagnosa Profil", fontNormal)
        subHeader.Alignment = Element.ALIGN_CENTER
        subHeader.SpacingAfter = 20
        doc.Add(subHeader)

        ' Garis pemisah
        Dim line As New LineSeparator(1.0F, 100.0F, BaseColor.GRAY, Element.ALIGN_CENTER, -1)
        doc.Add(New Chunk(line))
        doc.Add(New Paragraph(" "))

        ' ========== INFORMASI UMUM ==========
        Dim tanggal As New Paragraph($"Tanggal: {DateTime.Now:dddd, dd MMMM yyyy HH:mm}", fontNormal)
        tanggal.SpacingAfter = 5
        doc.Add(tanggal)

        ' ✅ Cek apakah CurrentUserName ada
        Dim userName As String = If(String.IsNullOrEmpty(moduleKoneksi.CurrentUserName), "Guest", moduleKoneksi.CurrentUserName)
        Dim user As New Paragraph($"User: {userName}", fontNormal)
        user.SpacingAfter = 15
        doc.Add(user)

        ' ========== HASIL DIAGNOSA ==========
        Dim resultTitle As New Paragraph("HASIL DIAGNOSA", fontHeader)
        resultTitle.SpacingBefore = 10
        resultTitle.SpacingAfter = 10
        doc.Add(resultTitle)

        ' Tabel untuk hasil
        Dim table As New PdfPTable(2)
        table.WidthPercentage = 100
        table.SetWidths(New Single() {1, 2})
        table.SpacingBefore = 10
        table.SpacingAfter = 20

        ' Row 1: Profil
        Dim cellLabel1 As New PdfPCell(New Phrase("PROFIL", fontBold))
        cellLabel1.BackgroundColor = New BaseColor(230, 230, 230)
        cellLabel1.Padding = 8
        table.AddCell(cellLabel1)

        Dim cellContent1 As New PdfPCell(New Phrase(profileName, fontNormal))
        cellContent1.Padding = 8
        table.AddCell(cellContent1)

        ' Row 2: Tingkat Keyakinan
        Dim cellLabel2 As New PdfPCell(New Phrase("TINGKAT KEYAKINAN", fontBold))
        cellLabel2.BackgroundColor = New BaseColor(230, 230, 230)
        cellLabel2.Padding = 8
        table.AddCell(cellLabel2)

        Dim cellContent2 As New PdfPCell(New Phrase($"{(confidenceLv * 100).ToString("0.##")}%", fontNormal))
        cellContent2.Padding = 8
        table.AddCell(cellContent2)

        doc.Add(table)

        ' ========== DESKRIPSI ==========
        Dim descTitle As New Paragraph("DESKRIPSI PROFIL", fontHeader)
        descTitle.SpacingBefore = 10
        descTitle.SpacingAfter = 10
        doc.Add(descTitle)

        Dim descContent As New Paragraph(description, fontNormal)
        descContent.Alignment = Element.ALIGN_JUSTIFIED
        descContent.SetLeading(0, 1.5F)
        doc.Add(descContent)

        ' ========== FOOTER ==========
        doc.Add(New Paragraph(" "))
        doc.Add(New Chunk(line))

        Dim footer As New Paragraph("Dokumen ini digenerate otomatis oleh Sistem Pakar Profil Lulusan IT", fontNormal)
        footer.Alignment = Element.ALIGN_CENTER
        footer.Font.Size = 9
        footer.Font.SetColor(128, 128, 128)
        footer.SpacingBefore = 10
        doc.Add(footer)

        ' 4. Tutup dokumen
        doc.Close()
        writer.Close()
    End Sub

End Class