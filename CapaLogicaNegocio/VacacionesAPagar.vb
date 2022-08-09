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

    Public Function GuardarVacacionesPagadas(id As String, idvacaciones As String, dias As Decimal, monto As Decimal, descripcion As String) As Integer
        comando = New SqlCommand()
        tabla = New DataTable()
        Dim res As Integer
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_guardar_pago_vacacion_generado"
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@idvacaciones", idvacaciones)
            comando.Parameters.AddWithValue("@dias", dias)
            comando.Parameters.AddWithValue("@monto", monto)
            comando.Parameters.AddWithValue("@descripcion", descripcion)
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return res
    End Function
End Class
