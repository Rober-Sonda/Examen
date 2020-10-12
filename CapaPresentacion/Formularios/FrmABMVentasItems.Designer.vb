<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMVentasItems
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_SeleccionarOtroVentaItem = New System.Windows.Forms.Button()
        Me.Btn_AceptarVentaItem = New System.Windows.Forms.Button()
        Me.Btn_CancelarVentaItem = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtProductoPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.LblClientesVenta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblEstadoItems = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Btn_SeleccionarOtroVentaItem)
        Me.Panel5.Controls.Add(Me.Btn_AceptarVentaItem)
        Me.Panel5.Controls.Add(Me.LblEstadoItems)
        Me.Panel5.Controls.Add(Me.Btn_CancelarVentaItem)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(426, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(128, 295)
        Me.Panel5.TabIndex = 25
        '
        'Btn_SeleccionarOtroVentaItem
        '
        Me.Btn_SeleccionarOtroVentaItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_SeleccionarOtroVentaItem.FlatAppearance.BorderSize = 0
        Me.Btn_SeleccionarOtroVentaItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_SeleccionarOtroVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SeleccionarOtroVentaItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SeleccionarOtroVentaItem.ForeColor = System.Drawing.Color.Black
        Me.Btn_SeleccionarOtroVentaItem.Location = New System.Drawing.Point(0, 151)
        Me.Btn_SeleccionarOtroVentaItem.Name = "Btn_SeleccionarOtroVentaItem"
        Me.Btn_SeleccionarOtroVentaItem.Size = New System.Drawing.Size(128, 48)
        Me.Btn_SeleccionarOtroVentaItem.TabIndex = 4
        Me.Btn_SeleccionarOtroVentaItem.Text = "Volver a elegir"
        Me.Btn_SeleccionarOtroVentaItem.UseVisualStyleBackColor = True
        '
        'Btn_AceptarVentaItem
        '
        Me.Btn_AceptarVentaItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_AceptarVentaItem.FlatAppearance.BorderSize = 0
        Me.Btn_AceptarVentaItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Btn_AceptarVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AceptarVentaItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AceptarVentaItem.ForeColor = System.Drawing.Color.Black
        Me.Btn_AceptarVentaItem.Location = New System.Drawing.Point(0, 199)
        Me.Btn_AceptarVentaItem.Name = "Btn_AceptarVentaItem"
        Me.Btn_AceptarVentaItem.Size = New System.Drawing.Size(128, 48)
        Me.Btn_AceptarVentaItem.TabIndex = 2
        Me.Btn_AceptarVentaItem.Text = "Aceptar"
        Me.Btn_AceptarVentaItem.UseVisualStyleBackColor = True
        '
        'Btn_CancelarVentaItem
        '
        Me.Btn_CancelarVentaItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_CancelarVentaItem.FlatAppearance.BorderSize = 0
        Me.Btn_CancelarVentaItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_CancelarVentaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CancelarVentaItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarVentaItem.ForeColor = System.Drawing.Color.Black
        Me.Btn_CancelarVentaItem.Location = New System.Drawing.Point(0, 247)
        Me.Btn_CancelarVentaItem.Name = "Btn_CancelarVentaItem"
        Me.Btn_CancelarVentaItem.Size = New System.Drawing.Size(128, 48)
        Me.Btn_CancelarVentaItem.TabIndex = 3
        Me.Btn_CancelarVentaItem.Text = "Cancelar"
        Me.Btn_CancelarVentaItem.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(554, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 295)
        Me.Panel6.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(423, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 295)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3, 295)
        Me.Panel2.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(557, 3)
        Me.Panel3.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.Location = New System.Drawing.Point(0, 298)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(557, 3)
        Me.Panel4.TabIndex = 34
        '
        'TxtProductoPrecio
        '
        Me.TxtProductoPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProductoPrecio.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtProductoPrecio.Location = New System.Drawing.Point(57, 140)
        Me.TxtProductoPrecio.Name = "TxtProductoPrecio"
        Me.TxtProductoPrecio.Size = New System.Drawing.Size(314, 26)
        Me.TxtProductoPrecio.TabIndex = 35
        '
        'TxtCantidadProducto
        '
        Me.TxtCantidadProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCantidadProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtCantidadProducto.Location = New System.Drawing.Point(57, 211)
        Me.TxtCantidadProducto.Name = "TxtCantidadProducto"
        Me.TxtCantidadProducto.Size = New System.Drawing.Size(314, 26)
        Me.TxtCantidadProducto.TabIndex = 36
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreProducto.Enabled = False
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.TxtNombreProducto.Location = New System.Drawing.Point(57, 67)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(314, 26)
        Me.TxtNombreProducto.TabIndex = 37
        '
        'LblClientesVenta
        '
        Me.LblClientesVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblClientesVenta.Location = New System.Drawing.Point(53, 33)
        Me.LblClientesVenta.Name = "LblClientesVenta"
        Me.LblClientesVenta.Size = New System.Drawing.Size(78, 31)
        Me.LblClientesVenta.TabIndex = 38
        Me.LblClientesVenta.Text = "Producto"
        Me.LblClientesVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(53, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 31)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Precio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(53, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 31)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cantidad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEstadoItems
        '
        Me.LblEstadoItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblEstadoItems.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblEstadoItems.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LblEstadoItems.Location = New System.Drawing.Point(0, 0)
        Me.LblEstadoItems.Name = "LblEstadoItems"
        Me.LblEstadoItems.Size = New System.Drawing.Size(128, 31)
        Me.LblEstadoItems.TabIndex = 38
        Me.LblEstadoItems.Text = "Agregar item"
        Me.LblEstadoItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmABMVentasItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 301)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblClientesVenta)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.TxtCantidadProducto)
        Me.Controls.Add(Me.TxtProductoPrecio)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmABMVentasItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmABMVentasItems"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Btn_AceptarVentaItem As Button
    Friend WithEvents Btn_CancelarVentaItem As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_SeleccionarOtroVentaItem As Button
    Friend WithEvents TxtProductoPrecio As TextBox
    Friend WithEvents TxtCantidadProducto As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents LblClientesVenta As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEstadoItems As Label
End Class
