Imports CapaNegocio
Imports CapaEntidad
Public Class FrmVentas
    Dim CN_ObjVentas As New CN_Ventas
    Dim CN_ObjVentasItems As New CN_VentasItems
    Dim ObjVentaActual As New CE_Ventas
    Dim DtblVentas As DataTable
    Private Sub Btn_CerrarVenta_Click(sender As Object, e As EventArgs) Handles Btn_CerrarVenta.Click
        Me.Dispose()
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloGrillas(Dgv_Ventas)
        EstiloGrillas(Dgv_VentasItems)
        Formulario = "Ventas" 'Variable para saber que formulario tengo abierto para el control de ventanas
        CP_ListarVentas()
    End Sub

    Private Sub Btn_AgregarVenta_Click(sender As Object, e As EventArgs) Handles Btn_AgregarVenta.Click
        Dim FrmVentasAgregar As New FrmABMVentas
        EstadoVentas = "Agregar"
        FrmVentasAgregar.ShowDialog()
        If VbYesNo = True Then
            CP_ListarVentas()
        End If
    End Sub

    Private Sub Btn_EditarVenta_Click(sender As Object, e As EventArgs) Handles Btn_EditarVenta.Click
        Dim FrmVentasEditar As New FrmABMVentas
        EstadoVentas = "Editar"
        FrmVentasEditar.ShowDialog()
        If VbYesNo = True Then
            CP_ListarVentas()
        End If
    End Sub

    Private Sub Btn_EliminarVenta_Click(sender As Object, e As EventArgs) Handles Btn_EliminarVenta.Click
        Dim FrmVentasEliminar As New FrmABMVentas
        EstadoVentas = "Eliminar"
        FrmVentasEliminar.ShowDialog()
        If VbYesNo = True Then
            CP_ListarVentas()
        End If
    End Sub

    Private Sub Dgv_Ventas_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_Ventas.SelectionChanged
        If Dgv_Ventas.Rows.Count > 0 Then
            'Dgv_VentasItems.Rows.Clear()
            ObjVentaActual.ID = CInt(Dgv_Ventas.CurrentRow.Cells(0).Value) 'cargo el id de la venta seleccionada
            CP_ListarVentasItems(ObjVentaActual.ID) 'Listo el detalle de la venta que seleccione
            DatosVentas.ID = ObjVentaActual.ID 'DatosVentas es global para pasar el ID al formABM
        Else
            CP_BorrarDetalleEnCeroVentas()
        End If
    End Sub


