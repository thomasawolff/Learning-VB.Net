Imports System

Module Program
    Sub Main(args As String())

        Dim FirstMammel = New WildAnimal("Lion")
        AddHandler FirstMammel.MammelMakingSound, AddressOf MammelSound_EventHandeler
        Console.WriteLine("The first mammel is " & FirstMammel.NameOfMammel)
        Console.WriteLine("It goes " & FirstMammel.SoundOfMammel())
        Console.WriteLine("Am I wild? " & FirstMammel.AmIWild())
        Console.WriteLine("")

        Dim SecondMammel = New TameAnimal("Kitten")
        AddHandler SecondMammel.MammelMakingSound, AddressOf MammelSound_EventHandeler
        Console.WriteLine("The second mammel is " & SecondMammel.NameOfMammel)
        Console.WriteLine("It goes " & SecondMammel.SoundOfMammel())
        Console.WriteLine("Am I wild? " & SecondMammel.AmIWild())
        Console.WriteLine("")

        Dim ThirdMammel As Mammel = FirstMammel
        AddHandler SecondMammel.MammelMakingSound, AddressOf MammelSound_EventHandeler
        'Console.WriteLine("The third mammel is " & ThirdMammel.NameOfMammel)
        'Console.WriteLine("It goes " & ThirdMammel.SoundOfMammel())
        Console.WriteLine("Am I wild? " & ThirdMammel.AmIWild())

    End Sub

    Sub MammelSound_EventHandeler()
        Console.WriteLine("I hear a sound")
    End Sub

End Module


Class Mammel

    Overridable Function AmIWild()
        Return "I dont know"
    End Function

    Public Event MammelMakingSound()

    Public Sub New()

    End Sub

    Public Sub New(NameOfMammel As String)
        Me.NameOfMammel = NameOfMammel
    End Sub


    Private _NameOfMammel As String

    Public Property NameOfMammel() As String
        Get
            Return _NameOfMammel
        End Get
        Set(ByVal value As String)
            _NameOfMammel = value
            If value = "Fish" Then
                _NameOfMammel = "not a mammel"
            Else
                _NameOfMammel = value
            End If
        End Set
    End Property

    Function SoundOfMammel()
        RaiseEvent MammelMakingSound()

        Select Case NameOfMammel()
            Case "Lion"
                Return "Roar"
            Case "Dog"
                Return "Bark"
            Case Else
                Return "Noise"
        End Select
    End Function

End Class

Class WildAnimal
    Inherits Mammel

    Public Sub New(NameOfMammel As String)
        Me.NameOfMammel = NameOfMammel
    End Sub

    Overrides Function AmIWild()
        Return "Yes, I am wild"
    End Function

End Class

Class TameAnimal
    Inherits Mammel

    Public Sub New(NameOfMammel As String)
        Me.NameOfMammel = NameOfMammel
    End Sub

    Overrides Function AmIWild()
        Return "No, I am tame"
    End Function

End Class