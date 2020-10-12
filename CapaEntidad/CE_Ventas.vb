Public Class CE_Ventas
    Private _ID As Integer
    Private _IDCliente As Integer
    Private _Fecha As DateTime
    Private _Total As Double

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property IDCliente As Integer
        Get
            Return _IDCliente
        End Get
        Set(value As Integer)
            _IDCliente = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property
End Class
