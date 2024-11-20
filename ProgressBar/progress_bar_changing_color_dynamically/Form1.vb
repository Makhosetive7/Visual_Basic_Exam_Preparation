Public Class Form1
    'Write code that changes the color of the ProgressBar (use ForeColor) based on its progress. For
    'example:
    '---o 0-30% Red
    '---o 31-70%: Yellow
    '---o 71-100%: Green

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Changing ProgressBar Color Dynamically"
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = ProgressBar1.Minimum To ProgressBar1.Maximum Step 5
            ProgressBar1.Value = i

            If ProgressBar1.Value >= 0 AndAlso ProgressBar1.Value <= 30 Then
                ProgressBar1.BackColor = Color.Red
            ElseIf ProgressBar1.Value >= 31 AndAlso ProgressBar1.Value <= 70 Then
                ProgressBar1.BackColor = Color.Yellow
            ElseIf ProgressBar1.Value >= 71 AndAlso ProgressBar1.Value = 100 Then
                ProgressBar1.BackColor = Color.Green
            End If
        Next
    End Sub
End Class
