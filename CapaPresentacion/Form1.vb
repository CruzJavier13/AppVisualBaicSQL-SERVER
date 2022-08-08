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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True


        HabulitarTextBox()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click



        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        LimpiarTextBox()
        DesabilitarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click


        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False

        LimpiarTextBox()
        DesabilitarTextBox()
    End Sub

    Public Sub LimpiarTextBox()
        txtId.Text = ""
        txtEstado.Text = ""
        txtNombres.Text = ""
        txtApellidos.Text = ""
        txtDocumento.Text = ""
        txtSalarioBase.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        btnEliminar.Enabled = False
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False

        LimpiarTextBox()
        DesabilitarTextBox()
    End Sub

    Public Sub HabulitarTextBox()
        txtNombres.Enabled = True
        txtApellidos.Enabled = True
        cmbTipo.Enabled = True
        txtDocumento.Enabled = True
        txtSalarioBase.Enabled = True
        dtpIngreso.Enabled = True
        txtDireccion.Enabled = True
    End Sub
    Public Sub DesabilitarTextBox()
        txtNombres.Enabled = False
        txtApellidos.Enabled = False
        cmbTipo.Enabled = False
        txtDocumento.Enabled = False
        txtSalarioBase.Enabled = False
        dtpIngreso.Enabled = False
        txtDireccion.Enabled = False
    End Sub
End Class
