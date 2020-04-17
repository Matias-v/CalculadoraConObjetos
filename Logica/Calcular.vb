Public Class Calcular
    Private val1, val2 As Integer

    Public Sub Calcular()

    End Sub

    Public Sub Calcular(val1 As Integer, val2 As Integer)

    End Sub

    Public Property propVal1() As Integer
        Get
            Return val1
        End Get
        Set(value As Integer)
            Me.val1 = val1
        End Set
    End Property

    Public Property propVal2() As Integer
        Get
            Return val2
        End Get
        Set(value As Integer)
            Me.val2 = val2
        End Set
    End Property


    Public Function suma(val1 As Integer, val2 As Integer) As Integer
        Return val1 + val2
    End Function

    Public Function resta(val1 As Integer, val2 As Integer) As Integer
        Return val1 - val2
    End Function

    Public Function multiplicacion(val1 As Integer, val2 As Integer) As Double
        Return val1 * val2
    End Function

    Public Function division(val1 As Integer, val2 As Integer) As Double
        Return val1 / val2

    End Function

End Class
