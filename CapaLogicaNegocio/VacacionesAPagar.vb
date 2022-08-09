Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient

Public Class VacacionesAPagar

    Private DB As New CapaDato.DB
    Private comando As SqlCommand
    Private tabla As DataTable
    Private leer As SqlDataReader


    Public Function GenerarPagoVacacion(IdVacacion As String) As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_generar_pago_vacaciones"
            comando.Parameters.AddWithValue("@IdVacaciones", IdVacacion)
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
