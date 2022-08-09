Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient

Public Class Reporte
    Private DB As New CapaDato.DB
    Private comando As SqlCommand
    Private tabla As DataTable
    Private leer As SqlDataReader


    Public Function LlenarDGV() As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_infor_report_full"
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            leer.Close()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return tabla
    End Function

    Public Function LlenarDGVacaciones() As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_listar_dias_libres"
            leer = comando.ExecuteReader()
            tabla.Load(leer)
            leer.Close()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return tabla
    End Function
    Public Function LlenarDGVacacionesID(id As String) As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_listar_dias_libres_id"
            comando.Parameters.AddWithValue("@id", id)
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
    Public Function LlenarDGVInformacionID(id As String) As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_infor_report"
            comando.Parameters.AddWithValue("@idEmpleado", id)
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
End Class
