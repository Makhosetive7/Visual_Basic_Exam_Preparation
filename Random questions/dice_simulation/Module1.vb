Module Module1
    'Write a VB.NET program to simulate the roll of two six-sided dice. Display the result of each die roll and their sum.
    Sub Main()
        Dim random_number As New Random()


        Dim first_chance As Integer = random_number.Next(1, 7)
        Dim second_chance As Integer = random_number.Next(1, 7)
        Dim total_number_rolled As Integer

        total_number_rolled = first_chance + second_chance

        Console.WriteLine("the total of rolled dice is: " & Environment.NewLine & "{0} + {1} = {2}", first_chance, second_chance, total_number_rolled)


        Console.ReadKey()
    End Sub

End Module
