Imports CapaNegocio
Imports CapaEntidad
Module FuncPropGral
    Public Sub EstiloGrillas(ByRef Dgview As DataGridView)
        Try
            With Dgview.ColumnHeadersDefaultCellStyle
                .Font = New Font("Century Gothic", 9)
                .ForeColor = Color.Blue
                .BackColor = ColorPersonalizado(224, 224, 224)
                .SelectionForeColor = Color.White
                .SelectionBackColor = SystemColors.Highlight
            End With 'celda titulo
            With Dgview.DefaultCellStyle
                .Font = New Font("Century Gothic", 9.75)
                .ForeColor = Color.Black
                .BackColor = Color.White
                .SelectionForeColor = Color.Black
                .SelectionBackColor = SystemColors.GradientActiveCaption
            End With 'Celdas listadas
            With Dgview.AlternatingRowsDefaultCellStyle
                .Font = New Font("Century Gothic", 9.75)
                .ForeColor = Color.Black
                .BackColor = Color.White
                .SelectionForeColor = Color.Black
                .SelectionBackColor = SystemColors.GradientActiveCaption
            End With 'Celdas listadas
            With Dgview
                .ReadOnly = True
                .MultiSelect = False
                .RowHeadersVisible = False 'Quita la columna con el *
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill 'Rellenan
                .AutoSizeRowsMode = CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeRowsMode)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False 'Quita la ultima fila vacia
            End With
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Sub
    Public Function ColorPersonalizado(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer) As Color
        Try
            ColorPersonalizado = Color.FromArgb(R, G, B)
            Return ColorPersonalizado
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Function

    Sub DeshabilitarTxt(ByRef Ventana As Form)
        Try
            Dim cuadro As Integer
            For cuadro = 0 To Ventana.Controls.Count - 1
                If TypeOf Ventana.Controls(cuadro) Is TextBox Then
                    Ventana.Controls(cuadro).Enabled = False
                End If
            Next cuadro
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Sub
    Public Sub CargarCmbClientes(ByVal combo As ComboBox)
        Try
            Dim dst As New DataSet
            Dim obj As New CN_Clientes
            dst = obj.CN_ListarClientes
            combo.DataSource = dst.Tables("Clientes")
            combo.DisplayMember = "Cliente"
            combo.ValueMember = "ID"
            combo.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try

    End Sub
    Public Sub SoloNumeros(ByVal e As KeyPressEventArgs)
        Try
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try

    End Sub 'No Permite Letras
    Public Sub NoPermiteEspacios(e As KeyPressEventArgs)
        Try
            If e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Sub 'No permite Espacios
    Public Sub CambiarComaPorPunto(ByVal e As KeyPressEventArgs) 'En un cuadro de texto
        Try
            If e.KeyChar = "," Then
                e.KeyChar = CChar(".")
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try
    End Sub
    Public Sub NoRepetirPuntoDecimal(ByVal cuadroText As TextBox, ByVal e As KeyPressEventArgs)
        Try
            Dim Valor As Boolean
            Dim texto As String = cuadroText.Text
            If texto.Contains(".") = True Then Valor = True
            If e.KeyChar = "." And Valor = False Then
                e.Handled = False
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error: " + ex.ToString)
        End Try

    End Sub
    Public Sub SiguienteControl(ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub 'CON ENTER O TAB PASA AL SIGUIENTE CONTROL.
End Module
