Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class formLogin


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Harap isi Username dan Password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            Try
                ' Cek username dan password di database
                Dim query As String = "SELECT id_user, nama_lengkap, role FROM tb_users WHERE username=@user AND password=@pass"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password) ' Note: Sebaiknya gunakan Hash di real project

                Using rd As MySqlDataReader = cmd.ExecuteReader()
                    If rd.Read() Then
                        ' 1. SIMPAN SESI USER KE MODULE GLOBAL
                        moduleKoneksi.CurrentUserID = Convert.ToInt32(rd("id_user"))
                        moduleKoneksi.CurrentUserName = rd("nama_lengkap").ToString()

                        MessageBox.Show("Login Berhasil! Selamat Datang, " & moduleKoneksi.CurrentUserName, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' 2. PINDAH KE FORM UTAMA (FORM3)
                        Dim frmUtama As New formSoal()
                        frmUtama.Show()
                        Me.Hide() ' Sembunyikan form login
                    Else
                        MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error Login: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPassword.PasswordChar = "*"c ' Sembunyikan password
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim registerForm As New formRegister()
        registerForm.Show()

        Me.Hide()
    End Sub
End Class
