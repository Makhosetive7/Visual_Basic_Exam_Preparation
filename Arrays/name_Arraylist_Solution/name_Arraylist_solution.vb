Public Class Form1
    'Create the interface given in the attached image.
    'Write appropriate code to populate an array and display the elements of the array in the listbox
    'when the button is clicked.
    'Pointers:
    '1. You need to declare an array to hold 5 names.
    '2. Add each names in array to listbox
    '3. Post a running application
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Array_names() As String = {"mellisa, shantell, melody, gail, marvis"}

        For i As Integer = 0 To Array_names.Length - 1
            ListBox1.Items.Add(Array_names(i))
        Next

    End Sub
End Class
