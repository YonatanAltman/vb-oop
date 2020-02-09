Module Program

    Sub Main(args As String())

        Part2()

    End Sub

    Sub Part1()
        Console.WriteLine("Hello My Company")
        Dim employee As Employee '= New Employee()
        Console.WriteLine(employee)
        Dim obj = New Object()
        Dim obj1 = New Object()
        Research(obj)



        employee = New Employee(1, "yonatan", "altman", "ddd", 444)


        Console.WriteLine(employee)
        Dim arr = GetAllEmployees()
        Dim name = Console.ReadLine()
        Console.WriteLine(name)
        Console.WriteLine("---------------------------------------")
        Research(employee)

        For Each emp In arr
            Console.WriteLine(emp)
        Next

        Dim ObjectArr = New List(Of Object)()
        ObjectArr.Add(employee) ' employee is son of object
        ObjectArr.Add(name) ' string is son of object
        ObjectArr.Add(obj) ' obj is object





    End Sub

    Sub Part2()

        Dim animals = New List(Of Animal)
        Dim flys = New List(Of IFly)
        'Dim fish = New Animal() => Error
        'Dim fish = New IFly() => Error
        Dim fish = New Fish()
        Dim person = New Person()
        Dim bird = New Bird()

        animals.Add(fish)
        animals.Add(person)
        animals.Add(bird)

        flys.Add(bird)
        flys.Add(New SuperMan())
        flys.Add(New Airplain())

        For Each a In animals
            a.Move()

        Next

        For Each f In flys
            f.LiftOff()

        Next



    End Sub

    Function GetAllEmployees() As List(Of Employee)

        Dim company As List(Of Employee) = New List(Of Employee)()
        Dim employee = New Employee(3, "yonatan", "altman", "ddd", 444)
        Dim manager = New Manager(2, "yonatan", "altman", "ddd", 444, "Toyota")
        Dim ceo = New CoFounder(1, "yonatan", "altman", "ddd", 444, "Lexos")


        company.Add(employee)
        company.Add(manager)
        company.Add(ceo)

        Return company




    End Function

    Sub Research(obj As Object)

        Console.WriteLine(obj.Equals(obj))
        Console.WriteLine(obj.GetType())
        Console.WriteLine(obj.ToString())
        Console.WriteLine(obj)
    End Sub

End Module
