<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.components = New System.ComponentModel.Container()
        Me.Pnl_ContenedorVentas = New System.Windows.Forms.Panel()
        Me.Dgv_VentasItems = New System.Windows.Forms.DataGridView()
        Me.Pnl_Divisor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_Ventas = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PnlFiltroVentas = New System.Windows.Forms.Panel()
        Me.TxtFechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.RbEntreFechasVenta = New System.Windows.Forms.RadioButton()
        Me.TxtFechaIni = New System.Windows.Forms.MaskedTextBox()
        Me.RbClienteVenta = New System.Windows.Forms.RadioButton()
        Me.RbIDVenta = New System.Windows.Forms.RadioButton()
        Me.LblFiltroVentas = New System.Windows.Forms.Label()
        Me.TxtBuscarVenta = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblMensajeGuia = New System.Windows.Forms.Label()
        Me.LblVentas = New System.Windows.Forms.Label()
        Me.PnlSubmenuVentas = New System.Windows.Forms.Panel()
        Me.Btn_EliminarVenta = New System.Windows.Forms.Button()
        Me.Btn_EditarVenta = New System.Windows.Forms.Button()
        Me.Btn_AgregarVenta = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Pnl_SalirVentas = New System.Windows.Forms.Panel()
        Me.Pnl_Cerrar = New System.Windows.Forms.Panel()
        Me.Btn_CerrarVenta = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pnl_ContenedorVentas.SuspendLayout()
        CType(Me.Dgv_VentasItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Divisor.SuspendLayout()
        CType(Me.Dgv_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFiltroVentas.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PnlSubmenuVentas.SuspendLayout()
        Me.Pnl_SalirVentas.SuspendLayout()
        Me.Pnl_Cerrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_ContenedorVentas
        '
        Me.Pnl_ContenedorVentas.Controls.Add(Me.Dgv_VentasItems)
        Me.Pnl_ContenedorVentas.Controls.Add(Me.Pnl_Divisor)
        Me.Pnl_ContenedorVentas.Controls.Add(Me.Dgv_Ventas)
        Me.Pnl_ContenedorVentas.Controls.Add(Me.Panel2)
        Me.Pnl_ContenedorVentas.Controls.Add(Me.PnlFiltroVentas)
        Me.Pnl_ContenedorVentas.Controls.Add(Me.Panel4)
        Me.Pnl_ContenedorVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_ContenedorVentas.Location = New System.Drawing.Point(80, 5)
        Me.Pnl_ContenedorVentas.Name = "Pnl_ContenedorVentas"
        Me.Pnl_ContenedorVentas.Size = New System.Drawing.Size(870, 625)
        Me.Pnl_ContenedorVentas.TabIndex = 3
        '
        'Dgv_VentasItems
        '
        Me.Dgv_VentasItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_VentasItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_VentasItems.Location = New System.Drawing.Point(0, 324)
        Me.Dgv_VentasItems.Name = "Dgv_VentasItems"
        Me.Dgv_VentasItems.Size = New System.Drawing.Size(693, 301)
        Me.Dgv_VentasItems.TabIndex = 4
        '
        'Pnl_Divisor
        '
        Me.Pnl_Divisor.Controls.Add(Me.Label1)
        Me.Pnl_Divisor.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Divisor.Location = New System.Drawing.Point(0, 304)
        Me.Pnl_Divisor.Name = "Pnl_Divisor"
        Me.Pnl_Divisor.Size = New System.Drawing.Size(693, 20)
        Me.Pnl_Divisor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgv_Ventas
        '
        Me.Dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dgv_Ventas.Location = New System.Drawing.Point(0, 33)
        Me.Dgv_Ventas.Name = "Dgv_Ventas"
        Me.Dgv_Ventas.Size = New System.Drawing.Size(693, 271)
        Me.Dgv_Ventas.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(693, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 592)
        Me.Panel2.TabIndex = 6
        '
        'PnlFiltroVentas
        '
        Me.PnlFiltroVentas.BackColor = System.Drawing.Color.White
        Me.PnlFiltroVentas.Controls.Add(Me.TxtFechaFin)
        Me.PnlFiltroVentas.Controls.Add(Me.RbEntreFechasVenta)
        Me.PnlFiltroVentas.Controls.Add(Me.TxtFechaIni)
        Me.PnlFiltroVentas.Controls.Add(Me.RbClienteVenta)
        Me.PnlFiltroVentas.Controls.Add(Me.RbIDVenta)
        Me.PnlFiltroVentas.Controls.Add(Me.LblFiltroVentas)
        Me.PnlFiltroVentas.Controls.Add(Me.TxtBuscarVenta)
        Me.PnlFiltroVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFiltroVentas.Location = New System.Drawing.Point(0, 0)
        Me.PnlFiltroVentas.Name = "PnlFiltroVentas"
        Me.PnlFiltroVentas.Size = New System.Drawing.Size(698, 33)
        Me.PnlFiltroVentas.TabIndex = 9
        '
        'TxtFechaFin
        '
        Me.TxtFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtFechaFin.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TxtFechaFin.Location = New System.Drawing.Point(596, 4)
        Me.TxtFechaFin.Mask = "00/00/0000"
        Me.TxtFechaFin.Name = "TxtFechaFin"
        Me.TxtFechaFin.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TxtFechaFin.Size = New System.Drawing.Size(96, 24)
        Me.TxtFechaFin.TabIndex = 12
        Me.TxtFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtFechaFin.Visible = False
        '
        'RbEntreFechasVenta
        '
        Me.RbEntreFechasVenta.AutoSize = True
        Me.RbEntreFechasVenta.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbEntreFechasVenta.Location = New System.Drawing.Point(304, 4)
        Me.RbEntreFechasVenta.Name = "RbEntreFechasVenta"
        Me.RbEntreFechasVenta.Size = New System.Drawing.Size(73, 24)
        Me.RbEntreFechasVenta.TabIndex = 14
        Me.RbEntreFechasVenta.Text = "Fecha"
        Me.RbEntreFechasVenta.UseVisualStyleBackColor = True
        '
        'TxtFechaIni
        '
        Me.TxtFechaIni.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtFechaIni.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.TxtFechaIni.Location = New System.Drawing.Point(494, 5)
        Me.TxtFechaIni.Mask = "00/00/0000"
        Me.TxtFechaIni.Name = "TxtFechaIni"
        Me.TxtFechaIni.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TxtFechaIni.Size = New System.Drawing.Size(96, 24)
        Me.TxtFechaIni.TabIndex = 11
        Me.TxtFechaIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtFechaIni.Visible = False
        '
        'RbClienteVenta
        '
        Me.RbClienteVenta.AutoSize = True
        Me.RbClienteVenta.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbClienteVenta.Location = New System.Drawing.Point(219, 3)
        Me.RbClienteVenta.Name = "RbClienteVenta"
        Me.RbClienteVenta.Size = New System.Drawing.Size(79, 24)
        Me.RbClienteVenta.TabIndex = 13
        Me.RbClienteVenta.Text = "Cliente"
        Me.RbClienteVenta.UseVisualStyleBackColor = True
        '
        'RbIDVenta
        '
        Me.RbIDVenta.AutoSize = True
        Me.RbIDVenta.Checked = True
        Me.RbIDVenta.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.RbIDVenta.Location = New System.Drawing.Point(102, 3)
        Me.RbIDVenta.Name = "RbIDVenta"
        Me.RbIDVenta.Size = New System.Drawing.Size(111, 24)
        Me.RbIDVenta.TabIndex = 13
        Me.RbIDVenta.TabStop = True
        Me.RbIDVenta.Text = "N de Venta"
        Me.RbIDVenta.UseVisualStyleBackColor = True
        '
        'LblFiltroVentas
        '
        Me.LblFiltroVentas.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblFiltroVentas.Location = New System.Drawing.Point(8, 2)
        Me.LblFiltroVentas.Name = "LblFiltroVentas"
        Me.LblFiltroVentas.Size = New System.Drawing.Size(88, 26)
        Me.LblFiltroVentas.TabIndex = 12
        Me.LblFiltroVentas.Text = "Filtrar por:"
        Me.LblFiltroVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBuscarVenta
        '
        Me.TxtBuscarVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtBuscarVenta.Location = New System.Drawing.Point(383, 4)
        Me.TxtBuscarVenta.Name = "TxtBuscarVenta"
        Me.TxtBuscarVenta.Size = New System.Drawing.Size(309, 26)
        Me.TxtBuscarVenta.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.LblMensajeGuia)
        Me.Panel4.Controls.Add(Me.LblVentas)
        Me.Panel4.Controls.Add(Me.PnlSubmenuVentas)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(698, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 625)
        Me.Panel4.TabIndex = 8
        '
        'LblMensajeGuia
        '
        Me.LblMensajeGuia.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblMensajeGuia.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblMensajeGuia.Location = New System.Drawing.Point(20, 55)
        Me.LblMensajeGuia.Name = "LblMensajeGuia"
        Me.LblMensajeGuia.Size = New System.Drawing.Size(130, 150)
        Me.LblMensajeGuia.TabIndex = 11
        Me.LblMensajeGuia.Text = "Ingrese fechas de venta y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "presione enter en el cuadro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de la última fecha"
        Me.LblMensajeGuia.Visible = False
        '
        'LblVentas
        '
        Me.LblVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblVentas.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblVentas.Location = New System.Drawing.Point(0, 0)
        Me.LblVentas.Name = "LblVentas"
        Me.LblVentas.Size = New System.Drawing.Size(167, 33)
        Me.LblVentas.TabIndex = 10
        Me.LblVentas.Text = "VENTAS"
        Me.LblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubmenuVentas
        '
        Me.PnlSubmenuVentas.BackColor = System.Drawing.Color.Transparent
        Me.PnlSubmenuVentas.Controls.Add(Me.Btn_EliminarVenta)
        Me.PnlSubmenuVentas.Controls.Add(Me.Btn_EditarVenta)
        Me.PnlSubmenuVentas.Controls.Add(Me.Btn_AgregarVenta)
        Me.PnlSubmenuVentas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlSubmenuVentas.Location = New System.Drawing.Point(0, 479)
        Me.PnlSubmenuVentas.Name = "PnlSubmenuVentas"
        Me.PnlSubmenuVentas.Size = New System.Drawing.Size(167, 146)
        Me.PnlSubmenuVentas.TabIndex = 8
        '
        'Btn_EliminarVenta
        '
        Me.Btn_EliminarVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_EliminarVenta.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarVenta.ForeColor = System.Drawing.Color.Black
        Me.Btn_EliminarVenta.Location = New System.Drawing.Point(0, 94)
        Me.Btn_EliminarVenta.Name = "Btn_EliminarVenta"
        Me.Btn_EliminarVenta.Size = New System.Drawing.Size(167, 47)
        Me.Btn_EliminarVenta.TabIndex = 4
        Me.Btn_EliminarVenta.Text = "Eliminar Venta"
        Me.Btn_EliminarVenta.UseVisualStyleBackColor = True
        '
        'Btn_EditarVenta
        '
        Me.Btn_EditarVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_EditarVenta.FlatAppearance.BorderSize = 0
        Me.Btn_EditarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EditarVenta.ForeColor = System.Drawing.Color.Black
        Me.Btn_EditarVenta.Location = New System.Drawing.Point(0, 47)
        Me.Btn_EditarVenta.Name = "Btn_EditarVenta"
        Me.Btn_EditarVenta.Size = New System.Drawing.Size(167, 47)
        Me.Btn_EditarVenta.TabIndex = 3
        Me.Btn_EditarVenta.Text = "Editar Venta"
        Me.Btn_EditarVenta.UseVisualStyleBackColor = True
        '
        'Btn_AgregarVenta
        '
        Me.Btn_AgregarVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_AgregarVenta.FlatAppearance.BorderSize = 0
        Me.Btn_AgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarVenta.ForeColor = System.Drawing.Color.Black
        Me.Btn_AgregarVenta.Location = New System.Drawing.Point(0, 0)
        Me.Btn_AgregarVenta.Name = "Btn_AgregarVenta"
        Me.Btn_AgregarVenta.Size = New System.Drawing.Size(167, 47)
        Me.Btn_AgregarVenta.TabIndex = 2
        Me.Btn_AgregarVenta.Text = "Agregar Venta"
        Me.Btn_AgregarVenta.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(167, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 625)
        Me.Panel7.TabIndex = 9
        '
        'Pnl_SalirVentas
        '
        Me.Pnl_SalirVentas.BackColor = System.Drawing.Color.White
        Me.Pnl_SalirVentas.Controls.Add(Me.Pnl_Cerrar)
        Me.Pnl_SalirVentas.Controls.Add(Me.Panel6)
        Me.Pnl_SalirVentas.Controls.Add(Me.Panel5)
        Me.Pnl_SalirVentas.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_SalirVentas.Location = New System.Drawing.Point(0, 5)
        Me.Pnl_SalirVentas.Name = "Pnl_SalirVentas"
        Me.Pnl_SalirVentas.Size = New System.Drawing.Size(80, 625)
        Me.Pnl_SalirVentas.TabIndex = 2
        '
        'Pnl_Cerrar
        '
        Me.Pnl_Cerrar.Controls.Add(Me.Btn_CerrarVenta)
        Me.Pnl_Cerrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Cerrar.Location = New System.Drawing.Point(5, 0)
        Me.Pnl_Cerrar.Name = "Pnl_Cerrar"
        Me.Pnl_Cerrar.Size = New System.Drawing.Size(70, 49)
        Me.Pnl_Cerrar.TabIndex = 2
        '
        'Btn_CerrarVenta
        '
        Me.Btn_CerrarVenta.BackColor = System.Drawing.Color.Transparent
        Me.Btn_CerrarVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_CerrarVenta.FlatAppearance.BorderSize = 0
        Me.Btn_CerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CerrarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Btn_CerrarVenta.Location = New System.Drawing.Point(0, 0)
        Me.Btn_CerrarVenta.Name = "Btn_CerrarVenta"
        Me.Btn_CerrarVenta.Size = New System.Drawing.Size(70, 49)
        Me.Btn_CerrarVenta.TabIndex = 0
        Me.Btn_CerrarVenta.Text = "Cerrar"
        Me.Btn_CerrarVenta.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 625)
        Me.Panel6.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(75, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 625)
        Me.Panel5.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 5)
        Me.Panel1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 630)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 5)
        Me.Panel3.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 8000
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 635)
        Me.Controls.Add(Me.Pnl_ContenedorVentas)
        Me.Controls.Add(Me.Pnl_SalirVentas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVentas"
        Me.Text = "Form1"
        Me.Pnl_ContenedorVentas.ResumeLayout(False)
        CType(Me.Dgv_VentasItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Divisor.ResumeLayout(False)
        Me.Pnl_Divisor.PerformLayout()
        CType(Me.Dgv_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFiltroVentas.ResumeLayout(False)
        Me.PnlFiltroVentas.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.PnlSubmenuVentas.ResumeLayout(False)
        Me.Pnl_SalirVentas.ResumeLayout(False)
        Me.Pnl_Cerrar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_ContenedorVentas As Panel
    Friend WithEvents Pnl_Divisor As Panel
    Friend WithEvents Dgv_Ventas As DataGridView
    Friend WithEvents Dgv_VentasItems As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Pnl_SalirVentas As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PnlSubmenuVentas As Panel
    Friend WithEvents Btn_EliminarVenta As Button
    Friend WithEvents Btn_EditarVenta As Button
    Friend WithEvents Btn_AgregarVenta As Button
    Friend WithEvents Pnl_Cerrar As Panel
    Friend WithEvents Btn_CerrarVenta As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblVentas As Label
    Friend WithEvents PnlFiltroVentas As Panel
    Friend WithEvents RbClienteVenta As RadioButton
    Friend WithEvents RbIDVenta As RadioButton
    Friend WithEvents LblFiltroVentas As Label
    Friend WithEvents TxtBuscarVenta As TextBox
    Friend WithEvents RbEntreFechasVenta As RadioButton
    Friend WithEvents TxtFechaFin As MaskedTextBox
    Friend WithEvents TxtFechaIni As MaskedTextBox
    Friend WithEvents LblMensajeGuia As Label
    Friend WithEvents Timer1 As Timer
End Class
