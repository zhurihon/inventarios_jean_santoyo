<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImputPrestar
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtservicio = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Precio:"
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.White
        Me.txtprecio.Location = New System.Drawing.Point(130, 106)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(202, 24)
        Me.txtprecio.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Servicio:"
        '
        'txtservicio
        '
        Me.txtservicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtservicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservicio.ForeColor = System.Drawing.Color.White
        Me.txtservicio.Location = New System.Drawing.Point(130, 78)
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.Size = New System.Drawing.Size(202, 24)
        Me.txtservicio.TabIndex = 21
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(16, 352)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 28)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(132, 352)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(200, 28)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.TabStop = False
        Me.btnRegistrar.Text = "Selecionar este servicio"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabla.Location = New System.Drawing.Point(12, 140)
        Me.tabla.Name = "tabla"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.tabla.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.tabla.Size = New System.Drawing.Size(320, 204)
        Me.tabla.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buscar Servicio:"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(12, 45)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(320, 24)
        Me.txtBuscar.TabIndex = 16
        '
        'FormImputServiciosComunes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 399)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtservicio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormImputServiciosComunes"
        Me.Text = "FormImputServiciosComunes"
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtservicio As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents tabla As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
End Class
