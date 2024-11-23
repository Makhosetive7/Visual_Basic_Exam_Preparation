Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random_number As New Random


        Dim random_number_generated_1 As Integer = random_number.Next(0, 8)
        Dim random_number_generated_2 As Integer = random_number.Next(0, 8)
        Dim random_number_generated_3 As Integer = random_number.Next(0, 8)

        Label1.Text = random_number_generated_1
        Label2.Text = random_number_generated_2
        Label3.Text = random_number_generated_3

        If Label1.Text = 7 Or Label2.Text = 7 Or Label3.Text = 7 Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Spin Button"
        PictureBox1.Visible = False
    End Sub
End Class
