Public Class dashboard
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formSoal As New formSoal()
        formSoal.Show()
    End Sub
End Class