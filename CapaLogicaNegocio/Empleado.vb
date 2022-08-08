Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient
Public Class Empleado
    Private DB As New CapaDato.DB

    Private comando As New SqlCommand()
    Private leer As SqlDataReader
    Private tabla As New DataTable()
    Public Function ListarEmpleadoId(Id As String) As DataTable
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_empleado_id"
        comando.Parameters.AddWithValue("@Id", Id)

        Try
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            comando.Connection = DB.Cerrar()
            leer.Close()
            comando.Parameters.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function
    Public Function ListarEmpleadoDocumento(Documento As String) As DataTable
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_empleado_documento"
        comando.Parameters.AddWithValue("@documento", Documento)

        Try
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            comando.Connection = DB.Cerrar()
            leer.Close()
            comando.Parameters.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function
    Public Function ListarEmpleado() As DataTable
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_empleado"

        Try
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            leer.Close()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function
End Class
