Imports System.Runtime.Remoting.Channels

Module Module1
    'Define a structure named Book that contains Title (String), Author (String), 
    'And ISBN (String). Create a method within the structure named FormatBookDetails that 
    'returns the book details In the format "Title by Author, ISBN: ISBN".


    Public Structure Book
        Dim title As String
        Dim author As String
        Dim ISBN As String

        Public Function FormatedBookDetails() As String
            Return String.Format("{0} by {1}, ISBN: {2}", title, author, ISBN)
        End Function
    End Structure


    Sub Main()
        Dim newBook As Book = New Book()

        Console.WriteLine("Please enter Book title")
        newBook.title = Console.ReadLine()

        Console.WriteLine("Please enter author of Book")
        newBook.author = Console.ReadLine()

        Console.WriteLine("Please enter Book ISBN")
        newBook.ISBN = Console.ReadLine()

        Console.WriteLine(newBook.FormatedBookDetails)

        Console.ReadKey()
    End Sub

End Module
