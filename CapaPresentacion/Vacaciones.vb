Imports CapaLogicaNegocio
Imports System.Data
Public Class Vacaciones

    Private Vacacion As New CapaLogicaNegocio.Vaciones()
    Private Generar As New CapaLogicaNegocio.GenerarVacacion()
    Private Pago As New CapaLogicaNegocio.VacacionesAPagar()
    Private tabla As DataTable
    Private bandera As String
    Private saldo As Decimal
    Private confirmar As MsgBoxResult

    Private Sub txtCodigoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoEmpleado.TextChanged
        tabla = New DataTable()
        tabla = Vacacion.encontrarEmpleado(txtCodigoEmpleado.Text.Trim)
        If tabla.Rows.Count > 0 Then
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
        End If
        If txtCodigoEmpleado.Text = String.Empty Then
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False
        End If




    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigoVacacion.Enabled = False
        txtCodigoEmpleado.Enabled = True
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        bandera = "nuevo"
    End Sub

    Private Sub txtCodigoVacacion_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoVacacion.TextChanged
        tabla = New DataTable()
        tabla = Vacacion.encontrarVacacion(txtCodigoVacacion.Text.Trim)

        If tabla.Rows.Count > 0 Then
            txtCodigoEmpleado.Enabled = True
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True

            For Each row As DataRow In tabla.Rows
                txtCodigoEmpleado.Text = row("empleado").ToString
                dtpDesde.Value = row(1).ToString
                dtpHasta.Value = row(2).ToString
            Next
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
        End If
        If txtCodigoEmpleado.Text = String.Empty Then
            txtCodigoEmpleado.Enabled = False
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtCodigoVacacion.Enabled = True
        btnNuevo.Enabled = False

        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        bandera = "modificar"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim desde As String
        Dim hasta As String
        Dim res As Integer
        If bandera = "nuevo" And txtCodigoEmpleado.Text <> "" Then
            desde = dtpDesde.Value.Year & "-" & dtpDesde.Value.Month & "-" & dtpHasta.Value.Day
            hasta = dtpHasta.Value.Year & "-" & dtpHasta.Value.Month & "-" & dtpHasta.Value.Day
            res = Vacacion.guardarDiaLibre(txtCodigoEmpleado.Text.Trim, desde, hasta)
            If res = 1 Then
                MsgBox("Datos guardados correctamente")
            End If
        End If

        If bandera = "modificar" And txtCodigoVacacion.Text <> "" Then
            desde = dtpDesde.Value.Year & "-" & dtpDesde.Value.Month & "-" & dtpHasta.Value.Day
            hasta = dtpHasta.Value.Year & "-" & dtpHasta.Value.Month & "-" & dtpHasta.Value.Day
            res = Vacacion.actualizarDiaLibre(txtCodigoVacacion.Text.Trim, txtCodigoEmpleado.Text.Trim, desde, hasta)
            If res = 1 Then
                MsgBox("Datos modificados correctamente")
            End If
        End If


        txtCodigoVacacion.Text = ""
        txtCodigoVacacion.Enabled = False
        txtCodigoEmpleado.Text = ""
        txtCodigoEmpleado.Enabled = False

        dtpDesde.Enabled = False
        dtpHasta.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        btnModificar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigoVacacion.Text = ""
        txtCodigoVacacion.Enabled = False
        txtCodigoEmpleado.Text = ""
        txtCodigoEmpleado.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False

        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar(dgvVacaciones)
    End Sub
    Public Sub Llenar(dgv As DataGridView)
        dgv.DataSource = Generar.BuscarVacacionPagar()
    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        tabla = New DataTable()
        Dim desde As String
        Dim hasta As String
        desde = dtpD.Value.Year & "-" & dtpD.Value.Month & "-" & dtpD.Value.Day
        hasta = dtpH.Value.Year & "-" & dtpH.Value.Month & "-" & dtpH.Value.Day
        tabla = Generar.GenerarVacacion(txtEmpleado.Text.Trim, desde, hasta)
        If txtEmpleado.Text <> "" Then
            If tabla.Rows.Count > 0 Then

                For Each row As DataRow In tabla.Rows
                    txtCodigo.Text = row(0).ToString
                    txtEmpleado.Text = row(2).ToString
                    dtpD.Value = row(3).ToString
                    dtpH.Value = row(4).ToString
                    txtSaldo.Text = row(5).ToString
                    saldo = row(5).ToString
                Next
                txtCodigo.Enabled = False
                txtSaldo.Enabled = False
                dtpD.Enabled = False
                dtpH.Enabled = False
                btnCancelar.Enabled = True
            End If
        End If

        btnGenerar.Enabled = False
        btnGuardarVacaion.Enabled = True
    End Sub

    Private Sub txtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtEmpleado.TextChanged
        tabla = New DataTable()
        tabla = Vacacion.encontrarEmpleado(txtEmpleado.Text.Trim)

        If tabla.Rows.Count > 0 Then
            txtCodigoEmpleado.Enabled = True
            dtpD.Enabled = True
            dtpH.Enabled = True

            btnGenerar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardarVacaion_Click(sender As Object, e As EventArgs) Handles btnGuardarVacaion.Click
        tabla = New DataTable
        Dim desde As String
        Dim hasta As String
        desde = dtpD.Value.Year & "-" & dtpD.Value.Month & "-" & dtpD.Value.Day
        hasta = dtpH.Value.Year & "-" & dtpH.Value.Month & "-" & dtpH.Value.Day
        tabla = Generar.Buscar(txtEmpleado.Text.Trim)

        If tabla.Rows.Count < 0 Then
            If saldo < 0 Then
                confirmar = MsgBox("Esta seguro que desea guardar unas vacaciones con saldo negativo?", MsgBoxStyle.YesNo, "Advertencia")

                If confirmar = MsgBoxResult.Yes Then
                    Generar.GuardarVacaciones(txtCodigo.Text.Trim, txtEmpleado.Text.Trim, desde, hasta, saldo)
                End If
            End If
        Else
            MessageBox.Show("Las vacaciones ya an sido generadas pero no se an pagado")
        End If
        btnGenerar.Enabled = False
        btnGenerar.Enabled = True
        txtCodigo.Text = ""
        txtCodigoEmpleado.Text = ""
        btnCancelar.Enabled = False
    End Sub

    Private Sub txtGenerar_TextChanged(sender As Object, e As EventArgs) Handles txtGenerar.TextChanged

    End Sub

    Private Sub dgvVacaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVacaciones.CellContentClick
        If txtGenerar.Text = "" And dgvVacaciones.Rows.Count <> -1 Then
            txtGenerar.Text = dgvVacaciones.Item(0, e.RowIndex).Value
        End If

    End Sub

    Private Sub btnGenerarPago_Click(sender As Object, e As EventArgs) Handles btnGenerarPago.Click
        If txtGenerar.Text <> "" Then
            dgvVacaciones.DataSource = Pago.GenerarPagoVacacion(txtGenerar.Text.Trim)
        End If
        btnGenerarPago.Enabled = False
        btnGuardarPago.Enabled = True
        btnCancelarGenerarPago.Enabled = True
        txtDescripcion.Enabled = True
    End Sub

    Private Sub btnGuardarPago_Click(sender As Object, e As EventArgs) Handles btnGuardarPago.Click
        If txtGenerar.Text <> String.Empty Then

            Pago.GuardarVacacionesPagadas(dgvVacaciones.Item(0, 0).Value.ToString, dgvVacaciones.Item(2, 0).Value.ToString, dgvVacaciones.Item(3, 0).Value.ToString, dgvVacaciones.Item(4, 0).Value.ToString, txtDescripcion.Text.Trim)

        End If
    End Sub
End Class