Imports MySql.Data.MySqlClient

Module moduleKoneksi

    ' Sesuaikan dengan konfigurasi XAMPP/MySQL Anda
    Public Const connStr As String = "Server=localhost;Database=db_sistempakarprofillulusanit;Uid=root;Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connStr)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Gagal koneksi database: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Variabel global untuk sesi user
    Public CurrentUserID As Integer = 0
    Public CurrentUserName As String = ""
End Module
