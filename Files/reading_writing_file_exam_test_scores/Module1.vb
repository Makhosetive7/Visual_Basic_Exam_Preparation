Imports System.IO

Module Module1

    'Write a VB.NETconsole application that prompts the user to input a student's name and their test scores for three
    'subjects. Calculate the average score and display the student's name, scores for each subject, and their average
    'score. Ensure the program validates that the input scores are between 0 and 100. If any score is outside this range,
    'display an error message and prompt the user to re-enter the score

    Sub Main()
        Dim file_path As String = "C:\Users\USER\Desktop\hello.txt"
        Dim line As String

        Using sw As StreamWriter = New StreamWriter(file_path)
            Dim student_name As String
            Dim test_score_1 As Integer
            Dim test_score_2 As Integer
            Dim test_score_3 As Integer
            Dim total_test_score As Double
            Dim average_score As Integer

            Console.WriteLine("Please enter students name : ")
            student_name = Console.ReadLine()

            Console.WriteLine("Please enter Test score 1 : ")
            test_score_1 = Integer.Parse(Console.ReadLine())

            Console.WriteLine("Please enter Test score 2 : ")
            test_score_2 = Integer.Parse(Console.ReadLine())

            Console.WriteLine("Please enter Test score 3 : ")
            test_score_3 = Integer.Parse(Console.ReadLine())

            total_test_score = test_score_1 + test_score_2 + test_score_3

            average_score = total_test_score / 3

            sw.WriteLine("The student name is : {0}" & Environment.NewLine & "Test score 1 is : {1}" & Environment.NewLine & "Test score 2 is : {2}" & Environment.NewLine & "Test score 3 is : {3}" & Environment.NewLine & "The avarage Test score is : {4}", student_name, test_score_1, test_score_2, test_score_3, average_score)
            Console.WriteLine("The student name is : {0}" & Environment.NewLine & "Test score 1 is : {1}" & Environment.NewLine & "Test score 2 is : {2}" & Environment.NewLine & "Test score 3 is : {3}" & Environment.NewLine & "The avarage Test score is : {4}", student_name, test_score_1, test_score_2, test_score_3, average_score)
        End Using


        'reading from file
        If File.Exists(file_path) Then
            Using sr As StreamReader = New StreamReader(file_path)
                line = sr.ReadLine()

                While (line <> Nothing)
                    Console.WriteLine("----------------------------------------------------------------------------")
                    Console.WriteLine(line)
                    line = sr.ReadLine()
                End While
            End Using
        End If


        Console.ReadKey()

    End Sub

End Module
