Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim text = HalloTextFabian.Text

        If text = "Hallo" Then
            text = text & " XY Test"
        Else
            text = text & " Fabians Test"
        End If

        MsgBox(text)
    End Sub
End Class
