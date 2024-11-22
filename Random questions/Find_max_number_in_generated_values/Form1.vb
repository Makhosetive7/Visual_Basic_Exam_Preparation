Public Class Form1
    ' Generate random numbers and display them all using an array
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Generate random numbers and display Maximum number"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random_numbers As New Random()
        Dim numbers(49) As Integer

        For i As Integer = 0 To 49
            numbers(i) = random_numbers.Next(0, 51)
            ListBox1.Items.Add(numbers(i))
        Next

        Dim maximum_number As Integer = numbers.Max()

        ListBox2.Items.Add(maximum_number)
    End Sub
End Class
