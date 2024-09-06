Public Class Form1

    Dim array_list() As Integer = {100, 40, 30, 70, 50}

    'button to add Array list to the listbox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("adding array list :")
        For i As Integer = 0 To array_list.Length - 1
            ListBox1.Items.Add(array_list(i))
        Next
    End Sub

    'button to sort Array list in the listbox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Array.Sort(array_list)
        ListBox1.Items.Add("Sorted array list :")
        For Each i As Integer In array_list

            ListBox1.Items.Add(i)
        Next
    End Sub

    'button to reverse Array list
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Array.Reverse(array_list)
        ListBox1.Items.Add("Reversed array list :")
        For Each i As Integer In array_list
            ListBox1.Items.Add(i)
        Next

    End Sub
End Class
