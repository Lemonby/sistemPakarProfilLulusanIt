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
        PanelSoal.Location = New Point(2, 79)
        PanelSoal.Name = "PanelSoal"
        PanelSoal.Size = New Size(798, 562)
        PanelSoal.TabIndex = 0
        ' 
        ' LblPageInfo
        ' 
        LblPageInfo.AutoSize = True
        LblPageInfo.Location = New Point(373, 651)
        LblPageInfo.Name = "LblPageInfo"
        LblPageInfo.Size = New Size(77, 15)
        LblPageInfo.TabIndex = 5
        LblPageInfo.Text = "info halaman"
        ' 
        ' BtnPrev
        ' 
        BtnPrev.Location = New Point(12, 647)
        BtnPrev.Name = "BtnPrev"
        BtnPrev.Size = New Size(75, 23)
        BtnPrev.TabIndex = 4
        BtnPrev.Text = "kembali"
        BtnPrev.UseVisualStyleBackColor = True
        ' 
        ' BtnNext
        ' 
        BtnNext.Location = New Point(713, 647)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(75, 23)
        BtnNext.TabIndex = 3
        BtnNext.Text = "lanjut"
        BtnNext.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 1)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(798, 81)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(226, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 30)
        Label1.TabIndex = 1
        Label1.Text = "SISTEM PAKAR PROFIL LULUSAN"
        ' 
        ' formSoal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 682)
        Controls.Add(Panel1)
        Controls.Add(LblPageInfo)
        Controls.Add(BtnPrev)
        Controls.Add(BtnNext)
        Controls.Add(PanelSoal)
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
