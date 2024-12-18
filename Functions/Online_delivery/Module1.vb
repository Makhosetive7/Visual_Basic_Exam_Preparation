﻿Module Module1
    'A food delivery service charges a base fee of $1.20 per km. Extra charges include:
    '--o $4 for weekend delivery
    '--o 10% of the total cost for rush-hour delivery

    'Write three functions:
    '--o One To calculate the base delivery fee based On distance.
    '--o One To apply extra charges For weekend Or rush-hour delivery.
    '--o Another To calculate the total, applying a 12% VAT
    Sub Main()

        Dim distance As Double = 10
        Dim is_Weekend As Boolean = False
        Dim is_Rush_Hour As Boolean = False
        Dim value_Added_Tax As Double = 0.12


        Dim baseFee As Double = calculate_Base_Delivery(distance)
        Console.WriteLine("Base Delivery Fee: $" & baseFee)

        Dim extraCharges As Double = calculate_Extra_Charges(baseFee, is_Weekend, is_Rush_Hour)
        Console.WriteLine("Extra Charges: $" & extraCharges)

        Dim totalCost As Double = calculate_Total(baseFee + extraCharges, value_Added_Tax)
        Console.WriteLine("Total Cost with VAT: $" & totalCost)


        Console.ReadKey()

    End Sub

    Function calculate_Base_Delivery(ByVal distance As Double) As Double
        Dim distance_Per_Kilometer As Double = 1.25

        Return distance * distance_Per_Kilometer

    End Function

    Function calculate_Extra_Charges(ByVal distance As Double, ByVal is_Weekend As Boolean, is_Rush_Hour As Boolean) As Double
        Dim is_Weekend_Rate As Integer
        Dim is_Rush_Hour_Rate As Integer

        If is_Rush_Hour Then
            Return is_Rush_Hour_Rate = 0.1
        ElseIf is_Weekend Then
            Return is_Weekend_Rate = 4.0
        End If

        Return distance * is_Weekend * is_Rush_Hour
    End Function

    Function calculate_Total(ByVal subtotal As Double, ByVal value_Added_Tax As Double) As Double
        Return subtotal * (1 + value_Added_Tax)
    End Function

End Module
