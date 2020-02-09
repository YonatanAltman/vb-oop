Public Class Humen
    Public Sub Talk()
        Console.WriteLine("Hey")

    End Sub
    Public Sub Lesten()
        Dim message = Console.ReadLine()
        Console.WriteLine("Very importent {0}", message)

    End Sub

    Public Overrides Function ToString() As String
        Return "I'm a Humen been!"
    End Function
End Class
