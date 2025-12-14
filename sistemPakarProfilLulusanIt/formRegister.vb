Imports MySql.Data.MySqlClient

Public Class formRegister

    Private Sub formRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup form
        SetupForm()
        LoadProdiList()
        LoadRoleList()  ' ✅ Tambahkan load role list
    End Sub

    ' ✅ Setup Form Initial State
    Private Sub SetupForm()
        ' Set password character
        txbPassword.PasswordChar = "*"c

        ' Set form properties
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Register - Sistem Pakar Profil Lulusan IT"

        ' Clear textbox
        ClearForm()

        ' Set Enter key untuk submit
        Me.AcceptButton = Button1  ' Button1 = Register
    End Sub

    ' ✅ Load Daftar Program Studi ke ComboBox
    Private Sub LoadProdiList()
        ' Clear existing items
        cbProdi.Items.Clear()

        ' Tambahkan list program studi
        cbProdi.Items.Add("Teknik Informatika")
        cbProdi.Items.Add("Sistem Informasi")
        cbProdi.Items.Add("Teknologi Informasi")
        cbProdi.Items.Add("Ilmu Komputer")
        cbProdi.Items.Add("Rekayasa Perangkat Lunak")
        cbProdi.Items.Add("Teknik Komputer")
        cbProdi.Items.Add("Manajemen Informatika")

        ' Set default
        cbProdi.SelectedIndex = -1  ' Tidak ada yang terpilih
    End Sub

    ' ✅ TAMBAHAN BARU: Load Daftar Role ke ComboBox
    Private Sub LoadRoleList()
        ' Clear existing items
        cbRole.Items.Clear()

        ' Tambahkan list role
        cbRole.Items.Add("user")
        cbRole.Items.Add("mahasiswa")
        cbRole.Items.Add("admin")  ' Opsional, bisa dihapus jika tidak ingin user bisa register sebagai admin

        ' Set default ke "user"
        cbRole.SelectedIndex = 0  ' Default: user
    End Sub

    ' ✅ BUTTON REGISTER (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validasi input
        If Not ValidateInput() Then
            Return
        End If

        ' Ambil data dari form
        Dim username As String = txbUserName.Text.Trim()
        Dim password As String = txbPassword.Text.Trim()
        Dim namaLengkap As String = txbNama.Text.Trim()
        Dim nim As String = txbNim.Text.Trim()
        Dim prodi As String = cbProdi.SelectedItem.ToString()
        Dim role As String = cbRole.SelectedItem.ToString()  ' ✅ Ambil role dari ComboBox

        ' Insert ke database
        If InsertUser(username, password, namaLengkap, nim, prodi, role) Then
            MessageBox.Show(
                "Registrasi berhasil!" & vbCrLf & vbCrLf &
                "Silakan login dengan username dan password Anda.",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            ' Clear form
            ClearForm()

            ' Redirect ke form login
            Dim loginForm As New formLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' ✅ Validasi Input
    Private Function ValidateInput() As Boolean
        ' Cek Nama Lengkap
        If String.IsNullOrWhiteSpace(txbNama.Text) Then
            MessageBox.Show("Nama lengkap tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbNama.Focus()
            Return False
        End If

        ' Cek Username
        If String.IsNullOrWhiteSpace(txbUserName.Text) Then
            MessageBox.Show("Username tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbUserName.Focus()
            Return False
        End If

        ' Cek panjang username
        If txbUserName.Text.Trim().Length < 4 Then
            MessageBox.Show("Username minimal 4 karakter!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbUserName.Focus()
            Return False
        End If

        ' Cek Password
        If String.IsNullOrWhiteSpace(txbPassword.Text) Then
            MessageBox.Show("Password tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbPassword.Focus()
            Return False
        End If

        ' Cek panjang password
        If txbPassword.Text.Trim().Length < 6 Then
            MessageBox.Show("Password minimal 6 karakter!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbPassword.Focus()
            Return False
        End If

        ' Cek NIM
        If String.IsNullOrWhiteSpace(txbNim.Text) Then
            MessageBox.Show("NIM tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txbNim.Focus()
            Return False
        End If

        ' Cek Program Studi
        If cbProdi.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Program Studi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbProdi.Focus()
            Return False
        End If

        ' ✅ TAMBAHAN BARU: Cek Role
        If cbRole.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Role!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbRole.Focus()
            Return False
        End If

        Return True
    End Function

    ' ✅ Insert User ke Database (UPDATED dengan parameter role)
    Private Function InsertUser(username As String, password As String, namaLengkap As String,
                                nim As String, prodi As String, role As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return False

            Try
                ' ✅ Query insert user baru (FIXED syntax error)
                Dim query As String = "INSERT INTO tb_users (username, password, namaLengkap, nim, prodi, role) " &
                                     "VALUES (@username, @password, @namaLengkap, @nim, @prodi, @role)"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)

                ' ✅ Hash password menggunakan function global dari moduleKoneksi
                Dim hashedPassword As String = moduleKoneksi.HashPassword(password)

                cmd.Parameters.AddWithValue("@password", hashedPassword)
                cmd.Parameters.AddWithValue("@namaLengkap", namaLengkap)
                cmd.Parameters.AddWithValue("@nim", nim)
                cmd.Parameters.AddWithValue("@prodi", prodi)
                cmd.Parameters.AddWithValue("@role", role)  ' ✅ Simpan role dari ComboBox

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                Return rowsAffected > 0

            Catch ex As MySqlException
                ' Handle duplicate username
                If ex.Number = 1062 Then
                    MessageBox.Show("Username sudah digunakan! Silakan gunakan username lain.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error registrasi: " & ex.Message,
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Return False

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    ' ✅ Clear Form
    Private Sub ClearForm()
        txbNama.Clear()
        txbUserName.Clear()
        txbPassword.Clear()
        txbNim.Clear()
        cbProdi.SelectedIndex = -1
        cbRole.SelectedIndex = 0  ' ✅ Reset ke default "user"
        txbNama.Focus()
    End Sub

    ' ✅ BUTTON KEMBALI KE LOGIN (Button2)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin kembali ke halaman login?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New formLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' ===== Event Handlers =====

    Private Sub txbNama_TextChanged(sender As Object, e As EventArgs) Handles txbNama.TextChanged
        ' Opsional: Validasi real-time
    End Sub

    Private Sub txbUserName_TextChanged(sender As Object, e As EventArgs) Handles txbUserName.TextChanged
        ' Opsional: Cek username availability real-time
    End Sub

    Private Sub txbPassword_TextChanged(sender As Object, e As EventArgs) Handles txbPassword.TextChanged
        ' Opsional: Password strength indicator
    End Sub

    Private Sub cbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProdi.SelectedIndexChanged
        ' Opsional: Action saat prodi dipilih
    End Sub

    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        ' ✅ OPSIONAL: Tampilkan info role yang dipilih
        ' Atau disable/enable field tertentu based on role
    End Sub

End Class