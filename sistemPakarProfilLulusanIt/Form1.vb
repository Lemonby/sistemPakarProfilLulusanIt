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
                ' ✅ Hash password menggunakan function global dari moduleKoneksi
                Dim hashedPassword As String = moduleKoneksi.HashPassword(password)

                Dim query As String = "SELECT userId, password, namaLengkap, nim, prodi, role 
                      FROM tb_users 
                      WHERE username=@user AND password=@pass"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", hashedPassword) ' Note: Sebaiknya gunakan Hash di real project

                Using rd As MySqlDataReader = cmd.ExecuteReader()
                    If rd.Read() Then
                        ' 1. SIMPAN SESI USER KE MODULE GLOBAL
                        moduleKoneksi.CurrentUserID = Convert.ToInt32(rd("userId"))
                        moduleKoneksi.CurrentUserName = rd("namaLengkap").ToString()
                        moduleKoneksi.CurrentPass = rd("password").ToString()
                        moduleKoneksi.CurrentUserRole = rd("role").ToString()
                        moduleKoneksi.CurrentNim = rd("nim").ToString()
                        moduleKoneksi.CurrentProdi = rd("prodi").ToString()


                        ' ✅ 2. REDIRECT BERDASARKAN ROLE
                        Select Case moduleKoneksi.CurrentUserRole.ToLower()
                            Case "admin"
                                ' Jika Admin → Buka Admin.vb
                                MessageBox.Show("Login Berhasil! Selamat Datang Admin, " & moduleKoneksi.CurrentUserName,
                                              "Admin Panel", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                Dim adminForm As New adminForm()
                                adminForm.Show()
                                Me.Hide()

                            Case "user", "mahasiswa"
                                ' Jika User/Mahasiswa → Buka formSoal
                                MessageBox.Show("Login Berhasil! Selamat Datang, " & moduleKoneksi.CurrentUserName,
                                              "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                Dim dashboard As New dashboard()
                                dashboard.Show()
                                Me.Hide()

                            Case Else
                                ' Role tidak dikenali
                                MessageBox.Show("Role user tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Select
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
