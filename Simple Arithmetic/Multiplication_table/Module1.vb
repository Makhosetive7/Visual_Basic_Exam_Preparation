Module Module1
    'program to display the multiplication table of a number
    Sub Main()
        Dim number As Integer
        Dim multiplication As Integer

        Console.WriteLine("Please enter number:")
        number = Console.ReadLine()

        Console.WriteLine("the multiplication table of{0}:", number)
        For i As Integer = 0 To 12
            multiplication = i * number
            Console.WriteLine("{0} * {1} = {2}", i, number, multiplication)
        Next

        Console.ReadLine()

    End Sub

End Module
