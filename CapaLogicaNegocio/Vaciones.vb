Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient

Public Class Vaciones
    Private DB As New CapaDato.DB
    Private comando As SqlCommand
    Private leer As SqlDataReader
    Private tabla As DataTable
    Private res As Integer

    Public Function guardarDiaLibre(Empleado As String, desde As Date, hasta As Date) As Integer
        comando = New SqlCommand()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_insertar_dia_libre"
            comando.Parameters.AddWithValue("@empleado", Empleado)
            comando.Parameters.AddWithValue("@desde", desde)
            comando.Parameters.AddWithValue("@hasta", hasta)
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return res
    End Function
    Public Function actualizarDiaLibre(Id As String, Empleado As String, desde As Date, hasta As Date) As Integer
        comando = New SqlCommand()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_actualizar_lia_libre"
            comando.Parameters.AddWithValue("@Id", Id)
            comando.Parameters.AddWithValue("@empleado", Empleado)
            comando.Parameters.AddWithValue("@desde", desde)
            comando.Parameters.AddWithValue("@hasta", hasta)
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    Public Function encontrarEmpleado(Id As String) As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_encontrar_empleado"
            comando.Parameters.AddWithValue("@Id", Id)
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
    Public Function encontrarVacacion(Id As String) As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
        Try
            comando.Connection = DB.Abrir()
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "sp_encontrar_vacacion_a_modificar"
            comando.Parameters.AddWithValue("@Id", Id)
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
