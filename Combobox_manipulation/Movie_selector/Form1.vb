Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Action")
        ComboBox1.Items.Add("Comedy")
        ComboBox1.Items.Add("Science-Fiction")
        ComboBox1.Items.Add("Horror")
        ComboBox1.Items.Add("Romance")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Action" Then
            ListBox1.Items.Add("Die-Hard")
            ListBox1.Items.Add("Mad Max")
            ListBox1.Items.Add("The dark night")
            ListBox1.Items.Add("John Weak")
            ListBox1.Items.Add("Gladiator")
        ElseIf ComboBox1.SelectedItem = "Commedy" Then
            ListBox1.Items.Add("The hangover")
            ListBox1.Items.Add("Super bad")
            ListBox1.Items.Add("Step brothers")
            ListBox1.Items.Add("Grey hound")
            ListBox1.Items.Add("Anchorman")
        ElseIf ComboBox1.SelectedItem = "Science-Fiction" Then
            ListBox1.Items.Add("Inception")
            ListBox1.Items.Add("Interstellar")
            ListBox1.Items.Add("The matrix")
        ElseIf ComboBox1.SelectedItem = "Horror" Then
            ListBox1.Items.Add("The exocist")
            ListBox1.Items.Add("The conjuring")
        End If

    End Sub
End Class
