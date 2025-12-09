<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSoal
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
        PanelSoal = New Panel()
        LblPageInfo = New Label()
        BtnPrev = New Button()
        BtnNext = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSoal
        ' 
        PanelSoal.AutoScroll = True
        PanelSoal.BorderStyle = BorderStyle.FixedSingle
        PanelSoal.Location = New Point(2, 105)
        PanelSoal.Margin = New Padding(3, 4, 3, 4)
        PanelSoal.Name = "PanelSoal"
        PanelSoal.Size = New Size(912, 749)
        PanelSoal.TabIndex = 0
        ' 
        ' LblPageInfo
        ' 
        LblPageInfo.AutoSize = True
        LblPageInfo.Location = New Point(426, 868)
        LblPageInfo.Name = "LblPageInfo"
        LblPageInfo.Size = New Size(96, 20)
        LblPageInfo.TabIndex = 5
        LblPageInfo.Text = "info halaman"
        ' 
        ' BtnPrev
        ' 
        BtnPrev.BackColor = Color.DodgerBlue
        BtnPrev.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPrev.ForeColor = Color.White
        BtnPrev.Location = New Point(14, 863)
        BtnPrev.Margin = New Padding(3, 4, 3, 4)
        BtnPrev.Name = "BtnPrev"
        BtnPrev.Size = New Size(86, 31)
        BtnPrev.TabIndex = 4
        BtnPrev.Text = "kembali"
        BtnPrev.UseVisualStyleBackColor = False
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = Color.LimeGreen
        BtnNext.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnNext.ForeColor = Color.White
        BtnNext.Location = New Point(815, 863)
        BtnNext.Margin = New Padding(3, 4, 3, 4)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(86, 31)
        BtnNext.TabIndex = 3
        BtnNext.Text = "lanjut"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(912, 108)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(258, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 38)
        Label1.TabIndex = 1
        Label1.Text = "SISTEM PAKAR PROFIL LULUSAN"
        ' 
        ' formSoal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 909)
        Controls.Add(Panel1)
        Controls.Add(LblPageInfo)
        Controls.Add(BtnPrev)
        Controls.Add(BtnNext)
        Controls.Add(PanelSoal)
        Margin = New Padding(3, 4, 3, 4)
        Name = "formSoal"
        Text = "formSoal"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelSoal As Panel
    Friend WithEvents LblPageInfo As Label
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
