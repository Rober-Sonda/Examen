Imports CapaDatos
Imports CapaEntidad
Public Class CN_Ventas
    Private Obj_Ventas As New CD_Ventas

    Public Function CN_InsertarVentas(ByVal Ventas As CE_Ventas) As Boolean
        Dim InsertoVenta As Boolean = False
        If CN_ValidarVenta(Ventas) = True Then
            Obj_Ventas.CD_InsertarVentas(Ventas)
            InsertoVenta = True
        End If
        Return InsertoVenta
    End Function

    Public Function CN_EditarVentas(ByVal Ventas As CE_Ventas) As Boolean
        Dim Validar As Boolean = False
        If CN_ValidarIDVenta(Ventas) Then
            If CN_ValidarVenta(Ventas) Then
                Obj_Ventas.CD_EditarVenta(Ventas)
                Validar = True
            End If
        End If
        Return Validar
    End Function

    Public Function CN_EliminarVentas(ByVal ID As Integer) As Boolean
        Dim Validar As Boolean = False
        If Obj_Ventas.CD_EliminarVenta(ID) Then
            Validar = True
        End If
        Return Validar
    End Function

    Public Function CN_ListarVentas() As DataSet
        Return Obj_Ventas.CD_ListarVentas
    End Function
    Public Function CN_ListarVentasLike_ID_Cliente(ByVal ID As Integer, ByVal Cliente As String) As DataSet
        Return Obj_Ventas.CD_ListarLikeVentas_ID_Cliente(ID, Cliente)
    End Function
    Public Function CN_ListarVentasEntreFechas(ByVal FechaIni As Date, ByVal FechaFin As Date) As DataSet
        Return Obj_Ventas.CD_ListarVentasEntreFechas(FechaIni, FechaFin)
    End Function

    Public Function CN_ConsultarVentas(ByVal ID As Integer) As CE_Ventas
        Return Obj_Ventas.CD_ConsultarVenta(ID) 'Devuelvo una entidad ventas
    End Function

    Public Function CN_UltimoIDVenta() As Integer
        Return Obj_Ventas.CD_UltimoIDVenta()
    End Function
    'Validaciones
    Public Function CN_ValidarVenta(ByVal Ventas As CE_Ventas) As Boolean
        Dim validar As Boolean = False
        Try
            If IsNumeric(Ventas.IDCliente) And (Ventas.IDCliente) > 0 Then
                validar = True
            Else
                validar = False
                MsgBox("Ingrese un Cliente válido")
                Return validar
                Exit Function
            End If
            If IsDate(Ventas.Fecha) Then
                validar = True
            Else
                validar = False
                MsgBox("Ingrese una fecha válida")
                Return validar
                Exit Function
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.ToString)
        End Try
        Return validar
    End Function
    Public Function CN_ValidarIDVenta(ByVal Ventas As CE_Ventas) As Boolean
        Dim validar As Boolean = False
        Try
            If IsNumeric(Ventas.ID) And (Ventas.ID) > 0 Then
                validar = True
            Else
                validar = False
                MsgBox("Error en el número de venta")
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.ToString)
        End Try
        Return validar
    End Function
End Class
