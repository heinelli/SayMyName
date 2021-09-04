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
        Console.Write("That sounds boring! " & name & ", can you press ENTER please so that I can go back to sleep?")
        Console.Read()
    End Sub

End Module
