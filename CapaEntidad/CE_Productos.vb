Public Class CE_Productos
    Private _ID As Integer
    Private _Nombre As String
    Private _Precio As Double
    Private _Categoria As String

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _Precio
        End Get
        Set(value As Double)
            _Precio = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property
End Class
