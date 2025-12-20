<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRegister))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        txbPassword = New TextBox()
        txbUserName = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        cbRole = New ComboBox()
        txbNim = New TextBox()
        Label7 = New Label()
        txbNama = New TextBox()
        cbProdi = New ComboBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumPurple
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 554)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(234, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(90, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 19)
        Label6.TabIndex = 1
        Label6.Text = "(Profile Expert for IT)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(30, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(265, 32)
        Label5.TabIndex = 1
        Label5.Text = "Wellcome To ProEx-IT"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-74, -57)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(129, 402)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(245, 164)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(130, 288)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Plum
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(140, 463)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 28)
        Button2.TabIndex = 19
        Button2.Text = "Kembali"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(308, 463)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 28)
        Button1.TabIndex = 20
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(63, 290)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 17
        ' 
        ' txbPassword
        ' 
        txbPassword.Location = New Point(63, 308)
        txbPassword.Margin = New Padding(3, 2, 3, 2)
        txbPassword.Name = "txbPassword"
        txbPassword.Size = New Size(512, 23)
        txbPassword.TabIndex = 15
        ' 
        ' txbUserName
        ' 
        txbUserName.Location = New Point(63, 253)
        txbUserName.Margin = New Padding(3, 2, 3, 2)
        txbUserName.Name = "txbUserName"
        txbUserName.Size = New Size(512, 23)
        txbUserName.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.GhostWhite
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MediumPurple
        Label1.Location = New Point(236, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 45)
        Label1.TabIndex = 14
        Label1.Text = "Register"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(cbRole)
        Panel2.Controls.Add(txbNim)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txbNama)
        Panel2.Controls.Add(cbProdi)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txbPassword)
        Panel2.Controls.Add(txbUserName)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(345, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(587, 554)
        Panel2.TabIndex = 21
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"mahasiswa", "admin"})
        cbRole.Location = New Point(63, 420)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(512, 23)
        cbRole.TabIndex = 29
        ' 
        ' txbNim
        ' 
        txbNim.Location = New Point(63, 199)
        txbNim.Margin = New Padding(3, 2, 3, 2)
        txbNim.Name = "txbNim"
        txbNim.Size = New Size(512, 23)
        txbNim.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.MediumPurple
        Label7.Location = New Point(63, 130)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 25
        Label7.Text = "Nama"
        ' 
        ' txbNama
        ' 
        txbNama.Location = New Point(63, 148)
        txbNama.Margin = New Padding(3, 2, 3, 2)
        txbNama.Name = "txbNama"
        txbNama.Size = New Size(512, 23)
        txbNama.TabIndex = 24
        ' 
        ' cbProdi
        ' 
        cbProdi.FormattingEnabled = True
        cbProdi.Items.AddRange(New Object() {"Teknik Informatika", "Teknik Multimedia Jaringan", "Teknik Multimedia Digital"})
        cbProdi.Location = New Point(63, 363)
        cbProdi.Name = "cbProdi"
        cbProdi.Size = New Size(512, 23)
        cbProdi.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.MediumPurple
        Label10.Location = New Point(63, 182)
        Label10.Name = "Label10"
        Label10.Size = New Size(31, 15)
        Label10.TabIndex = 30
        Label10.Text = "NIM"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.MediumPurple
        Label11.Location = New Point(63, 402)
        Label11.Name = "Label11"
        Label11.Size = New Size(30, 15)
        Label11.TabIndex = 32
        Label11.Text = "Role"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.MediumPurple
        Label12.Location = New Point(63, 345)
        Label12.Name = "Label12"
        Label12.Size = New Size(35, 15)
        Label12.TabIndex = 33
        Label12.Text = "Prodi"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.MediumPurple
        Label13.Location = New Point(63, 286)
        Label13.Name = "Label13"
        Label13.Size = New Size(57, 15)
        Label13.TabIndex = 34
        Label13.Text = "Password"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.MediumPurple
        Label14.Location = New Point(63, 236)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 15)
        Label14.TabIndex = 35
        Label14.Text = "Username"
        ' 
        ' formRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 554)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "formRegister"
        Text = "formRegister"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents txbUserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbNama As TextBox
    Friend WithEvents txbNim As TextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
