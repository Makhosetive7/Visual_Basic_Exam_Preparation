Imports System.Windows.Forms.VisualStyles

Public Class Form1
    'Build a Windows Forms application where the user inputs a rental start date, return date, daily
    'rate, And monthly rate. If the rental duration exceeds 30 days, the program uses the monthly
    'rate; otherwise, it uses the daily rate. Display the total rental cost in a label.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rental_start_date As DateTime = DateTimePicker1.Value
        Dim rental_return_date As DateTime = DateTimePicker2.Value

        Dim total_rental_days As Long
        Dim total_rental_cost As Long

        Dim selected_rate As Integer = calculate_rates()

        total_rental_days = DateDiff(DateInterval.Day, rental_start_date, rental_return_date)

        total_rental_cost = selected_rate * total_rental_days

        MessageBox.Show(String.Format("The total cost expected to be paid is: {0}", total_rental_cost))


    End Sub
    Function calculate_rates() As Integer

        Dim rate As Integer

        If RadioButton1.Checked Then
            rate = 3.0
        ElseIf RadioButton2.Checked Then
            rate = 100.0
        Else
            MessageBox.Show("Please select an option", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return rate
    End Function
End Class
