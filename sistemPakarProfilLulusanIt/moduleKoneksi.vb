Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

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

    ' ✅ Function untuk hash password (Global - bisa dipanggil dari mana saja)
    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    ' Variabel global untuk sesi user
    Public CurrentUserID As Integer = 0
    Public CurrentUserName As String = ""
    Public CurrentPass As String = ""
    Public CurrentUserRole As String = ""
    Public CurrentNim As String = ""
    Public CurrentProdi As String = ""
End Module
