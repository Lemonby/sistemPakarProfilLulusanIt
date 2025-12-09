<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        BtnLogin = New Button()
        Label3 = New Label()
        Label2 = New Label()
        TxtPassword = New TextBox()
        TxtUsername = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(0, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 453)
        Panel1.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(103, 296)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 23)
        Label6.TabIndex = 1
        Label6.Text = "(Profile Expert for IT)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(34, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(326, 41)
        Label5.TabIndex = 1
        Label5.Text = "Wellcome To ProEx-IT"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-87, -71)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(147, 536)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(280, 221)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(149, 384)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Teal
        LinkLabel1.Location = New Point(637, 375)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(56, 17)
        LinkLabel1.TabIndex = 14
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(495, 375)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 17)
        Label4.TabIndex = 13
        Label4.Text = "Belum punya account?"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(536, 312)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 37)
        BtnLogin.TabIndex = 12
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(458, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 10
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(458, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 11
        Label2.Text = "Username"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(458, 255)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(250, 27)
        TxtPassword.TabIndex = 8
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(458, 176)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(250, 27)
        TxtUsername.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(514, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 54)
        Label1.TabIndex = 7
        Label1.Text = "Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.IMG_3539
        PictureBox1.Location = New Point(57, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(254, 241)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 453)
        Controls.Add(LinkLabel1)
        Controls.Add(Label4)
        Controls.Add(BtnLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "formLogin"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
