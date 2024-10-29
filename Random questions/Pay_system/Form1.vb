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
        Dim hours_worked As Integer = Integer.Parse(TextBox1.Text)
        Dim rate_per_hour As Integer = Integer.Parse(TextBox3.Text)
        Dim overtime As Integer = Math.Max(0, hours_worked - 40)
        Dim overtime_pay As Integer = rate_per_hour * overtime * 1.5
        Dim tax_rate As Decimal = Decimal.Parse(TextBox5.Text) / 100

        Dim gross_salary As Decimal = (hours_worked * rate_per_hour) + overtime
        Dim tax_deductions As Decimal = gross_salary * tax_rate
        Dim net_salary As Decimal = gross_salary - tax_deductions


        TextBox4.Text = overtime.ToString()
        Label10.Text = tax_deductions.ToString("C")
        Label11.Text = net_salary.ToString("C")











    End Sub
End Class
