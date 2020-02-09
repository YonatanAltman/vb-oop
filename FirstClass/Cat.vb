Public Class Cat
    Public HasClaws As Boolean = True

    Public Sub Hiss()
        Console.WriteLine("Meo")

    End Sub
    Public Sub Hiss(num As Integer)
        For index = 1 To num
            Console.WriteLine("Meo")

        Next

    End Sub


End Class
