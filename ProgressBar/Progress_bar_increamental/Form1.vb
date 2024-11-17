Public Class Form1
    'Write a program in Visual Basic that uses a For...Next loop to increase the value of a ProgressBar
    'by 5 units on each iteration until it reaches the maximum value. Display a message box saying
    '"Completed" when it reaches 100.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100


        For i As Integer = ProgressBar1.Minimum To ProgressBar1.Maximum
            ProgressBar1.Value = i

            If ProgressBar1.Value = 100 Then
                MessageBox.Show("Progress bar has reached 100%", "success", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Next
    End Sub




End Class
