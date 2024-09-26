Module Module1
    'Define a structure named Student that stores the following details:
    '• Student ID
    '• Name
    '• Course
    '• Grade
    'Allow the user To input the details For 5 students, store them In an array Of Student structures, And print out the list
    'of students And their grades.

    Public Structure Student
        Dim student_id As Double
        Dim name As String
        Dim course As String
        Dim grade As Char
    End Structure
    Sub Main()

        Dim student_data(2) As Student

        For i As Integer = 0 To 2
            Console.WriteLine("Please enter student Identity:")
            student_data(i).student_id = Console.ReadLine()

            Console.WriteLine("Please enter student name:")
            student_data(i).name = Console.ReadLine()

            Console.WriteLine("Please enter student course:")
            student_data(i).course = Console.ReadLine()

            Console.WriteLine("Please enter student grade:")
            student_data(i).grade = Console.ReadLine()
        Next

        Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10}", "student_id", "name", "couse", "grade")
        Console.WriteLine(New String("-"c, 55))

        For i As Integer = 0 To 2
            Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10}", student_data(i).student_id, student_data(i).name, student_data(i).course, student_data(i).grade)
        Next

        Console.ReadKey()

    End Sub

End Module