#Region "Llamadas a CapaNegocio Ventas y VentasItems"
    Private Sub CP_ListarVentas()
        Dgv_Ventas.DataSource = CN_ObjVentas.CN_ListarVentas.Tables("Ventas")
        If Dgv_Ventas.Rows.Count > 0 Then
            CP_EncabezadoVentas()
        Else 'Ventas esta vacia
            'Limpio el detalle
            CP_BorrarDetalleEnCeroVentas()
        End If
    End Sub
    Private Sub CP_ListarVentasItems(ByVal IDVenta As Integer)
        Dgv_VentasItems.DataSource = CN_ObjVentasItems.CN_ListarVentasItems(IDVenta).Tables("VentasItems")
        If Dgv_VentasItems.Rows.Count > 0 Then
            CP_EncabezadoVentaItems()
        End If
    End Sub
    Public Sub CP_EncabezadoVentaItems()
        Dim ArrayStr(5) As String
        ArrayStr(0) = "IDProducto"
        ArrayStr(1) = "Producto"
        ArrayStr(2) = "Precio Unitario"
        ArrayStr(3) = "Cantidad"
        ArrayStr(4) = "Precio Total"
        ArrayStr(5) = "ID"
        For i = 0 To 5
            With Dgv_VentasItems
                .Columns(i).Name = ArrayStr(i)
                .Columns(i).HeaderText = ArrayStr(i)
                If i = 0 Or i = 5 Then
                    .Columns(i).Visible = False
                End If
            End With
        Next

    End Sub
    Public Sub CP_EncabezadoVentas()
        If Dgv_Ventas.Rows.Count > 0 Then
            Dim ArrayStr(4) As String
            ArrayStr(0) = "Venta"
            ArrayStr(1) = "IDCliente"
            ArrayStr(2) = "Cliente"
            ArrayStr(3) = "Fecha"
            ArrayStr(4) = "Precio Total"
            For i = 0 To 4
                With Dgv_Ventas
                    .Columns(i).Name = ArrayStr(i)
                    .Columns(i).HeaderText = ArrayStr(i)
                    If i = 1 Then
                        .Columns(i).Visible = False 'Columna de IdCliente no se muestra
                    End If
                End With
            Next
        End If
    End Sub
    Private Sub RbClienteVenta_CheckedChanged(sender As Object, e As EventArgs) Handles RbClienteVenta.CheckedChanged
        CP_OcultarTxtFechas()
        TxtBuscarVenta.Focus()
    End Sub

    Private Sub RbIDVenta_CheckedChanged(sender As Object, e As EventArgs) Handles RbIDVenta.CheckedChanged
        CP_OcultarTxtFechas()
        TxtBuscarVenta.Focus()
    End Sub

    Private Sub RbEntreFechasVenta_CheckedChanged(sender As Object, e As EventArgs) Handles RbEntreFechasVenta.CheckedChanged
        If RbEntreFechasVenta.Checked Then
            CP_MostrarTxtFechas()
            Me.Timer1.Enabled = True
            TxtFechaIni.Focus()
        End If
    End Sub
    Private Sub CP_OcultarTxtFechas()
        TxtFechaIni.Visible = False
        TxtFechaFin.Visible = False
        TxtBuscarVenta.Visible = True
    End Sub
    Private Sub CP_MostrarTxtFechas()
        TxtFechaIni.Visible = True
        TxtFechaFin.Visible = True
        TxtBuscarVenta.Visible = False
        LblMensajeGuia.Visible = True
    End Sub

    Private Sub TxtBuscarVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarVenta.KeyPress
        If RbIDVenta.Checked Then
            SoloNumeros(e)
        End If
    End Sub

    Private Sub TxtBuscarVenta_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarVenta.TextChanged
        If RbIDVenta.Checked And TxtBuscarVenta.Text <> "" Then
            CP_ListarVentasLikeID()
            If Dgv_Ventas.Rows.Count <= 0 Then
                CP_BorrarDetalleEnCeroVentas()
            End If
        ElseIf RbClienteVenta.Checked And TxtBuscarVenta.Text <> "" Then
            DtblVentas = CN_ObjVentas.CN_ListarVentasLike_ID_Cliente(0, TxtBuscarVenta.Text).Tables("Ventas")
            Dgv_Ventas.DataSource = DtblVentas
            CP_EncabezadoVentas()
            If Dgv_Ventas.Rows.Count <= 0 Then
                CP_BorrarDetalleEnCeroVentas()
            End If
        Else
            CP_ListarVentas()
        End If
    End Sub

    Private Sub TxtFechaFin_Leave(sender As Object, e As EventArgs) Handles TxtFechaFin.Leave
        If TxtFechaIni.MaskFull = True And TxtFechaFin.MaskFull = True Then
            CP_ListarVentasEntreFechas()
            If Dgv_Ventas.Rows.Count <= 0 Then
                CP_BorrarDetalleEnCeroVentas()
            End If
        End If
    End Sub

    Private Sub TxtFechaIni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFechaIni.KeyPress
        SiguienteControl(e)
    End Sub

    Private Sub CP_ListarVentasLikeID()
        DtblVentas = CN_ObjVentas.CN_ListarVentasLike_ID_Cliente(CInt(TxtBuscarVenta.Text), "").Tables("Ventas")
        Dgv_Ventas.DataSource = DtblVentas
        CP_EncabezadoVentas()
    End Sub
    Private Sub CP_ListarVentasEntreFechas()
        DtblVentas = CN_ObjVentas.CN_ListarVentasEntreFechas(CDate(TxtFechaIni.Text), CDate(TxtFechaFin.Text)).Tables("Ventas")
        Dgv_Ventas.DataSource = DtblVentas
        CP_EncabezadoVentas()
    End Sub


    Private Sub CP_BorrarDetalleEnCeroVentas()
        Dgv_VentasItems.DataSource = Nothing
        Dgv_VentasItems.Columns.Clear()
        Dgv_VentasItems.Rows.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = Me.Timer1.Interval
        While i > 0
            i -= 1
        End While
        LblMensajeGuia.Visible = False
        Me.Timer1.Enabled = False
    End Sub

    Private Sub TxtFechaFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFechaFin.KeyPress
        SiguienteControl(e)
    End Sub

#End Region
End Class
