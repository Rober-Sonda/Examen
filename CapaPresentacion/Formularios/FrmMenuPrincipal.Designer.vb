<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
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
        Me.PnlMenuPrincipal = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Ventas = New System.Windows.Forms.Button()
        Me.Btn_Clientes = New System.Windows.Forms.Button()
        Me.Btn_Productos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlBarraSuperior = New System.Windows.Forms.Panel()
        Me.Pnl_Cerrar = New System.Windows.Forms.Panel()
        Me.Btn_CerrarAplicacion = New System.Windows.Forms.Button()
        Me.PnlContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblMensajeGuia = New System.Windows.Forms.Label()
        Me.PnlMenuPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarraSuperior.SuspendLayout()
        Me.Pnl_Cerrar.SuspendLayout()
        Me.PnlContenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenuPrincipal
        '
        Me.PnlMenuPrincipal.AutoScroll = True
        Me.PnlMenuPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlMenuPrincipal.Controls.Add(Me.LblMensajeGuia)
        Me.PnlMenuPrincipal.Controls.Add(Me.Panel2)
        Me.PnlMenuPrincipal.Controls.Add(Me.Btn_Ventas)
        Me.PnlMenuPrincipal.Controls.Add(Me.Btn_Clientes)
        Me.PnlMenuPrincipal.Controls.Add(Me.Btn_Productos)
        Me.PnlMenuPrincipal.Controls.Add(Me.PictureBox1)
        Me.PnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenuPrincipal.Location = New System.Drawing.Point(0, 33)
        Me.PnlMenuPrincipal.Name = "PnlMenuPrincipal"
        Me.PnlMenuPrincipal.Size = New System.Drawing.Size(204, 836)
        Me.PnlMenuPrincipal.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 803)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 33)
        Me.Panel2.TabIndex = 9
        '
        'Btn_Ventas
        '
        Me.Btn_Ventas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_Ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Ventas.FlatAppearance.BorderSize = 0
        Me.Btn_Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ventas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ventas.ForeColor = System.Drawing.Color.White
        Me.Btn_Ventas.Location = New System.Drawing.Point(0, 274)
        Me.Btn_Ventas.Name = "Btn_Ventas"
        Me.Btn_Ventas.Size = New System.Drawing.Size(204, 47)
        Me.Btn_Ventas.TabIndex = 6
        Me.Btn_Ventas.Text = "Ventas"
        Me.Btn_Ventas.UseVisualStyleBackColor = False
        '
        'Btn_Clientes
        '
        Me.Btn_Clientes.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_Clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Clientes.FlatAppearance.BorderSize = 0
        Me.Btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Clientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clientes.ForeColor = System.Drawing.Color.White
        Me.Btn_Clientes.Location = New System.Drawing.Point(0, 227)
        Me.Btn_Clientes.Name = "Btn_Clientes"
        Me.Btn_Clientes.Size = New System.Drawing.Size(204, 47)
        Me.Btn_Clientes.TabIndex = 4
        Me.Btn_Clientes.Text = "Clientes"
        Me.Btn_Clientes.UseVisualStyleBackColor = False
        '
        'Btn_Productos
        '
        Me.Btn_Productos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Btn_Productos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Productos.FlatAppearance.BorderSize = 0
        Me.Btn_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Productos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Productos.ForeColor = System.Drawing.Color.White
        Me.Btn_Productos.Location = New System.Drawing.Point(0, 180)
        Me.Btn_Productos.Name = "Btn_Productos"
        Me.Btn_Productos.Size = New System.Drawing.Size(204, 47)
        Me.Btn_Productos.TabIndex = 1
        Me.Btn_Productos.Text = "Productos"
        Me.Btn_Productos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.logo_tactica_preview_rev_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PnlBarraSuperior
        '
        Me.PnlBarraSuperior.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PnlBarraSuperior.Controls.Add(Me.Pnl_Cerrar)
        Me.PnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarraSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarraSuperior.Name = "PnlBarraSuperior"
        Me.PnlBarraSuperior.Size = New System.Drawing.Size(1037, 33)
        Me.PnlBarraSuperior.TabIndex = 2
        '
        'Pnl_Cerrar
        '
        Me.Pnl_Cerrar.Controls.Add(Me.Btn_CerrarAplicacion)
        Me.Pnl_Cerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pnl_Cerrar.Location = New System.Drawing.Point(1000, 0)
        Me.Pnl_Cerrar.Name = "Pnl_Cerrar"
        Me.Pnl_Cerrar.Size = New System.Drawing.Size(37, 33)
        Me.Pnl_Cerrar.TabIndex = 3
        '
        'Btn_CerrarAplicacion
        '
        Me.Btn_CerrarAplicacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_CerrarAplicacion.BackColor = System.Drawing.Color.Transparent
        Me.Btn_CerrarAplicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_CerrarAplicacion.FlatAppearance.BorderSize = 0
        Me.Btn_CerrarAplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_CerrarAplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_CerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CerrarAplicacion.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Btn_CerrarAplicacion.ForeColor = System.Drawing.Color.White
        Me.Btn_CerrarAplicacion.Location = New System.Drawing.Point(0, 0)
        Me.Btn_CerrarAplicacion.Name = "Btn_CerrarAplicacion"
        Me.Btn_CerrarAplicacion.Size = New System.Drawing.Size(37, 33)
        Me.Btn_CerrarAplicacion.TabIndex = 0
        Me.Btn_CerrarAplicacion.Text = "X"
        Me.Btn_CerrarAplicacion.UseVisualStyleBackColor = False
        '
        'PnlContenedor
        '
        Me.PnlContenedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlContenedor.BackColor = System.Drawing.Color.White
        Me.PnlContenedor.Controls.Add(Me.PictureBox2)
        Me.PnlContenedor.Controls.Add(Me.Panel3)
        Me.PnlContenedor.Location = New System.Drawing.Point(204, 33)
        Me.PnlContenedor.Name = "PnlContenedor"
        Me.PnlContenedor.Size = New System.Drawing.Size(833, 836)
        Me.PnlContenedor.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.CapaPresentacion.My.Resources.Resources.logo_tactica_preview_rev_1
        Me.PictureBox2.Location = New System.Drawing.Point(211, 251)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(406, 351)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 803)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(833, 33)
        Me.Panel3.TabIndex = 3
        '
        'LblMensajeGuia
        '
        Me.LblMensajeGuia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblMensajeGuia.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblMensajeGuia.ForeColor = System.Drawing.Color.Black
        Me.LblMensajeGuia.Location = New System.Drawing.Point(0, 746)
        Me.LblMensajeGuia.Name = "LblMensajeGuia"
        Me.LblMensajeGuia.Size = New System.Drawing.Size(204, 57)
        Me.LblMensajeGuia.TabIndex = 12
        Me.LblMensajeGuia.Text = "Examen Roberto Carlos Sonda"
        Me.LblMensajeGuia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblMensajeGuia.Visible = False
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 869)
        Me.Controls.Add(Me.PnlContenedor)
        Me.Controls.Add(Me.PnlMenuPrincipal)
        Me.Controls.Add(Me.PnlBarraSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Ventas TACTICASOFT"
        Me.PnlMenuPrincipal.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarraSuperior.ResumeLayout(False)
        Me.Pnl_Cerrar.ResumeLayout(False)
        Me.PnlContenedor.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMenuPrincipal As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_Ventas As Button
    Friend WithEvents Btn_Clientes As Button
    Friend WithEvents Btn_Productos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlBarraSuperior As Panel
    Friend WithEvents PnlContenedor As Panel
    Friend WithEvents Pnl_Cerrar As Panel
    Friend WithEvents Btn_CerrarAplicacion As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblMensajeGuia As Label
End Class
