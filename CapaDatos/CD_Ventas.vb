Imports System.Data.SqlClient
Imports CapaEntidad
Public Class CD_Ventas
    Dim ObjConexion As New Conexion
    Dim Cn As SqlConnection
    Dim SqlAdap As SqlDataAdapter
    Dim SQLTransanct As SqlTransaction

    Public Sub CD_InsertarVentas(ByVal Entidad_Venta As CE_Ventas)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("insert into Ventas values (@IDCliente, @Fecha, @Total)", Cn)
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@IDCliente", Entidad_Venta.IDCliente)
                .AddWithValue("@Fecha", Entidad_Venta.Fecha)
                .AddWithValue("@Total", Entidad_Venta.Total)
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
    Public Sub CD_EditarVenta(ByVal Entidad_Venta As CE_Ventas)
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Update Ventas set IDCliente=@IDCliente, Fecha=@Fecha, Total=@Total where id=@id", Cn)
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            cmd.CommandType = CommandType.Text
            With cmd.Parameters
                .AddWithValue("@id", Entidad_Venta.ID)
                .AddWithValue("@IDCliente", Entidad_Venta.IDCliente)
                .AddWithValue("@Fecha", Entidad_Venta.Fecha)
                .AddWithValue("@Total", Entidad_Venta.Total)
            End With
            cmd.Transaction = SQLTransanct
            cmd.ExecuteNonQuery()
            SQLTransanct.Commit()
        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al editar: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
    End Sub
    Public Function CD_EliminarVenta(ByVal ID As Integer) As Boolean
        Dim Validar As Boolean = False
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Delete From Ventas where id=@id", Cn)
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
            Validar = True
        Catch ex As Exception
            Validar = False
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al eliminar: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
        Return Validar
    End Function

    Public Function CD_UltimoIDVenta() As Integer
        Dim UltimoIDVenta As Integer = 0
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            Dim cmd As New SqlCommand("Select TOP 1 ID From Ventas order by ID DESC", Cn)
            cmd.CommandType = CommandType.Text
            cmd.Transaction = SQLTransanct
            If IsNumeric(CInt(cmd.ExecuteScalar())) And CInt(cmd.ExecuteScalar()) > 0 Then
                UltimoIDVenta = CInt(cmd.ExecuteScalar())
            End If
            SQLTransanct.Commit()
        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al listar: " + ex.ToString, MsgBoxStyle.Critical)
        Finally
            Cn.Close()
            Cn.Dispose()
            SQLTransanct.Dispose()
        End Try
        Return UltimoIDVenta
    End Function
    Public Function CD_ConsultarVenta(ByVal ID As Integer) As CE_Ventas
        Dim Entidad_Venta As New CE_Ventas
        Cn = ObjConexion.Conectar
        Dim cmd As New SqlCommand("Select ID, IDCliente, Fecha, Total From Ventas where id=@id", Cn)
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
            Dim registro As SqlDataReader
            registro = cmd.ExecuteReader()
            If registro.Read() = True Then
                Entidad_Venta.ID = registro("ID")
                Entidad_Venta.IDCliente = registro("IDCliente")
                Entidad_Venta.Fecha = registro("Fecha")
                Entidad_Venta.Total = registro("Total")
            End If

        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al editar: " + ex.ToString)
        Finally
            Cn.Close()
            Cn.Dispose()
            cmd.Parameters.Clear()
            SQLTransanct.Dispose()
        End Try
        Return Entidad_Venta
    End Function
    Public Function CD_ListarVentas() As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            SQLTransanct = Cn.BeginTransaction()
            Dim cmd As New SqlCommand("Select ID, IDCliente, (Select Cliente From Clientes Where ID = IDCliente) As Cliente, Fecha, Total From Ventas", Cn)
            cmd.CommandType = CommandType.Text
            SqlAdap = New SqlDataAdapter(cmd)
            cmd.Transaction = SQLTransanct
            SqlAdap.Fill(dst, "Ventas")
            SqlAdap.SelectCommand.ExecuteNonQuery()
            SQLTransanct.Commit()
        Catch ex As Exception
            SQLTransanct.Rollback()
            MsgBox("Se produjo un error al listar: " + ex.ToString, MsgBoxStyle.Critical)
        Finally
            dst.Dispose()
            SqlAdap.Dispose()
            Cn.Close()
            Cn.Dispose()
            SQLTransanct.Dispose()
        End Try
        Return dst
    End Function

    Public Function CD_ListarLikeVentas_ID_Cliente(Optional ByVal ID As Integer = 0, Optional ByVal Cliente As String = "") As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            If ID <> 0 Then
                SqlAdap = New SqlDataAdapter("Select ID, IDCliente, (Select Cliente From Clientes Where ID = IDCliente) As 'Cliente', Fecha, Total From Ventas Where ID Like '" & ID & "%'", Cn)
            End If
            If Cliente <> "" Then
                SqlAdap = New SqlDataAdapter("Select ID, IDCliente, (Select Cliente From Clientes Where ID = IDCliente) As 'Cliente', Fecha, Total From Ventas Where 'Cliente' Like '%" & Cliente & "%'", Cn)
            End If
            SqlAdap.Fill(dst, "Ventas")
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
    Public Function CD_ListarVentasEntreFechas(ByVal FechaIni As Date, ByVal FechaFin As Date) As DataSet
        Dim dst As New DataSet
        Cn = ObjConexion.Conectar
        Try
            Cn.Open()
            SqlAdap = New SqlDataAdapter("Select ID, IDCliente, (Select Cliente From Clientes Where ID = IDCliente) As 'Cliente', Fecha, Total From Ventas Where Fecha Between '" & FechaIni & "' and '" & FechaFin & "'", Cn)
            SqlAdap.Fill(dst, "Ventas")
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
