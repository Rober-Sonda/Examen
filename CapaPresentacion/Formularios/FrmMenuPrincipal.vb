Public Class FrmMenuPrincipal

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private FrmActual As Form = Nothing
    Private Sub AbrirFormHijo(ByVal FrmHijo As Form)
        If FrmActual IsNot Nothing Then
            If MenuPrincipal = Formulario Then
                FrmActual.Dispose()
                FrmActual = Nothing
                Formulario = "" 'Quito el registro del formulario que se abrio para que me respete el cierre del segundo clic al mismo boton
            Else
                FrmActual.Dispose()
                FrmActual = Nothing
                FrmActual = FrmHijo
                FrmActual.TopLevel = False
                FrmActual.Dock = DockStyle.Fill
                PnlContenedor.Controls.Add(FrmHijo)
                PnlContenedor.Tag = FrmActual
                FrmActual.BringToFront()
                FrmActual.Show()
            End If
        Else
            FrmActual = FrmHijo
            FrmActual.TopLevel = False
            FrmActual.Dock = DockStyle.Fill
            PnlContenedor.Controls.Add(FrmHijo)
            PnlContenedor.Tag = FrmActual
            FrmActual.BringToFront()
            FrmActual.Show()
        End If

    End Sub

    Private Sub Btn_Productos_Click(sender As Object, e As EventArgs) Handles Btn_Productos.Click
        MenuPrincipal = "Productos"
        AbrirFormHijo(FrmProductos)
    End Sub

    Private Sub Btn_Clientes_Click(sender As Object, e As EventArgs) Handles Btn_Clientes.Click
        MenuPrincipal = "Clientes"
        AbrirFormHijo(FrmClientes)
    End Sub

    Private Sub Btn_Ventas_Click(sender As Object, e As EventArgs) Handles Btn_Ventas.Click
        MenuPrincipal = "Ventas"
        AbrirFormHijo(FrmVentas)
    End Sub

    Private Sub Btn_CerrarAplicacion_Click(sender As Object, e As EventArgs) Handles Btn_CerrarAplicacion.Click
        Me.Dispose()
    End Sub
End Class