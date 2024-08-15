Module Module1
    'Define a Structure named Student that includes the following fields: Name
    '(String), StudentID (Integer), DateOfBirth (Date), And Marks (Double). Write a subroutine 
    'called DisplayStudentDetails that takes an instance Of Student As a parameter And 
    'displays the student's details in a formatted manner.

    Public Structure Student
        Dim name As String
        Dim studentID As Integer
        Dim dateOfBirth As Date
        Dim Marks As Double
    End Structure

    Sub Main()
        Dim student_details As Student = New Student()

        Console.WriteLine("Please enter student name:")
        student_details.name = Console.ReadLine()

        Console.WriteLine("Please enter student identity:")
        student_details.studentID = Console.ReadLine()

        Console.WriteLine("Please enter student date of birth:")
        student_details.dateOfBirth = Console.ReadLine()

        Console.WriteLine("Please enter student marks:")
        student_details.Marks = Console.ReadLine()

        DisplayStudentDetails(student_details)
        Console.ReadLine()

    End Sub

    Sub DisplayStudentDetails(Student As Student)
        Console.WriteLine("{0}, date of birth {1}, whose student id is {2} got {3} marks in english test", Student.name, Student.dateOfBirth, Student.studentID, Student.Marks)
    End Sub

End Module
