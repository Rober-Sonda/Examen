Imports CapaNegocio
Public Class FrmSeleccionVentasItems
    Dim CN_ObjProductos As New CN_Productos
    Private Sub Btn_AceptarProducto_Click(sender As Object, e As EventArgs) Handles Btn_AceptarProducto.Click
        If Dgv_ListadoProductosVenta.Rows.Count > 0 Then
            DatosProducto.ID = CInt(Dgv_ListadoProductosVenta.CurrentRow.Cells(0).Value)
            DatosProducto.Nombre = CStr(Dgv_ListadoProductosVenta.CurrentRow.Cells(1).Value)
            DatosProducto.Precio = CDbl(Dgv_ListadoProductosVenta.CurrentRow.Cells(2).Value)
            VbYesNo = True
            Me.Dispose()
        End If
    End Sub

    Private Sub Btn_CancelarProducto_Click(sender As Object, e As EventArgs) Handles Btn_CancelarProducto.Click
        VbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub FrmSeleccionVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloGrillas(Dgv_ListadoProductosVenta)
        CP_ListarProductos()
    End Sub
#Region "Llamadas a CapaNegocio Productos"
    Private Sub CP_ListarProductos()
        Dgv_ListadoProductosVenta.DataSource = CN_ObjProductos.CN_ListarProductos.Tables("Productos")
    End Sub
#End Region
End Class