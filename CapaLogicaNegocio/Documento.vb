Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient
Public Class Documento

    Private DB As New CapaDato.DB
    Private comando As SqlCommand
    Private leer As SqlDataReader
    Private tabla As DataTable

    Public Function ListarDocumento() As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_documento"
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
    Public Function ListarDocumentoId(Id As String) As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_documento_id"
        comando.Parameters.AddWithValue("@Id", Id)
        Try
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            leer.Close()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return tabla
    End Function

    Public Function ListarDocumentoNombre(Nombre As String) As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_listar_documento_nombre"
        comando.Parameters.AddWithValue("@Nombre", Nombre)
        Try
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            leer.Close()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return tabla
    End Function

    Public Function GuardarDocumento(Tipo As String)
        Dim res As Integer
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_insertar_documento"
        comando.Parameters.AddWithValue("@Estado", 1)
        comando.Parameters.AddWithValue("@Tpo", Tipo)
        Try
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return res
    End Function

    Public Function ActualizarDocumento(Id As String, Tipo As String)
        Dim res As Integer
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_actualizar_documento"
        comando.Parameters.AddWithValue("@Id", Id)
        comando.Parameters.AddWithValue("@Estado", 1)
        comando.Parameters.AddWithValue("@Tpo", Tipo)
        Try
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return res
    End Function
End Class
