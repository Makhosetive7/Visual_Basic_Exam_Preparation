Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'changing label text color with a click of a button
        Dim r, g, b As Integer

        r = Int(Rnd() * 256)
        g = Int(Rnd() * 256)
        b = Int(Rnd() * 256)

        Label1.ForeColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'changing form background color with a click of a button
        Dim r As Integer = Int(Rnd() * 256)
        Dim g As Integer = Int(Rnd() * 256)
        Dim b As Integer = Int(Rnd() * 256)

        Me.BackColor = Color.FromArgb(r, g, b)
    End Sub
End Class
