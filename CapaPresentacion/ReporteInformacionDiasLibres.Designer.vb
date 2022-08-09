<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteInformacionDiasLibres
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
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDiasLires = New System.Windows.Forms.DataGridView()
        Me.txtBuscarDiasLibres = New System.Windows.Forms.Button()
        Me.txtDiasLibres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDiasLires, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInfo
        '
        Me.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.Location = New System.Drawing.Point(13, 110)
        Me.dgvInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.Size = New System.Drawing.Size(957, 140)
        Me.dgvInfo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(511, 68)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(164, 71)
        Me.txtBuscarCodigo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(339, 21)
        Me.txtBuscarCodigo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo del Empleado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(16, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 53)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Información del Empleado"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(16, 295)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 53)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dias Libres"
        '
        'dgvDiasLires
        '
        Me.dgvDiasLires.AllowUserToAddRows = False
        Me.dgvDiasLires.AllowUserToDeleteRows = False
        Me.dgvDiasLires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDiasLires.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDiasLires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiasLires.Location = New System.Drawing.Point(13, 396)
        Me.dgvDiasLires.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvDiasLires.Name = "dgvDiasLires"
        Me.dgvDiasLires.ReadOnly = True
        Me.dgvDiasLires.Size = New System.Drawing.Size(957, 140)
        Me.dgvDiasLires.TabIndex = 0
        '
        'txtBuscarDiasLibres
        '
        Me.txtBuscarDiasLibres.Location = New System.Drawing.Point(511, 366)
        Me.txtBuscarDiasLibres.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBuscarDiasLibres.Name = "txtBuscarDiasLibres"
        Me.txtBuscarDiasLibres.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscarDiasLibres.TabIndex = 1
        Me.txtBuscarDiasLibres.Text = "Buscar"
        Me.txtBuscarDiasLibres.UseVisualStyleBackColor = True
        '
        'txtDiasLibres
        '
        Me.txtDiasLibres.Location = New System.Drawing.Point(164, 369)
        Me.txtDiasLibres.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDiasLibres.Name = "txtDiasLibres"
        Me.txtDiasLibres.Size = New System.Drawing.Size(339, 21)
        Me.txtDiasLibres.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 369)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Codigo del Empleado"
        '
        'ReporteInformacionDiasLibres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 548)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiasLibres)
        Me.Controls.Add(Me.txtBuscarDiasLibres)
        Me.Controls.Add(Me.txtBuscarCodigo)
        Me.Controls.Add(Me.dgvDiasLires)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvInfo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ReporteInformacionDiasLibres"
        Me.Text = "ReporteInformacionDiasLibres"
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvDiasLires, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInfo As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBuscarCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDiasLires As DataGridView
    Friend WithEvents txtBuscarDiasLibres As Button
    Friend WithEvents txtDiasLibres As TextBox
    Friend WithEvents Label4 As Label
End Class
