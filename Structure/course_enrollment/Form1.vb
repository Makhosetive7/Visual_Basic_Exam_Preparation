Imports System.Diagnostics.PerformanceData
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    'Design a form that accepts course details (CourseID, CourseName, Credits, Instructor) and stores
    'each course in a Course structure. Populate a ComboBox with the course names after each entry.
    'Selecting a course from the ComboBox displays its details In labels below

    Public Structure Course_details
        Dim course_Id As Double
        Dim course_Name As String
        Dim course_Credits As String
        Dim course_Instructor As String
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim course As Course_details = New Course_details()

        course.course_Id = TextBox1.Text
        course.course_Name = TextBox2.Text
        course.course_Credits = TextBox3.Text
        course.course_Instructor = TextBox4.Text


        ComboBox1.Items.Add(course.course_Id)
        ComboBox1.Items.Add(course.course_Name)
        ComboBox1.Items.Add(course.course_Credits)
        ComboBox1.Items.Add(course.course_Instructor)

    End Sub
End Class
