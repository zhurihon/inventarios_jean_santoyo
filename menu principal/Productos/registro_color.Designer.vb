<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_color
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
        Me.gb_color = New System.Windows.Forms.GroupBox()
        Me.btn_modif = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_nuevo_color = New System.Windows.Forms.Button()
        Me.color = New System.Windows.Forms.TextBox()
        Me.Código = New System.Windows.Forms.Label()
        Me.gb_color.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_color
        '
        Me.gb_color.BackColor = System.Drawing.Color.White
        Me.gb_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gb_color.Controls.Add(Me.btn_modif)
        Me.gb_color.Controls.Add(Me.btn_delete)
        Me.gb_color.Controls.Add(Me.btn_nuevo_color)
        Me.gb_color.Controls.Add(Me.color)
        Me.gb_color.Controls.Add(Me.Código)
        Me.gb_color.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.gb_color.Location = New System.Drawing.Point(3, 3)
        Me.gb_color.Name = "gb_color"
        Me.gb_color.Size = New System.Drawing.Size(261, 167)
        Me.gb_color.TabIndex = 6
        Me.gb_color.TabStop = False
        Me.gb_color.Text = "REGISTRAR COLOR"
        Me.gb_color.Visible = False
        '
        'btn_modif
        '
        Me.btn_modif.BackColor = System.Drawing.Color.Cyan
        Me.btn_modif.Enabled = False
        Me.btn_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modif.Location = New System.Drawing.Point(141, 93)
        Me.btn_modif.Name = "btn_modif"
        Me.btn_modif.Size = New System.Drawing.Size(120, 30)
        Me.btn_modif.TabIndex = 14
        Me.btn_modif.Text = "MODIFICAR"
        Me.btn_modif.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(0, 93)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(120, 30)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "ELIMNAR"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_nuevo_color
        '
        Me.btn_nuevo_color.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nuevo_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_color.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_color.Location = New System.Drawing.Point(0, 129)
        Me.btn_nuevo_color.Name = "btn_nuevo_color"
        Me.btn_nuevo_color.Size = New System.Drawing.Size(261, 35)
        Me.btn_nuevo_color.TabIndex = 12
        Me.btn_nuevo_color.Text = "REGISTRA NUEVO COLOR"
        Me.btn_nuevo_color.UseVisualStyleBackColor = False
        '
        'color
        '
        Me.color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color.Location = New System.Drawing.Point(9, 45)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(246, 26)
        Me.color.TabIndex = 5
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Código.Location = New System.Drawing.Point(6, 27)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(176, 20)
        Me.Código.TabIndex = 1
        Me.Código.Text = "Color, material o textura"
        '
        'registro_color
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gb_color)
        Me.Name = "registro_color"
        Me.Text = "registro_color"
        Me.gb_color.ResumeLayout(False)
        Me.gb_color.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_color As GroupBox
    Friend WithEvents btn_modif As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_nuevo_color As Button
    Friend WithEvents color As TextBox
    Friend WithEvents Código As Label
End Class
