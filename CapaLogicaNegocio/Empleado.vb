Imports CapaDato
Imports System.Data
Imports System.Data.SqlClient
Public Class Empleado
    Private DB As New CapaDato.DB

    Private comando As SqlCommand
    Private leer As SqlDataReader
    Private tabla As DataTable
    Public Function ListarEmpleadoId(Id As String) As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
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
        tabla = New DataTable()
        comando = New SqlCommand()
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
        tabla = New DataTable()
        comando = New SqlCommand()
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
    Public Function LlenarCMB() As DataTable
        tabla = New DataTable()
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_llenar_cmb_documento_id"

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
    Public Function InsertarEmpleado(Nombre As String, Apellido As String, Tipo As String, Documento As String, SalarioBase As String, Ingreso As Date, Direccion As String) As Integer
        Dim res As Integer
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_insertar_empleado_documento"
        comando.Parameters.AddWithValue("@Estado", 1)
        comando.Parameters.AddWithValue("@Nombres", Nombre)
        comando.Parameters.AddWithValue("@Apellidos", Apellido)
        comando.Parameters.AddWithValue("@Tipo", Tipo)
        comando.Parameters.AddWithValue("@documento", Documento)
        comando.Parameters.AddWithValue("@SalarioBase", Convert.ToDouble(SalarioBase))
        comando.Parameters.AddWithValue("@Ingreso", Ingreso)
        comando.Parameters.AddWithValue("@Direccion", Direccion)
        Try
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return res
    End Function
    Public Function ActualizarEmpleado(Id As String, Nombre As String, Apellido As String, Tipo As String, Documento As String, SalarioBase As String, Ingreso As Date, Direccion As String) As Integer
        Dim res As Integer
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_actualizar_empleado"
        comando.Parameters.AddWithValue("@Id", Id)
        comando.Parameters.AddWithValue("@Estado", 1)
        comando.Parameters.AddWithValue("@Nombres", Nombre)
        comando.Parameters.AddWithValue("@Apellidos", Apellido)
        comando.Parameters.AddWithValue("@Tipo", Tipo)
        comando.Parameters.AddWithValue("@documento", Documento)
        comando.Parameters.AddWithValue("@SalarioBase", Convert.ToDouble(SalarioBase))
        comando.Parameters.AddWithValue("@Ingreso", Ingreso)
        comando.Parameters.AddWithValue("@Direccion", Direccion)
        Try
            res = comando.ExecuteNonQuery()
            comando.Parameters.Clear()
            comando.Connection = DB.Cerrar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return res
    End Function

    Public Function ElimiarEmpleado(Id As String) As Integer
        Dim res As Integer
        comando = New SqlCommand()
        comando.Connection = DB.Abrir()
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "sp_Eliminar_empleado_id"
        comando.Parameters.AddWithValue("@Id", Id)
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
