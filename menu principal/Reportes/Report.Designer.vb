<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Código = New System.Windows.Forms.Label()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_Desde = New System.Windows.Forms.CheckBox()
        Me.cb_Hasta = New System.Windows.Forms.CheckBox()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.txtCP_id = New System.Windows.Forms.TextBox()
        Me.txtCnombre = New System.Windows.Forms.TextBox()
        Me.cbpc = New System.Windows.Forms.ComboBox()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(141, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 477)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Código.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Código.ForeColor = System.Drawing.Color.White
        Me.Código.Location = New System.Drawing.Point(141, 16)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(111, 20)
        Me.Código.TabIndex = 20
        Me.Código.Text = "Tipo de report:"
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.Location = New System.Drawing.Point(145, 252)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(258, 30)
        Me.btn_report.TabIndex = 29
        Me.btn_report.Text = "GENERAR REPORTE"
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'cb_tipo
        '
        Me.cb_tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.cb_tipo.ForeColor = System.Drawing.Color.White
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Stock", "Stock bajo", "Ventas de hoy", "Ventas del mes", "Ventas por parámetros", "Compras por parametros", "Contactos de proveedores"})
        Me.cb_tipo.Location = New System.Drawing.Point(258, 18)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cb_tipo.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabla)
        Me.GroupBox1.Controls.Add(Me.cbpc)
        Me.GroupBox1.Controls.Add(Me.txtCP_id)
        Me.GroupBox1.Controls.Add(Me.txtCnombre)
        Me.GroupBox1.Controls.Add(Me.cb2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_hasta)
        Me.GroupBox1.Controls.Add(Me.dtp_Desde)
        Me.GroupBox1.Controls.Add(Me.cb_Hasta)
        Me.GroupBox1.Controls.Add(Me.cb_Desde)
        Me.GroupBox1.Controls.Add(Me.cb_tipo)
        Me.GroupBox1.Controls.Add(Me.btn_report)
        Me.GroupBox1.Controls.Add(Me.Código)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 471)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGREGAR PROVEEDOR"
        '
        'cb_Desde
        '
        Me.cb_Desde.AutoSize = True
        Me.cb_Desde.BackColor = System.Drawing.Color.White
        Me.cb_Desde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Desde.ForeColor = System.Drawing.Color.Black
        Me.cb_Desde.Location = New System.Drawing.Point(82, 88)
        Me.cb_Desde.Name = "cb_Desde"
        Me.cb_Desde.Size = New System.Drawing.Size(54, 17)
        Me.cb_Desde.TabIndex = 31
        Me.cb_Desde.Text = "Desde"
        Me.cb_Desde.UseVisualStyleBackColor = False
        '
        'cb_Hasta
        '
        Me.cb_Hasta.AutoSize = True
        Me.cb_Hasta.BackColor = System.Drawing.Color.White
        Me.cb_Hasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Hasta.ForeColor = System.Drawing.Color.Black
        Me.cb_Hasta.Location = New System.Drawing.Point(292, 88)
        Me.cb_Hasta.Name = "cb_Hasta"
        Me.cb_Hasta.Size = New System.Drawing.Size(51, 17)
        Me.cb_Hasta.TabIndex = 32
        Me.cb_Hasta.Text = "Hasta"
        Me.cb_Hasta.UseVisualStyleBackColor = False
        '
        'dtp_Desde
        '
        Me.dtp_Desde.CalendarForeColor = System.Drawing.Color.Black
        Me.dtp_Desde.Location = New System.Drawing.Point(82, 111)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(200, 20)
        Me.dtp_Desde.TabIndex = 34
        '
        'dtp_hasta
        '
        Me.dtp_hasta.CalendarForeColor = System.Drawing.Color.Black
        Me.dtp_hasta.Location = New System.Drawing.Point(292, 111)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(200, 20)
        Me.dtp_hasta.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Label1"
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.BackColor = System.Drawing.Color.White
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.ForeColor = System.Drawing.Color.Black
        Me.cb2.Location = New System.Drawing.Point(82, 174)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(72, 17)
        Me.cb2.TabIndex = 37
        Me.cb2.Text = "Proveedor"
        Me.cb2.UseVisualStyleBackColor = False
        '
        'txtCP_id
        '
        Me.txtCP_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCP_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP_id.ForeColor = System.Drawing.Color.White
        Me.txtCP_id.Location = New System.Drawing.Point(82, 199)
        Me.txtCP_id.Name = "txtCP_id"
        Me.txtCP_id.ReadOnly = True
        Me.txtCP_id.Size = New System.Drawing.Size(126, 24)
        Me.txtCP_id.TabIndex = 39
        '
        'txtCnombre
        '
        Me.txtCnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnombre.ForeColor = System.Drawing.Color.White
        Me.txtCnombre.Location = New System.Drawing.Point(214, 199)
        Me.txtCnombre.Name = "txtCnombre"
        Me.txtCnombre.ReadOnly = True
        Me.txtCnombre.Size = New System.Drawing.Size(259, 24)
        Me.txtCnombre.TabIndex = 38
        '
        'cbpc
        '
        Me.cbpc.ForeColor = System.Drawing.Color.Black
        Me.cbpc.FormattingEnabled = True
        Me.cbpc.Location = New System.Drawing.Point(214, 172)
        Me.cbpc.Name = "cbpc"
        Me.cbpc.Size = New System.Drawing.Size(259, 21)
        Me.cbpc.TabIndex = 40
        '
        'tabla
        '
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Location = New System.Drawing.Point(6, 288)
        Me.tabla.Name = "tabla"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.tabla.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.tabla.Size = New System.Drawing.Size(551, 174)
        Me.tabla.TabIndex = 41
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(719, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents btn_report As Button
    Friend WithEvents Código As Label
    Friend WithEvents cb_Hasta As CheckBox
    Friend WithEvents cb_Desde As CheckBox
    Friend WithEvents dtp_hasta As DateTimePicker
    Friend WithEvents dtp_Desde As DateTimePicker
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbpc As ComboBox
    Friend WithEvents txtCP_id As TextBox
    Friend WithEvents txtCnombre As TextBox
    Friend WithEvents tabla As DataGridView
End Class
