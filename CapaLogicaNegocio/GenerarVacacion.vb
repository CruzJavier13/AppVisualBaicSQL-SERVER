Imports CapaDato
Imports System.Data.SqlClient
Imports System.Data

Public Class GenerarVacacion

    Private DB As New CapaDato.DB
    Private comando As SqlCommand
    Private tabla As DataTable
    Private leer As SqlDataReader

    Public Function GenerarVacacion(Empleado As String, desde As String, hasta As String) As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_generar_vacacion"
            comando.Parameters.AddWithValue("@IdEmpleado", Empleado)
            comando.Parameters.AddWithValue("@desde", desde)
            comando.Parameters.AddWithValue("@hasta", hasta)
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

    Public Function GuardarVacaciones(Id As String, Empleado As String, desde As Date, hasta As Date, Saldo As Decimal) As Integer
        comando = New SqlCommand()
        tabla = New DataTable()
        Dim res As Integer
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_guardar_vacaciones"
            comando.Parameters.AddWithValue("@Id", Id)
            comando.Parameters.AddWithValue("@Empleado", Empleado)
            comando.Parameters.AddWithValue("@desde", desde)
            comando.Parameters.AddWithValue("@hasta", hasta)
            comando.Parameters.AddWithValue("@saldo", Saldo)
            res = comando.ExecuteNonQuery()

            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Return res
    End Function

    Public Function Buscar(Empleado As String) As DataTable
        comando = New SqlCommand()
        tabla = New DataTable()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_buscar_vacaciones_sin_pagar"
            comando.Parameters.AddWithValue("@Empleado", Empleado)
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
