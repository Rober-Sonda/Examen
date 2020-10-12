Imports CapaDatos
Imports CapaEntidad
Public Class CN_VentasItems
    Private Obj_VentasItems As New CD_VentasItems
    Public Function CN_ListarVentasItems(ByVal IDVenta As Integer) As DataSet
        Return Obj_VentasItems.CD_ListarVentasItems(IDVenta)
    End Function

    Public Sub CN_InsertarVentasItems(ByVal VentasItems As CE_VentasItems)
        Obj_VentasItems.CD_InsertarVentasItems(VentasItems)
    End Sub
    Public Sub CN_EditarVentasItems(ByVal VentasItems As CE_VentasItems)
        Obj_VentasItems.CD_EditarVentasItems(VentasItems)
    End Sub

    Public Sub CN_EliminarUnVentasItems(ByVal ID As Integer)
        Obj_VentasItems.CD_EliminarUnVentasItems(ID)
    End Sub
    Public Function CN_EliminarTodosVentasItems(ByVal IDVenta As Integer) As Boolean
        Return Obj_VentasItems.CD_EliminarTodosVentasItems(IDVenta)
    End Function

    Public Function CN_ValidarVentasItems(ByVal VentasItems As CE_VentasItems) As Boolean
        Dim validar As Boolean = False
        Try
            If IsNumeric(VentasItems.ID) And (VentasItems.ID) > 0 Then
                validar = True
            ElseIf IsNumeric(VentasItems.IDProducto) And (VentasItems.IDProducto) > 0 Then

                validar = True
            Else
                validar = False
                MsgBox("Ingrese un Cliente válido")
                Return validar
                Exit Function
            End If
            If IsNumeric(VentasItems.PrecioTotal) And VentasItems.PrecioTotal > 0 Then
                validar = True
            Else
                validar = False
                MsgBox("Por favor revisar el total de la venta, este no puede ser (0) nulo")
                Return validar
                Exit Function
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.ToString)
        End Try
        Return validar
    End Function
    Public Function CN_ValidarIDVentasItems(ByVal VentasItems As CE_VentasItems) As Boolean
        Dim validar As Boolean = False
        Try
            If IsNumeric(VentasItems.ID) And (VentasItems.ID) > 0 Then
                validar = True
            Else
                validar = False
                MsgBox("Error en el número de item de la venta")
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error: " + ex.ToString)
        End Try
        Return validar
    End Function
End Class
