Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rental_start_date As DateTime = DateTimePicker1.Value
        Dim expected_return_date As DateTime = DateTimePicker2.Value
        Dim actual_return_date As DateTime = DateTimePicker3.Value
        Dim rental_fee As Double = 5
        Dim total_amount_payable_after_penalties As Double
        Dim total_amount_payed_before_penalties As Double



        Dim total_number_of_days As Long

        total_number_of_days = DateDiff(DateInterval.Day, rental_start_date, expected_return_date)
        ListBox1.Items.Add($"You have rented our product for: {total_number_of_days}")



        If actual_return_date > expected_return_date Then
            total_amount_payable_after_penalties = (15 / 100) + (total_number_of_days * rental_fee)
            ListBox1.Items.Add($"The amount payed after penalties is: { total_amount_payable_after_penalties}")
        Else
            total_amount_payed_before_penalties = total_number_of_days * rental_fee
            ListBox1.Items.Add($"The total amount payed is: {total_amount_payed_before_penalties}")
        End If

    End Sub
End Class
