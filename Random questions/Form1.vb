Public Class Form1
    Dim rnd As New Random

    Dim first_number As Integer = rnd.Next(0, 10)
    Dim second_number As Integer = rnd.Next(0, 10)
    Dim third_number As Integer = rnd.Next(0, 10)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = first_number.ToString()
        Label2.Text = second_number.ToString()
        Label3.Text = third_number.ToString()

        If first_number = 7 And second_number = 7 And third_number = 7 Then
            PictureBox1.Visible = True

        Else
            PictureBox1.Visible = False
        End If
    End Sub
End Class
