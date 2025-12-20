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
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSoal
        ' 
        PanelSoal.AutoScroll = True
        PanelSoal.BorderStyle = BorderStyle.FixedSingle
        PanelSoal.Location = New Point(2, 79)
        PanelSoal.Name = "PanelSoal"
        PanelSoal.Size = New Size(1164, 585)
        PanelSoal.TabIndex = 0
        ' 
        ' LblPageInfo
        ' 
        LblPageInfo.AutoSize = True
        LblPageInfo.Font = New Font("Segoe UI", 12F)
        LblPageInfo.ForeColor = Color.MediumPurple
        LblPageInfo.Location = New Point(554, 12)
        LblPageInfo.Name = "LblPageInfo"
        LblPageInfo.Size = New Size(101, 21)
        LblPageInfo.TabIndex = 5
        LblPageInfo.Text = "info halaman"
        ' 
        ' BtnPrev
        ' 
        BtnPrev.BackColor = Color.DodgerBlue
        BtnPrev.Dock = DockStyle.Left
        BtnPrev.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPrev.ForeColor = Color.White
        BtnPrev.Location = New Point(0, 0)
        BtnPrev.Name = "BtnPrev"
        BtnPrev.Size = New Size(98, 100)
        BtnPrev.TabIndex = 4
        BtnPrev.Text = "kembali"
        BtnPrev.UseVisualStyleBackColor = False
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = Color.LimeGreen
        BtnNext.Dock = DockStyle.Right
        BtnNext.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnNext.ForeColor = Color.White
        BtnNext.Location = New Point(1091, 0)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(75, 100)
        BtnNext.TabIndex = 3
        BtnNext.Text = "lanjut"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumPurple
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1166, 81)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(421, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 30)
        Label1.TabIndex = 1
        Label1.Text = "SISTEM PAKAR PROFIL LULUSAN"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnPrev)
        Panel2.Controls.Add(LblPageInfo)
        Panel2.Controls.Add(BtnNext)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 670)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1166, 100)
        Panel2.TabIndex = 7
        ' 
        ' formSoal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1166, 770)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PanelSoal)
        Name = "formSoal"
        Text = "formSoal"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSoal As Panel
    Friend WithEvents LblPageInfo As Label
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
