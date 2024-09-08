Module Module1

    'write a console application to calculate the revenue from sales based on the unit price and
    'the quantity of the product input by the user
    'the discount rate is 10% for the quantity purchased between 100 and 200 units
    '15% for the quantity puchased greater than 120 units 
    'if the quantity purchased is less than 100 units, the discount rate is 0%

    Sub Main()
        Dim unit_price As Integer = 500
        Dim quantity As Integer
        Dim total As Integer
        Dim discounted_total As Integer
        Dim discount_rate As Double = 0.0

        Console.WriteLine("please enter the quantity you want purchase")
        quantity = Console.ReadLine()

        If quantity >= 100 Or quantity <= 120 Then
            discount_rate = 0.1
        ElseIf quantity > 120 Then
            discount_rate = 0.15
            Else
                discount_rate = 0


        End If


        total = quantity * unit_price
        discounted_total = total - (total * discount_rate)

        Console.WriteLine("the total you have to pay is {0}", discounted_total)

        Console.ReadKey()

    End Sub

End Module
