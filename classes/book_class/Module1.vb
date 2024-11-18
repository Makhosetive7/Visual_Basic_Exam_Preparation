Module Module1
    'Create a Book class with properties Title, Author, and Pages.
    'Implement a method GetSummary() that returns a summary Of the book. Instantiate a Book
    'Object And call the method to verify its output.

    Public Class Book_class
        Dim book_title As String
        Dim book_author As String
        Dim book_page_numbers As Integer

        Public Sub New(ByVal title As String, ByVal author As String, ByVal pages As Integer)
            Me.book_title = title
            Me.book_author = author
            Me.book_page_numbers = pages
        End Sub

        Public Function GetSummary() As String
            Return $"{book_title} {book_author} {book_page_numbers}"
        End Function
    End Class

    Sub Main()
        Console.WriteLine("Here is the book summary")



        Console.WriteLine("Please enter Book title:")
        Dim title As String = Console.ReadLine()

        Console.WriteLine("Please enter Book Author:")
        Dim author As String = Console.ReadLine()

        Console.WriteLine("Please enter Book total page number:")
        Dim page_number As String = Console.ReadLine()

        Dim book As Book_class = New Book_class(title, author, page_number)


        Console.WriteLine("The Book Title: {0}" & Environment.NewLine & "The book Author: {1}" & Environment.NewLine & "Total number of pages: {2}", title, author, page_number)


        Console.ReadKey()
    End Sub

End Module
