<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMProductos
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
        Me.LblCategoriaProducto = New System.Windows.Forms.Label()
        Me.LblPrecioProducto = New System.Windows.Forms.Label()
        Me.LblNombreProducto = New System.Windows.Forms.Label()
        Me.TxtCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.TxtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.PnlMenuProductos = New System.Windows.Forms.Panel()
        Me.LblProductos = New System.Windows.Forms.Label()
        Me.PnlSubmenuClientes = New System.Windows.Forms.Panel()
        Me.Btn_CancelarProductos = New System.Windows.Forms.Button()
        Me.Btn_AceptarProductos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlMenuProductos.SuspendLayout()
        Me.PnlSubmenuClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCategoriaProducto
        '
        Me.LblCategoriaProducto.AutoSize = True
        Me.LblCategoriaProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.LblCategoriaProducto.Location = New System.Drawing.Point(83, 200)
        Me.LblCategoriaProducto.Name = "LblCategoriaProducto"
        Me.LblCategoriaProducto.Size = New System.Drawing.Size(84, 20)
        Me.LblCategoriaProducto.TabIndex = 17
        Me.LblCategoriaProducto.Text = "Categoria"
        '
        'LblPrecioProducto
        '
        Me.LblPrecioProducto.AutoSize = True
        Me.LblPrecioProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.LblPrecioProducto.Location = New System.Drawing.Point(83, 139)
        Me.LblPrecioProducto.Name = "LblPrecioProducto"
        Me.LblPrecioProducto.Size = New System.Drawing.Size(56, 20)
        Me.LblPrecioProducto.TabIndex = 18
        Me.LblPrecioProducto.Text = "Precio"
        '
        'LblNombreProducto
        '
        Me.LblNombreProducto.AutoSize = True
        Me.LblNombreProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.LblNombreProducto.Location = New System.Drawing.Point(83, 79)
        Me.LblNombreProducto.Name = "LblNombreProducto"
        Me.LblNombreProducto.Size = New System.Drawing.Size(68, 20)
        Me.LblNombreProducto.TabIndex = 19
        Me.LblNombreProducto.Text = "Nombre"
        '
        'TxtCategoriaProducto
        '
        Me.TxtCategoriaProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCategoriaProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtCategoriaProducto.Location = New System.Drawing.Point(82, 223)
        Me.TxtCategoriaProducto.Name = "TxtCategoriaProducto"
        Me.TxtCategoriaProducto.Size = New System.Drawing.Size(295, 25)
        Me.TxtCategoriaProducto.TabIndex = 16
        '
        'TxtPrecioProducto
        '
        Me.TxtPrecioProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrecioProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtPrecioProducto.Location = New System.Drawing.Point(82, 162)
        Me.TxtPrecioProducto.Name = "TxtPrecioProducto"
        Me.TxtPrecioProducto.Size = New System.Drawing.Size(295, 25)
        Me.TxtPrecioProducto.TabIndex = 15
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtNombreProducto.Location = New System.Drawing.Point(82, 102)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(295, 25)
        Me.TxtNombreProducto.TabIndex = 14
        '
        'PnlMenuProductos
        '
        Me.PnlMenuProductos.BackColor = System.Drawing.Color.White
        Me.PnlMenuProductos.Controls.Add(Me.LblProductos)
        Me.PnlMenuProductos.Controls.Add(Me.PnlSubmenuClientes)
        Me.PnlMenuProductos.Controls.Add(Me.Panel2)
        Me.PnlMenuProductos.Controls.Add(Me.Panel1)
        Me.PnlMenuProductos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMenuProductos.Location = New System.Drawing.Point(472, 0)
        Me.PnlMenuProductos.Name = "PnlMenuProductos"
        Me.PnlMenuProductos.Size = New System.Drawing.Size(150, 352)
        Me.PnlMenuProductos.TabIndex = 13
        '
        'LblProductos
        '
        Me.LblProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblProductos.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblProductos.Location = New System.Drawing.Point(5, 0)
        Me.LblProductos.Name = "LblProductos"
        Me.LblProductos.Size = New System.Drawing.Size(140, 49)
        Me.LblProductos.TabIndex = 12
        Me.LblProductos.Text = "PRODUCTOS"
        Me.LblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubmenuClientes
        '
        Me.PnlSubmenuClientes.AutoSize = True
        Me.PnlSubmenuClientes.BackColor = System.Drawing.Color.Transparent
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_CancelarProductos)
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_AceptarProductos)
        Me.PnlSubmenuClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlSubmenuClientes.Location = New System.Drawing.Point(5, 258)
        Me.PnlSubmenuClientes.Name = "PnlSubmenuClientes"
        Me.PnlSubmenuClientes.Size = New System.Drawing.Size(140, 94)
        Me.PnlSubmenuClientes.TabIndex = 7
        '
        'Btn_CancelarProductos
        '
        Me.Btn_CancelarProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_CancelarProductos.FlatAppearance.BorderSize = 0
        Me.Btn_CancelarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_CancelarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CancelarProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarProductos.ForeColor = System.Drawing.Color.Black
        Me.Btn_CancelarProductos.Location = New System.Drawing.Point(0, 47)
        Me.Btn_CancelarProductos.Name = "Btn_CancelarProductos"
        Me.Btn_CancelarProductos.Size = New System.Drawing.Size(140, 47)
        Me.Btn_CancelarProductos.TabIndex = 3
        Me.Btn_CancelarProductos.Text = "Cancelar"
        Me.Btn_CancelarProductos.UseVisualStyleBackColor = True
        '
        'Btn_AceptarProductos
        '
        Me.Btn_AceptarProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_AceptarProductos.FlatAppearance.BorderSize = 0
        Me.Btn_AceptarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Btn_AceptarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AceptarProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AceptarProductos.ForeColor = System.Drawing.Color.Black
        Me.Btn_AceptarProductos.Location = New System.Drawing.Point(0, 0)
        Me.Btn_AceptarProductos.Name = "Btn_AceptarProductos"
        Me.Btn_AceptarProductos.Size = New System.Drawing.Size(140, 47)
        Me.Btn_AceptarProductos.TabIndex = 2
        Me.Btn_AceptarProductos.Text = "Aceptar"
        Me.Btn_AceptarProductos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 352)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(145, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 352)
        Me.Panel1.TabIndex = 9
        '
        'FrmABMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 352)
        Me.Controls.Add(Me.LblCategoriaProducto)
        Me.Controls.Add(Me.LblPrecioProducto)
        Me.Controls.Add(Me.LblNombreProducto)
        Me.Controls.Add(Me.TxtCategoriaProducto)
        Me.Controls.Add(Me.TxtPrecioProducto)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.PnlMenuProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmABMProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABM Productos"
        Me.PnlMenuProductos.ResumeLayout(False)
        Me.PnlMenuProductos.PerformLayout()
        Me.PnlSubmenuClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCategoriaProducto As Label
    Friend WithEvents LblPrecioProducto As Label
    Friend WithEvents LblNombreProducto As Label
    Friend WithEvents TxtCategoriaProducto As TextBox
    Friend WithEvents TxtPrecioProducto As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents PnlMenuProductos As Panel
    Friend WithEvents LblProductos As Label
    Friend WithEvents PnlSubmenuClientes As Panel
    Friend WithEvents Btn_CancelarProductos As Button
    Friend WithEvents Btn_AceptarProductos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
