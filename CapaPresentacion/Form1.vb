Imports CapaLogicaNegocio
Public Class frmEmpleado

    Private Empleado As New CapaLogicaNegocio.Empleado
    Dim bandera As String
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
        If bandera = "modificar" Then

        End If


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
        If bandera = "modificar" Then

        End If

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

    Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick
        If rbCodigo.Checked = False And rbDocumento.Checked = False Then
            txtId.Text = dgvEmpleado.Item(0, e.RowIndex).Value
            txtEstado.Text = dgvEmpleado.Item(1, e.RowIndex).Value
            txtNombres.Text = dgvEmpleado.Item(2, e.RowIndex).Value
            txtApellidos.Text = dgvEmpleado.Item(3, e.RowIndex).Value
            cmbTipo.Text = dgvEmpleado.Item(4, e.RowIndex).Value
            txtDocumento.Text = dgvEmpleado.Item(5, e.RowIndex).Value

            txtSalarioBase.Text = dgvEmpleado.Item(6, e.RowIndex).Value
            dtpIngreso.Value = dgvEmpleado.Item(7, e.RowIndex).Value
            txtDireccion.Text = dgvEmpleado.Item(8, e.RowIndex).Value

            'dtpIngreso.Enabled = True
            btnGuardar.Enabled = True
            btnNuevo.Enabled = False
            btnEliminar.Enabled = True
            btnCancelar.Enabled = True



            bandera = "modificar"

            HabulitarTextBox()
        End If

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If rbDocumento.Checked = True And txtBuscar.Text.Trim <> String.Empty Then
            LimpiarDGV(dgvEmpleado)
            dgvEmpleado.DataSource = Empleado.ListarEmpleadoDocumento(txtBuscar.Text)
        End If
        If rbCodigo.Checked = True And txtBuscar.Text.Trim <> String.Empty Then
            LimpiarDGV(dgvEmpleado)
            dgvEmpleado.DataSource = Empleado.ListarEmpleadoId(txtBuscar.Text)

        End If
    End Sub

    Public Sub LimpiarDGV(dgv As DataGridView)
        dgv.DataSource = Nothing
    End Sub
End Class
