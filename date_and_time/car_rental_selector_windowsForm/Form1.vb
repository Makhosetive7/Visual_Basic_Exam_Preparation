Public Class Form1
    'Create a Windows Forms application that allows users to select a rental start date and
    'Return Date Using DateTimePicker controls. Calculate the number Of days between the
    'two dates And display the total rental days In a label

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start_date As DateTime = DateTimePicker1.Value
        Dim end_date As DateTime = DateTimePicker2.Value
        Dim return_date As Long

        return_date = DateDiff(DateInterval.Day, start_date, end_date)

        Label3.Text = return_date
    End Sub
End Class
