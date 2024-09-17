Public Class Form1

    'adding items
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.SelectedItem)
    End Sub

    'populates the combobox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Add("2020")
        ComboBox1.Items.Add("2021")
        ComboBox1.Items.Add("2022")
        ComboBox1.Items.Add("2023")
        ComboBox1.Items.Add("2024")
    End Sub

    'sorting items
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Sorted = True
    End Sub

    'clearing items
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub
End Class
