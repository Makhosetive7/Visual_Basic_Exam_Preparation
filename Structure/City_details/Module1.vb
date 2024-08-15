Module Module1
    'Structure storing details of Bulawayo City


    Public Structure Zimbabwe_Cities
        Dim Name As String
        Dim Population As Double
        Dim Diameter As Double
        Dim year As Double
    End Structure
    Sub Main()
        Dim City_Details As Zimbabwe_Cities = New Zimbabwe_Cities

        Console.WriteLine("Please enter Name of the city")
        City_Details.Name = Console.ReadLine()

        Console.WriteLine("Please enter Population of the city")
        City_Details.Population = Console.ReadLine()

        Console.WriteLine("Please enter Diameter of the city")
        City_Details.Diameter = Console.ReadLine()

        Console.WriteLine("Please enter year of data collection")
        City_Details.year = Console.ReadLine()


        Console.WriteLine("According to data collected on the year {0}, In the City of {1}, that covers distance of {2}km , has a population of {3} people", City_Details.year, City_Details.Name, City_Details.Diameter, City_Details.Population)
        Console.ReadKey()
    End Sub
End Module
