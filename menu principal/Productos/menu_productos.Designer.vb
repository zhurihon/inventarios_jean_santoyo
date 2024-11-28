<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_productos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btm_gb_color_material = New System.Windows.Forms.Button()
        Me.btn_gb_marca = New System.Windows.Forms.Button()
        Me.btn_gb_productos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.btm_gb_color_material)
        Me.GroupBox1.Controls.Add(Me.btn_gb_marca)
        Me.GroupBox1.Controls.Add(Me.btn_gb_productos)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 407)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿QUÉ DESEA REGISTRAR?"
        '
        'btm_gb_color_material
        '
        Me.btm_gb_color_material.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btm_gb_color_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btm_gb_color_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btm_gb_color_material.ForeColor = System.Drawing.Color.White
        Me.btm_gb_color_material.Location = New System.Drawing.Point(0, 121)
        Me.btm_gb_color_material.Name = "btm_gb_color_material"
        Me.btm_gb_color_material.Size = New System.Drawing.Size(261, 74)
        Me.btm_gb_color_material.TabIndex = 21
        Me.btm_gb_color_material.Text = "Registrar Colores y Materiales"
        Me.btm_gb_color_material.UseVisualStyleBackColor = False
        '
        'btn_gb_marca
        '
        Me.btn_gb_marca.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_gb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gb_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gb_marca.ForeColor = System.Drawing.Color.White
        Me.btn_gb_marca.Location = New System.Drawing.Point(0, 67)
        Me.btn_gb_marca.Name = "btn_gb_marca"
        Me.btn_gb_marca.Size = New System.Drawing.Size(261, 55)
        Me.btn_gb_marca.TabIndex = 20
        Me.btn_gb_marca.Text = "Registrar Marca"
        Me.btn_gb_marca.UseVisualStyleBackColor = False
        '
        'btn_gb_productos
        '
        Me.btn_gb_productos.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_gb_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gb_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gb_productos.ForeColor = System.Drawing.Color.White
        Me.btn_gb_productos.Location = New System.Drawing.Point(0, 13)
        Me.btn_gb_productos.Name = "btn_gb_productos"
        Me.btn_gb_productos.Size = New System.Drawing.Size(261, 55)
        Me.btn_gb_productos.TabIndex = 19
        Me.btn_gb_productos.Text = "Registrar Producto"
        Me.btn_gb_productos.UseVisualStyleBackColor = False
        '
        'menu_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "menu_productos"
        Me.Text = "menu_productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_gb_productos As Button
    Friend WithEvents btm_gb_color_material As Button
    Friend WithEvents btn_gb_marca As Button
End Class
