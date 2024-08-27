Public Class Form1
    Dim number As Integer
    Dim answer As Double

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        number = TextBox1.Text
        answer = Math.Sqrt(number)
        MsgBox(answer)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        number = TextBox1.Text
        answer = number ^ (1 / 3)
        MsgBox(answer)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
