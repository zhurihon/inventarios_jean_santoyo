<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registro_producto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo_productos = New System.Windows.Forms.Button()
        Me.tipos = New System.Windows.Forms.ComboBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Código = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo_productos)
        Me.GroupBox1.Controls.Add(Me.tipos)
        Me.GroupBox1.Controls.Add(Me.precio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Código)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 111)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTOS"
        Me.GroupBox1.Visible = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.White
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.btn_modificar.ForeColor = System.Drawing.Color.Black
        Me.btn_modificar.Location = New System.Drawing.Point(440, 43)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(120, 30)
        Me.btn_modificar.TabIndex = 14
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.White
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Location = New System.Drawing.Point(440, 77)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 30)
        Me.btn_eliminar.TabIndex = 13
        Me.btn_eliminar.Text = "ELIMNAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_nuevo_productos
        '
        Me.btn_nuevo_productos.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_productos.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.btn_nuevo_productos.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_productos.Location = New System.Drawing.Point(440, 9)
        Me.btn_nuevo_productos.Name = "btn_nuevo_productos"
        Me.btn_nuevo_productos.Size = New System.Drawing.Size(120, 30)
        Me.btn_nuevo_productos.TabIndex = 12
        Me.btn_nuevo_productos.Text = "REGISTRAR"
        Me.btn_nuevo_productos.UseVisualStyleBackColor = False
        '
        'tipos
        '
        Me.tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipos.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.tipos.FormattingEnabled = True
        Me.tipos.Items.AddRange(New Object() {"Herramienta", "Repuesto", "Aceites", "Otros"})
        Me.tipos.Location = New System.Drawing.Point(97, 34)
        Me.tipos.Name = "tipos"
        Me.tipos.Size = New System.Drawing.Size(159, 26)
        Me.tipos.TabIndex = 9
        '
        'precio
        '
        Me.precio.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.precio.Location = New System.Drawing.Point(266, 34)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(133, 26)
        Me.precio.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(263, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "PRECIO:"
        '
        'codigo
        '
        Me.codigo.Enabled = False
        Me.codigo.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.codigo.Location = New System.Drawing.Point(5, 34)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(86, 26)
        Me.codigo.TabIndex = 5
        '
        'nombre
        '
        Me.nombre.BackColor = System.Drawing.Color.White
        Me.nombre.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.nombre.Location = New System.Drawing.Point(97, 66)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(302, 26)
        Me.nombre.TabIndex = 4
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.Código.ForeColor = System.Drawing.Color.White
        Me.Código.Location = New System.Drawing.Point(2, 16)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(80, 18)
        Me.Código.TabIndex = 1
        Me.Código.Text = "CÓDIGO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(94, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TIPO:"
        '
        'registro_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "registro_producto"
        Me.Text = "u"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_nuevo_productos As Button
    Friend WithEvents tipos As ComboBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents Código As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents precio As TextBox
    Friend WithEvents Label7 As Label
End Class
