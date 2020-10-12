Imports System.Data.SqlClient
Imports CapaEntidad
Public Class CD_Clientes
    Dim ObjConexion As New Conexion
    Dim Cn As SqlConnection
    Dim SqlAdap As SqlDataAdapter

    Public Sub CD_InsertarClientes(ByVal Entidad_Cliente As CE_Clientes)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("insert into Clientes values (@Cliente, @Telefono, @Correo)", Cn)
        Try
            Cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@Cliente", Entidad_Cliente.Cliente)
                .AddWithValue("@Telefono", Entidad_Cliente.Telefono)
                .AddWithValue("@Correo", Entidad_Cliente.Correo)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo un error de inserción: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
        End Try
    End Sub
    Public Sub CD_EditarClientes(ByVal Entidad_Cliente As CE_Clientes)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Update Clientes set Cliente=@Cliente, Telefono=@Telefono, Correo=@Correo where id=@id", Cn)
        Try
            Cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", Entidad_Cliente.ID)
                .AddWithValue("@Cliente", Entidad_Cliente.Cliente)
                .AddWithValue("@Telefono", Entidad_Cliente.Telefono)
                .AddWithValue("@Correo", Entidad_Cliente.Correo)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo un error al editar el cliente: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
        End Try
    End Sub
    Public Sub CD_EliminarCliente(ByVal ID As Integer)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Delete From Clientes where id=@id", Cn)
        Try
            Cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", ID)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo un error al eliminar: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
        End Try
    End Sub

    Public Function CD_ListarClientes() As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            SqlAdap = New SqlDataAdapter("Select * From Clientes", Cn)
            SqlAdap.Fill(dst, "Clientes")
            SqlAdap.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo un error al listar: " + ex.ToString, MsgBoxStyle.Critical)
        Finally
            dst.Dispose()
            SqlAdap.Dispose()
            Cn.Close()
            Cn.Dispose()
        End Try
        Return dst
    End Function

    Public Function CD_ListarLikeClientes(Optional ByVal Nombre As String = "", Optional ByVal Correo As String = "") As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            If Nombre <> "" Then
                SqlAdap = New SqlDataAdapter("Select * From Clientes Where Cliente Like '%" & Nombre & "%'", Cn)
            End If
            If Correo <> "" Then
                SqlAdap = New SqlDataAdapter("Select * From Clientes Where Correo Like '%" & Correo & "%'", Cn)
            End If
            SqlAdap.Fill(dst, "Clientes")
            SqlAdap.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo un error al listar: " + ex.ToString, MsgBoxStyle.Critical)
        Finally
            dst.Dispose()
            SqlAdap.Dispose()
            Cn.Close()
            Cn.Dispose()
        End Try
        Return dst
    End Function
End Class
