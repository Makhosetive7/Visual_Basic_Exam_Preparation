Module Module1
    'A taxi service charges:
    '--- $1.50 per km during the day
    '--- $2.00 per km during the night

    'Clients can add two services:
    '--- Wi-Fi: $3 per trip
    '--- Luggage :  $5 per bag

    'Write three functions:
    '--- One To calculate the basic fare based On the distance And time Of day.
    '--- Another To add service costs For Wi-Fi And luggage.
    '--- A third To calculate the total fare With a 5% service fee added
    Sub Main()
        Dim distance As Integer = 10
        Dim is_Night As Boolean = False
        Dim wifi As Boolean = True
        Dim lagguage_count As Boolean = 2

        Dim basic_fare As Double = calculate_basic_fare(distance, is_Night)
        Console.WriteLine("the basic fare is" & basic_fare)

        Dim service_cost As Double = calculate_service_cost(wifi, lagguage_count)
        Console.WriteLine("the service cost is" & service_cost)

        Dim total_fare As Double = CalculateTotalFare(basic_fare, service_cost)
        Console.WriteLine("the basic fare is" & total_fare)


        Console.ReadKey()

    End Sub

    Function calculate_basic_fare(ByRef distance As Integer, is_Night As Boolean) As Double
        Dim rate As Integer

        If is_Night Then
            rate = 1.5
        Else
            rate = 2.0
        End If

        Return rate * distance
    End Function


    Function calculate_service_cost(ByVal wifi As Boolean, ByVal lagguage_count As Integer) As Double
        Dim wifi_cost As Double = If(wifi, 3.0, 0)
        Dim lagguage_cost As Integer = 5.0 * lagguage_count


        Return lagguage_cost * wifi_cost
    End Function

    Function CalculateTotalFare(ByVal basicFare As Double, ByVal serviceCost As Double) As Double
        Dim subtotal As Double = basicFare + serviceCost
        Dim serviceFee As Double = 0.05 * subtotal

        Return subtotal + serviceFee
    End Function



End Module
