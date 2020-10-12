<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMVentas
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
        Me.Dgv_VentaItems = New System.Windows.Forms.DataGridView()
        Me.PnlABMProductos = New System.Windows.Forms.Panel()
        Me.LblPrecioTotalVenta = New System.Windows.Forms.Label()
        Me.Btn_EliminarProductoVentaItem = New System.Windows.Forms.Button()
        Me.Btn_EditarProductoVentaItem = New System.Windows.Forms.Button()
        Me.Btn_AgregarProductoVentaItem = New System.Windows.Forms.Button()
        Me.LblEncabezadoDetalleVenta = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PnlMenuLateral = New System.Windows.Forms.Panel()
        Me.LblEstadoVentas = New System.Windows.Forms.Label()
        Me.Btn_AceptarVenta = New System.Windows.Forms.Button()
        Me.Btn_CancelarVenta = New System.Windows.Forms.Button()
        Me.PnlDatosVenta = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TxtFechaVenta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlClienteVenta = New System.Windows.Forms.Panel()
        Me.CmbClientesVenta = New System.Windows.Forms.ComboBox()
        Me.LblClientesVenta = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Pnl_Superior = New System.Windows.Forms.Panel()
        Me.LblTituloVentas = New System.Windows.Forms.Label()
        Me.PnlBase = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TxtPrecioProdVenta = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        CType(Me.Dgv_VentaItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlABMProductos.SuspendLayout()
        Me.PnlMenuLateral.SuspendLayout()
        Me.PnlDatosVenta.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.PnlClienteVenta.SuspendLayout()
        Me.Pnl_Superior.SuspendLayout()
        Me.PnlBase.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_VentaItems
        '
        Me.Dgv_VentaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_VentaItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_VentaItems.Location = New System.Drawing.Point(3, 113)
        Me.Dgv_VentaItems.Name = "Dgv_VentaItems"
        Me.Dgv_VentaItems.Size = New System.Drawing.Size(692, 469)
        Me.Dgv_VentaItems.TabIndex = 17
        '
        'PnlABMProductos
        '
        Me.PnlABMProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlABMProductos.Controls.Add(Me.LblEncabezadoDetalleVenta)
        Me.PnlABMProductos.Controls.Add(Me.Btn_AgregarProductoVentaItem)
        Me.PnlABMProductos.Controls.Add(Me.Btn_EditarProductoVentaItem)
        Me.PnlABMProductos.Controls.Add(Me.Btn_EliminarProductoVentaItem)
        Me.PnlABMProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlABMProductos.Location = New System.Drawing.Point(3, 79)
        Me.PnlABMProductos.Name = "PnlABMProductos"
        Me.PnlABMProductos.Size = New System.Drawing.Size(692, 34)
        Me.PnlABMProductos.TabIndex = 18
        '
        'LblPrecioTotalVenta
        '
        Me.LblPrecioTotalVenta.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecioTotalVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblPrecioTotalVenta.Location = New System.Drawing.Point(371, 2)
        Me.LblPrecioTotalVenta.Name = "LblPrecioTotalVenta"
        Me.LblPrecioTotalVenta.Size = New System.Drawing.Size(198, 32)
        Me.LblPrecioTotalVenta.TabIndex = 7
        Me.LblPrecioTotalVenta.Text = "Precio Total de la venta"
        Me.LblPrecioTotalVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_EliminarProductoVentaItem
        '
        Me.Btn_EliminarProductoVentaItem.AutoSize = True
        Me.Btn_EliminarProductoVentaItem.BackColor = System.Drawing.Color.Tomato
        Me.Btn_EliminarProductoVentaItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_EliminarProductoVentaItem.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarProductoVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarProductoVentaItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_EliminarProductoVentaItem.ForeColor = System.Drawing.Color.White
        Me.Btn_EliminarProductoVentaItem.Location = New System.Drawing.Point(618, 0)
        Me.Btn_EliminarProductoVentaItem.Name = "Btn_EliminarProductoVentaItem"
        Me.Btn_EliminarProductoVentaItem.Size = New System.Drawing.Size(72, 32)
        Me.Btn_EliminarProductoVentaItem.TabIndex = 3
        Me.Btn_EliminarProductoVentaItem.Text = "Eliminar"
        Me.Btn_EliminarProductoVentaItem.UseVisualStyleBackColor = False
        '
        'Btn_EditarProductoVentaItem
        '
        Me.Btn_EditarProductoVentaItem.AutoSize = True
        Me.Btn_EditarProductoVentaItem.BackColor = System.Drawing.Color.Orange
        Me.Btn_EditarProductoVentaItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_EditarProductoVentaItem.FlatAppearance.BorderSize = 0
        Me.Btn_EditarProductoVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarProductoVentaItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_EditarProductoVentaItem.ForeColor = System.Drawing.Color.White
        Me.Btn_EditarProductoVentaItem.Location = New System.Drawing.Point(563, 0)
        Me.Btn_EditarProductoVentaItem.Name = "Btn_EditarProductoVentaItem"
        Me.Btn_EditarProductoVentaItem.Size = New System.Drawing.Size(55, 32)
        Me.Btn_EditarProductoVentaItem.TabIndex = 4
        Me.Btn_EditarProductoVentaItem.Text = "Editar"
        Me.Btn_EditarProductoVentaItem.UseVisualStyleBackColor = False
        '
        'Btn_AgregarProductoVentaItem
        '
        Me.Btn_AgregarProductoVentaItem.AutoSize = True
        Me.Btn_AgregarProductoVentaItem.BackColor = System.Drawing.Color.ForestGreen
        Me.Btn_AgregarProductoVentaItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_AgregarProductoVentaItem.FlatAppearance.BorderSize = 0
        Me.Btn_AgregarProductoVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarProductoVentaItem.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_AgregarProductoVentaItem.ForeColor = System.Drawing.Color.White
        Me.Btn_AgregarProductoVentaItem.Location = New System.Drawing.Point(491, 0)
        Me.Btn_AgregarProductoVentaItem.Name = "Btn_AgregarProductoVentaItem"
        Me.Btn_AgregarProductoVentaItem.Size = New System.Drawing.Size(72, 32)
        Me.Btn_AgregarProductoVentaItem.TabIndex = 5
        Me.Btn_AgregarProductoVentaItem.Text = "Agregar"
        Me.Btn_AgregarProductoVentaItem.UseVisualStyleBackColor = False
        '
        'LblEncabezadoDetalleVenta
        '
        Me.LblEncabezadoDetalleVenta.BackColor = System.Drawing.Color.Transparent
        Me.LblEncabezadoDetalleVenta.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblEncabezadoDetalleVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblEncabezadoDetalleVenta.Location = New System.Drawing.Point(384, 0)
        Me.LblEncabezadoDetalleVenta.Name = "LblEncabezadoDetalleVenta"
        Me.LblEncabezadoDetalleVenta.Size = New System.Drawing.Size(107, 32)
        Me.LblEncabezadoDetalleVenta.TabIndex = 0
        Me.LblEncabezadoDetalleVenta.Text = "Productos"
        Me.LblEncabezadoDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(3, 582)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(826, 3)
        Me.Panel8.TabIndex = 20
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(823, 3)
        Me.Panel9.TabIndex = 21
        '
        'PnlMenuLateral
        '
        Me.PnlMenuLateral.BackColor = System.Drawing.Color.Transparent
        Me.PnlMenuLateral.Controls.Add(Me.LblEstadoVentas)
        Me.PnlMenuLateral.Controls.Add(Me.Btn_AceptarVenta)
        Me.PnlMenuLateral.Controls.Add(Me.Btn_CancelarVenta)
        Me.PnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMenuLateral.Location = New System.Drawing.Point(698, 3)
        Me.PnlMenuLateral.Name = "PnlMenuLateral"
        Me.PnlMenuLateral.Size = New System.Drawing.Size(128, 579)
        Me.PnlMenuLateral.TabIndex = 24
        '
        'LblEstadoVentas
        '
        Me.LblEstadoVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblEstadoVentas.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblEstadoVentas.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LblEstadoVentas.Location = New System.Drawing.Point(0, 0)
        Me.LblEstadoVentas.Name = "LblEstadoVentas"
        Me.LblEstadoVentas.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LblEstadoVentas.Size = New System.Drawing.Size(128, 36)
        Me.LblEstadoVentas.TabIndex = 25
        Me.LblEstadoVentas.Text = "Agregar"
        Me.LblEstadoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_AceptarVenta
        '
        Me.Btn_AceptarVenta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_AceptarVenta.FlatAppearance.BorderSize = 0
        Me.Btn_AceptarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Btn_AceptarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AceptarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AceptarVenta.ForeColor = System.Drawing.Color.Black
        Me.Btn_AceptarVenta.Location = New System.Drawing.Point(0, 483)
        Me.Btn_AceptarVenta.Name = "Btn_AceptarVenta"
        Me.Btn_AceptarVenta.Size = New System.Drawing.Size(128, 48)
        Me.Btn_AceptarVenta.TabIndex = 2
        Me.Btn_AceptarVenta.Text = "Aceptar"
        Me.Btn_AceptarVenta.UseVisualStyleBackColor = True
        '
        'Btn_CancelarVenta
        '
        Me.Btn_CancelarVenta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_CancelarVenta.FlatAppearance.BorderSize = 0
        Me.Btn_CancelarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_CancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CancelarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarVenta.ForeColor = System.Drawing.Color.Black
        Me.Btn_CancelarVenta.Location = New System.Drawing.Point(0, 531)
        Me.Btn_CancelarVenta.Name = "Btn_CancelarVenta"
        Me.Btn_CancelarVenta.Size = New System.Drawing.Size(128, 48)
        Me.Btn_CancelarVenta.TabIndex = 3
        Me.Btn_CancelarVenta.Text = "Cancelar"
        Me.Btn_CancelarVenta.UseVisualStyleBackColor = True
        '
        'PnlDatosVenta
        '
        Me.PnlDatosVenta.BackColor = System.Drawing.Color.Transparent
        Me.PnlDatosVenta.Controls.Add(Me.Panel11)
        Me.PnlDatosVenta.Controls.Add(Me.PnlClienteVenta)
        Me.PnlDatosVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlDatosVenta.Location = New System.Drawing.Point(3, 39)
        Me.PnlDatosVenta.Name = "PnlDatosVenta"
        Me.PnlDatosVenta.Size = New System.Drawing.Size(692, 40)
        Me.PnlDatosVenta.TabIndex = 25
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.TxtFechaVenta)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(437, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(255, 40)
        Me.Panel11.TabIndex = 24
        '
        'TxtFechaVenta
        '
        Me.TxtFechaVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtFechaVenta.Location = New System.Drawing.Point(71, 7)
        Me.TxtFechaVenta.Mask = "00/00/0000"
        Me.TxtFechaVenta.Name = "TxtFechaVenta"
        Me.TxtFechaVenta.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TxtFechaVenta.Size = New System.Drawing.Size(165, 26)
        Me.TxtFechaVenta.TabIndex = 2
        Me.TxtFechaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlClienteVenta
        '
        Me.PnlClienteVenta.Controls.Add(Me.CmbClientesVenta)
        Me.PnlClienteVenta.Controls.Add(Me.LblClientesVenta)
        Me.PnlClienteVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlClienteVenta.Location = New System.Drawing.Point(0, 0)
        Me.PnlClienteVenta.Name = "PnlClienteVenta"
        Me.PnlClienteVenta.Size = New System.Drawing.Size(411, 40)
        Me.PnlClienteVenta.TabIndex = 23
        '
        'CmbClientesVenta
        '
        Me.CmbClientesVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.CmbClientesVenta.FormattingEnabled = True
        Me.CmbClientesVenta.Location = New System.Drawing.Point(84, 6)
        Me.CmbClientesVenta.Name = "CmbClientesVenta"
        Me.CmbClientesVenta.Size = New System.Drawing.Size(312, 28)
        Me.CmbClientesVenta.TabIndex = 1
        '
        'LblClientesVenta
        '
        Me.LblClientesVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblClientesVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblClientesVenta.Location = New System.Drawing.Point(0, 0)
        Me.LblClientesVenta.Name = "LblClientesVenta"
        Me.LblClientesVenta.Size = New System.Drawing.Size(78, 40)
        Me.LblClientesVenta.TabIndex = 15
        Me.LblClientesVenta.Text = "Cliente"
        Me.LblClientesVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 585)
        Me.Panel2.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(695, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 579)
        Me.Panel4.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(826, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 582)
        Me.Panel6.TabIndex = 29
        '
        'Panel10
        '
        Me.Panel10.AutoSize = True
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(692, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(0, 36)
        Me.Panel10.TabIndex = 23
        '
        'Pnl_Superior
        '
        Me.Pnl_Superior.Controls.Add(Me.LblTituloVentas)
        Me.Pnl_Superior.Controls.Add(Me.Panel10)
        Me.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Superior.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_Superior.Name = "Pnl_Superior"
        Me.Pnl_Superior.Size = New System.Drawing.Size(692, 36)
        Me.Pnl_Superior.TabIndex = 16
        '
        'LblTituloVentas
        '
        Me.LblTituloVentas.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblTituloVentas.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblTituloVentas.Location = New System.Drawing.Point(0, 0)
        Me.LblTituloVentas.Name = "LblTituloVentas"
        Me.LblTituloVentas.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LblTituloVentas.Size = New System.Drawing.Size(108, 36)
        Me.LblTituloVentas.TabIndex = 24
        Me.LblTituloVentas.Text = "VENTAS"
        Me.LblTituloVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlBase
        '
        Me.PnlBase.Controls.Add(Me.TxtPrecioProdVenta)
        Me.PnlBase.Controls.Add(Me.Panel12)
        Me.PnlBase.Controls.Add(Me.LblPrecioTotalVenta)
        Me.PnlBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBase.Location = New System.Drawing.Point(3, 546)
        Me.PnlBase.Name = "PnlBase"
        Me.PnlBase.Size = New System.Drawing.Size(692, 36)
        Me.PnlBase.TabIndex = 30
        '
        'Panel12
        '
        Me.Panel12.AutoSize = True
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(692, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(0, 36)
        Me.Panel12.TabIndex = 23
        '
        'TxtPrecioProdVenta
        '
        Me.TxtPrecioProdVenta.Enabled = False
        Me.TxtPrecioProdVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtPrecioProdVenta.Location = New System.Drawing.Point(575, 5)
        Me.TxtPrecioProdVenta.Name = "TxtPrecioProdVenta"
        Me.TxtPrecioProdVenta.Size = New System.Drawing.Size(98, 26)
        Me.TxtPrecioProdVenta.TabIndex = 24
        Me.TxtPrecioProdVenta.Text = "0.00"
        Me.TxtPrecioProdVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(3, 543)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(692, 3)
        Me.Panel13.TabIndex = 31
        '
        'FrmABMVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 585)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.PnlBase)
        Me.Controls.Add(Me.Dgv_VentaItems)
        Me.Controls.Add(Me.PnlABMProductos)
        Me.Controls.Add(Me.PnlDatosVenta)
        Me.Controls.Add(Me.Pnl_Superior)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PnlMenuLateral)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmABMVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABM Ventas"
        CType(Me.Dgv_VentaItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlABMProductos.ResumeLayout(False)
        Me.PnlABMProductos.PerformLayout()
        Me.PnlMenuLateral.ResumeLayout(False)
        Me.PnlDatosVenta.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.PnlClienteVenta.ResumeLayout(False)
        Me.Pnl_Superior.ResumeLayout(False)
        Me.Pnl_Superior.PerformLayout()
        Me.PnlBase.ResumeLayout(False)
        Me.PnlBase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_VentaItems As DataGridView
    Friend WithEvents PnlABMProductos As Panel
    Friend WithEvents Btn_AgregarProductoVentaItem As Button
    Friend WithEvents Btn_EditarProductoVentaItem As Button
    Friend WithEvents Btn_EliminarProductoVentaItem As Button
    Friend WithEvents LblEncabezadoDetalleVenta As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PnlMenuLateral As Panel
    Friend WithEvents Btn_AceptarVenta As Button
    Friend WithEvents Btn_CancelarVenta As Button
    Friend WithEvents PnlDatosVenta As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PnlClienteVenta As Panel
    Friend WithEvents CmbClientesVenta As ComboBox
    Friend WithEvents LblClientesVenta As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Pnl_Superior As Panel
    Friend WithEvents LblTituloVentas As Label
    Friend WithEvents LblPrecioTotalVenta As Label
    Friend WithEvents TxtFechaVenta As MaskedTextBox
    Friend WithEvents LblEstadoVentas As Label
    Friend WithEvents PnlBase As Panel
    Friend WithEvents TxtPrecioProdVenta As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
End Class
