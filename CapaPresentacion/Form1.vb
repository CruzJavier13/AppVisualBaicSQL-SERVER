Imports CapaLogicaNegocio
Public Class frmEmpleado

    Private Empleado As New CapaLogicaNegocio.Empleado

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDGVEmpleado()
    End Sub


    Private Function LlenarDGVEmpleadoId(Id As String) As DataGridView
        Dim dgv As New DataGridView
        Try
            dgv.DataSource = Empleado.ListarEmpleadoId(Id)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dgv
    End Function

    Private Function LlenarDGVEmpleado()
        Try
            dgvEmpleado.DataSource = Empleado.ListarEmpleado()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dgvEmpleado
    End Function
End Class
