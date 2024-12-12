<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prestamos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.lbDias = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabla_prestamos = New System.Windows.Forms.DataGridView()
        Me.tabla_herramienta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla_prestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabla_herramienta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tabla_prestamos)
        Me.Panel1.Controls.Add(Me.tabla_herramienta)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(141, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 477)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(7, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 200)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 100)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Para alquilar una" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "herramienta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selecione una y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "luego rellene el" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "formulario"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtdias)
        Me.GroupBox1.Controls.Add(Me.lbDias)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(7, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 209)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ALQUILERES"
        '
        'txtdias
        '
        Me.txtdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdias.Location = New System.Drawing.Point(15, 39)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(146, 26)
        Me.txtdias.TabIndex = 33
        '
        'lbDias
        '
        Me.lbDias.AutoSize = True
        Me.lbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDias.Location = New System.Drawing.Point(11, 16)
        Me.lbDias.Name = "lbDias"
        Me.lbDias.Size = New System.Drawing.Size(117, 20)
        Me.lbDias.TabIndex = 32
        Me.lbDias.Text = "Días de retraso"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(41, 173)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 30)
        Me.btn_eliminar.TabIndex = 28
        Me.btn_eliminar.Text = "RECIBIDO"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(463, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ALQUILAR HERRAMIENTAS                                                            " &
    ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "HERRAMIENTEAS ALQUILADAS                                                  "
        '
        'tabla_prestamos
        '
        Me.tabla_prestamos.AllowUserToAddRows = False
        Me.tabla_prestamos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabla_prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_prestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tabla_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_prestamos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.tabla_prestamos.Location = New System.Drawing.Point(180, 34)
        Me.tabla_prestamos.MultiSelect = False
        Me.tabla_prestamos.Name = "tabla_prestamos"
        Me.tabla_prestamos.ReadOnly = True
        Me.tabla_prestamos.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.tabla_prestamos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tabla_prestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_prestamos.Size = New System.Drawing.Size(395, 209)
        Me.tabla_prestamos.TabIndex = 9
        Me.tabla_prestamos.TabStop = False
        '
        'tabla_herramienta
        '
        Me.tabla_herramienta.AllowUserToAddRows = False
        Me.tabla_herramienta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabla_herramienta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_herramienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_herramienta.Location = New System.Drawing.Point(180, 269)
        Me.tabla_herramienta.MultiSelect = False
        Me.tabla_herramienta.Name = "tabla_herramienta"
        Me.tabla_herramienta.ReadOnly = True
        Me.tabla_herramienta.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.tabla_herramienta.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.tabla_herramienta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_herramienta.Size = New System.Drawing.Size(395, 196)
        Me.tabla_herramienta.TabIndex = 8
        Me.tabla_herramienta.TabStop = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "codherramienta"
        Me.Column2.HeaderText = "Herramienta"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "fechaprestamo"
        Me.Column3.HeaderText = "Retirado"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "fechalimite"
        Me.Column4.HeaderText = "Límite"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "clienteid"
        Me.Column5.HeaderText = "Cliente"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "‌inicial"
        Me.Column6.HeaderText = "Inicial"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "diario"
        Me.Column7.HeaderText = "diario"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "prestamos"
        Me.Text = "prestamos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tabla_prestamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabla_herramienta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tabla_herramienta As DataGridView
    Friend WithEvents tabla_prestamos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbDias As Label
    Friend WithEvents txtdias As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
