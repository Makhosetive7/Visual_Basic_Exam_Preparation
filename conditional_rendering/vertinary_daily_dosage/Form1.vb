Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dog_name As String = TextBox1.Text
        Dim dog_weight As Double
        Dim dosage As Double = 0

        ' Check if the dog name is empty
        If dog_name = "" Then
            MessageBox.Show("Dog name cannot be left empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' TryParse the weight to ensure it's numeric
        If Not Double.TryParse(TextBox2.Text, dog_weight) Then
            MessageBox.Show("Please enter a valid weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Calculate the dosage based on the weight
        If dog_weight < 5 Then
            dosage = 1.0
        ElseIf dog_weight >= 5 AndAlso dog_weight <= 8 Then
            dosage = 0.9
        ElseIf dog_weight > 8 AndAlso dog_weight <= 12 Then
            dosage = 0.75
        ElseIf dog_weight > 12 Then
            dosage = 0.55
        End If

        ' Display the dosage and dog name
        Label3.Text = $"The daily dosage for {dog_name} is {dosage} ml per 500g."

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear the form fields
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Exit the application
        Me.Close()
    End Sub
End Class
