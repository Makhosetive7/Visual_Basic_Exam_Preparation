Imports System.IO

Module Module1

    'Write a Visual Basic console program that reads a text file named students.txt, which 
    'contains student names On Each line. Display Each student's name and the total number 
    'of students read from the file.

    Sub Main()
        Dim filepath As String = "C:\Users\USER\Desktop\Visual_Basic\Files\Reading TextFile\students.txt"
        Dim line As String
        Dim studentCount As Integer = 0

        Using sr As StreamReader = New StreamReader(filepath)
            line = sr.ReadLine()

            While (line IsNot Nothing)
                Console.WriteLine(line)
                studentCount += 1
                line = sr.ReadLine()
            End While

            Console.WriteLine("they are {0} students in total", studentCount)

        End Using

        Console.ReadKey()

    End Sub

End Module
