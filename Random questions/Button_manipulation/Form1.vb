Public Class Form1
    '"Design an interface with a frame containing two textboxes labelled keyboard and mouse and another frame with two option buttons enabled and disabled respectively. Write VB code such that when a user selects the option disabled, the textboxes will be grayed, and when the user selects the option enabled, the textboxes will be enabled
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub
End Class
