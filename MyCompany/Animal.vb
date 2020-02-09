' Abstract
Public MustInherit Class Animal
    Public Name As String

    Public Eyes As Integer

    MustOverride Sub Move()

    Overridable Sub Eat()
        Console.WriteLine("Eat!")

    End Sub

End Class

Interface IFly
    Sub LiftOff()
    Sub Land()
End Interface




Public Class Fish
    Inherits Animal


    Sub New()
        Me.Eyes = 2
        Me.Name = "Clown Fish"
    End Sub

    Public Overrides Sub Move()
        Console.WriteLine("Swim")
    End Sub
End Class
Public Class Bird
    Inherits Animal
    Implements IFly



    Sub New()

    End Sub
    Public Overrides Sub Move()
        Console.WriteLine("Jump")
    End Sub

    Public Sub LiftOff() Implements IFly.LiftOff
        Console.WriteLine("Wings")
    End Sub
    Public Sub Land() Implements IFly.Land
        Console.WriteLine("Close Wings")
    End Sub
End Class
Public Class Person
    Inherits Animal
    Sub New()

    End Sub

    Public Overrides Sub Move()
        Console.WriteLine("Walk")
    End Sub
    Public Overrides Sub Eat()
        Console.WriteLine("Politly")
    End Sub
End Class

Public Class SuperMan
    Inherits Person
    Implements IFly

    Public Sub LiftOff() Implements IFly.LiftOff
        Console.WriteLine("Magic")
    End Sub

    Public Sub Land() Implements IFly.Land
        Console.WriteLine("Nothing Happens")
    End Sub
End Class

Public Class Airplain
    Implements IFly

    Public Sub LiftOff() Implements IFly.LiftOff
        Console.WriteLine("Engine")
    End Sub

    Public Sub Land() Implements IFly.Land
        Console.WriteLine("Alert")
    End Sub
End Class