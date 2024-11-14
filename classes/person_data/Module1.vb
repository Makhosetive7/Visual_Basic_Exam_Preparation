Module Module1
    'Develop a Person class with FirstName, LastName, and Age properties.
    'Implement a method GetFullName() that returns the full name Of the person. Create a Person
    'Object And test the GetFullName() method to ensure it works as expected.

    Public Class Person
        Public first_Name As String
        Public last_Name As String
        Public age As Double

        Public Sub New(firstName As String, lastName As String, Age As Integer)
            Me.first_Name = firstName
            Me.last_Name = lastName
            Me.age = Age
        End Sub

        Public Function getFullName() As String
            Return $"{first_Name} {last_Name}"
        End Function
    End Class

    Sub Main()
        Dim person_data As New Person("John", "Doe", 25)

        Console.WriteLine("Full Name: " & person_data.getFullName())

        Console.ReadKey()


    End Sub

End Module
