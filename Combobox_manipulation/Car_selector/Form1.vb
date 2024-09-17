Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populating combo box one
        ComboBox1.Items.Add("Honda")
        ComboBox1.Items.Add("Ford")
        ComboBox1.Items.Add("BMW")
        ComboBox1.Items.Add("Toyota")
        ComboBox1.Items.Add("Mazda")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Populating combobox two
        If ComboBox1.SelectedItem = "Honda" Then
            ComboBox2.Items.Add("Fit")
            Label3.Text = "The selected model is: FIT "
        ElseIf ComboBox1.SelectedItem = "Ford" Then
            ComboBox2.Items.Add("Focus")
            Label3.Text = "The selected model is: FOCUS "
        ElseIf ComboBox1.SelectedItem = "BMW" Then
            ComboBox2.Items.Add("X5")
            Label3.Text = "The selected model is: X5 "
        ElseIf ComboBox1.SelectedItem = "Toyota" Then
            ComboBox2.Items.Add("Corolla")
            Label3.Text = "The selected model is: COROLLA "
        ElseIf ComboBox1.SelectedItem = "Mazda" Then
            ComboBox2.Items.Add("CX-5")
            Label3.Text = "The selected model is: CX-5 "
        End If
    End Sub
End Class
