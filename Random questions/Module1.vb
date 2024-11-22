Module Module1
    'Write a VB.NET program that generates a random integer between 1 and 100 and displays it in a console

    Sub Main()
        Dim random_number As New Random

        Dim random_integers As Integer = random_number.Next(1, 100)

        Console.WriteLine("the generated random numbers are: {0}", random_integers)

        Console.ReadKey()

    End Sub

End Module
