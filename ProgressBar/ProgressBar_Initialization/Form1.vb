Public Class Form1
    'Write a Visual Basic code snippet to initialize a ProgressBar control with a minimum value of 0, a
    'maximum value Of 100, And a starting value Of 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100

        For i As Integer = ProgressBar1.Minimum To ProgressBar1.Maximum Step 10
            ProgressBar1.Value = i
            System.Threading.Thread.Sleep(100)

            If ProgressBar1.Value = 100 Then
                MessageBox.Show("progress bar has reached 100%")
            End If
        Next


    End Sub

End Class
