<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        rcDesc = New RichTextBox()
        txbProfile = New TextBox()
        txbCf = New TextBox()
        Button1 = New Button()
        btnExportPDF = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumPurple
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(972, 81)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(288, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(396, 30)
        Label1.TabIndex = 1
        Label1.Text = "HASIL SISTEM PAKAR MENUNJUKAN"
        ' 
        ' rcDesc
        ' 
        rcDesc.Location = New Point(223, 159)
        rcDesc.Name = "rcDesc"
        rcDesc.Size = New Size(564, 96)
        rcDesc.TabIndex = 10
        rcDesc.Text = ""
        ' 
        ' txbProfile
        ' 
        txbProfile.Location = New Point(223, 43)
        txbProfile.Name = "txbProfile"
        txbProfile.Size = New Size(564, 23)
        txbProfile.TabIndex = 12
        ' 
        ' txbCf
        ' 
        txbCf.Location = New Point(223, 103)
        txbCf.Name = "txbCf"
        txbCf.Size = New Size(564, 23)
        txbCf.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Plum
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(223, 286)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 28)
        Button1.TabIndex = 14
        Button1.Text = "tutup"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.BackColor = Color.Red
        btnExportPDF.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportPDF.ForeColor = Color.White
        btnExportPDF.Location = New Point(408, 286)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(150, 28)
        btnExportPDF.TabIndex = 15
        btnExportPDF.Text = "print pdf"
        btnExportPDF.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(btnExportPDF)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(txbCf)
        Panel2.Controls.Add(txbProfile)
        Panel2.Controls.Add(rcDesc)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 81)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(972, 501)
        Panel2.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.MediumPurple
        Label3.Location = New Point(66, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 28
        Label3.Text = "Nama Profile"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.MediumPurple
        Label2.Location = New Point(66, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 27
        Label2.Text = "Nilai Keyakinan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.MediumPurple
        Label7.Location = New Point(66, 159)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 26
        Label7.Text = "Deskripsi"
        ' 
        ' formHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(972, 582)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "formHasil"
        Text = "formHasil"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents rcDesc As RichTextBox
    Friend WithEvents txbProfile As TextBox
    Friend WithEvents txbCf As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
