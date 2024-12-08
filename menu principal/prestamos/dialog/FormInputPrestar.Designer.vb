<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputPrestar
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
        Me.txtHcod = New System.Windows.Forms.TextBox()
        Me.txtHnombre = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCid = New System.Windows.Forms.TextBox()
        Me.txtCnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpLimite = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtHcod
        '
        Me.txtHcod.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtHcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHcod.ForeColor = System.Drawing.Color.White
        Me.txtHcod.Location = New System.Drawing.Point(12, 76)
        Me.txtHcod.Name = "txtHcod"
        Me.txtHcod.ReadOnly = True
        Me.txtHcod.Size = New System.Drawing.Size(89, 24)
        Me.txtHcod.TabIndex = 23
        '
        'txtHnombre
        '
        Me.txtHnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtHnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHnombre.ForeColor = System.Drawing.Color.White
        Me.txtHnombre.Location = New System.Drawing.Point(107, 76)
        Me.txtHnombre.Name = "txtHnombre"
        Me.txtHnombre.ReadOnly = True
        Me.txtHnombre.Size = New System.Drawing.Size(223, 24)
        Me.txtHnombre.TabIndex = 21
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
        Me.btnRegistrar.Text = "Registrar préstamo"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "PRESTAR HERRAMIENTA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(84, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 28)
        Me.Button1.TabIndex = 24
        Me.Button1.TabStop = False
        Me.Button1.Text = "Selecionar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Herramienta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Cliente/Empresa"
        '
        'txtCid
        '
        Me.txtCid.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCid.ForeColor = System.Drawing.Color.White
        Me.txtCid.Location = New System.Drawing.Point(14, 146)
        Me.txtCid.Name = "txtCid"
        Me.txtCid.ReadOnly = True
        Me.txtCid.Size = New System.Drawing.Size(89, 24)
        Me.txtCid.TabIndex = 34
        '
        'txtCnombre
        '
        Me.txtCnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnombre.ForeColor = System.Drawing.Color.White
        Me.txtCnombre.Location = New System.Drawing.Point(109, 146)
        Me.txtCnombre.Name = "txtCnombre"
        Me.txtCnombre.ReadOnly = True
        Me.txtCnombre.Size = New System.Drawing.Size(223, 24)
        Me.txtCnombre.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Fecha límite"
        '
        'dtpLimite
        '
        Me.dtpLimite.Location = New System.Drawing.Point(84, 247)
        Me.dtpLimite.Name = "dtpLimite"
        Me.dtpLimite.Size = New System.Drawing.Size(200, 20)
        Me.dtpLimite.TabIndex = 36
        '
        'FormInputPrestar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 399)
        Me.Controls.Add(Me.dtpLimite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCid)
        Me.Controls.Add(Me.txtCnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtHcod)
        Me.Controls.Add(Me.txtHnombre)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormInputPrestar"
        Me.Text = "FormImputPrestar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHcod As TextBox
    Friend WithEvents txtHnombre As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCid As TextBox
    Friend WithEvents txtCnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpLimite As DateTimePicker
End Class
