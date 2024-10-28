Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hours_worked As Integer = Decimal.Parse(TextBox1.Text)
        Dim rate_per_hour As Integer



        Dim gross_salary As Integer = 

        If hours_worked > 40 Then
            TextBox4.Text = hours_worked - 40
        Else
            TextBox4.Text = 0
        End If

        gross_salary = (hours_worked * rate_per_hour)



    End Sub
End Class
