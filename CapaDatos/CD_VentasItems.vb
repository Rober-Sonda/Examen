Imports System.Data.SqlClient
Imports CapaEntidad
Public Class CD_VentasItems
    Dim ObjConexion As New Conexion
    Dim Cn As SqlConnection
    Dim SqlAdap As SqlDataAdapter
    Dim SQLTransanct As SqlTransaction

    Public Sub CD_InsertarVentasItems(ByVal Entidad_VentasItems As CE_VentasItems)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("insert into VentasItems values (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)", Cn)
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@IDVenta", Entidad_VentasItems.IDVenta)
                .AddWithValue("@IDProducto", Entidad_VentasItems.IDProducto)
                .AddWithValue("@PrecioUnitario", Entidad_VentasItems.PrecioUnitario)
                .AddWithValue("@Cantidad", Entidad_VentasItems.Cantidad)
                .AddWithValue("@PrecioTotal", Entidad_VentasItems.PrecioTotal)
            End With
            cmd.Transaction = SQLTransanct
            cmd.ExecuteNonQuery()
            SQLTransanct.Commit()
        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error de inserción: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
    End Sub
    Public Sub CD_EditarVentasItems(ByVal Entidad_VentasItems As CE_VentasItems)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Update VentasItems set IDVenta=@IDVenta, IDProducto=@IDProducto, PrecioUnitario=@PrecioUnitario, Cantidad=@Cantidad, PrecioTotal=@PrecioTotal where id=@id", Cn)
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", Entidad_VentasItems.ID)
                .AddWithValue("@IDVenta", Entidad_VentasItems.IDVenta)
                .AddWithValue("@IDProducto", Entidad_VentasItems.IDProducto)
                .AddWithValue("@PrecioUnitario", Entidad_VentasItems.PrecioUnitario)
                .AddWithValue("@Cantidad", Entidad_VentasItems.Cantidad)
                .AddWithValue("@PrecioTotal", Entidad_VentasItems.PrecioTotal)
            End With
            cmd.Transaction = SQLTransanct
            cmd.ExecuteNonQuery()
            SQLTransanct.Commit()
        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al editar el detalle de venta: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
    End Sub
    Public Sub CD_EliminarUnVentasItems(ByVal ID As Integer)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Delete From VentasItems where id=@id", Cn)
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", ID)
            End With
            cmd.Transaction = SQLTransanct
            cmd.ExecuteNonQuery()
            SQLTransanct.Commit()
        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al eliminar: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
    End Sub
    Public Function CD_EliminarTodosVentasItems(ByVal IDVenta As Integer) As Boolean
        Dim Validar As Boolean = False
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Delete From VentasItems where IDVenta=@IDVenta", Cn)
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", IDVenta)
            End With
            cmd.Transaction = SQLTransanct
            cmd.ExecuteNonQuery()
            SQLTransanct.Commit()
            Validar = True
        Catch ex As Exception
            Validar = False
            SQLTransanct.Dispose()
            MsgBox("Se produjo un error al eliminar: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
        Return Validar
    End Function

    Public Function CD_ListarVentasItems(ByVal IDVenta As Integer) As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            SqlAdap = New SqlDataAdapter("Select IDProducto,(Select Nombre From Productos where ID=IDProducto) As Producto, PrecioUnitario, Cantidad, PrecioTotal, ID From VentasItems Where IDVenta = " & IDVenta & "", Cn)
            SqlAdap.Fill(dst, "VentasItems")
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
