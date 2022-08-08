Imports CapaLogicaNegocio
Public Class frm_Gestionar_Documento
    Private Documento As New CapaLogicaNegocio.Documento()
    Private bandera As String = ""
    Private confirm As New MsgBoxResult
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If rbCodigo.Checked And TextBox1.Text <> "" Then
            dgvDocumento.DataSource = Documento.ListarDocumentoId(TextBox1.Text.Trim)
        End If

        If rbNombre.Checked And TextBox1.Text <> "" Then
            dgvDocumento.DataSource = Documento.ListarDocumentoNombre(TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub LlenarDGV(dgv As DataGridView)
        dgv.DataSource = Documento.ListarDocumento()
    End Sub

    Private Sub frm_Gestionar_Documento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDGV(dgvDocumento)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False

        txtTipo.Enabled = True

        bandera = "nuevo"
    End Sub

    Private Sub dgvDocumento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumento.CellContentClick

        If dgvDocumento.Rows.Count > 0 Then
            txtCodigo.Text = dgvDocumento.Item(0, e.RowIndex).Value
            txtEstado.Text = dgvDocumento.Item(1, e.RowIndex).Value
            txtTipo.Text = dgvDocumento.Item(2, e.RowIndex).Value
            bandera = "modificar"
            btnCancelar.Enabled = True
            btnEliminar.Enabled = True
            btnGuardar.Enabled = True
            btnNuevo.Enabled = False

            txtTipo.Enabled = True
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class