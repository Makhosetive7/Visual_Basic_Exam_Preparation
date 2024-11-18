Public Class Form1
    'Create a Visual Basic application that has a ComboBox filled with a list of colors
    '(e.g., Red, Blue, Green, Yellow). When the user selects a color from the dropdown
    'and clicks the "Change Color" button, the background color of the form should change to the selected color.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("red")
        ComboBox1.Items.Add("green")
        ComboBox1.Items.Add("yellow")
        ComboBox1.Items.Add("blue")
        ComboBox1.Items.Add("pink")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Red"
                Me.BackColor = Color.Red
            Case "Green"
                Me.BackColor = Color.Green
            Case "Yellow"
                Me.BackColor = Color.Yellow
            Case "Blue"
                Me.BackColor = Color.Blue
            Case "Pink"
                Me.BackColor = Color.Pink
            Case Else
                MessageBox.Show("Please select a valid color.")
        End Select
    End Sub
End Class
