Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Label1.Text = "you have selected the checkbox"
        Else
            Label1.Text = "you have not selected the checkbox"
        End If
    End Sub
End Class
