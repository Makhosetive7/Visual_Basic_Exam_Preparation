Module Module1
    'Nenyasha works as a part time assistant in a book shop and receives an hourly wage. Enter the number
    'of hours he worked for a specific week, as well as the pay rate per hour. He has to pay $8 per week
    'towards the recreation club. Write a console application To calculate And display how much he has
    'earned for the week.

    Sub Main()
        Dim hourly_wage As Double
        Dim hours_worked As Double
        Dim total_salary As Double
        Dim recreational_club_fee As Double = 8



        Console.WriteLine("Please enter Nenyasha's hourly wage: ")
        hourly_wage = Console.ReadLine()

        Console.WriteLine("Enter the number of hours he worked: ")
        hours_worked = Console.ReadLine()

        total_salary = (hourly_wage * hours_worked) - recreational_club_fee

        Console.WriteLine("The amount he earned this week is {0}", total_salary)


        Console.ReadKey()


    End Sub

End Module
