<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMClientes
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
        Me.PnlMenuClientes = New System.Windows.Forms.Panel()
        Me.LblClientes = New System.Windows.Forms.Label()
        Me.PnlSubmenuClientes = New System.Windows.Forms.Panel()
        Me.Btn_CancelarClientes = New System.Windows.Forms.Button()
        Me.Btn_AceptarClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.TxtCorreoCliente = New System.Windows.Forms.TextBox()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlMenuClientes.SuspendLayout()
        Me.PnlSubmenuClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMenuClientes
        '
        Me.PnlMenuClientes.BackColor = System.Drawing.Color.White
        Me.PnlMenuClientes.Controls.Add(Me.LblClientes)
        Me.PnlMenuClientes.Controls.Add(Me.PnlSubmenuClientes)
        Me.PnlMenuClientes.Controls.Add(Me.Panel2)
        Me.PnlMenuClientes.Controls.Add(Me.Panel1)
        Me.PnlMenuClientes.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMenuClientes.Location = New System.Drawing.Point(442, 0)
        Me.PnlMenuClientes.Name = "PnlMenuClientes"
        Me.PnlMenuClientes.Size = New System.Drawing.Size(124, 288)
        Me.PnlMenuClientes.TabIndex = 8
        '
        'LblClientes
        '
        Me.LblClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblClientes.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.LblClientes.Location = New System.Drawing.Point(5, 0)
        Me.LblClientes.Name = "LblClientes"
        Me.LblClientes.Size = New System.Drawing.Size(114, 49)
        Me.LblClientes.TabIndex = 12
        Me.LblClientes.Text = "CLIENTES"
        Me.LblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSubmenuClientes
        '
        Me.PnlSubmenuClientes.AutoSize = True
        Me.PnlSubmenuClientes.BackColor = System.Drawing.Color.Transparent
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_CancelarClientes)
        Me.PnlSubmenuClientes.Controls.Add(Me.Btn_AceptarClientes)
        Me.PnlSubmenuClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlSubmenuClientes.Location = New System.Drawing.Point(5, 194)
        Me.PnlSubmenuClientes.Name = "PnlSubmenuClientes"
        Me.PnlSubmenuClientes.Size = New System.Drawing.Size(114, 94)
        Me.PnlSubmenuClientes.TabIndex = 7
        '
        'Btn_CancelarClientes
        '
        Me.Btn_CancelarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_CancelarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_CancelarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Btn_CancelarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CancelarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarClientes.ForeColor = System.Drawing.Color.Black
        Me.Btn_CancelarClientes.Location = New System.Drawing.Point(0, 47)
        Me.Btn_CancelarClientes.Name = "Btn_CancelarClientes"
        Me.Btn_CancelarClientes.Size = New System.Drawing.Size(114, 47)
        Me.Btn_CancelarClientes.TabIndex = 3
        Me.Btn_CancelarClientes.Text = "Cancelar"
        Me.Btn_CancelarClientes.UseVisualStyleBackColor = True
        '
        'Btn_AceptarClientes
        '
        Me.Btn_AceptarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_AceptarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_AceptarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Btn_AceptarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AceptarClientes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AceptarClientes.ForeColor = System.Drawing.Color.Black
        Me.Btn_AceptarClientes.Location = New System.Drawing.Point(0, 0)
        Me.Btn_AceptarClientes.Name = "Btn_AceptarClientes"
        Me.Btn_AceptarClientes.Size = New System.Drawing.Size(114, 47)
        Me.Btn_AceptarClientes.TabIndex = 2
        Me.Btn_AceptarClientes.Text = "Aceptar"
        Me.Btn_AceptarClientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 288)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(119, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 288)
        Me.Panel1.TabIndex = 9
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreCliente.BackColor = System.Drawing.Color.White
        Me.TxtNombreCliente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtNombreCliente.Location = New System.Drawing.Point(70, 84)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(295, 25)
        Me.TxtNombreCliente.TabIndex = 9
        '
        'TxtTelefonoCliente
        '
        Me.TxtTelefonoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefonoCliente.BackColor = System.Drawing.Color.White
        Me.TxtTelefonoCliente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtTelefonoCliente.Location = New System.Drawing.Point(70, 144)
        Me.TxtTelefonoCliente.Name = "TxtTelefonoCliente"
        Me.TxtTelefonoCliente.Size = New System.Drawing.Size(295, 25)
        Me.TxtTelefonoCliente.TabIndex = 10
        '
        'TxtCorreoCliente
        '
        Me.TxtCorreoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCorreoCliente.BackColor = System.Drawing.Color.White
        Me.TxtCorreoCliente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.TxtCorreoCliente.Location = New System.Drawing.Point(70, 205)
        Me.TxtCorreoCliente.Name = "TxtCorreoCliente"
        Me.TxtCorreoCliente.Size = New System.Drawing.Size(295, 25)
        Me.TxtCorreoCliente.TabIndex = 11
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.AutoSize = True
        Me.LblNombreCliente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.LblNombreCliente.Location = New System.Drawing.Point(71, 61)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(146, 20)
        Me.LblNombreCliente.TabIndex = 12
        Me.LblNombreCliente.Text = "Nombre de cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(71, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(71, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Correo electrónico"
        '
        'FrmABMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 288)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblNombreCliente)
        Me.Controls.Add(Me.TxtCorreoCliente)
        Me.Controls.Add(Me.TxtTelefonoCliente)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.PnlMenuClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmABMClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABM Clientes"
        Me.PnlMenuClientes.ResumeLayout(False)
        Me.PnlMenuClientes.PerformLayout()
        Me.PnlSubmenuClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlMenuClientes As Panel
    Friend WithEvents LblClientes As Label
    Friend WithEvents PnlSubmenuClientes As Panel
    Friend WithEvents Btn_CancelarClientes As Button
    Friend WithEvents Btn_AceptarClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents TxtTelefonoCliente As TextBox
    Friend WithEvents TxtCorreoCliente As TextBox
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
