Imports CapaNegocio
Imports CapaEntidad
Imports System.Drawing.Color
Public Class FrmABMVentas
    Dim CN_ObjVentasABM As New CN_Ventas
    Dim CN_ObjVentasItemsABM As New CN_VentasItems
    Dim ObjVentaActual As New CE_Ventas
    Dim ObjVentaItemActual As New CE_VentasItems
    Dim TotalVenta As Double
    Dim DtblDetalleItemVenta As DataTable
    Dim ListaIDItemsExistentes As New List(Of Integer)
    Dim ListaIDItemsEditadosExistentes As New List(Of Integer) 'Lista para saber que items existentes en la BD se editaron
    Dim ListaIDItemsEliminadosExistentes As New List(Of Integer) 'Lista para saber que items existentes en la BD se eliminaron



    Private Sub Btn_CancelarVenta_Click(sender As Object, e As EventArgs) Handles Btn_CancelarVenta.Click
        Me.Dispose()
    End Sub

    Private Sub FrmABMVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigLocalRegional()

        EstiloGrillas(Dgv_VentaItems)
        CargarCmbClientes(CmbClientesVenta)
        LblEstadoVentas.Text = EstadoVentas

        If EstadoVentas = "Agregar" Then
            TxtFechaVenta.Text = CStr(Today)
            CP_ColorLineas(DodgerBlue)
            CP_CrearColumnasDgv()
        ElseIf EstadoVentas = "Editar" Then
            CP_ColorLineas(Orange)
            CP_DatosdeVenta()
            CP_EncabezadoVentaItems()
            'CP_IDItemsExistentes() 'Cargo en lista los ID de los items que existen (lista de referencia)
        ElseIf EstadoVentas = "Eliminar" Then
            CP_ColorLineas(Tomato)
            CP_DatosdeVenta()
            DeshabilitarTxt(Me)
            CP_EncabezadoVentaItems()
            TxtFechaVenta.Enabled = False
            Btn_EditarProductoVentaItem.Enabled = False
            Btn_EliminarProductoVentaItem.Enabled = False
            Btn_AgregarProductoVentaItem.Enabled = False
            CmbClientesVenta.Enabled = False
            Dgv_VentaItems.Enabled = False
        End If
    End Sub

    Private Sub Btn_AgregarProductoVentaItem_Click(sender As Object, e As EventArgs) Handles Btn_AgregarProductoVentaItem.Click
        Dim FrmSeleccionVentasItems As New FrmSeleccionVentasItems
        EstadoProductoVentaItem = "Agregar"
        FrmSeleccionVentasItems.ShowDialog()
        If VbYesNo = True Then
            Dim FrmApruebaItemVenta As New FrmABMVentasItems
            FrmApruebaItemVenta.ShowDialog()
            If VbYesNo = True Then
                CP_AgregarProductoVentaItem() 'Por Agregar venta o editar agregamos item en el grid o dataset
                CP_PrecioTotalItems()
            End If
        End If
    End Sub

    Private Sub Btn_EditarProductoVentaItem_Click(sender As Object, e As EventArgs) Handles Btn_EditarProductoVentaItem.Click
        EstadoProductoVentaItem = "Editar"
        If Dgv_VentaItems.Rows.Count > 0 Then
            CP_EditarProductoVentaItem()
            CP_PrecioTotalItems()
        Else
            'Mensaje error
            MensajeError("Seleccione un item para Editar")
        End If
    End Sub

    Private Sub Btn_EliminarProductoVentaItem_Click(sender As Object, e As EventArgs) Handles Btn_EliminarProductoVentaItem.Click
        EstadoProductoVentaItem = "Eliminar"
        If Dgv_VentaItems.Rows.Count > 0 Then
            CP_EliminarProductoVentaItem()
            CP_PrecioTotalItems()
        Else
            'Mensaje error
            MensajeError("Seleccione un item para Eliminar")
        End If
    End Sub

    Private Sub Btn_AceptarVenta_Click(sender As Object, e As EventArgs) Handles Btn_AceptarVenta.Click
        'Validaciones
        If EstadoVentas = "Agregar" Then
            IfDgvVacioNoSeguir()
            ObjVentaActual.Fecha = CDate(TxtFechaVenta.Text)
            ObjVentaActual.IDCliente = CInt(CmbClientesVenta.SelectedValue)
            ObjVentaActual.Total = TotalVenta
            'Inserto encabezado de venta
            If CN_ObjVentasABM.CN_InsertarVentas(ObjVentaActual) Then
                ObjVentaActual.ID = CN_ObjVentasABM.CN_UltimoIDVenta()
            Else
                Exit Sub
            End If
            'recorremos cada item del detalle
            For Each row As DataGridViewRow In Me.Dgv_VentaItems.Rows
                'Cargo los datos del detalle actual y los paso a la clase
                ObjVentaItemActual.IDVenta = ObjVentaActual.ID
                ObjVentaItemActual.IDProducto = CInt(row.Cells("IDProducto").Value)
                ObjVentaItemActual.PrecioUnitario = CInt(row.Cells("Precio Unitario").Value)
                ObjVentaItemActual.Cantidad = CInt(row.Cells("Cantidad").Value)
                ObjVentaItemActual.PrecioTotal = CInt(row.Cells("Precio Total").Value)
                'Paso la entidad con los datos que cargue anteriormente
                CN_ObjVentasItemsABM.CN_InsertarVentasItems(ObjVentaItemActual)
            Next

        ElseIf EstadoVentas = "Editar" Then
            IfDgvVacioNoSeguir()
            ObjVentaActual.Fecha = CDate(TxtFechaVenta.Text)
            ObjVentaActual.IDCliente = CInt(CmbClientesVenta.SelectedValue)
            ObjVentaActual.Total = TotalVenta
            If CN_ObjVentasABM.CN_EditarVentas(ObjVentaActual) Then
                If ListaIDItemsEditadosExistentes.Count > 0 Then
                    For Each row As DataGridViewRow In Me.Dgv_VentaItems.Rows
                        For i = 0 To ListaIDItemsEditadosExistentes.Count - 1
                            If CInt(row.Cells("ID").Value) = ListaIDItemsEditadosExistentes(i) Then
                                ObjVentaItemActual.IDVenta = ObjVentaActual.ID
                                ObjVentaItemActual.IDProducto = CInt(row.Cells("IDProducto").Value)
                                ObjVentaItemActual.PrecioUnitario = CInt(row.Cells("Precio Unitario").Value)
                                ObjVentaItemActual.Cantidad = CInt(row.Cells("Cantidad").Value)
                                ObjVentaItemActual.PrecioTotal = CInt(row.Cells("Precio Total").Value)
                                ObjVentaItemActual.ID = ListaIDItemsEditadosExistentes(i)
                                CN_ObjVentasItemsABM.CN_EditarVentasItems(ObjVentaItemActual)
                            End If
                        Next
                    Next
                ElseIf ListaIDItemsEliminadosExistentes.Count > 0 Then
                    For i = 0 To ListaIDItemsEliminadosExistentes.Count - 1
                        CN_ObjVentasItemsABM.CN_EliminarUnVentasItems(ListaIDItemsEliminadosExistentes(i))
                    Next
                End If
                'Items nuevos
                For Each row As DataGridViewRow In Me.Dgv_VentaItems.Rows
                    If CInt(row.Cells("ID").Value) = 0 Then '0 es el valor del ID cuando se agrega al detalle
                        ObjVentaItemActual.IDVenta = ObjVentaActual.ID
                        ObjVentaItemActual.IDProducto = CInt(row.Cells("IDProducto").Value)
                        ObjVentaItemActual.PrecioUnitario = CInt(row.Cells("Precio Unitario").Value)
                        ObjVentaItemActual.Cantidad = CInt(row.Cells("Cantidad").Value)
                        ObjVentaItemActual.PrecioTotal = CInt(row.Cells("Precio Total").Value)
                        CN_ObjVentasItemsABM.CN_InsertarVentasItems(ObjVentaItemActual)
                    End If
                Next
            End If
            MsgBox("Venta Editada Correctamente")
            Me.Dispose()
        ElseIf EstadoVentas = "Eliminar" Then
            MsgBox("¿Eliminar esta venta?", MsgBoxStyle.YesNo)
            If vbYes = MsgBoxResult.Yes Then
                VbYesNo = True
                If CN_ObjVentasABM.CN_EliminarVentas(DatosVentas.ID) Then
                    If CN_ObjVentasItemsABM.CN_EliminarTodosVentasItems(DatosVentas.ID) Then
                        MsgBox("Venta Eliminada Correctamente")
                    End If
                End If
                Me.Dispose()
            Else
                VbYesNo = False
            End If
        End If
    End Sub
    Private Sub CP_AgregarProductoVentaItem()
        If EstadoProductoVentaItem = "Agregar" And EstadoVentas = "Agregar" Then
            Dgv_VentaItems.Rows.Add(DatosProducto.ID, DatosProducto.Nombre, DatosProducto.Precio, CantidadProducto, PrecioTotalItem)
        End If
        If EstadoProductoVentaItem = "Agregar" And EstadoVentas = "Editar" Then
            'Agrega un item en estado de edicion de la venta
            CP_AgregarItemVentaAlDst()
        End If
    End Sub
    Private Sub CP_EditarProductoVentaItem()
        With DatosProducto
            With Dgv_VentaItems
                DatosProducto.ID = CInt(Dgv_VentaItems.CurrentRow.Cells(0).Value)
                DatosProducto.Nombre = CStr(Dgv_VentaItems.CurrentRow.Cells(1).Value)
                DatosProducto.Precio = CDbl(Dgv_VentaItems.CurrentRow.Cells(2).Value)
                CantidadProducto = CDbl(Dgv_VentaItems.CurrentRow.Cells(3).Value)
            End With
            'paso datos del cliente seleccionado para editar los datos
        End With
        Dim FrmProductosEditarItems As New FrmABMVentasItems
        FrmProductosEditarItems.ShowDialog()
        If VbYesNo = True Then
            CP_IDItemsEditadosExistentes() 'Agrego el ID si no es 0, en caso de ser 0 se edita uno asignado
            Dgv_VentaItems.CurrentRow.Cells(0).Value = DatosProducto.ID
            Dgv_VentaItems.CurrentRow.Cells(1).Value = DatosProducto.Nombre
            Dgv_VentaItems.CurrentRow.Cells(2).Value = DatosProducto.Precio
            Dgv_VentaItems.CurrentRow.Cells(3).Value = CantidadProducto
            PrecioTotalItem = DatosProducto.Precio * CantidadProducto
            Dgv_VentaItems.CurrentRow.Cells(4).Value = PrecioTotalItem
        End If
    End Sub
    Private Sub CP_EliminarProductoVentaItem()
        'If EstadoProductoVentaItem = "Eliminar" And EstadoVentas = "Agregar" Then
        With DatosProducto
            With Dgv_VentaItems
                DatosProducto.ID = CInt(Dgv_VentaItems.CurrentRow.Cells(0).Value)
                DatosProducto.Nombre = CStr(Dgv_VentaItems.CurrentRow.Cells(1).Value)
                DatosProducto.Precio = CDbl(Dgv_VentaItems.CurrentRow.Cells(2).Value)
                CantidadProducto = CDbl(Dgv_VentaItems.CurrentRow.Cells(3).Value)
            End With
            'paso datos del cliente seleccionado para editar los datos
        End With
        Dim FrmProductosEliminarItems As New FrmABMVentasItems
        FrmProductosEliminarItems.ShowDialog()
        If VbYesNo = True Then
            CP_IDItemsEliminadosExistentes() 'Si es ID <> 0 guardo para eliminar si se acepta la edicion
            Dgv_VentaItems.Rows.Remove(Dgv_VentaItems.CurrentRow)
        End If
        'End If
        'If EstadoProductoVentaItem = "Eliminar" And EstadoVentas = "Editar" Then
        '    'Elimina un item en estado de edicion de la venta
        '    CP_EliminarItemVentaAlDtble()
        'End If
    End Sub

    Private Sub MensajeError(ByVal StrMsj As String)
        MsgBox(StrMsj, vbCritical)
    End Sub
    Private Sub CP_PrecioTotalItems()
        'Sumar una Columna
        Dim Total As Double
        For Each row As DataGridViewRow In Me.Dgv_VentaItems.Rows
            Total += Val(row.Cells("Precio Total").Value)
        Next
        TotalVenta = Total 'Cada actualizacion de precio ya prepara el total
        Me.TxtPrecioProdVenta.Text = Total.ToString
    End Sub
    Public Sub CP_ColorLineas(ByVal BkColor As Color)
        LblEstadoVentas.ForeColor = BkColor
        Panel2.BackColor = BkColor
        Panel4.BackColor = BkColor
        Panel6.BackColor = BkColor
        Panel8.BackColor = BkColor
        Panel9.BackColor = BkColor
        Panel10.BackColor = BkColor
        Panel12.BackColor = BkColor
    End Sub

    Public Function CP_CargarVentaCompleta() As CE_Ventas
        Return CN_ObjVentasABM.CN_ConsultarVentas(DatosVentas.ID)
    End Function
    Private Sub CP_ListarVentasItems(ByVal IDVenta As Integer)
        DtblDetalleItemVenta = CN_ObjVentasItemsABM.CN_ListarVentasItems(IDVenta).Tables("VentasItems")
        Dgv_VentaItems.DataSource = DtblDetalleItemVenta
    End Sub
    Private Sub CP_DatosdeVenta()
        DatosVentas = CP_CargarVentaCompleta()
        ObjVentaActual.ID = DatosVentas.ID
        TxtFechaVenta.Text = CStr(DatosVentas.Fecha)
        TxtPrecioProdVenta.Text = CStr(DatosVentas.Total)
        CmbClientesVenta.SelectedValue = DatosVentas.IDCliente 'Lista el cliente con el mismo ID
        CP_ListarVentasItems(DatosVentas.ID)
    End Sub
    Public Sub CP_CrearColumnasDgv()
        Dim ArrayStr(5) As String
        ArrayStr(0) = "IDProducto"
        ArrayStr(1) = "Producto"
        ArrayStr(2) = "Precio Unitario"
        ArrayStr(3) = "Cantidad"
        ArrayStr(4) = "Precio Total"
        ArrayStr(5) = "ID" 'ID de ventasitems
        For i = 0 To 5
            Dim col As New DataGridViewTextBoxColumn
            Dgv_VentaItems.Columns.Add(col)
            With Dgv_VentaItems
                .Columns(i).Name = ArrayStr(i)
                .Columns(i).HeaderText = ArrayStr(i)
                If i = 0 Or i = 5 Then
                    .Columns(i).Visible = False
                End If
            End With
        Next

    End Sub
    Public Sub CP_EliminarItemVentaAlDtble()
        ' Fila actualmente seleccionada en el control DataGridView
        Dim FilaActual As DataGridViewRow = Dgv_VentaItems.CurrentRow
        If (Not FilaActual Is Nothing) Then
            ' Eliminar la fila en el control DataGridView.
            Dgv_VentaItems.Rows.Remove(FilaActual)
            ' Aceptar los cambios en el objeto DataTable enlazado
            DirectCast(Dgv_VentaItems.DataSource, DataTable).AcceptChanges()
        End If
    End Sub
    Public Sub CP_EncabezadoVentaItems()
        Dim ArrayStr(5) As String
        ArrayStr(0) = "IDProducto"
        ArrayStr(1) = "Producto"
        ArrayStr(2) = "Precio Unitario"
        ArrayStr(3) = "Cantidad"
        ArrayStr(4) = "Precio Total"
        ArrayStr(5) = "ID" 'ID de ventasitems
        For i = 0 To 5
            With Dgv_VentaItems
                .Columns(i).Name = ArrayStr(i)
                .Columns(i).HeaderText = ArrayStr(i)
                If i = 0 Or i = 5 Then
                    .Columns(i).Visible = False
                End If
            End With
        Next
    End Sub
    Public Sub IfDgvVacioNoSeguir()
        If Dgv_VentaItems.Rows.Count <= 0 Then
            MsgBox("Ingrese items para el detalle de la venta")
            Exit Sub
        End If
    End Sub


    Public Sub CP_AgregarItemVentaAlDst()
        'Declarar Filas como DataRow
        Dim fila As Data.DataRow

        'Asignamos a fila la nueva Row(Fila)del Dataset 
        fila = DtblDetalleItemVenta.NewRow

        'Agregamos los valores a los campos de la tabla
        fila("IDProducto") = DatosProducto.ID
        fila("Producto") = DatosProducto.Nombre
        fila("PrecioUnitario") = DatosProducto.Precio
        fila("Cantidad") = CantidadProducto
        fila("PrecioTotal") = PrecioTotalItem
        fila("ID") = DatosVentasItems.ID
        DtblDetalleItemVenta.Rows.Add(fila)
        'Dgv_VentaItems.DataSource = DtblDetalleItemVenta
    End Sub
    'Public Sub CP_IDItemsExistentes() 'Ejecutamos solo en el load
    '    Dim IDItemsExistentes As Integer = 0
    '    If Dgv_VentaItems.Rows.Count > 0 Then
    '        For Each row As DataGridViewRow In Me.Dgv_VentaItems.Rows
    '            IDItemsExistentes = CInt(row.Cells("ID").Value)
    '            ListaIDItemsExistentes.Add(IDItemsExistentes)
    '        Next
    '    End If
    'End Sub
    Public Sub CP_IDItemsEditadosExistentes()
        Dim IDItemsEditadosExistentes As Integer = 0
        If CInt(Dgv_VentaItems.CurrentRow.Cells("ID").Value) <> 0 Then 'las filas asignadas se asignan con ID 0 por eso guardamos las <> 0
            IDItemsEditadosExistentes = CInt(Dgv_VentaItems.CurrentRow.Cells("ID").Value)
            ListaIDItemsEditadosExistentes.Add(IDItemsEditadosExistentes)
        End If
    End Sub
    Public Sub CP_IDItemsEliminadosExistentes()
        Dim IDItemsEliminadosExistentes As Integer = 0
        If CInt(Dgv_VentaItems.CurrentRow.Cells("ID").Value) <> 0 Then 'las filas asignadas se asignan con ID 0 por eso guardamos las <> 0
            IDItemsEliminadosExistentes = CInt(Dgv_VentaItems.CurrentRow.Cells("ID").Value)
            ListaIDItemsEliminadosExistentes.Add(IDItemsEliminadosExistentes)
        End If
    End Sub
End Class