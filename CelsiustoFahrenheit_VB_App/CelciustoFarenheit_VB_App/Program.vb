Imports System

Module Program
    Public numF As Decimal
    Public answer As Decimal
    Public Const multiplier As Decimal = 1.8
    Public Const addend As Integer = 32
    Sub Main()
        Console.WriteLine("Type the Celcius value you want to convert and press Enter")
        numF = Console.ReadLine()
        answer = numF * multiplier + addend
        Console.WriteLine("The answer is " & answer)
        Console.ReadLine()
    End Sub
End Module
