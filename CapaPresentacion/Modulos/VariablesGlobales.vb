Imports CapaEntidad
Module VariablesGlobales
    Public DatosCliente As New CE_Clientes
    Public DatosProducto As New CE_Productos
    Public DatosVentas As New CE_Ventas
    Public DatosVentasItems As New CE_VentasItems
    Friend Config As Globalization.CultureInfo
    Public MenuPrincipal As String = ""
    Public Formulario As String = ""
    Public VbYesNo As Boolean = True
    Public EstadoClientes As String = ""
    Public EstadoProductos As String = ""
    Public EstadoVentas As String = ""
    Public EstadoProductoVentaItem As String = ""
    Public CantidadProducto, PrecioTotalItem As Double 'Para cada registro del detalle
End Module
