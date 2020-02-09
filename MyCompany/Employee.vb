Public Class Employee

    Public ID As Integer
    Public FirstName As String
    Public LastName As String
    Public Email As String
    Public Address As String
    Public Salary As Double




    ' Constractors
    Public Sub New()

    End Sub

    Public Sub New(id As Integer, fname As String, lname As String)
        Me.ID = id
        Me.FirstName = fname
        Me.LastName = lname

    End Sub
    Public Sub New(id As Integer, fname As String, lname As String, address As String, salary As Double)
        Me.ID = id
        Me.FirstName = fname + " EPR"
        Me.LastName = lname
        Me.Salary = salary
        Me.Address = address
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("ID:{0} First Name: {1}", Me.ID, Me.FirstName)
    End Function


End Class


Public Class Manager
    Inherits Employee



    Public Car As Car
    Public Bounos As Double

    Sub New()

    End Sub
    Sub New(id As Integer, fname As String, lname As String)
        MyBase.New(id, fname, lname)
    End Sub
    Public Sub New(id As Integer, fname As String, lname As String, address As String, salary As Double, carType As String)
        MyBase.New(id, fname, lname, address, salary)
        Me.Car = New Car(carType)

    End Sub


End Class


Public Class CoFounder
    Inherits Manager

    Public Stucks

    Sub New()

    End Sub

    Sub New(id As Integer, fname As String, lname As String)
        MyBase.New(id, fname, lname)
    End Sub
    Public Sub New(id As Integer, fname As String, lname As String, address As String, salary As Double, carType As String)
        MyBase.New(id, fname, lname, address, salary, carType)

    End Sub

End Class


Public Class Car

    Public Type As String

    Sub New(type)
        Me.Type = type

    End Sub

End Class
