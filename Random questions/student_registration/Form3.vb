Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Information Technology")
        ComboBox1.Items.Add("Food Science")
        ComboBox1.Items.Add("Diesil plant and fitting")
        ComboBox1.Items.Add("Quantity Survey")


        ComboBox2.Items.Add("National Certificate")
        ComboBox2.Items.Add("National Diploma")
        ComboBox2.Items.Add("Higher National Diploma")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fullname As String = TextBox1.Text
        Dim selected_course As String = ComboBox1.SelectedItem
        Dim selected_level As String = ComboBox2.SelectedItem

        If ComboBox1.SelectedItem IsNot Nothing And ComboBox2.SelectedItem IsNot Nothing Then
            MessageBox.Show("Hello " & fullname & "! You selected the course '" & ComboBox1.SelectedItem.ToString() & "' and the level '" & ComboBox2.SelectedItem.ToString() & "'.")
        End If

    End Sub

End Class