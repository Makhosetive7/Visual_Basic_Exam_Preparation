Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim first_Number As Double = TextBox1.Text
            Dim second_Number As Double = TextBox2.Text
            Dim answer As Double = TextBox3.Text
            answer = first_Number / second_Number
        Catch ex As Exception
            TextBox3.Text = "Error"
            Label4.Text = "One of the inputs is not a number. Please try again"
        End Try

    End Sub
End Class
