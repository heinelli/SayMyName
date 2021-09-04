'Elliot Heiner
'RCET0265
'Fall 2021
'Say My Name
'
Module SayMyName

    Sub Main()
        Dim name As String
        Console.WriteLine("Hello there. What's your name?")
        name = Console.ReadLine()
        Console.WriteLine("Hello there " & name & ". What are you doing?")
        Console.ReadLine()
        Console.Write("Lame!!! Press enter please.")
        Console.Read()
    End Sub

End Module
