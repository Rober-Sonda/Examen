Imports CapaDatos
Imports CapaEntidad
Public Class CN_Productos
    Private Obj_Productos As New CD_Productos
    Public Sub CN_InsertarProductos(ByVal Producto As CE_Productos)
        Obj_Productos.CD_InsertarProductos(Producto)
    End Sub
    Public Sub CN_EditarProductos(ByVal Producto As CE_Productos)
        Obj_Productos.CD_EditarProductos(Producto)
    End Sub

    Public Sub CN_EliminarProductos(ByVal ID As Integer)
        Obj_Productos.CD_EliminarProductos(ID)
    End Sub
    Public Function CN_ListarProductos() As DataSet
        Return Obj_Productos.CD_ListarProductos
    End Function

    Public Function CN_ListarLikeProductos(ByVal Nombre As String, ByVal Categoria As String) As DataSet
        Return Obj_Productos.CD_ListarLikeProductos(Nombre, Categoria)
    End Function
End Class
