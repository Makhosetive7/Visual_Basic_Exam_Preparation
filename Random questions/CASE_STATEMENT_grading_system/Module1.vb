Module Module1
    'Write a program that prompts the user to input a student's score (integer between 0 and 100). Use a Select Case statement to determine the grade according to the following criteria:
    '--- 90-100: Grade A
    '--- 80-89: Grade B
    '--- 70-79: Grade C
    '--- 60-69: Grade D
    '--- Below 60: Grade F
    'Display the student's grade based on their score.

    Sub Main()
        Dim student_score As Integer

        Console.WriteLine("Please enter student score")
        student_score = Console.ReadLine()

        Select Case student_score
            Case 90 To 100
                Console.WriteLine("Congradulations. you attained GRADE A")
            Case 80 To 89
                Console.WriteLine("Congradulations. you attained GRADE B")
            Case 70 To 79
                Console.WriteLine("Congradulations. you attained GRADE C")
            Case 60 To 69
                Console.WriteLine("Congradulations. you attained GRADE D")
            Case 0 To 59
                Console.WriteLine("Congradulations. you attained GRADE E")
            Case Else
                Console.WriteLine("Invalid score. Please enter a score between 0 and 100.")
        End Select


        Console.ReadKey()
    End Sub

End Module
