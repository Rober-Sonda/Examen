Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class Conexion
    Dim conexion As SqlConnection
    Public Function Conectar() As SqlConnection
        conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Cnx").ConnectionString)
        Return conexion
    End Function
End Class
