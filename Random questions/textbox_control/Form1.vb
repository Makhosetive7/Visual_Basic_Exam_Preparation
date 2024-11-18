Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enter_name As String
        Dim enter_surname As String

        enter_name = TextBox1.Text
        enter_surname = TextBox2.Text

        If enter_name IsNot "" And enter_surname IsNot "" Then
            MessageBox.Show(String.Format("Hello {0} {1}", enter_name, enter_surname), "success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("There is an empty field", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class
