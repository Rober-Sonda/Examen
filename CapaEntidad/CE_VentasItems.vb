Public Class CE_VentasItems
    Private _ID As Integer
    Private _IDVenta As Integer
    Private _IDProducto As Integer
    Private _PrecioUnitario As Double
    Private _Cantidad As Double
    Private _PrecioTotal As Double

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property IDVenta As Integer
        Get
            Return _IDVenta
        End Get
        Set(value As Integer)
            _IDVenta = value
        End Set
    End Property

    Public Property IDProducto As Integer
        Get
            Return _IDProducto
        End Get
        Set(value As Integer)
            _IDProducto = value
        End Set
    End Property

    Public Property PrecioUnitario As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Double)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(value As Double)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioTotal As Double
        Get
            Return _PrecioTotal
        End Get
        Set(value As Double)
            _PrecioTotal = value
        End Set
    End Property
End Class
