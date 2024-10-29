Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Label1.Text = "Area = (Length * 2) + (width * 2)"
        ElseIf RadioButton2.Checked Then
            Label1.Text = "Area = Math.pi * radius * radius"
        ElseIf RadioButton3.checked Then
            Label1.Text = "Area = Length * width"
        ElseIf RadioButton4.Checked Then
            Label1.Text = "0.5 * base * height"
        Else
            Label1.Text = "There is no shape selected at the moment"
        End If
    End Sub
End Class
