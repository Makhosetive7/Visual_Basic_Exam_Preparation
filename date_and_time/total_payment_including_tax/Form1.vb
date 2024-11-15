Public Class Form1
    'Design a Windows Forms application where the user selects the rental start date and
    'Return Date And inputs the daily rental fee. The application calculates the total rental
    'days And the total payment, including tax fee, And displays it in a label.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rental_start_date As DateTime = DateTimePicker1.Value
        Dim rental_return_date As DateTime = DateTimePicker2.Value
        Dim daily_rental_fee As Integer = 2
        Dim tax_fee As Double = TextBox1.Text

        Dim total_amount_paid_before_tax As Double
        Dim total_amount_paid_after_tax As Double

        Dim total_rental_days As Long

        total_rental_days = DateDiff(DateInterval.Day, rental_start_date, rental_return_date)


        total_amount_paid_before_tax = total_rental_days * daily_rental_fee
        total_amount_paid_after_tax = total_amount_paid_before_tax * (1 + tax_fee)


        Label4.Text = $"Total Rental Days: {total_rental_days}" & vbTab &
                      $"Total Amount Before Tax: ${total_amount_paid_before_tax:F2}" & vbTab &
                      $"Total Amount After Tax: ${total_amount_paid_after_tax:F2}"




    End Sub
End Class
