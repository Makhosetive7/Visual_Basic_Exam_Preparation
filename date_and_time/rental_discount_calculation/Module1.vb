Module Module1
    'Create a console application where the user inputs a rental start date, return date, and
    'the daily rental rate. If the rental duration Is more than 7 days, the program applies a
    '10% discount. Calculate And display the total payment after applying any discount.


    Sub Main()
        Dim start_date As DateTime
        Dim end_date As DateTime
        Dim discount As Double
        Dim daily_rental_rate As Double = 2
        Dim rental_durartion As Integer
        Dim total As Integer


        Console.WriteLine("Please enter start_date:")
        start_date = Console.ReadLine()

        Console.WriteLine("please enter end_date:")
        end_date = Console.ReadLine()

        rental_durartion = (end_date - start_date).Days

        Console.WriteLine("they are {0} number of days rented out", rental_durartion)

        If rental_durartion > 7 Then
            discount = 0.1
        Else
            discount = 0.0
        End If

        total = daily_rental_rate * (rental_durartion - discount)

        Console.WriteLine("The total expected to be payed on end_date is {0}", total)
        Console.ReadKey()



    End Sub

End Module
