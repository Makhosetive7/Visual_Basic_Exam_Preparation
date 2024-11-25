Public Class Form1
    'ADDING MULTIPLE VALUES IN 0NE TEXTBOX

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim values As String() = TextBox1.Text.Split(" ")
        Dim total As Long

        For Each value In values
            total += CType(value, Long)
        Next

        MessageBox.Show(String.Format("the total is {0}", total))
    End Sub
End Class
