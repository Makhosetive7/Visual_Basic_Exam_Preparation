Imports Microsoft.VisualBasic.ApplicationServices

Module Module1
    'Write a console application that calculates the total number of rental days and adds a
    'late fee If the Return Date Is past the expected Date. The user inputs the rental start Date,
    'expected return date, And actual return date. If the return date Is later than expected,
    'apply a late fee Of $20 per day For Each day past the expected Return Date

    '-- Hint: Use DateTime To calculate the days between dates And apply the late fee
    'conditionally.


    Sub Main()

        Dim rental_start_date As DateTime
        Dim rental_return_date As DateTime
        Dim actual_return_date As Integer

        Dim rental_days_payed_for As Integer
        Dim late_return As Integer
        Dim late_fee As Integer = 0


        Console.WriteLine("Wellcome to Code_Guluva Kick and Go car rentals")


        Console.WriteLine("Please enter rental start date (yyyy-md-d):")
        rental_start_date = Console.ReadLine()

        Console.WriteLine("Please enter rental end date (yyyy-md-d):")
        rental_return_date = Console.ReadLine()

        Console.WriteLine("Please enter number of rental days payed for:")
        rental_days_payed_for = Console.ReadLine()

        actual_return_date = (rental_return_date - rental_start_date).Days

        late_return = actual_return_date - rental_days_payed_for

        Console.WriteLine("Renter is late by {0} days:", late_return)



        If actual_return_date > rental_days_payed_for Then
            late_fee = late_return * 20
        End If

        Console.WriteLine("The fee for late rental is: {0} dollars", late_fee)
        Console.WriteLine("the number of rental days is {0}", actual_return_date)













        Console.ReadKey()
    End Sub

End Module
