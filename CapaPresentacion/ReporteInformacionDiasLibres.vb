Imports CapaLogicaNegocio
Public Class ReporteInformacionDiasLibres

    Dim reporte As New CapaLogicaNegocio.Reporte
    Private Sub ReporteInformacionDiasLibres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar(dgvInfo)
        LlenarVacacuines(dgvDiasLires)
    End Sub

    Public Sub LlenarVacacuines(dgv As DataGridView)
        dgv.DataSource = reporte.LlenarDGVacaciones()
    End Sub
    Public Sub Llenar(dgv As DataGridView)
        dgv.DataSource = reporte.LlenarDGV()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBuscarCodigo.Text.Trim <> String.Empty Then

            dgvInfo.DataSource = reporte.LlenarDGVInformacionID(txtBuscarCodigo.Text.Trim)

        End If
    End Sub

    Private Sub txtBuscarDiasLibres_Click(sender As Object, e As EventArgs) Handles txtBuscarDiasLibres.Click
        If txtBuscarDiasLibres.Text.Trim <> String.Empty Then

            dgvDiasLires.DataSource = reporte.LlenarDGVacacionesID(txtBuscarDiasLibres.Text.Trim)

        End If
    End Sub
End Class