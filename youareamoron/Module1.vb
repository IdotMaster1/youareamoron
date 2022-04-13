Module Module1

    Sub Main()
        Console.WriteLine("Hey, Jackass! Whats your name?")
        Console.WriteLine("Name:")
        Dim vadimblyat = Console.ReadLine()
        Const V As String = ", you are a moron."
        Console.WriteLine(vadimblyat + V)
        Console.WriteLine("I made this program in less then 5 minutes lol")
        Console.Write($"{Environment.NewLine}Press any key to exit...")
        Console.ReadKey(True)
    End Sub

End Module
