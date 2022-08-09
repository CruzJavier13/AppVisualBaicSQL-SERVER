Imports CapaLogicaNegocio
Imports System.Data
Public Class Vacaciones

    Private Vacacion As New CapaLogicaNegocio.Vaciones()
    Private tabla As DataTable
    Private bandera As String
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

    End Sub
End Class