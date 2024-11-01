Imports System.IO
Imports System.Runtime.Remoting.Channels

Module Module1
    'Write a console application that:
    '--Reads a text file named Document.txt.
    '--Counts the total number Of words In the file.
    '--Displays the word count In the console.
    Sub Main()

        Dim lines As String
        Dim file_path As String = "C:\Users\USER\Desktop\Desktop\Code\Visual_Basic_local_storage\Files\counting_words_in_a_file\counting_words_in_file\document.txt"
        Dim word_count As Integer = 0


        If File.Exists(file_path) Then
            Using sr As StreamReader = New StreamReader(file_path)

                Do While (sr.Peek() >= 0)
                    Console.WriteLine("the lines in the document reads: ")

                    lines = sr.ReadLine()
                    Console.WriteLine(lines)
                    word_count += 1

                    Console.WriteLine("the word count is = {0}", word_count)
                Loop





            End Using
        End If


        Console.ReadKey()
    End Sub

End Module
