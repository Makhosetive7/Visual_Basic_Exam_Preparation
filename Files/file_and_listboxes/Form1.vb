Imports System.IO

Public Class Form1
    'Using VB.Net design and write code for an application to create the file sports.txt on any location of
    'the computer, with the following details: Football, Basketball, Golf And Volleyball. Display the content
    'of the file sports.txt in a Listbox.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file_path As String = "C:\Users\USER\Desktop\hello.txt"
        Dim line As String

        Using sw As StreamWriter = New StreamWriter(file_path)
            sw.WriteLine("Football")
            sw.WriteLine("Basketball")
            sw.WriteLine("Golf")
            sw.WriteLine("Volleyball")
        End Using

        If File.Exists(file_path) Then
            Using sr As StreamReader = New StreamReader(file_path)
                line = sr.ReadLine()
                While (line <> Nothing)
                    ListBox1.Items.Add(line)
                    line = sr.ReadLine()
                End While

            End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Files and Text boxes"
    End Sub
End Class
