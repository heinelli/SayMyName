'Elliot Heiner
'RCET0265
'Fall 2021
'Say My Name
'https://github.com/heinelli/SayMyName.git

Option Explicit On
Option Strict On
Option Compare Text
Module SayMyNameAgain
    Sub Main()
        Dim name As String  'A variable called "name" is created
        Console.WriteLine("Hello there. What's your name?")
        name = Console.ReadLine()   'User input is saved as the variable "name"
        If name = "Joe" Or name = "Emily" Then
            Console.WriteLine("Hello there " & name & ". It's good to see you.")
        ElseIf name = "Elliot" Then
            Console.WriteLine("Bom dia Elliot! Tudo bem?")
        Else
            Console.WriteLine("Oh no. Not you again!")
        End If
        Console.WriteLine("Press ENTER to quit")
        Console.Read()  'Creates delay so that user can press ENTER.
    End Sub

End Module
