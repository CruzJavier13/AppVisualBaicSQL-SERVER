<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacaciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtCodigoVacacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpD = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpH = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.btnGuardarVacaion = New System.Windows.Forms.Button()
        Me.btnCancelarGenerar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvVacaciones = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGenerar = New System.Windows.Forms.TextBox()
        Me.btnGenerarPago = New System.Windows.Forms.Button()
        Me.btnCancelarGenerarPago = New System.Windows.Forms.Button()
        Me.btnGuardarPago = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.txtCodigoVacacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.txtCodigoEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar dias libres a cuenta de vacaciones"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(649, 68)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(80, 26)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtCodigoVacacion
        '
        Me.txtCodigoVacacion.Enabled = False
        Me.txtCodigoVacacion.Location = New System.Drawing.Point(155, 20)
        Me.txtCodigoVacacion.Name = "txtCodigoVacacion"
        Me.txtCodigoVacacion.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoVacacion.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Codígo de vacación"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(851, 68)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 26)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(765, 68)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 26)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(563, 68)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(80, 26)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(811, 20)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(120, 21)
        Me.dtpHasta.TabIndex = 3
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(622, 20)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(116, 21)
        Me.dtpDesde.TabIndex = 2
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.Enabled = False
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(428, 20)
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(117, 21)
        Me.txtCodigoEmpleado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(761, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codígo del Empleado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtEmpleado)
        Me.GroupBox2.Controls.Add(Me.btnCancelarGenerar)
        Me.GroupBox2.Controls.Add(Me.btnGuardarVacaion)
        Me.GroupBox2.Controls.Add(Me.btnGenerar)
        Me.GroupBox2.Controls.Add(Me.dtpH)
        Me.GroupBox2.Controls.Add(Me.dtpD)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(937, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generar vacaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(75, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(95, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Codígo de Empleado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(621, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Desde"
        '
        'dtpD
        '
        Me.dtpD.Enabled = False
        Me.dtpD.Location = New System.Drawing.Point(680, 72)
        Me.dtpD.Name = "dtpD"
        Me.dtpD.Size = New System.Drawing.Size(251, 21)
        Me.dtpD.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(621, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Hasta"
        '
        'dtpH
        '
        Me.dtpH.Enabled = False
        Me.dtpH.Location = New System.Drawing.Point(683, 26)
        Me.dtpH.Name = "dtpH"
        Me.dtpH.Size = New System.Drawing.Size(248, 21)
        Me.dtpH.TabIndex = 2
        '
        'btnGenerar
        '
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Location = New System.Drawing.Point(305, 72)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 26)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(350, 28)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(100, 21)
        Me.txtEmpleado.TabIndex = 4
        '
        'btnGuardarVacaion
        '
        Me.btnGuardarVacaion.Enabled = False
        Me.btnGuardarVacaion.Location = New System.Drawing.Point(386, 71)
        Me.btnGuardarVacaion.Name = "btnGuardarVacaion"
        Me.btnGuardarVacaion.Size = New System.Drawing.Size(75, 26)
        Me.btnGuardarVacaion.TabIndex = 3
        Me.btnGuardarVacaion.Text = "Guardar"
        Me.btnGuardarVacaion.UseVisualStyleBackColor = True
        '
        'btnCancelarGenerar
        '
        Me.btnCancelarGenerar.Enabled = False
        Me.btnCancelarGenerar.Location = New System.Drawing.Point(470, 71)
        Me.btnCancelarGenerar.Name = "btnCancelarGenerar"
        Me.btnCancelarGenerar.Size = New System.Drawing.Size(75, 26)
        Me.btnCancelarGenerar.TabIndex = 3
        Me.btnCancelarGenerar.Text = "Cancelar"
        Me.btnCancelarGenerar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(467, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(517, 28)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(80, 21)
        Me.txtSaldo.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Controls.Add(Me.btnGuardarPago)
        Me.GroupBox3.Controls.Add(Me.btnCancelarGenerarPago)
        Me.GroupBox3.Controls.Add(Me.btnGenerarPago)
        Me.GroupBox3.Controls.Add(Me.txtGenerar)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.dgvVacaciones)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(937, 228)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pago de vacaciones"
        '
        'dgvVacaciones
        '
        Me.dgvVacaciones.AllowUserToAddRows = False
        Me.dgvVacaciones.AllowUserToDeleteRows = False
        Me.dgvVacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVacaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVacaciones.Location = New System.Drawing.Point(6, 99)
        Me.dgvVacaciones.Name = "dgvVacaciones"
        Me.dgvVacaciones.ReadOnly = True
        Me.dgvVacaciones.Size = New System.Drawing.Size(925, 123)
        Me.dgvVacaciones.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Codigo del Empleado"
        '
        'txtGenerar
        '
        Me.txtGenerar.Location = New System.Drawing.Point(200, 29)
        Me.txtGenerar.Name = "txtGenerar"
        Me.txtGenerar.Size = New System.Drawing.Size(195, 22)
        Me.txtGenerar.TabIndex = 2
        '
        'btnGenerarPago
        '
        Me.btnGenerarPago.Location = New System.Drawing.Point(12, 70)
        Me.btnGenerarPago.Name = "btnGenerarPago"
        Me.btnGenerarPago.Size = New System.Drawing.Size(153, 23)
        Me.btnGenerarPago.TabIndex = 3
        Me.btnGenerarPago.Text = "Generar Pago"
        Me.btnGenerarPago.UseVisualStyleBackColor = True
        '
        'btnCancelarGenerarPago
        '
        Me.btnCancelarGenerarPago.Enabled = False
        Me.btnCancelarGenerarPago.Location = New System.Drawing.Point(280, 70)
        Me.btnCancelarGenerarPago.Name = "btnCancelarGenerarPago"
        Me.btnCancelarGenerarPago.Size = New System.Drawing.Size(115, 23)
        Me.btnCancelarGenerarPago.TabIndex = 3
        Me.btnCancelarGenerarPago.Text = "Cancelar"
        Me.btnCancelarGenerarPago.UseVisualStyleBackColor = True
        '
        'btnGuardarPago
        '
        Me.btnGuardarPago.Enabled = False
        Me.btnGuardarPago.Location = New System.Drawing.Point(171, 70)
        Me.btnGuardarPago.Name = "btnGuardarPago"
        Me.btnGuardarPago.Size = New System.Drawing.Size(98, 23)
        Me.btnGuardarPago.TabIndex = 3
        Me.btnGuardarPago.Text = "Guardar"
        Me.btnGuardarPago.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(522, 32)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(409, 61)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(425, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Descripción"
        '
        'Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 488)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Vacaciones"
        Me.Text = "Vacaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents txtCodigoEmpleado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoVacacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpH As DateTimePicker
    Friend WithEvents dtpD As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents btnCancelarGenerar As Button
    Friend WithEvents btnGuardarVacaion As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvVacaciones As DataGridView
    Friend WithEvents btnCancelarGenerarPago As Button
    Friend WithEvents btnGenerarPago As Button
    Friend WithEvents txtGenerar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGuardarPago As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDescripcion As TextBox
End Class
