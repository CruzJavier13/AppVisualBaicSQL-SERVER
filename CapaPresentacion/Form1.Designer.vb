<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.lblTextoBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbDocumento = New System.Windows.Forms.RadioButton()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSalarioBase = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToDeleteRows = False
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Location = New System.Drawing.Point(13, 434)
        Me.dgvEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.Size = New System.Drawing.Size(935, 163)
        Me.dgvEmpleado.TabIndex = 1
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.rbDocumento)
        Me.gbBuscar.Controls.Add(Me.rbCodigo)
        Me.gbBuscar.Controls.Add(Me.txtBuscar)
        Me.gbBuscar.Controls.Add(Me.lblTextoBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(13, 363)
        Me.gbBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbBuscar.Size = New System.Drawing.Size(935, 53)
        Me.gbBuscar.TabIndex = 0
        Me.gbBuscar.TabStop = False
        '
        'lblTextoBuscar
        '
        Me.lblTextoBuscar.AutoSize = True
        Me.lblTextoBuscar.Location = New System.Drawing.Point(8, 23)
        Me.lblTextoBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextoBuscar.Name = "lblTextoBuscar"
        Me.lblTextoBuscar.Size = New System.Drawing.Size(50, 16)
        Me.lblTextoBuscar.TabIndex = 0
        Me.lblTextoBuscar.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(93, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(397, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(571, 21)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(94, 20)
        Me.rbCodigo.TabIndex = 2
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Por Codigo"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'rbDocumento
        '
        Me.rbDocumento.AutoSize = True
        Me.rbDocumento.Location = New System.Drawing.Point(769, 23)
        Me.rbDocumento.Name = "rbDocumento"
        Me.rbDocumento.Size = New System.Drawing.Size(119, 20)
        Me.rbDocumento.TabIndex = 3
        Me.rbDocumento.TabStop = True
        Me.rbDocumento.Text = "Por Documento"
        Me.rbDocumento.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(561, 292)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(92, 40)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(659, 292)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 40)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guarar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(757, 292)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 40)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(855, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 40)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codígo"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(120, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(257, 22)
        Me.txtId.TabIndex = 2
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(24, 71)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 16)
        Me.lblEstado.TabIndex = 2
        Me.lblEstado.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(120, 68)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(112, 22)
        Me.txtEstado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombres"
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(118, 110)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(257, 22)
        Me.txtNombres.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellidos"
        '
        'txtApellidos
        '
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Location = New System.Drawing.Point(120, 150)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(257, 22)
        Me.txtApellidos.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Documento"
        '
        'txtDocumento
        '
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Location = New System.Drawing.Point(118, 233)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(257, 22)
        Me.txtDocumento.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(405, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Salario Base"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(405, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha de Ingreso"
        '
        'txtSalarioBase
        '
        Me.txtSalarioBase.Enabled = False
        Me.txtSalarioBase.Location = New System.Drawing.Point(561, 19)
        Me.txtSalarioBase.Name = "txtSalarioBase"
        Me.txtSalarioBase.Size = New System.Drawing.Size(190, 22)
        Me.txtSalarioBase.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(561, 116)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(386, 139)
        Me.txtDireccion.TabIndex = 10
        '
        'cmbTipo
        '
        Me.cmbTipo.Enabled = False
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(118, 190)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(257, 24)
        Me.cmbTipo.TabIndex = 6
        '
        'dtpIngreso
        '
        Me.dtpIngreso.Enabled = False
        Me.dtpIngreso.Location = New System.Drawing.Point(561, 68)
        Me.dtpIngreso.Name = "dtpIngreso"
        Me.dtpIngreso.Size = New System.Drawing.Size(259, 22)
        Me.dtpIngreso.TabIndex = 9
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 610)
        Me.Controls.Add(Me.dtpIngreso)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtSalarioBase)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmpleado As DataGridView
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents rbDocumento As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblTextoBuscar As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSalarioBase As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents dtpIngreso As DateTimePicker
End Class
