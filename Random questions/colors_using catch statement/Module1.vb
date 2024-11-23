Module Module1

    Sub Main()

        For i As Integer = 1 To 4

            Console.WriteLine("Enter a color number (1-4): ")
            Dim color As Integer = Integer.Parse(Console.ReadLine())

            Select Case color

                Case 1
                    Console.ForegroundColor = ConsoleColor.White
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.WriteLine("I LOVE WORKING WITH COLORS")
                Case 2
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.BackgroundColor = ConsoleColor.Blue
                    Console.WriteLine("I LOVE WORKING WITH COLORS")
                Case 3
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.BackgroundColor = ConsoleColor.DarkBlue
                Case 4
                    Console.ForegroundColor = ConsoleColor.DarkGreen
                    Console.BackgroundColor = ConsoleColor.DarkRed

            End Select
        Next

        Console.ReadKey()


    End Sub

End Module
