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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHasil))
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        rcDesc = New RichTextBox()
        Label4 = New Label()
        txbProfile = New TextBox()
        txbCf = New TextBox()
        Button1 = New Button()
        btnExportPDF = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(867, 108)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(177, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(509, 38)
        Label1.TabIndex = 1
        Label1.Text = "HASIL SISTEM PAKAR MENUNJUKAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(39, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 8
        Label2.Text = "nama profile"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(39, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 9
        Label3.Text = "keyakinan"
        ' 
        ' rcDesc
        ' 
        rcDesc.Location = New Point(203, 205)
        rcDesc.Margin = New Padding(3, 4, 3, 4)
        rcDesc.Name = "rcDesc"
        rcDesc.Size = New Size(249, 127)
        rcDesc.TabIndex = 10
        rcDesc.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(39, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 11
        Label4.Text = "deskripsi"
        ' 
        ' txbProfile
        ' 
        txbProfile.Location = New Point(203, 49)
        txbProfile.Margin = New Padding(3, 4, 3, 4)
        txbProfile.Name = "txbProfile"
        txbProfile.Size = New Size(249, 27)
        txbProfile.TabIndex = 12
        ' 
        ' txbCf
        ' 
        txbCf.Location = New Point(203, 129)
        txbCf.Margin = New Padding(3, 4, 3, 4)
        txbCf.Name = "txbCf"
        txbCf.Size = New Size(249, 27)
        txbCf.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(203, 382)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 14
        Button1.Text = "tutup"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.BackColor = Color.Red
        btnExportPDF.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportPDF.ForeColor = Color.White
        btnExportPDF.Location = New Point(310, 382)
        btnExportPDF.Margin = New Padding(3, 4, 3, 4)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(86, 31)
        btnExportPDF.TabIndex = 15
        btnExportPDF.Text = "print pdf"
        btnExportPDF.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(btnExportPDF)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(txbCf)
        Panel2.Controls.Add(txbProfile)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(rcDesc)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(0, 107)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(867, 495)
        Panel2.TabIndex = 16
        ' 
        ' formHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 600)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rcDesc As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbProfile As TextBox
    Friend WithEvents txbCf As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents Panel2 As Panel
End Class
