<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductos
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
        Me.Pnl_ContenedorArticulos = New System.Windows.Forms.Panel()
        Me.Dgv_Productos = New System.Windows.Forms.DataGridView()
        Me.PnlFiltroProductos = New System.Windows.Forms.Panel()
        Me.RbCategoriaProducto = New System.Windows.Forms.RadioButton()
        Me.RbNombreProducto = New System.Windows.Forms.RadioButton()
        Me.LblFiltroProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.PnlMenuArticulos = New System.Windows.Forms.Panel()
        Me.LblProductos = New System.Windows.Forms.Label()
        Me.PnlSubmenuProductos = New System.Windows.Forms.Panel()
        Me.Btn_EliminarProducto = New System.Windows.Forms.Button()
        Me.Btn_EditarProducto = New System.Windows.Forms.Button()
        Me.Btn_AgregarProducto = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Pnl_SalirArticulos = New System.Windows.Forms.Panel()
        Me.Pnl_Cerrar = New System.Windows.Forms.Panel()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Pnl_ContenedorArticulos.SuspendLayout()
        CType(Me.Dgv_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFiltroProductos.SuspendLayout()
        Me.PnlMenuArticulos.SuspendLayout()
        Me.PnlSubmenuProductos.SuspendLayout()
        Me.Pnl_SalirArticulos.SuspendLayout()
        Me.Pnl_Cerrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_ContenedorArticulos
        '
        Me.Pnl_ContenedorArticulos.Controls.Add(Me.Dgv_Productos)
        Me.Pnl_ContenedorArticulos.Controls.Add(Me.PnlFiltroProductos)
        Me.Pnl_ContenedorArticulos.Controls.Add(Me.PnlMenuArticulos)
        Me.Pnl_ContenedorArticulos.Controls.Add(Me.Pnl_SalirArticulos)
        Me.Pnl_ContenedorArticulos.Controls.Add(Me.Panel1)
        Me.Pnl_ContenedorArticulos.Controls.Add(Me.Panel4)
        Me.Pnl_ContenedorArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_ContenedorArticulos.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_ContenedorArticulos.Name = "Pnl_ContenedorArticulos"
        Me.Pnl_ContenedorArticulos.Size = New System.Drawing.Size(884, 583)
        Me.Pnl_ContenedorArticulos.TabIndex = 2
        '
        'Dgv_Productos
        '
        Me.Dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Productos.Location = New System.Drawing.Point(80, 38)
        Me.Dgv_Productos.Name = "Dgv_Productos"
        Me.Dgv_Productos.Size = New System.Drawing.Size(632, 540)
        Me.Dgv_Productos.TabIndex = 2
        '
        'PnlFiltroProductos
        '
        Me.PnlFiltroProductos.BackColor = System.Drawing.Color.White
        Me.PnlFiltroProductos.Controls.Add(Me.RbCategoriaProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.RbNombreProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.LblFiltroProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.TxtBuscarProductos)
        Me.PnlFiltroProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFiltroProductos.Location = New System.Drawing.Point(80, 5)
        Me.PnlFiltroProductos.Name = "PnlFiltroProductos"
        Me.PnlFiltroProductos.Size = New System.Drawing.Size(632, 33)
        Me.PnlFiltroProductos.TabIndex = 8
        '
        'RbCategoriaProducto
        '
        Me.RbCategoriaProducto.AutoSize = True
        Me.RbCategoriaProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbCategoriaProducto.Location = New System.Drawing.Point(192, 3)
        Me.RbCategoriaProducto.Name = "RbCategoriaProducto"
        Me.RbCategoriaProducto.Size = New System.Drawing.Size(102, 24)
        Me.RbCategoriaProducto.TabIndex = 13
        Me.RbCategoriaProducto.Text = "Categoria"
        Me.RbCategoriaProducto.UseVisualStyleBackColor = True
        '
        'RbNombreProducto
        '
        Me.RbNombreProducto.AutoSize = True
        Me.RbNombreProducto.Checked = True
        Me.RbNombreProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbNombreProducto.Location = New System.Drawing.Point(102, 3)
        Me.RbNombreProducto.Name = "RbNombreProducto"
        Me.RbNombreProducto.Size = New System.Drawing.Size(86, 24)
        Me.RbNombreProducto.TabIndex = 13
        Me.RbNombreProducto.TabStop = True
        Me.RbNombreProducto.Text = "Nombre"
        Me.RbNombreProducto.UseVisualStyleBackColor = True
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
        'TxtBuscarProductos
        '
        Me.TxtBuscarProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtBuscarProductos.Location = New System.Drawing.Point(320, 4)
        Me.TxtBuscarProductos.Name = "TxtBuscarProductos"
        Me.TxtBuscarProductos.Size = New System.Drawing.Size(309, 26)
        Me.TxtBuscarProductos.TabIndex = 0
        '
        'PnlMenuArticulos
        '
        Me.PnlMenuArticulos.BackColor = System.Drawing.Color.White
        Me.PnlMenuArticulos.Controls.Add(Me.LblProductos)
        Me.PnlMenuArticulos.Controls.Add(Me.PnlSubmenuProductos)
        Me.PnlMenuArticulos.Controls.Add(Me.Panel5)
        Me.PnlMenuArticulos.Controls.Add(Me.Panel6)
        Me.PnlMenuArticulos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMenuArticulos.Location = New System.Drawing.Point(712, 5)
        Me.PnlMenuArticulos.Name = "PnlMenuArticulos"
        Me.PnlMenuArticulos.Size = New System.Drawing.Size(172, 573)
        Me.PnlMenuArticulos.TabIndex = 4
        '
        'LblProductos
        '
        Me.LblProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblProductos.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblProductos.Location = New System.Drawing.Point(5, 0)
        Me.LblProductos.Name = "LblProductos"
        Me.LblProductos.Size = New System.Drawing.Size(162, 33)
        Me.LblProductos.TabIndex = 11
        Me.LblProductos.Text = "PRODUCTOS"
        Me.LblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubmenuProductos
        '
        Me.PnlSubmenuProductos.BackColor = System.Drawing.Color.Transparent
        Me.PnlSubmenuProductos.Controls.Add(Me.Btn_EliminarProducto)
        Me.PnlSubmenuProductos.Controls.Add(Me.Btn_EditarProducto)
        Me.PnlSubmenuProductos.Controls.Add(Me.Btn_AgregarProducto)
        Me.PnlSubmenuProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlSubmenuProductos.Location = New System.Drawing.Point(5, 427)
        Me.PnlSubmenuProductos.Name = "PnlSubmenuProductos"
        Me.PnlSubmenuProductos.Size = New System.Drawing.Size(162, 146)
        Me.PnlSubmenuProductos.TabIndex = 4
        '
        'Btn_EliminarProducto
        '
        Me.Btn_EliminarProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_EliminarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarProducto.ForeColor = System.Drawing.Color.Black
        Me.Btn_EliminarProducto.Location = New System.Drawing.Point(0, 94)
        Me.Btn_EliminarProducto.Name = "Btn_EliminarProducto"
        Me.Btn_EliminarProducto.Size = New System.Drawing.Size(162, 47)
        Me.Btn_EliminarProducto.TabIndex = 4
        Me.Btn_EliminarProducto.Text = "Eliminar producto"
        Me.Btn_EliminarProducto.UseVisualStyleBackColor = True
        '
        'Btn_EditarProducto
        '
        Me.Btn_EditarProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_EditarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_EditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EditarProducto.ForeColor = System.Drawing.Color.Black
        Me.Btn_EditarProducto.Location = New System.Drawing.Point(0, 47)
        Me.Btn_EditarProducto.Name = "Btn_EditarProducto"
        Me.Btn_EditarProducto.Size = New System.Drawing.Size(162, 47)
        Me.Btn_EditarProducto.TabIndex = 3
        Me.Btn_EditarProducto.Text = "Editar producto"
        Me.Btn_EditarProducto.UseVisualStyleBackColor = True
        '
        'Btn_AgregarProducto
        '
        Me.Btn_AgregarProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_AgregarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarProducto.ForeColor = System.Drawing.Color.Black
        Me.Btn_AgregarProducto.Location = New System.Drawing.Point(0, 0)
        Me.Btn_AgregarProducto.Name = "Btn_AgregarProducto"
        Me.Btn_AgregarProducto.Size = New System.Drawing.Size(162, 47)
        Me.Btn_AgregarProducto.TabIndex = 2
        Me.Btn_AgregarProducto.Text = "Agregar producto"
        Me.Btn_AgregarProducto.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(167, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 573)
        Me.Panel5.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 573)
        Me.Panel6.TabIndex = 9
        '
        'Pnl_SalirArticulos
        '
        Me.Pnl_SalirArticulos.BackColor = System.Drawing.Color.White
        Me.Pnl_SalirArticulos.Controls.Add(Me.Pnl_Cerrar)
        Me.Pnl_SalirArticulos.Controls.Add(Me.Panel2)
        Me.Pnl_SalirArticulos.Controls.Add(Me.Panel3)
        Me.Pnl_SalirArticulos.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_SalirArticulos.Location = New System.Drawing.Point(0, 5)
        Me.Pnl_SalirArticulos.Name = "Pnl_SalirArticulos"
        Me.Pnl_SalirArticulos.Size = New System.Drawing.Size(80, 573)
        Me.Pnl_SalirArticulos.TabIndex = 3
        '
        'Pnl_Cerrar
        '
        Me.Pnl_Cerrar.Controls.Add(Me.Btn_Cerrar)
        Me.Pnl_Cerrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Cerrar.Location = New System.Drawing.Point(5, 0)
        Me.Pnl_Cerrar.Name = "Pnl_Cerrar"
        Me.Pnl_Cerrar.Size = New System.Drawing.Size(70, 49)
        Me.Pnl_Cerrar.TabIndex = 1
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Btn_Cerrar.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(70, 49)
        Me.Btn_Cerrar.TabIndex = 0
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 573)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(75, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 573)
        Me.Panel3.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 5)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 578)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(884, 5)
        Me.Panel4.TabIndex = 7
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 583)
        Me.Controls.Add(Me.Pnl_ContenedorArticulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductos"
        Me.Text = "FrmArticulos"
        Me.Pnl_ContenedorArticulos.ResumeLayout(False)
        CType(Me.Dgv_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFiltroProductos.ResumeLayout(False)
        Me.PnlFiltroProductos.PerformLayout()
        Me.PnlMenuArticulos.ResumeLayout(False)
        Me.PnlSubmenuProductos.ResumeLayout(False)
        Me.Pnl_SalirArticulos.ResumeLayout(False)
        Me.Pnl_Cerrar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_ContenedorArticulos As Panel
    Friend WithEvents Dgv_Productos As DataGridView
    Friend WithEvents Pnl_SalirArticulos As Panel
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents PnlMenuArticulos As Panel
    Friend WithEvents PnlSubmenuProductos As Panel
    Friend WithEvents Btn_EliminarProducto As Button
    Friend WithEvents Btn_EditarProducto As Button
    Friend WithEvents Btn_AgregarProducto As Button
    Friend WithEvents Pnl_Cerrar As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblProductos As Label
    Friend WithEvents PnlFiltroProductos As Panel
    Friend WithEvents RbCategoriaProducto As RadioButton
    Friend WithEvents RbNombreProducto As RadioButton
    Friend WithEvents LblFiltroProducto As Label
    Friend WithEvents TxtBuscarProductos As TextBox
End Class
