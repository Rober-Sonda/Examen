Imports CapaNegocio
Public Class FrmProductos
    Dim CN_ObjProductos As New CN_Productos
    Dim DtblProductos As DataTable
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Dispose()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloGrillas(Dgv_Productos)
        Formulario = "Productos"
        CP_ListarProductos()
    End Sub

    Private Sub Btn_AgregarProducto_Click(sender As Object, e As EventArgs) Handles Btn_AgregarProducto.Click
        Dim FrmProductosAgregar As New FrmABMProductos
        EstadoProductos = "Agregar"
        FrmProductosAgregar.ShowDialog()
        If VbYesNo = True Then
            CP_ListarProductos()
        End If
    End Sub

    Private Sub Btn_EditarProducto_Click(sender As Object, e As EventArgs) Handles Btn_EditarProducto.Click
        If Dgv_Productos.Rows.Count > 0 Then
            With DatosProducto
                With Dgv_Productos
                    DatosProducto.ID = CInt(Dgv_Productos.CurrentRow.Cells(0).Value)
                    DatosProducto.Nombre = CStr(Dgv_Productos.CurrentRow.Cells(1).Value)
                    DatosProducto.Precio = CDbl(Dgv_Productos.CurrentRow.Cells(2).Value)
                    DatosProducto.Categoria = CStr(Dgv_Productos.CurrentRow.Cells(3).Value)
                End With
                'paso datos del cliente seleccionado para editar los datos
            End With
            Dim FrmProductosEditar As New FrmABMProductos
            EstadoProductos = "Editar"
            FrmProductosEditar.ShowDialog()
            If VbYesNo = True Then
                CP_ListarProductos()
            End If
        End If
    End Sub

    Private Sub Btn_EliminarProducto_Click(sender As Object, e As EventArgs) Handles Btn_EliminarProducto.Click
        If Dgv_Productos.Rows.Count > 0 Then
            With DatosProducto
                With Dgv_Productos
                    DatosProducto.ID = CInt(Dgv_Productos.CurrentRow.Cells(0).Value)
                    DatosProducto.Nombre = CStr(Dgv_Productos.CurrentRow.Cells(1).Value)
                    DatosProducto.Precio = CDbl(Dgv_Productos.CurrentRow.Cells(2).Value)
                    DatosProducto.Categoria = CStr(Dgv_Productos.CurrentRow.Cells(3).Value)
                End With
                'paso datos del cliente seleccionado para editar los datos
            End With
            Dim FrmProductosEliminar As New FrmABMProductos
            EstadoProductos = "Eliminar"
            FrmProductosEliminar.ShowDialog()
            If VbYesNo = True Then
                CP_ListarProductos()
            End If
        End If
    End Sub
    Private Sub TxtBuscarProductos_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProductos.TextChanged
        If TxtBuscarProductos.Text = "" Then
            CP_ListarProductos()
        End If
        If RbNombreProducto.Checked = True And TxtBuscarProductos.Text <> "" Then
            CP_ListarProductosLikeNombre()
        End If
        If RbCategoriaProducto.Checked = True And TxtBuscarProductos.Text <> "" Then
            CP_ListarProductosLikeCategoria()
        End If
    End Sub

#Region "Llamadas a CapaNegocio Productos"
    Private Sub CP_ListarProductos()
        Dgv_Productos.DataSource = CN_ObjProductos.CN_ListarProductos.Tables("Productos")
        CP_EncabezadoProductos()
    End Sub
    Private Sub CP_ListarProductosLikeNombre()
        DtblProductos = CN_ObjProductos.CN_ListarLikeProductos(TxtBuscarProductos.Text, "").Tables("Productos")
        Dgv_Productos.DataSource = DtblProductos
        CP_EncabezadoProductos()
    End Sub
    Private Sub CP_ListarProductosLikeCategoria()
        DtblProductos = CN_ObjProductos.CN_ListarLikeProductos("", TxtBuscarProductos.Text).Tables("Productos")
        Dgv_Productos.DataSource = DtblProductos
        CP_EncabezadoProductos()
    End Sub
    Public Sub CP_EncabezadoProductos()
        If Dgv_Productos.Rows.Count > 0 Then
            Dim ArrayStr(3) As String
            ArrayStr(0) = "ID"
            ArrayStr(1) = "Nombre"
            ArrayStr(2) = "Precio"
            ArrayStr(3) = "Categoria"
            For i = 0 To 3
                With Dgv_Productos
                    .Columns(i).Name = ArrayStr(i)
                    .Columns(i).HeaderText = ArrayStr(i)
                    If i = 0 Then
                        .Columns(i).Visible = False
                    End If
                End With
            Next
        End If
    End Sub


#End Region
End Class