Module Module1
    'write a VB.NET console application that displays the statement "I LOVE YOU FOUR TIME WITH DIFFERENT FORE AND  BACK COLORS"
    Sub Main()

        Dim line_One As String = "i Love you"
        Dim line_Two As String = "i Love you"
        Dim line_Three As String = "i Love you"
        Dim line_Four As String = "i Love you"

        For i As Integer = 1 To 4
            Select Case i
                Case 1
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.BackgroundColor = ConsoleColor.Green
                    Console.WriteLine(line_One)
                Case 2
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.BackgroundColor = ConsoleColor.Magenta
                    Console.WriteLine(line_Two)
                Case 3
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.BackgroundColor = ConsoleColor.DarkCyan
                    Console.WriteLine(line_Three)
                Case 4
                    Console.ForegroundColor = ConsoleColor.White
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.WriteLine(line_Four)
            End Select

            Console.ReadKey()
        Next

    End Sub

End Module
