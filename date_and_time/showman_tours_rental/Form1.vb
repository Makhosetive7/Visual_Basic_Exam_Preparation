Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start_date As Date = TextBox1.Text
        Dim end_date As Date = TextBox2.Text
        Dim starting_mileage As Double
        Dim ending_mileage As Double
        Dim total_distance As Double
        Dim total_charge_per_kilometre As Double = 2.6
        Dim result As Integer
        Dim daily_rate As Double = 270



        result = (end_date - start_date).Days
        total_distance = ending_mileage - starting_mileage

        TextBox5.Text = result
        TextBox8.Text = total_distance


        TextBox7.Text = daily_rate * result
        TextBox10.Text = total_distance * total_charge_per_kilometre

        TextBox11.Text = (daily_rate * result) * (total_distance * total_charge_per_kilometre)




    End Sub
End Class
