Imports CapaLogicaNegocio
Public Class frm_Gestionar_Documento
    Private Documento As New CapaLogicaNegocio.Documento
    Private bandera As String = ""
    Private confirm As New MsgBoxResult
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If rbCodigo.Checked And TextBox1.Text <> "" Then
            dgvDocumento.DataSource = Documento.ListarDocumentoId(TextBox1.Text.Trim)
        End If

        If rbNombre.Checked And TextBox1.Text <> "" Then
            dgvDocumento.DataSource = Documento.ListarDocumentoNombre(TextBox1.Text.Trim)
        End If
        If TextBox1.Text = String.Empty Then
            LlenarDGV(dgvDocumento)
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
        btnCancelar.Enabled = True

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
        Dim res As Integer

        If bandera = "modificar" And txtCodigo.Text <> "" And txtTipo.Text.Trim <> "" Then
            confirm = MsgBox("Está seguro que desea modificar los datos", MsgBoxStyle.OkCancel, "Advertencia")
            If confirm = MsgBoxResult.Ok Then
                res = Documento.ActualizarDocumento(txtCodigo.Text.Trim, txtTipo.Text.Trim)
                If res = 1 Then
                    MessageBox.Show("Dato modificado correctamente", "Información")
                End If
            End If
        End If
        If bandera = "nuevo" And txtTipo.Text.Trim <> "" Then
            res = Documento.GuardarDocumento(txtTipo.Text.Trim)
            If res = 1 Then
                MessageBox.Show("Dato guardado correctamente", "Información")
            End If
        End If

        LlenarDGV(dgvDocumento)

        LimpiarTextBox()

        txtCodigo.Enabled = False
        txtEstado.Enabled = False
        txtTipo.Enabled = False

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub LimpiarTextBox()
        txtCodigo.Text = ""
        txtEstado.Text = ""
        txtTipo.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim res As Integer
        If bandera = "modificar" And txtCodigo.Text.Trim <> "" Then
            confirm = MsgBox("Esta seguro de eliminar este dato?", MsgBoxStyle.YesNo, "Advertencia")
            If confirm = MsgBoxResult.Yes Then
                res = Documento.EliminarDocumento(txtCodigo.Text.Trim)
                If res = 1 Then
                    MsgBox("Dato eliminado correctamente", MsgBoxResult.Ok, "Información")
                End If
            End If
        End If
        LlenarDGV(dgvDocumento)
        LimpiarTextBox()

        txtCodigo.Enabled = False
        txtEstado.Enabled = False
        txtTipo.Enabled = False

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarTextBox()

        txtCodigo.Enabled = False
        txtEstado.Enabled = False
        txtTipo.Enabled = False

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
End Class