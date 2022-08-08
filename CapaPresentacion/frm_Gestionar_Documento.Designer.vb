<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Gestionar_Documento
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
        Me.dgvDocumento = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDocumento
        '
        Me.dgvDocumento.AllowUserToAddRows = False
        Me.dgvDocumento.AllowUserToDeleteRows = False
        Me.dgvDocumento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDocumento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumento.Location = New System.Drawing.Point(12, 280)
        Me.dgvDocumento.Name = "dgvDocumento"
        Me.dgvDocumento.ReadOnly = True
        Me.dgvDocumento.Size = New System.Drawing.Size(495, 137)
        Me.dgvDocumento.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbCodigo)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar tipo de documento datos por"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(313, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 22)
        Me.TextBox1.TabIndex = 0
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(46, 29)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(70, 20)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Codígo"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(179, 29)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(75, 20)
        Me.rbNombre.TabIndex = 1
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codígo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(129, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(108, 22)
        Me.txtCodigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(129, 74)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(108, 22)
        Me.txtEstado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(129, 126)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(108, 22)
        Me.txtTipo.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(325, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(124, 26)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(325, 51)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(124, 26)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(325, 92)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 26)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(325, 124)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(124, 26)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frm_Gestionar_Documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 428)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDocumento)
        Me.Name = "frm_Gestionar_Documento"
        Me.Text = "Gestionar Documento"
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDocumento As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
End Class
