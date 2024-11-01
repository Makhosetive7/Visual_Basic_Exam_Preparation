Imports System.IO

Module Module1

    'Reads a text file named Students.txt located In the same directory As your application. Each line In the file contains the name Of a student.
    'Displays each student's name on a new line in the console.

    Sub Main()
        Dim lines As String
        Dim file_path As String = "C:\Users\USER\Desktop\Desktop\Code\Visual_Basic_local_storage\Files\student_names\Student_names\student.txt"


        If File.Exists(file_path) Then

            Using sr As StreamReader = New StreamReader(file_path)
                Console.WriteLine("The students names are: ")

                Do While (sr.Peek() >= 0)
                    lines = sr.ReadLine
                    Console.WriteLine(lines)
                Loop
            End Using

        End If

        Console.ReadKey()

    End Sub

End Module
