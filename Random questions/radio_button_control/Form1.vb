Public Class Form1
    ' Design a form that allows the user to select their preferred membership plan using RadioButton controls:
    ' "Basic", "Standard", or "Premium". When the user clicks the "Submit" button, display a message box that shows
    ' the selected membership plan.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MessageBox.Show("you've selected BASIC package")
        ElseIf RadioButton2.Checked = True Then
            MessageBox.Show("you've selected STANDARD package")
        ElseIf RadioButton3.Checked = True Then
            MessageBox.Show("you've selected Premium package")
        Else
            MessageBox.Show("You need to select an option")
        End If
    End Sub
End Class
