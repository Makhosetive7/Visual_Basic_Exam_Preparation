Module Module1
    ' Design a Car class with properties Make, Model, and Year. Create a
    ' constructor to initialize these properties, then instantiate a Car object And display its details to
    ' confirm correct initialization.

    Public Class Car
        Public Property make As String
        Public Property model As String
        Public Property year As Double

        Public Sub New(car_make As String, car_model As String, car_year As Double)
            Me.make = car_make
            Me.model = car_model
            Me.year = car_year
        End Sub

        Public Function get_Car_details() As String
            Return $"{make} {model} {year}"
        End Function
    End Class
    Sub Main()
        Console.WriteLine("Please enter car make:")
        Dim car_make As String = Console.ReadLine()

        Console.WriteLine("Please enter car model:")
        Dim car_model As String = Console.ReadLine()

        Console.WriteLine("Please enter car year:")
        Dim car_year As Double = Console.ReadLine()

        Dim car_information As Car = New Car(car_make, car_model, car_year)

        Console.WriteLine("car information is:" & car_information.get_Car_details())


    End Sub

End Module
