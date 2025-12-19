<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        txbProdi = New TextBox()
        Label3 = New Label()
        txbNim = New TextBox()
        Label2 = New Label()
        txbUname = New TextBox()
        Panel2 = New Panel()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txbProdi)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txbNim)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txbUname)
        Panel1.Location = New Point(279, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(521, 393)
        Panel1.TabIndex = 1
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Aqua
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.DarkCyan
        LinkLabel1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.ForeColor = Color.White
        LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), Image)
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(368, 347)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(124, 15)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Mulai Sistem Pakar ->"
        LinkLabel1.VisitedLinkColor = Color.Violet
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Image = CType(resources.GetObject("Label4.Image"), Image)
        Label4.Location = New Point(54, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 10
        Label4.Text = "Program studi"
        ' 
        ' txbProdi
        ' 
        txbProdi.Location = New Point(54, 186)
        txbProdi.Margin = New Padding(3, 2, 3, 2)
        txbProdi.Name = "txbProdi"
        txbProdi.Size = New Size(409, 23)
        txbProdi.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Image = CType(resources.GetObject("Label3.Image"), Image)
        Label3.Location = New Point(54, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 8
        Label3.Text = "nim"
        ' 
        ' txbNim
        ' 
        txbNim.Location = New Point(54, 120)
        txbNim.Margin = New Padding(3, 2, 3, 2)
        txbNim.Name = "txbNim"
        txbNim.Size = New Size(409, 23)
        txbNim.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(54, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 4
        Label2.Text = "Username"
        ' 
        ' txbUname
        ' 
        txbUname.Location = New Point(54, 58)
        txbUname.Margin = New Padding(3, 2, 3, 2)
        txbUname.Name = "txbUname"
        txbUname.Size = New Size(409, 23)
        txbUname.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Aqua
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(1, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(284, 393)
        Panel2.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(78, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 30)
        Label5.TabIndex = 2
        Label5.Text = "Label Jam"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(192, 156)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 20)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(74, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 389)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "dashboard"
        Text = "dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txbUname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents txbProdi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbNim As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
