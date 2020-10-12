<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Pnl_SalirClientes = New System.Windows.Forms.Panel()
        Me.Pnl_Cerrar = New System.Windows.Forms.Panel()
        Me.Btn_CerrarClientes = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Pnl_ContenedorClientes = New System.Windows.Forms.Panel()
        Me.Dgv_Clientes = New System.Windows.Forms.DataGridView()
        Me.PnlFiltroClientes = New System.Windows.Forms.Panel()
        Me.RbCorreoCliente = New System.Windows.Forms.RadioButton()
        Me.RbNombreCliente = New System.Windows.Forms.RadioButton()
        Me.LblFiltroProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.PnlMenuClientes = New System.Windows.Forms.Panel()
        Me.LblClientes = New System.Windows.Forms.Label()
        Me.PnlSubmenuClientes = New System.Windows.Forms.Panel()
        Me.Btn_EliminarClientes = New System.Windows.Forms.Button()
        Me.Btn_EditarClientes = New System.Windows.Forms.Button()
        Me.Btn_AgregarClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Pnl_SalirClientes.SuspendLayout()
        Me.Pnl_Cerrar.SuspendLayout()
        Me.Pnl_ContenedorClientes.SuspendLayout()
        CType(Me.Dgv_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFiltroClientes.SuspendLayout()
        Me.PnlMenuClientes.SuspendLayout()
        Me.PnlSubmenuClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_SalirClientes
        '
        Me.Pnl_SalirClientes.BackColor = System.Drawing.Color.White
        Me.Pnl_SalirClientes.Controls.Add(Me.Pnl_Cerrar)
        Me.Pnl_SalirClientes.Controls.Add(Me.Panel4)
        Me.Pnl_SalirClientes.Controls.Add(Me.Panel5)
        Me.Pnl_SalirClientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_SalirClientes.Location = New System.Drawing.Point(0, 5)
        Me.Pnl_SalirClientes.Name = "Pnl_SalirClientes"
        Me.Pnl_SalirClientes.Size = New System.Drawing.Size(80, 555)
        Me.Pnl_SalirClientes.TabIndex = 1
        '
        'Pnl_Cerrar
        '
        Me.Pnl_Cerrar.Controls.Add(Me.Btn_CerrarClientes)
        Me.Pnl_Cerrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Cerrar.Location = New System.Drawing.Point(5, 0)
        Me.Pnl_Cerrar.Name = "Pnl_Cerrar"
        Me.Pnl_Cerrar.Size = New System.Drawing.Size(70, 49)
        Me.Pnl_Cerrar.TabIndex = 2
        '
        'Btn_CerrarClientes
        '
        Me.Btn_CerrarClientes.BackColor = System.Drawing.Color.Transparent
        Me.Btn_CerrarClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_CerrarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_CerrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CerrarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Btn_CerrarClientes.Location = New System.Drawing.Point(0, 0)
        Me.Btn_CerrarClientes.Name = "Btn_CerrarClientes"
        Me.Btn_CerrarClientes.Size = New System.Drawing.Size(70, 49)
        Me.Btn_CerrarClientes.TabIndex = 0
        Me.Btn_CerrarClientes.Text = "Cerrar"
        Me.Btn_CerrarClientes.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 555)
        Me.Panel4.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(75, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 555)
        Me.Panel5.TabIndex = 10
        '
        'Pnl_ContenedorClientes
        '
        Me.Pnl_ContenedorClientes.Controls.Add(Me.Dgv_Clientes)
        Me.Pnl_ContenedorClientes.Controls.Add(Me.PnlFiltroClientes)
        Me.Pnl_ContenedorClientes.Controls.Add(Me.PnlMenuClientes)
        Me.Pnl_ContenedorClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_ContenedorClientes.Location = New System.Drawing.Point(80, 5)
        Me.Pnl_ContenedorClientes.Name = "Pnl_ContenedorClientes"
        Me.Pnl_ContenedorClientes.Size = New System.Drawing.Size(709, 555)
        Me.Pnl_ContenedorClientes.TabIndex = 1
        '
        'Dgv_Clientes
        '
        Me.Dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Clientes.Location = New System.Drawing.Point(0, 33)
        Me.Dgv_Clientes.Name = "Dgv_Clientes"
        Me.Dgv_Clientes.Size = New System.Drawing.Size(537, 522)
        Me.Dgv_Clientes.TabIndex = 2
        '
        'PnlFiltroClientes
        '
        Me.PnlFiltroClientes.BackColor = System.Drawing.Color.White
        Me.PnlFiltroClientes.Controls.Add(Me.RbCorreoCliente)
        Me.PnlFiltroClientes.Controls.Add(Me.RbNombreCliente)
        Me.PnlFiltroClientes.Controls.Add(Me.LblFiltroProducto)
        Me.PnlFiltroClientes.Controls.Add(Me.TxtBuscarClientes)
        Me.PnlFiltroClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFiltroClientes.Location = New System.Drawing.Point(0, 0)
        Me.PnlFiltroClientes.Name = "PnlFiltroClientes"
        Me.PnlFiltroClientes.Size = New System.Drawing.Size(537, 33)
        Me.PnlFiltroClientes.TabIndex = 9
        '
        'RbCorreoCliente
        '
        Me.RbCorreoCliente.AutoSize = True
        Me.RbCorreoCliente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbCorreoCliente.Location = New System.Drawing.Point(192, 3)
        Me.RbCorreoCliente.Name = "RbCorreoCliente"
        Me.RbCorreoCliente.Size = New System.Drawing.Size(79, 24)
        Me.RbCorreoCliente.TabIndex = 13
        Me.RbCorreoCliente.Text = "Correo"
        Me.RbCorreoCliente.UseVisualStyleBackColor = True
        '
        'RbNombreCliente
        '
        Me.RbNombreCliente.AutoSize = True
        Me.RbNombreCliente.Checked = True
        Me.RbNombreCliente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbNombreCliente.Location = New System.Drawing.Point(102, 3)
        Me.RbNombreCliente.Name = "RbNombreCliente"
        Me.RbNombreCliente.Size = New System.Drawing.Size(86, 24)
        Me.RbNombreCliente.TabIndex = 13
        Me.RbNombreCliente.TabStop = True
        Me.RbNombreCliente.Text = "Nombre"
        Me.RbNombreCliente.UseVisualStyleBackColor = True
        '
        'LblFiltroProducto
        '
        Me.LblFiltroProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblFiltroProducto.Location = New System.Drawing.Point(8, 2)
        Me.LblFiltroProducto.Name = "LblFiltroProducto"
        Me.LblFiltroProducto.Size = New System.Drawing.Size(88, 26)
        Me.LblFiltroProducto.TabIndex = 12
        Me.LblFiltroProducto.Text = "Filtrar por:"
        Me.LblFiltroProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBuscarClientes
        '
        Me.TxtBuscarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtBuscarClientes.Location = New System.Drawing.Point(277, 4)
        Me.TxtBuscarClientes.Name = "TxtBuscarClientes"
        Me.TxtBuscarClientes.Size = New System.Drawing.Size(254, 26)
        Me.TxtBuscarClientes.TabIndex = 0
        '
        'PnlMenuClientes
        '
        Me.PnlMenuClientes.BackColor = System.Drawing.Color.White
        Me.PnlMenuClientes.Controls.Add(Me.LblClientes)
        Me.PnlMenuClientes.Controls.Add(Me.PnlSubmenuClientes)
        Me.PnlMenuClientes.Controls.Add(Me.Panel2)
        Me.PnlMenuClientes.Controls.Add(Me.Panel1)
        Me.PnlMenuClientes.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMenuClientes.Location = New System.Drawing.Point(537, 0)
        Me.PnlMenuClientes.Name = "PnlMenuClientes"
        Me.PnlMenuClientes.Size = New System.Drawing.Size(172, 555)
        Me.PnlMenuClientes.TabIndex = 7
        '
        'LblClientes
        '
        Me.LblClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblClientes.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblClientes.Location = New System.Drawing.Point(5, 0)
        Me.LblClientes.Name = "LblClientes"
        Me.LblClientes.Size = New System.Drawing.Size(162, 49)
        Me.LblClientes.TabIndex = 12
        Me.LblClientes.Text = "CLIENTES"
        Me.LblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubmenuClientes
        '
        Me.PnlSubmenuClientes.BackColor = System.Drawing.Color.Transparent
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_EliminarClientes)
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_EditarClientes)
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_AgregarClientes)
        Me.PnlSubmenuClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlSubmenuClientes.Location = New System.Drawing.Point(5, 409)
        Me.PnlSubmenuClientes.Name = "PnlSubmenuClientes"
        Me.PnlSubmenuClientes.Size = New System.Drawing.Size(162, 146)
        Me.PnlSubmenuClientes.TabIndex = 7
        '
        'Btn_EliminarClientes
        '
        Me.Btn_EliminarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_EliminarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarClientes.ForeColor = System.Drawing.Color.Black
        Me.Btn_EliminarClientes.Location = New System.Drawing.Point(0, 94)
        Me.Btn_EliminarClientes.Name = "Btn_EliminarClientes"
        Me.Btn_EliminarClientes.Size = New System.Drawing.Size(162, 47)
        Me.Btn_EliminarClientes.TabIndex = 4
        Me.Btn_EliminarClientes.Text = "Eliminar Cliente"
        Me.Btn_EliminarClientes.UseVisualStyleBackColor = True
        '
        'Btn_EditarClientes
        '
        Me.Btn_EditarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_EditarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_EditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EditarClientes.ForeColor = System.Drawing.Color.Black
        Me.Btn_EditarClientes.Location = New System.Drawing.Point(0, 47)
        Me.Btn_EditarClientes.Name = "Btn_EditarClientes"
        Me.Btn_EditarClientes.Size = New System.Drawing.Size(162, 47)
        Me.Btn_EditarClientes.TabIndex = 3
        Me.Btn_EditarClientes.Text = "Editar Cliente"
        Me.Btn_EditarClientes.UseVisualStyleBackColor = True
        '
        'Btn_AgregarClientes
        '
        Me.Btn_AgregarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_AgregarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_AgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarClientes.ForeColor = System.Drawing.Color.Black
        Me.Btn_AgregarClientes.Location = New System.Drawing.Point(0, 0)
        Me.Btn_AgregarClientes.Name = "Btn_AgregarClientes"
        Me.Btn_AgregarClientes.Size = New System.Drawing.Size(162, 47)
        Me.Btn_AgregarClientes.TabIndex = 2
        Me.Btn_AgregarClientes.Text = "Agregar Cliente"
        Me.Btn_AgregarClientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 555)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(167, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 555)
        Me.Panel1.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 560)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(789, 5)
        Me.Panel6.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(789, 5)
        Me.Panel3.TabIndex = 11
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 565)
        Me.Controls.Add(Me.Pnl_ContenedorClientes)
        Me.Controls.Add(Me.Pnl_SalirClientes)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClientes"
        Me.Text = "Formulario de Clientes"
        Me.Pnl_SalirClientes.ResumeLayout(False)
        Me.Pnl_Cerrar.ResumeLayout(False)
        Me.Pnl_ContenedorClientes.ResumeLayout(False)
        CType(Me.Dgv_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFiltroClientes.ResumeLayout(False)
        Me.PnlFiltroClientes.PerformLayout()
        Me.PnlMenuClientes.ResumeLayout(False)
        Me.PnlSubmenuClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_SalirClientes As Panel
    Friend WithEvents Pnl_ContenedorClientes As Panel
    Friend WithEvents Dgv_Clientes As DataGridView
    Friend WithEvents Pnl_Cerrar As Panel
    Friend WithEvents Btn_CerrarClientes As Button
    Friend WithEvents PnlMenuClientes As Panel
    Friend WithEvents PnlSubmenuClientes As Panel
    Friend WithEvents Btn_EliminarClientes As Button
    Friend WithEvents Btn_EditarClientes As Button
    Friend WithEvents Btn_AgregarClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblClientes As Label
    Friend WithEvents PnlFiltroClientes As Panel
    Friend WithEvents RbCorreoCliente As RadioButton
    Friend WithEvents RbNombreCliente As RadioButton
    Friend WithEvents LblFiltroProducto As Label
    Friend WithEvents TxtBuscarClientes As TextBox
End Class
