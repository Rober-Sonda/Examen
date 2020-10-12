Imports CapaEntidad
Imports System.Data.SqlClient
Public Class CD_Productos
    Dim ObjConexion As New Conexion
    Dim Cn As SqlConnection
    Dim SqlAdap As SqlDataAdapter

    Public Sub CD_InsertarProductos(ByVal Entidad_Producto As CE_Productos)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("insert into Productos values (@nombre, @precio, @categoria)", Cn)
        Try
            Cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@nombre", Entidad_Producto.Nombre)
                .AddWithValue("@precio", Entidad_Producto.Precio)
                .AddWithValue("@categoria", Entidad_Producto.Categoria)
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
    Public Sub CD_EditarProductos(ByVal Entidad_Producto As CE_Productos)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Update Productos set nombre=@nombre, precio=@precio, categoria=@categoria where id=@id", Cn)
        Try
            Cn.Open()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", Entidad_Producto.ID)
                .AddWithValue("@nombre", Entidad_Producto.Nombre)
                .AddWithValue("@precio", Entidad_Producto.Precio)
                .AddWithValue("@categoria", Entidad_Producto.Categoria)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Se produjo un error al editar el producto: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
        End Try
    End Sub
    Public Sub CD_EliminarProductos(ByVal ID As Integer)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Delete From Productos where id=@id", Cn)
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

    Public Function CD_ListarProductos() As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            SqlAdap = New SqlDataAdapter("Select * From Productos", Cn)
            SqlAdap.Fill(dst, "Productos")
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

    Public Function CD_ListarLikeProductos(Optional ByVal Nombre As String = "", Optional ByVal Categoria As String = "") As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            If Nombre <> "" Then
                SqlAdap = New SqlDataAdapter("Select * From Productos Where Nombre Like '%" & Nombre & "%'", Cn)
            End If
            If Categoria <> "" Then
                SqlAdap = New SqlDataAdapter("Select * From Productos Where Categoria Like '%" & Categoria & "%'", Cn)
            End If
            SqlAdap.Fill(dst, "Productos")
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
