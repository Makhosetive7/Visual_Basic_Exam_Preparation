Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim shirt As Decimal = 12.0
        Dim trouse As Decimal = 25.0
        Dim shoe As Decimal = 55.0
        Dim socks As Decimal = 3.5
        Dim hat As Decimal = 5.0
        Dim suit As Decimal = 95.0

        Dim total = shirt + trouse + shoe + socks + hat + suit

        Label8.Text = total

        If CheckBox1.Checked Then
            total += shirt

        ElseIf CheckBox2.Checked Then
            total += trouse

        ElseIf CheckBox3.Checked Then
            total += shoe

        ElseIf CheckBox4.Checked Then
            total += socks

        ElseIf CheckBox5.Checked Then
            total += hat

        ElseIf CheckBox6.Checked Then
            total += suit
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub
End Class
