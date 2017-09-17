Module Module1

    Sub Main()

        Dim zahl As Integer
        Dim zahl2 = 1.19

        Console.WriteLine("Bitte geben Sie eine Zahl ein:")
        zahl = Console.ReadLine()

        Dim ergebnis As Double = zahl * zahl2
        Console.WriteLine("Eingegebene Zahl: " & zahl)
        Console.WriteLine("Ergebnis: " & ergebnis)



        'SwitchCase(5)

        'ForTest()

        'KlassenTest()
    End Sub

    Sub FirstTest()
        Dim test As String
        Dim datum As Date = Now

        test = "Hallo Fabian"
        Console.WriteLine(test)

        MsgBox(datum.ToString("dd.MM.yyyy HH:mm"))
    End Sub

    Sub SwitchCase(i As Integer)
        Select Case i
            Case 3
                Console.WriteLine("Ich bin eine " + i.ToString())
            Case 5
                Console.WriteLine("Ich bin nicht definiert " + i.ToString())
                Console.WriteLine(Fabian.VBasic)
            Case Else
                Console.WriteLine("Gibbet nicht")
        End Select
    End Sub

    Sub ForTest()
        For i As Integer = 0 To 5
            Console.WriteLine(i)
        Next
    End Sub

    Sub KlassenTest()
        Dim a As Buch = New Buch("CSharp")

        Dim b = New Zeitschrift("Java Buch")

        Dim ausgabe = a.Ausgabe()
        Console.WriteLine(ausgabe)
        Console.WriteLine(b.Ausgabe())
    End Sub

    Enum Fabian
        Csharp = 1
        Java = 2
        VBasic = 5
    End Enum

End Module
