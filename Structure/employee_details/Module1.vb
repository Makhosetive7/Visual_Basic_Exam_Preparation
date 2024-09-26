Module Module1
    'Create a Visual Basic structure named Employee that stores the following details for each employee:
    '• Name
    '• Age
    '• Job Title
    '• Salary
    'Write a program that accepts input For 3 employees, stores their details, And displays the information For Each
    'employee.

    Public Structure Employee
        Dim name As String
        Dim age As Integer
        Dim job_title As String
        Dim salary As Decimal
    End Structure
    Sub Main()

        Dim employee_data(2) As Employee

        For i As Integer = 0 To 2
            Console.WriteLine("Please enter employee name:")
            employee_data(i).name = Console.ReadLine()

            Console.WriteLine("Please enter employee age:")
            employee_data(i).age = Console.ReadLine()

            Console.WriteLine("Please enter employee Job Title:")
            employee_data(i).job_title = Console.ReadLine()

            Console.WriteLine("Please enter employee salary:")
            employee_data(i).salary = Console.ReadLine()
        Next

        For i As Integer = 0 To 2
            Console.WriteLine("Employee {0} details", i + 1)
            Console.WriteLine("Name: " & employee_data(i).name)
            Console.WriteLine("Age: " & employee_data(i).age)
            Console.WriteLine("Job Title: " & employee_data(i).job_title)
            Console.WriteLine("Salary: " & employee_data(i).salary)
        Next


        Console.ReadKey()

    End Sub


End Module
