<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        Panel1 = New Panel()
        DataGridView2 = New DataGridView()
        DataGridView1 = New DataGridView()
        btnDelate = New Button()
        btnSimpan = New Button()
        btnUpdate = New Button()
        Label2 = New Label()
        txbUname = New TextBox()
        Panel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(DataGridView2)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(btnDelate)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txbUname)
        Panel1.Location = New Point(1, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(704, 393)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(341, 9)
        DataGridView2.Margin = New Padding(3, 2, 3, 2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(344, 140)
        DataGridView2.TabIndex = 25
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(10, 205)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(679, 178)
        DataGridView1.TabIndex = 24
        ' 
        ' btnDelate
        ' 
        btnDelate.BackColor = Color.Red
        btnDelate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelate.ForeColor = Color.White
        btnDelate.Location = New Point(233, 159)
        btnDelate.Margin = New Padding(3, 2, 3, 2)
        btnDelate.Name = "btnDelate"
        btnDelate.Size = New Size(82, 28)
        btnDelate.TabIndex = 23
        btnDelate.Text = "Delete"
        btnDelate.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DodgerBlue
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(27, 159)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(82, 28)
        btnSimpan.TabIndex = 21
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.LimeGreen
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(131, 159)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(82, 28)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(27, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 4
        Label2.Text = "Username"
        ' 
        ' txbUname
        ' 
        txbUname.Location = New Point(27, 62)
        txbUname.Margin = New Padding(3, 2, 3, 2)
        txbUname.Name = "txbUname"
        txbUname.Size = New Size(262, 23)
        txbUname.TabIndex = 3
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 392)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "adminForm"
        Text = "Admin Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txbUname As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDelate As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
End Class
