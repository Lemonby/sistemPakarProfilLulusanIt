Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class adminForm

    ' ✅ Variable untuk menyimpan ID user yang dipilih
    Private selectedUserId As Integer = 0

    Private Sub tampilDataUser()
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            Try
                Dim query As String = "SELECT userId as id, username, password, namaLengkap, nim, role FROM tb_users WHERE role='mahasiswa'"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)

                DataGridView2.DataSource = table
                DataGridView2.ReadOnly = True
                DataGridView2.AllowUserToAddRows = False
                DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView2.MultiSelect = False
                DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Sembunyikan kolom password di grid
                If DataGridView2.Columns.Contains("password") Then
                    DataGridView2.Columns("password").Visible = False
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal menampilkan data user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub tampilDataProfilLulusan()
        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            Try
                Dim query As String = "SELECT u.userName AS username, 
                                          IFNULL(u.prodi, '-') AS prodi, 
                                          p.namaProfile AS profile, 
                                          CONCAT(ROUND(k.hasilNilaiCf * 100, 2), '%') AS tingkat_keakuratan
                                   FROM tb_users u
                                   LEFT JOIN tb_konsultasi k ON u.userId = k.userId
                                   LEFT JOIN tb_profil p ON k.hasilKodeProfile = p.kodeProfile
                                   WHERE u.role != 'admin'
                                   ORDER BY u.userId ASC"

                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridView1.DataSource = table
                DataGridView1.ReadOnly = True
                DataGridView1.AllowUserToAddRows = False
                DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView1.MultiSelect = False
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Format header
                DataGridView1.Columns("username").HeaderText = "Username"
                DataGridView1.Columns("prodi").HeaderText = "Program Studi"
                DataGridView1.Columns("profile").HeaderText = "Profil Lulusan"
                DataGridView1.Columns("tingkat_keakuratan").HeaderText = "Tingkat Keakuratan"

            Catch ex As Exception
                MessageBox.Show("Gagal menampilkan data hasil profil user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

                ' ✅ Simpan ID user yang dipilih
                If row.Cells("id").Value IsNot Nothing Then
                    selectedUserId = Convert.ToInt32(row.Cells("id").Value)
                End If

                ' Isi TextBox dengan data dari row yang diklik
                If row.Cells("username").Value IsNot Nothing Then
                    txbUname.Text = row.Cells("username").Value.ToString()
                Else
                    txbUname.Clear()
                End If

                'If row.Cells("password").Value IsNot Nothing Then
                '    txbPass.Text = row.Cells("password").Value.ToString()
                'Else
                '    txbPass.Clear()
                'End If

            Catch ex As Exception
                MessageBox.Show("Error mengambil data: " & ex.Message & vbCrLf & ex.StackTrace,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Admin Panel - " & moduleKoneksi.CurrentUserName
        tampilDataUser()
        tampilDataProfilLulusan()
        txbUname.Clear()
        'txbPass.Clear()
    End Sub

    ' ========== BUTTON UPDATE ==========
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validasi: Pastikan ada data yang dipilih
        If selectedUserId = 0 Then
            MessageBox.Show("Silakan pilih user yang ingin diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi: Pastikan TextBox tidak kosong
        'If String.IsNullOrWhiteSpace(txbUname.Text) Or String.IsNullOrWhiteSpace(txbPass.Text) Then
        '    MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return
        'End If

        ' Konfirmasi update
        Dim result As DialogResult = MessageBox.Show(
            $"Apakah Anda yakin ingin mengupdate data user ini?" & vbCrLf & vbCrLf &
            $"Username: {txbUname.Text}" & vbCrLf &
            $"User ID: {selectedUserId}",
            "Konfirmasi Update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.No Then Return

        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            Try
                ' ✅ Update berdasarkan ID (lebih aman dari pada WHERE username)
                Dim query As String = "UPDATE tb_users SET username=@username WHERE userId=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txbUname.Text.Trim())
                'cmd.Parameters.AddWithValue("@password", txbPass.Text.Trim())
                cmd.Parameters.AddWithValue("@id", selectedUserId)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Data user berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh data
                    tampilDataUser()
                    tampilDataProfilLulusan()

                    ' Clear selection
                    txbUname.Clear()
                    'txbPass.Clear()
                    selectedUserId = 0
                Else
                    MessageBox.Show("Data tidak ditemukan atau tidak ada perubahan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As MySqlException
                If ex.Number = 1062 Then ' Duplicate entry error
                    MessageBox.Show("Username sudah digunakan! Silakan gunakan username lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Error update data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ========== BUTTON DELETE ==========
    Private Sub btnDelate_Click(sender As Object, e As EventArgs) Handles btnDelate.Click
        ' Validasi: Pastikan ada data yang dipilih
        If selectedUserId = 0 Then
            MessageBox.Show("Silakan pilih user yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ✅ Proteksi: Jangan hapus user yang sedang login
        If selectedUserId = moduleKoneksi.CurrentUserID Then
            MessageBox.Show("Anda tidak dapat menghapus akun yang sedang digunakan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Konfirmasi delete
        Dim result As DialogResult = MessageBox.Show(
            $"PERHATIAN!" & vbCrLf & vbCrLf &
            $"Apakah Anda yakin ingin menghapus user ini?" & vbCrLf &
            $"Username: {txbUname.Text}" & vbCrLf &
            $"User ID: {selectedUserId}" & vbCrLf & vbCrLf &
            $"Data yang terhapus TIDAK DAPAT dikembalikan!",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If result = DialogResult.No Then Return

        Using conn As MySqlConnection = GetConnection()
            If conn Is Nothing Then Return

            Try
                ' ✅ Gunakan transaksi untuk delete data terkait
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' 1. Hapus data konsultasi user
                    Dim deleteKonsultasiQuery As String = "DELETE FROM tb_konsultasi WHERE userId=@id"
                    Dim cmdKonsultasi As New MySqlCommand(deleteKonsultasiQuery, conn, transaction)
                    cmdKonsultasi.Parameters.AddWithValue("@id", selectedUserId)
                    cmdKonsultasi.ExecuteNonQuery()

                    ' 2. Hapus data user
                    Dim deleteUserQuery As String = "DELETE FROM tb_users WHERE userId=@id"
                    Dim cmdUser As New MySqlCommand(deleteUserQuery, conn, transaction)
                    cmdUser.Parameters.AddWithValue("@id", selectedUserId)
                    Dim rowsAffected As Integer = cmdUser.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        transaction.Commit()
                        MessageBox.Show("Data user berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh data
                        tampilDataUser()
                        tampilDataProfilLulusan()

                        ' Clear selection
                        txbUname.Clear()
                        'txbPass.Clear()
                        selectedUserId = 0
                    Else
                        transaction.Rollback()
                        MessageBox.Show("Data tidak ditemukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try

            Catch ex As Exception
                MessageBox.Show("Error delete data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ========== BONUS: Button Clear ==========
    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '    txbUname.Clear()
    '    txbPass.Clear()
    '    selectedUserId = 0
    '    DataGridView2.ClearSelection()
    'End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Event handler kosong (bisa dihapus jika tidak digunakan)
    End Sub

End Class