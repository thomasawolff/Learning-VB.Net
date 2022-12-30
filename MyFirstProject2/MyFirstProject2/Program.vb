'Imports System

'Module Program

'    Sub Main(args As String())
'        Dim SoundOfTyping As String

'        Dim Item As Computer = New Computer With {.TypeOfComputer = "Laptop"}
'        AddHandler Item.IamTyping, AddressOf IamTyping_EventHandler
'        With Item
'            .Typing()
'            SoundOfTyping = .Typing()
'            Console.WriteLine(SoundOfTyping & " goes the computer")
'            Console.WriteLine(SoundOfTyping & " goes the " & .TypeOfComputer & ".")
'            .Sound()
'        End With

'        Dim Item2 As Computer = New Computer With {.TypeOfComputer = "Desktop"}
'        AddHandler Item.IamTyping, AddressOf IamTyping_EventHandler
'        With Item2
'            .Typing()
'            SoundOfTyping = .Typing()
'            Console.WriteLine(SoundOfTyping & " goes the computer")
'            Console.WriteLine(SoundOfTyping & " goes the " & .TypeOfComputer & ".")
'            .Sound()
'        End With

'        Dim Item3 As Computer = New Computer
'        Item3.TypeOfComputer = "Motorbike"
'        SoundOfTyping = Item3.Typing()
'        Console.WriteLine(SoundOfTyping & " goes the " & Item3.TypeOfComputer & ".")
'        Item3.Sound()

'        Console.WriteLine(GrandTotal(9))

'    End Sub

'    Dim RunningTotal As Integer
'    Function GrandTotal(StartWith As Integer)
'        RunningTotal = 0
'        Return AddUp(StartWith)
'    End Function

'    Function AddUp(AddNumber As Integer)
'        RunningTotal += AddNumber
'        If AddNumber <= 0 Then
'            Return RunningTotal
'        End If
'        Return AddUp(AddNumber - 1)
'    End Function

'    Sub IamTyping_EventHandler()
'        Console.WriteLine("I am typing in an event")
'    End Sub

'End Module


'Class Computer

'    Public Event IamTyping()

'    Public Sub New()
'        Console.WriteLine("I am creating a new computer")
'    End Sub

'    Public Sub New(strTypeOfComputer As String)
'        Me.New()
'        TypeOfComputer = strTypeOfComputer
'    End Sub

'    Private _TypeOfComputer As String
'    Public Property TypeOfComputer() As String
'        Get
'            Select Case _TypeOfComputer
'                Case "Laptop"
'                    Return "pretty good laptop"
'                Case "Desktop"
'                    Return "nice desktop"
'                Case Else
'                    Return _TypeOfComputer
'            End Select
'        End Get
'        Set(ByVal value As String)
'            _TypeOfComputer = value
'            Select Case value
'                Case "Laptop", "Desktop"
'                    _TypeOfComputer = value
'                Case Else
'                    _TypeOfComputer = "Unknown"
'            End Select
'        End Set
'    End Property

'    Function Typing() As String
'        'Console.WriteLine("I am typing")
'        RaiseEvent IamTyping()
'        Return "type type type"
'    End Function

'    Sub Sound()
'        Console.WriteLine("I am creating a sound")
'    End Sub

'End Class