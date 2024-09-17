Public Class Form1
    Dim random_Number = New Random()
    Dim first_num As Integer
    Dim second_num As Integer
    Dim answer As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = random_Number.Next(0, 100)
        TextBox2.Text = random_Number.Next(0, 100)

        answer = TextBox1.Text + TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim user_answer As Integer = TextBox3.Text

        If user_answer = answer Then
            MessageBox.Show("The answer is correct!")
        Else
            MessageBox.Show("The answer is wrong!")
        End If
    End Sub
End Class
