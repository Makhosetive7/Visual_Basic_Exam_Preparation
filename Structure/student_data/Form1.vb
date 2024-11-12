Public Class Form1
    'Design a Windows forms application that accepts (in textboxes) student details which are name, class, year and tuition. Create a structure called Student and use it to capture the values entered by user.
    'Display the student record In a listbox. Remember To include a line Of column headings In the listbox.



    Public Structure student_details
        Public name As String
        Public year As Double
        Public tuition As Double
        Public class_number As Double
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim student_records(2) As student_details

        For i As Integer = 0 To 2
            student_records(i).name = TextBox1.Text
            student_records(i).year = TextBox2.Text
            student_records(i).tuition = TextBox3.Text
            student_records(i).class_number = TextBox4.Text
        Next


        ListBox1.Items.Clear()

        ListBox1.Items.Add("Name" & vbTab & "Year" & vbTab & "Tuition" & vbTab & "Class Number")

        For i As Integer = 0 To 2
            ListBox1.Items.Add(student_records(i).name & vbTab & student_records(i).year & vbTab & student_records(i).tuition & vbTab & student_records(i).class_number)
        Next

    End Sub
End Class
