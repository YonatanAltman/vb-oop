Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("dddd")

        'Dim a = Console.ReadLine()
        'Console.WriteLine(a)
        Dim obj As Object = New Object()
        Dim yonatan As Humen = New Humen()
        Dim cat As Cat = New Cat()

        yonatan.Lesten()
        Console.WriteLine(obj)
        Console.WriteLine(yonatan)


        cat.Hiss(10)




    End Sub
End Module
