<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contenedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarTipoDeCoumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarEmpleadosToolStripMenuItem, Me.VacacionesToolStripMenuItem, Me.GestionarTipoDeCoumentoToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1044, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionarEmpleadosToolStripMenuItem
        '
        Me.GestionarEmpleadosToolStripMenuItem.Name = "GestionarEmpleadosToolStripMenuItem"
        Me.GestionarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(150, 21)
        Me.GestionarEmpleadosToolStripMenuItem.Text = "Gestionar Empleados"
        '
        'VacacionesToolStripMenuItem
        '
        Me.VacacionesToolStripMenuItem.Name = "VacacionesToolStripMenuItem"
        Me.VacacionesToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.VacacionesToolStripMenuItem.Text = "Vacaciones"
        '
        'GestionarTipoDeCoumentoToolStripMenuItem
        '
        Me.GestionarTipoDeCoumentoToolStripMenuItem.Name = "GestionarTipoDeCoumentoToolStripMenuItem"
        Me.GestionarTipoDeCoumentoToolStripMenuItem.Size = New System.Drawing.Size(193, 21)
        Me.GestionarTipoDeCoumentoToolStripMenuItem.Text = "Gestionar tipo de coumento"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'Contenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 527)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Contenedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contenedor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarTipoDeCoumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
End Class
