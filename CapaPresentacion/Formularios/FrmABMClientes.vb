Imports CapaEntidad
Imports CapaNegocio
Public Class FrmABMClientes
    Dim Ent_Clientes As New CE_Clientes
    Dim ObjNeg_Clientes As New CN_Clientes
    Private Sub Btn_CancelarClientes_Click(sender As Object, e As EventArgs) Handles Btn_CancelarClientes.Click
        VbYesNo = False
        Me.Dispose()
    End Sub

    Private Sub Btn_AceptarClientes_Click(sender As Object, e As EventArgs) Handles Btn_AceptarClientes.Click
        VbYesNo = True
        With Ent_Clientes
            .Cliente = TxtNombreCliente.Text
            .Telefono = TxtTelefonoCliente.Text
            .Correo = TxtCorreoCliente.Text
        End With
        If EstadoClientes = "Agregar" Then
            ObjNeg_Clientes.CN_InsertarClientes(Ent_Clientes)
            MsgBox("Cliente ingresado correctamente", vbInformation)
        ElseIf EstadoClientes = "Editar" Then
            Ent_Clientes.ID = DatosCliente.ID
            ObjNeg_Clientes.CN_EditarClientes(Ent_Clientes)
            MsgBox("Cliente editado correctamente", vbInformation)
        ElseIf EstadoClientes = "Eliminar" Then
            Ent_Clientes.ID = DatosCliente.ID
            ObjNeg_Clientes.CN_EliminarClientes(Ent_Clientes.ID)
            MsgBox("Cliente eliminado correctamente", vbInformation)
        End If

        Me.Dispose()
    End Sub

    Private Sub FrmABMClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If EstadoClientes = "Agregar" Then
            TxtNombreCliente.Focus()
        ElseIf EstadoClientes = "Editar" Then
            TxtNombreCliente.Text = DatosCliente.Cliente
            TxtTelefonoCliente.Text = DatosCliente.Telefono
            TxtCorreoCliente.Text = DatosCliente.Correo
            TxtNombreCliente.Focus()
        ElseIf EstadoClientes = "Eliminar" Then
            TxtNombreCliente.Text = DatosCliente.Cliente
            TxtTelefonoCliente.Text = DatosCliente.Telefono
            TxtCorreoCliente.Text = DatosCliente.Correo
            DeshabilitarTxt(Me)
        End If
    End Sub
End Class