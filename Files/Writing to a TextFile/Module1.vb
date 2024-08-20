Imports System.IO

Module Module1
    'Write a console program that asks the user to enter five different product names and 
    'prices. Save the entered data into a file named products.txt with each product name And 
    'price on a New line, formatted as ProductName - Price

    Sub Main()
        Dim filepath As String = "C:\Users\USER\Desktop\Visual_Basic\Files\Writing to a TextFile\textFile.txt"
        Dim productName As String
        Dim productPrice As String

        Using sw As StreamWriter = New StreamWriter(filepath)
            For i As Integer = 1 To 5
                Console.WriteLine("Please enter product name")
                productName = Console.ReadLine

                Console.WriteLine("Please enter product price")
                productPrice = Console.ReadLine

                sw.WriteLine("{0} - {1}", productName, productPrice)

                Console.WriteLine("writting to file successfully")

            Next

            Console.ReadKey()

        End Using

    End Sub

End Module
