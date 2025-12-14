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
        Label2 = New Label()
        Label3 = New Label()
        rcDesc = New RichTextBox()
        Label4 = New Label()
        txbProfile = New TextBox()
        txbCf = New TextBox()
        Button1 = New Button()
        btnExportPDF = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(798, 81)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(197, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(396, 30)
        Label1.TabIndex = 1
        Label1.Text = "HASIL SISTEM PAKAR MENUNJUKAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 8
        Label2.Text = "nama profile"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 9
        Label3.Text = "keyakinan"
        ' 
        ' rcDesc
        ' 
        rcDesc.Location = New Point(197, 263)
        rcDesc.Name = "rcDesc"
        rcDesc.Size = New Size(218, 96)
        rcDesc.TabIndex = 10
        rcDesc.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 11
        Label4.Text = "deskripsi"
        ' 
        ' txbProfile
        ' 
        txbProfile.Location = New Point(197, 146)
        txbProfile.Name = "txbProfile"
        txbProfile.Size = New Size(218, 23)
        txbProfile.TabIndex = 12
        ' 
        ' txbCf
        ' 
        txbCf.Location = New Point(197, 206)
        txbCf.Name = "txbCf"
        txbCf.Size = New Size(218, 23)
        txbCf.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(531, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "tutup"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Location = New Point(625, 392)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(75, 23)
        btnExportPDF.TabIndex = 15
        btnExportPDF.Text = "print pdf"
        btnExportPDF.UseVisualStyleBackColor = True
        ' 
        ' formHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(793, 450)
        Controls.Add(btnExportPDF)
        Controls.Add(Button1)
        Controls.Add(txbCf)
        Controls.Add(txbProfile)
        Controls.Add(Label4)
        Controls.Add(rcDesc)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "formHasil"
        Text = "formHasil"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
End Class
