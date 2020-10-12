Imports CapaNegocio
Imports CapaEntidad
Public Class FrmClientes
    Dim CN_ObjClientes As New CN_Clientes
    Dim DtblClientes As New DataTable
    Private Sub Btn_Cerrar_Click_1(sender As Object, e As EventArgs) Handles Btn_CerrarClientes.Click
        Me.Dispose()
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloGrillas(Dgv_Clientes)
        Formulario = "Clientes"
        CP_ListarClientes()
    End Sub
    Private Sub Btn_AgregarClientes_Click(sender As Object, e As EventArgs) Handles Btn_AgregarClientes.Click
        Dim FrmClientesAgregar As New FrmABMClientes
        EstadoClientes = "Agregar"
        FrmClientesAgregar.ShowDialog()
        If VbYesNo = True Then
            CP_ListarClientes()
        End If
    End Sub

    Private Sub Btn_EditarClientes_Click(sender As Object, e As EventArgs) Handles Btn_EditarClientes.Click
        If Dgv_Clientes.Rows.Count > 0 Then
            With DatosCliente
                With Dgv_Clientes
                    DatosCliente.ID = CInt(Dgv_Clientes.CurrentRow.Cells(0).Value)
                    DatosCliente.Cliente = CStr(Dgv_Clientes.CurrentRow.Cells(1).Value)
                    DatosCliente.Telefono = CStr(Dgv_Clientes.CurrentRow.Cells(2).Value)
                    DatosCliente.Correo = CStr(Dgv_Clientes.CurrentRow.Cells(3).Value)
                End With
                'paso datos del cliente seleccionado para editar los datos
            End With
            Dim FrmClientesEditar As New FrmABMClientes
            EstadoClientes = "Editar"
            FrmClientesEditar.ShowDialog()
            If VbYesNo = True Then
                CP_ListarClientes()
            End If
        End If
    End Sub

    Private Sub Btn_EliminarClientes_Click(sender As Object, e As EventArgs) Handles Btn_EliminarClientes.Click
        If Dgv_Clientes.Rows.Count > 0 Then
            With DatosCliente
                With Dgv_Clientes
                    DatosCliente.ID = CInt(Dgv_Clientes.CurrentRow.Cells(0).Value)
                    DatosCliente.Cliente = CStr(Dgv_Clientes.CurrentRow.Cells(1).Value)
                    DatosCliente.Telefono = CStr(Dgv_Clientes.CurrentRow.Cells(2).Value)
                    DatosCliente.Correo = CStr(Dgv_Clientes.CurrentRow.Cells(3).Value)
                End With
                'paso datos del cliente seleccionado para Mostrar el cliente a eliminar
            End With
            Dim FrmClientesEliminar As New FrmABMClientes
            EstadoClientes = "Eliminar"
            FrmClientesEliminar.ShowDialog()
            If VbYesNo = True Then
                CP_ListarClientes()
            End If
        End If
    End Sub
#Region "Llamadas a CapaNegocio Clientes"

    Public Sub CP_EncabezadoClientes()
        If Dgv_Clientes.Rows.Count > 0 Then
            Dim ArrayStr(3) As String
            ArrayStr(0) = "ID"
            ArrayStr(1) = "Cliente"
            ArrayStr(2) = "Telefono"
            ArrayStr(3) = "Correo"
            For i = 0 To 3
                With Dgv_Clientes
                    .Columns(i).Name = ArrayStr(i)
                    .Columns(i).HeaderText = ArrayStr(i)
                    If i = 0 Then
                        .Columns(i).Visible = False
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub TxtBuscarClientes_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarClientes.TextChanged
        If TxtBuscarClientes.Text = "" Then
            CP_ListarClientes()
        End If
        If RbNombreCliente.Checked = True And TxtBuscarClientes.Text <> "" Then
            CP_ListarClientesLikeNombre()
        End If
        If RbCorreoCliente.Checked = True And TxtBuscarClientes.Text <> "" Then
            CP_ListarClientesLikeCorreo()
        End If
    End Sub
    Private Sub CP_ListarClientes()
        DtblClientes = CN_ObjClientes.CN_ListarClientes.Tables("Clientes")
        Dgv_Clientes.DataSource = DtblClientes
        CP_EncabezadoClientes()
    End Sub
    Private Sub CP_ListarClientesLikeNombre()
        DtblClientes = CN_ObjClientes.CN_ListarLikeClientes(TxtBuscarClientes.Text, "").Tables("Clientes")
        Dgv_Clientes.DataSource = DtblClientes
        CP_EncabezadoClientes()
    End Sub
    Private Sub CP_ListarClientesLikeCorreo()
        DtblClientes = CN_ObjClientes.CN_ListarLikeClientes("", TxtBuscarClientes.Text).Tables("Clientes")
        Dgv_Clientes.DataSource = DtblClientes
        CP_EncabezadoClientes()
    End Sub
#End Region
End Class