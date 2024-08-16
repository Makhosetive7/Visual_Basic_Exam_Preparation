Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim word As String
        Dim isPalendrome As String

        isPalendrome = StrReverse(word)

        If word = isPalendrome Then
            TextBox1.Text = "the string is a palendrome"
        Else
            TextBox1.Text = "it is not a palendrome"
        End If

    End Sub
End Class
