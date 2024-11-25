Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Principal As Double = Double.Parse(TextBox1.Text)
        Dim interest As Double = Double.Parse(TextBox2.Text)
        Dim number_of_period As Double = Double.Parse(TextBox3.Text)

        Dim compound As Integer

        If RadioButton1.Checked Then
            compound = 1
        ElseIf RadioButton2.Checked Then
            compound = 2
        ElseIf RadioButton3.Checked Then
            compound = 3
        ElseIf RadioButton4.Checked Then
            compound = 4
        End If

        Dim ri As Double = interest / (compound * 100)
        Dim rn As Double = number_of_period * compound

        Dim amount_earned As Double = Principal * Math.Pow(1 + ri, rn)
        Dim interest_earned As Double = amount_earned - Principal

        TextBox4.Text = interest_earned.ToString("0.00")
        TextBox5.Text = amount_earned.ToString("0.00")
    End Sub
End Class
