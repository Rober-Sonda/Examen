Imports CapaDatos
Imports CapaEntidad
Public Class CN_Clientes
    Private Obj_Clientes As New CD_Clientes
    Public Function CN_ListarClientes() As DataSet
        Return Obj_Clientes.CD_ListarClientes
    End Function
    Public Function CN_ListarLikeClientes(ByVal Nombre As String, ByVal Correo As String) As DataSet
        Return Obj_Clientes.CD_ListarLikeClientes(Nombre, Correo)
    End Function

    Public Sub CN_InsertarClientes(ByVal Cliente As CE_Clientes)
        Obj_Clientes.CD_InsertarClientes(Cliente)
    End Sub
    Public Sub CN_EditarClientes(ByVal Cliente As CE_Clientes)
        Obj_Clientes.CD_EditarClientes(Cliente)
    End Sub

    Public Sub CN_EliminarClientes(ByVal ID As Integer)
        Obj_Clientes.CD_EliminarCliente(ID)
    End Sub
End Class
