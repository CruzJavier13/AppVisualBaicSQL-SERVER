Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient
Public Class Empleado
    Private DB As New CapaDato.DB

    Private comando As New SqlCommand()
    Private leer As SqlDataReader
    Private tabla As New DataTable()
    Public Function ListarEmpleado(Id As String) As DataTable
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_empleado_id"
        comando.Parameters.AddWithValue("@Id", Id)

        Try
            leer = comando.ExecuteReader()
            tabla.load(leer)
            comando.Connection = DB.Cerrar()
            comando.Parameters.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function

End Class
