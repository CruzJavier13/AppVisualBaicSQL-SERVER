Imports System.Data.SqlClient
Public Class DB
    Private coneccion As String = "Data Source=.;Initial Catalog=Empleados;Integrated Security=True"
    Private strinDB As New SqlConnection(coneccion)

    Public Function Abrir() As SqlConnection
        If strinDB.State = ConnectionState.Closed Then
            strinDB.Open()
        End If
        Return strinDB
    End Function

    Public Function Cerrar() As SqlConnection
        If strinDB.State = ConnectionState.Open Then
            strinDB.Close()
        End If
        Return strinDB
    End Function
End Class
