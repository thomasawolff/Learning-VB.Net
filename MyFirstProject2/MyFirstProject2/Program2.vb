Imports System
Imports System.Collections

' Module Program3
'    Sub Main(args As String())
'        Console.WriteLine("Computers")
'        Console.WriteLine("")
'        Dim Item = New Computer()
'        Item.TypeOfComputer = "A generic computer"
'        Console.WriteLine(Item.Hardware())
'        Console.WriteLine(Item.TypeOfComputer)
'        Console.WriteLine(Item.AmIMobile)
'        Console.WriteLine()

'        Dim Item2 = New Laptop()
'        Item2.TypeOfComputer = "A laptop"
'        Console.WriteLine(Item2.Hardware())
'        Console.WriteLine(Item2.TypeOfComputer)
'        Console.WriteLine(Item2.AmIMobile)
'        Console.WriteLine()

'        Dim Item3 = New Desktop()
'        Item3.TypeOfComputer = "A desktop"
'        Console.WriteLine(Item3.Hardware())
'        Console.WriteLine(Item3.TypeOfComputer)
'        Console.WriteLine(Item3.AmIMobile)
'        Console.WriteLine("")

'        Dim Item4 As Computer = Item2
'        Console.WriteLine(Item4.AmIMobile)

'    End Sub
'End Module

Class SalesTax

End Class

Class Computer
    Private strTypeOfComputer As String

    Public Property TypeOfComputer As String
        Get
            Return strTypeOfComputer
        End Get
        Set(value As String)
            strTypeOfComputer = value
        End Set
    End Property

    Function Hardware()
        Return "Hardware"
    End Function

    Overridable Function AmIMobile()
        Return "I dont know"
    End Function
End Class


Class Laptop
    Inherits Computer

    Overrides Function AmIMobile()
        Return "Yes, I am mobile"
    End Function
End Class

Class LaptopSmall
    Inherits Laptop

    Shadows Function AmIMobile()
        Return "Yes, I am very mobile"
    End Function
End Class

Class Desktop
    Inherits Computer

    Overrides Function AmIMobile()
        Return "No, I am not mobile"
    End Function
End Class


'Module Program3
'    Sub Main(args As String())
'        Dim items As Integer() = {10, 11, 12, 13, 14, 15}
'        Console.WriteLine("The first item is " & items(0))
'        Console.WriteLine("The last item is " & items(4))
'        Console.WriteLine("The number of items is {0}", items.Length)

'        Dim items2(4, 1) As Integer
'        items2(0, 0) = 10
'        items2(1, 0) = 12
'        items2(3, 0) = 13

'        Console.WriteLine("The items going across is from {0} to {1}", items2.GetLowerBound(0), items.GetLowerBound(0))
'        Console.WriteLine("The first item in 2-d is " & items2(0, 0))
'        Console.WriteLine("The second item in 2-d is " & items2(1, 0))
'        Console.WriteLine("The number of dimensions is {0}", items2.Rank)

'        For x As Integer = 0 To 4
'            Console.WriteLine("This line uses just a For x: " & items(x))
'        Next

'        For Each Itm As Integer In items
'            Console.WriteLine("This line uses For Each: " & Itm)
'        Next
'    End Sub
'End Module

'Module Program4
'    Sub Main(args As String())
'        Dim names As String()
'        names = {"John Smith", "Jane Smith", "Phillip Burton", "Fred Bloggs"}

'        For X As Byte = 0 To names.Length - 1
'            Console.WriteLine("The names are " & names(X))
'        Next

'        Dim names2 = {{"John", "Jane", "Phillip", "Fred"}, {"Smith", "Smith", "Burton", "Bloggs"}}
'        For Each nme As String In names2
'            Console.WriteLine("The names in 2d are: " & nme)
'        Next

'    End Sub
'End Module



' Stacks are LIFO: Last In First Out
'Module Stacks
'    Sub Main(args As String())
'        Dim myStack As New Stack
'        myStack.Push("A")
'        myStack.Push("B")
'        myStack.Push("C")
'        myStack.Push("D")
'        myStack.Push("E")
'        Console.WriteLine(myStack.Pop())
'        Console.WriteLine(myStack.Peek())
'        Console.WriteLine(myStack.Pop())
'        myStack.Push("F")
'        For Each obj As Object In myStack
'            Console.WriteLine("In my stack there is a {0}", obj)
'        Next
'        If myStack.Contains("B") Then
'            Console.WriteLine("Yes, there is a B.")
'        End If
'    End Sub
'End Module


' Queues are are FIFO: Last in First Out
'Module Queues
'    Sub Main(args As String())
'        Dim myQueue As New Queue
'        myQueue.Enqueue("A")
'        myQueue.Enqueue("B")
'        myQueue.Enqueue("C")
'        myQueue.Enqueue("D")
'        myQueue.Enqueue("E")
'        Console.WriteLine(myQueue.Dequeue())
'        Console.WriteLine(myQueue.Peek())
'        Console.WriteLine(myQueue.Dequeue())
'        myQueue.Enqueue("F")
'        For Each obj As Object In myQueue
'            Console.WriteLine("In my Queue there is a {0}", obj)
'        Next
'        If myQueue.Contains("B") Then
'            Console.WriteLine("Yes, there is a B.")
'        End If
'    End Sub
'End Module


'Module LinkedList
'    Sub Main(args As String())
'        Dim LL As New LinkedList(Of String)
'        LL.AddFirst("A")
'        LL.AddLast("B")
'        LL.AddLast("C")
'        LL.AddLast("D")
'        LL.AddLast("E")

'        LL.Remove(LL.Find("B"))
'        LL.AddBefore(LL.Find("C"), "F")
'        LL.AddAfter(LL.Find("C"), "G")
'        LL.RemoveLast()

'        For Each word As String In LL
'            Console.WriteLine(word)
'        Next
'    End Sub
'End Module


Module DataStructuresPrac
    Sub Main(args As String())

        Dim myStack As New Stack
        myStack.Push("John Smith")
        myStack.Push("Jane Smith")
        myStack.Push("Phillip Burton")
        myStack.Push("Fred Bloggs")
        Console.WriteLine(myStack.Pop())

        Dim myQueue As New Queue
        myQueue.Enqueue("John Smith")
        myQueue.Enqueue("Jane Smith")
        myQueue.Enqueue("Phillip Burton")
        myQueue.Enqueue("Fred Bloggs")
        Console.WriteLine(myQueue.Dequeue())

        Dim LL As New LinkedList(Of String)
        LL.AddFirst("John Smith")
        LL.AddLast("Jane Smith")
        LL.AddLast("Phillip Burton")
        LL.AddLast("Fred Blogg")
        LL.AddBefore(LL.Find("Phillip Burton"), "Pual Jones")
        LL.AddAfter(LL.Find("John Smith"), "Sarah Jane")
        Console.WriteLine("")

        For Each name As Object In myStack
            Console.WriteLine("This is from the stack {0} ", name)
        Next
        Console.WriteLine("")
        For Each name As Object In myQueue
            Console.WriteLine("This is from the queue {0} ", name)
        Next
        Console.WriteLine("")
        For Each name As Object In LL
            Console.WriteLine("This is from the linked list {0} ", name)
        Next

    End Sub
End Module