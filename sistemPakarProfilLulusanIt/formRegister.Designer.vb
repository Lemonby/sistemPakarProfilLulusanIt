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
        Label2 = New Label()
        txbPassword = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
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
        Panel1.Location = New Point(2, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 459)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(61, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(267, 251)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
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
        PictureBox3.Location = New Point(-85, -76)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(147, 536)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(280, 219)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(149, 384)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(90, 334)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 37)
        Button2.TabIndex = 19
        Button2.Text = "Kembali"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(209, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 37)
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
        Label3.Location = New Point(70, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 17
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(70, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 18
        Label2.Text = "Username"
        ' 
        ' txbPassword
        ' 
        txbPassword.Location = New Point(70, 277)
        txbPassword.Name = "txbPassword"
        txbPassword.Size = New Size(250, 27)
        txbPassword.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(70, 197)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 27)
        TextBox1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLightLight
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(106, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 54)
        Label1.TabIndex = 14
        Label1.Text = "Register"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txbPassword)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(394, -3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(389, 459)
        Panel2.TabIndex = 21
        ' 
        ' formRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(783, 457)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
