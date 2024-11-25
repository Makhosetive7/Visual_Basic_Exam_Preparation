Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Mathematics"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim number_1 As Integer = TextBox1.Text
        Dim number_2 As Integer = TextBox2.Text
        Dim result As Double


        If RadioButton1.Checked Then
            result = number_1 + number_2
        End If

        If RadioButton2.Checked Then
            result = number_1 - number_2
        End If

        If RadioButton3.Checked Then
            result = number_1 * number_2
        End If

        If RadioButton4.Checked Then
            result = number_1 / number_2
        End If

        TextBox3.Text = result



    End Sub
End Class
