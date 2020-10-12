Public Class FrmABMVentasItems
    Private Sub Btn_AceptarVentaItem_Click(sender As Object, e As EventArgs) Handles Btn_AceptarVentaItem.Click

        'Info que paso al grid detalle de venta
        If EstadoProductoVentaItem = "Agregar" Then
            'Datos que vienen de la seleccion del producto
            DatosProducto.Precio = CDbl(TxtProductoPrecio.Text)
            CantidadProducto = CDbl(TxtCantidadProducto.Text)
            PrecioTotalItem = DatosProducto.Precio * CantidadProducto
        ElseIf EstadoProductoVentaItem = "Editar" Then
            DatosProducto.Nombre = TxtNombreProducto.Text
            DatosProducto.Precio = CDbl(TxtProductoPrecio.Text)
            CantidadProducto = CInt(TxtCantidadProducto.Text)
        ElseIf EstadoProductoVentaItem = "Eliminar" Then

        End If
        VbYesNo = True
        Me.Dispose()
    End Sub

    Private Sub Btn_CancelarVentaItem_Click(sender As Object, e As EventArgs) Handles Btn_CancelarVentaItem.Click
        VbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub FrmABMVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblEstadoItems.Text = EstadoProductoVentaItem + " Item"
        If EstadoProductoVentaItem = "Eliminar" Then
            TxtNombreProducto.Text = DatosProducto.Nombre
            TxtProductoPrecio.Text = CStr(DatosProducto.Precio)
            TxtCantidadProducto.Text = CStr(CantidadProducto)
            TxtProductoPrecio.Enabled = False
            TxtCantidadProducto.Enabled = False
        ElseIf EstadoProductoVentaItem = "Agregar" Then
            'Datos que vienen de la seleccion del producto
            TxtNombreProducto.Text = DatosProducto.Nombre
            TxtProductoPrecio.Text = CStr(DatosProducto.Precio)
            TxtCantidadProducto.Text = CStr(CantidadProducto)
            TxtCantidadProducto.Text = "0"
            TxtCantidadProducto.SelectAll()
        ElseIf EstadoProductoVentaItem = "Editar" Then
            TxtNombreProducto.Text = DatosProducto.Nombre
            TxtProductoPrecio.Text = CStr(DatosProducto.Precio)
            TxtCantidadProducto.Text = CStr(CantidadProducto)
            TxtCantidadProducto.SelectAll()
        End If
    End Sub

    Private Sub TxtProductoPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProductoPrecio.KeyPress
        SoloNumeros(e)
        NoPermiteEspacios(e)
        CambiarComaPorPunto(e)
        NoRepetirPuntoDecimal(TxtProductoPrecio, e)
    End Sub

    Private Sub TxtCantidadProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadProducto.KeyPress
        SoloNumeros(e)
        NoPermiteEspacios(e)
        CambiarComaPorPunto(e)
        NoRepetirPuntoDecimal(TxtCantidadProducto, e)
    End Sub
End Class