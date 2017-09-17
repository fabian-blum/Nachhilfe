Public Class Buch
    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Public Property Name As String
    Public Function Ausgabe() As String
        Return "Hallo Welt" & Name
    End Function
End Class
