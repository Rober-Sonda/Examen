<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionVentasItems
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PnlMenuArticulos = New System.Windows.Forms.Panel()
        Me.LblProductos = New System.Windows.Forms.Label()
        Me.PnlSubmenuProductos = New System.Windows.Forms.Panel()
        Me.Btn_AceptarProducto = New System.Windows.Forms.Button()
        Me.Btn_CancelarProducto = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Dgv_ListadoProductosVenta = New System.Windows.Forms.DataGridView()
        Me.PnlFiltroProductos = New System.Windows.Forms.Panel()
        Me.RbCategoriaProducto = New System.Windows.Forms.RadioButton()
        Me.RbIDProducto = New System.Windows.Forms.RadioButton()
        Me.RbNombreProducto = New System.Windows.Forms.RadioButton()
        Me.LblFiltroProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PnlMenuArticulos.SuspendLayout()
        Me.PnlSubmenuProductos.SuspendLayout()
        CType(Me.Dgv_ListadoProductosVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFiltroProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMenuArticulos
        '
        Me.PnlMenuArticulos.BackColor = System.Drawing.Color.White
        Me.PnlMenuArticulos.Controls.Add(Me.LblProductos)
        Me.PnlMenuArticulos.Controls.Add(Me.PnlSubmenuProductos)
        Me.PnlMenuArticulos.Controls.Add(Me.Panel5)
        Me.PnlMenuArticulos.Controls.Add(Me.Panel6)
        Me.PnlMenuArticulos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMenuArticulos.Location = New System.Drawing.Point(628, 3)
        Me.PnlMenuArticulos.Name = "PnlMenuArticulos"
        Me.PnlMenuArticulos.Size = New System.Drawing.Size(172, 444)
        Me.PnlMenuArticulos.TabIndex = 5
        '
        'LblProductos
        '
        Me.LblProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblProductos.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblProductos.Location = New System.Drawing.Point(3, 0)
        Me.LblProductos.Name = "LblProductos"
        Me.LblProductos.Size = New System.Drawing.Size(166, 73)
        Me.LblProductos.TabIndex = 11
        Me.LblProductos.Text = "Seleccionar producto"
        Me.LblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubmenuProductos
        '
        Me.PnlSubmenuProductos.AutoSize = True
        Me.PnlSubmenuProductos.BackColor = System.Drawing.Color.Transparent
        Me.PnlSubmenuProductos.Controls.Add(Me.Btn_AceptarProducto)
        Me.PnlSubmenuProductos.Controls.Add(Me.Btn_CancelarProducto)
        Me.PnlSubmenuProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlSubmenuProductos.Location = New System.Drawing.Point(3, 348)
        Me.PnlSubmenuProductos.Name = "PnlSubmenuProductos"
        Me.PnlSubmenuProductos.Size = New System.Drawing.Size(166, 96)
        Me.PnlSubmenuProductos.TabIndex = 4
        '
        'Btn_AceptarProducto
        '
        Me.Btn_AceptarProducto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_AceptarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_AceptarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Btn_AceptarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AceptarProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AceptarProducto.ForeColor = System.Drawing.Color.Black
        Me.Btn_AceptarProducto.Location = New System.Drawing.Point(0, 0)
        Me.Btn_AceptarProducto.Name = "Btn_AceptarProducto"
        Me.Btn_AceptarProducto.Size = New System.Drawing.Size(166, 48)
        Me.Btn_AceptarProducto.TabIndex = 4
        Me.Btn_AceptarProducto.Text = "Aceptar"
        Me.Btn_AceptarProducto.UseVisualStyleBackColor = True
        '
        'Btn_CancelarProducto
        '
        Me.Btn_CancelarProducto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_CancelarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_CancelarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_CancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CancelarProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarProducto.ForeColor = System.Drawing.Color.Black
        Me.Btn_CancelarProducto.Location = New System.Drawing.Point(0, 48)
        Me.Btn_CancelarProducto.Name = "Btn_CancelarProducto"
        Me.Btn_CancelarProducto.Size = New System.Drawing.Size(166, 48)
        Me.Btn_CancelarProducto.TabIndex = 5
        Me.Btn_CancelarProducto.Text = "Cancelar"
        Me.Btn_CancelarProducto.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(169, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(3, 444)
        Me.Panel5.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 444)
        Me.Panel6.TabIndex = 9
        '
        'Dgv_ListadoProductosVenta
        '
        Me.Dgv_ListadoProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListadoProductosVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_ListadoProductosVenta.Location = New System.Drawing.Point(3, 36)
        Me.Dgv_ListadoProductosVenta.Name = "Dgv_ListadoProductosVenta"
        Me.Dgv_ListadoProductosVenta.Size = New System.Drawing.Size(625, 411)
        Me.Dgv_ListadoProductosVenta.TabIndex = 6
        '
        'PnlFiltroProductos
        '
        Me.PnlFiltroProductos.BackColor = System.Drawing.Color.White
        Me.PnlFiltroProductos.Controls.Add(Me.RbCategoriaProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.RbIDProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.RbNombreProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.LblFiltroProducto)
        Me.PnlFiltroProductos.Controls.Add(Me.TxtBuscarProductos)
        Me.PnlFiltroProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFiltroProductos.Location = New System.Drawing.Point(3, 3)
        Me.PnlFiltroProductos.Name = "PnlFiltroProductos"
        Me.PnlFiltroProductos.Size = New System.Drawing.Size(625, 33)
        Me.PnlFiltroProductos.TabIndex = 9
        '
        'RbCategoriaProducto
        '
        Me.RbCategoriaProducto.AutoSize = True
        Me.RbCategoriaProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbCategoriaProducto.Location = New System.Drawing.Point(243, 3)
        Me.RbCategoriaProducto.Name = "RbCategoriaProducto"
        Me.RbCategoriaProducto.Size = New System.Drawing.Size(102, 24)
        Me.RbCategoriaProducto.TabIndex = 13
        Me.RbCategoriaProducto.TabStop = True
        Me.RbCategoriaProducto.Text = "Categoria"
        Me.RbCategoriaProducto.UseVisualStyleBackColor = True
        '
        'RbIDProducto
        '
        Me.RbIDProducto.AutoSize = True
        Me.RbIDProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbIDProducto.Location = New System.Drawing.Point(102, 3)
        Me.RbIDProducto.Name = "RbIDProducto"
        Me.RbIDProducto.Size = New System.Drawing.Size(43, 24)
        Me.RbIDProducto.TabIndex = 13
        Me.RbIDProducto.TabStop = True
        Me.RbIDProducto.Text = "ID"
        Me.RbIDProducto.UseVisualStyleBackColor = True
        '
        'RbNombreProducto
        '
        Me.RbNombreProducto.AutoSize = True
        Me.RbNombreProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbNombreProducto.Location = New System.Drawing.Point(151, 3)
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
        Me.TxtBuscarProductos.Location = New System.Drawing.Point(351, 3)
        Me.TxtBuscarProductos.Name = "TxtBuscarProductos"
        Me.TxtBuscarProductos.Size = New System.Drawing.Size(271, 26)
        Me.TxtBuscarProductos.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 444)
        Me.Panel2.TabIndex = 27
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(800, 3)
        Me.Panel9.TabIndex = 28
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 447)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(800, 3)
        Me.Panel8.TabIndex = 29
        '
        'FrmSeleccionVentasItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dgv_ListadoProductosVenta)
        Me.Controls.Add(Me.PnlFiltroProductos)
        Me.Controls.Add(Me.PnlMenuArticulos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSeleccionVentasItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmProductoDetalleVenta"
        Me.PnlMenuArticulos.ResumeLayout(False)
        Me.PnlMenuArticulos.PerformLayout()
        Me.PnlSubmenuProductos.ResumeLayout(False)
        CType(Me.Dgv_ListadoProductosVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFiltroProductos.ResumeLayout(False)
        Me.PnlFiltroProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMenuArticulos As Panel
    Friend WithEvents LblProductos As Label
    Friend WithEvents PnlSubmenuProductos As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_AceptarProducto As Button
    Friend WithEvents Btn_CancelarProducto As Button
    Friend WithEvents Dgv_ListadoProductosVenta As DataGridView
    Friend WithEvents PnlFiltroProductos As Panel
    Friend WithEvents RbCategoriaProducto As RadioButton
    Friend WithEvents RbNombreProducto As RadioButton
    Friend WithEvents LblFiltroProducto As Label
    Friend WithEvents TxtBuscarProductos As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents RbIDProducto As RadioButton
End Class
