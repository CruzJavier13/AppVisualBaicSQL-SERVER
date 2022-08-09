Public Class Contenedor
    Private Sub GestionarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarEmpleadosToolStripMenuItem.Click
        Dim empleado As New frmEmpleado
        empleado.MdiParent = Me
        empleado.Show()
    End Sub

    Private Sub VacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacacionesToolStripMenuItem.Click
        Dim vacaciones As New Vacaciones
        vacaciones.MdiParent = Me
        vacaciones.Show()
    End Sub

    Private Sub GestionarTipoDeCoumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarTipoDeCoumentoToolStripMenuItem.Click
        Dim documento As New frm_Gestionar_Documento
        documento.MdiParent = Me
        documento.Show()
    End Sub
End Class