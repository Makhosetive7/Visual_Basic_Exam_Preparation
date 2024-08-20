Imports System.IO

Module Module1
    Sub Main()
        Dim filepath As String = "C:\Users\USER\Desktop\Visual_Basic\Files\Writing and reading from Files\textFile.txt"
        Dim line As String
        ' Writing to file
        Using sw As StreamWriter = New StreamWriter(filepath)
            sw.WriteLine("This is the first line.")
            sw.WriteLine("This is the second line.")
        End Using

        Console.WriteLine("File written successfully")

        Using sr As StreamReader = New StreamReader(filepath)
            line = sr.ReadLine()

            While (line IsNot Nothing)
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using

        Console.ReadKey()
    End Sub
End Module
