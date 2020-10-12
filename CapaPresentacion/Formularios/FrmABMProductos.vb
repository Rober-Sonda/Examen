Imports CapaEntidad
Imports CapaNegocio
Public Class FrmABMProductos
    Dim Ent_Producto As New CE_Productos
    Dim ObjNeg_Producto As New CN_Productos
    Private Sub Btn_CancelarProductos_Click(sender As Object, e As EventArgs) Handles Btn_CancelarProductos.Click
        VbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub FrmABMProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EstadoProductos = "Agregar" Then
            TxtNombreProducto.Focus()
        ElseIf EstadoProductos = "Editar" Then
            TxtNombreProducto.Text = DatosProducto.Nombre
            TxtPrecioProducto.Text = CStr(DatosProducto.Precio)
            TxtCategoriaProducto.Text = DatosProducto.Categoria
            TxtNombreProducto.Focus()
        ElseIf EstadoProductos = "Eliminar" Then
            TxtNombreProducto.Text = DatosProducto.Nombre
            TxtPrecioProducto.Text = CStr(DatosProducto.Precio)
            TxtCategoriaProducto.Text = DatosProducto.Categoria
            DeshabilitarTxt(Me)
        End If
    End Sub

    Private Sub Btn_AceptarProductos_Click(sender As Object, e As EventArgs) Handles Btn_AceptarProductos.Click
        VbYesNo = True
        With Ent_Producto
            .Nombre = TxtNombreProducto.Text
            .Precio = CDbl(TxtPrecioProducto.Text)
            .Categoria = TxtCategoriaProducto.Text
        End With
        If EstadoProductos = "Agregar" Then
            ObjNeg_Producto.CN_InsertarProductos(Ent_Producto)
            MsgBox("Producto ingresado correctamente", vbInformation)
        ElseIf EstadoProductos = "Editar" Then
            Ent_Producto.ID = DatosProducto.ID
            ObjNeg_Producto.CN_EditarProductos(Ent_Producto)
            MsgBox("Producto editado correctamente", vbInformation)
        ElseIf EstadoProductos = "Eliminar" Then
            Ent_Producto.ID = DatosProducto.ID
            ObjNeg_Producto.CN_EliminarProductos(Ent_Producto.ID)
            MsgBox("Producto eliminado correctamente", vbInformation)
        End If

        Me.Dispose()
    End Sub
End Class