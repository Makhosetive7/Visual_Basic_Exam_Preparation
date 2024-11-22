Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arrival_day As DateTime = DateTimePicker1.Value
        Dim departure_day As DateTime = DateTimePicker2.Value
        Dim single_room As Integer = 3.0
        Dim double_room As Integer = 5.5


        Dim total_number_of_days As Long
        Dim amount_due As Double

        total_number_of_days = DateDiff(DateInterval.Day, arrival_day, departure_day)

        If RadioButton1.Checked Then
            amount_due = total_number_of_days * single_room
        ElseIf RadioButton2.Checked Then
            amount_due = total_number_of_days * double_room
        End If


        ListBox1.Items.Add(String.Format("The total number of days: {0}", total_number_of_days))
        ListBox1.Items.Add(String.Format("Amount due: {0}", amount_due))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
