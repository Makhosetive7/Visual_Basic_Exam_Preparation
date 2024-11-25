Module Module1

    Sub Main()

        Dim array_integers(4) As Integer

        For i As Integer = 0 To array_integers.Length - 1
            Console.WriteLine("Please enter array numbers")
            array_integers(i) = Console.ReadLine()
        Next


        'array reversal
        Array.Reverse(array_integers)

        Console.WriteLine("---------------------------------------------------------------------------------------")
        For Each num As Integer In array_integers
            Console.WriteLine(num)
        Next

        'array sorting
        Array.Sort(array_integers)

        Console.WriteLine("----------------------------------------------------------------------------------------")
        For Each num As Integer In array_integers
            Console.WriteLine(num)
        Next


        Console.ReadKey()

    End Sub

End Module
