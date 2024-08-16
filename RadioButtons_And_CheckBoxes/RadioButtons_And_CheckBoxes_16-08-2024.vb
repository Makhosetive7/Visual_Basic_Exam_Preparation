Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'functionality for exit button
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If RadioButton1.Checked And CheckBox1.Checked Then
            Label1.Text = "Green"
        ElseIf RadioButton2.Checked And CheckBox2.Checked Then
            Label1.Text = "Blue"
        ElseIf RadioButton3.Checked And CheckBox3.Checked Then
            Label1.Text = "Red"
        ElseIf RadioButton4.Checked And CheckBox4.Checked Then
            Label1.Text = "Yellow"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'functionality for default button
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub
End Class
