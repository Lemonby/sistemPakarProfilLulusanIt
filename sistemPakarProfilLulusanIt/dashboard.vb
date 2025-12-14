Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ✅ Setup layout (opsional)
        SetupLayout()

        ' ✅ Auto-fill data user
        LoadUserData()
    End Sub

    Private Sub SetupLayout()
        Me.Text = "DASHBOARD"
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub LoadUserData()
        txbUname.Text = moduleKoneksi.CurrentUserName
        txbPass.Text = moduleKoneksi.CurrentPass
        txbNim.Text = moduleKoneksi.CurrentNim
        txbProdi.Text = moduleKoneksi.CurrentProdi

        txbUname.ReadOnly = True
        txbPass.ReadOnly = True
        txbNim.ReadOnly = True
        txbProdi.ReadOnly = True

        txbUname.BackColor = Color.WhiteSmoke
        txbPass.BackColor = Color.WhiteSmoke
        txbNim.BackColor = Color.WhiteSmoke
        txbProdi.BackColor = Color.WhiteSmoke

        Me.Text = "Dashboard - " & moduleKoneksi.CurrentUserName
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim formSoal As New formSoal()
        formSoal.Show()
        Me.Hide()
    End Sub
End Class