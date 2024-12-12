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
        Me.txtinicial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdiario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.lbshowdias = New System.Windows.Forms.Label()
        Me.rbVes = New System.Windows.Forms.RadioButton()
        Me.rbDivisa = New System.Windows.Forms.RadioButton()
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
        Me.btnCancelar.Location = New System.Drawing.Point(14, 422)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(130, 422)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(200, 28)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.TabStop = False
        Me.btnRegistrar.Text = "ALQUILAR"
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
        Me.Label1.Size = New System.Drawing.Size(244, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ALQUILAR HERRAMIENTA"
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
        Me.dtpLimite.CustomFormat = "ddddd, dd MMMMM yyyy - hh:mm"
        Me.dtpLimite.Location = New System.Drawing.Point(69, 247)
        Me.dtpLimite.MinDate = New Date(2024, 12, 12, 0, 0, 0, 0)
        Me.dtpLimite.Name = "dtpLimite"
        Me.dtpLimite.Size = New System.Drawing.Size(226, 20)
        Me.dtpLimite.TabIndex = 36
        Me.dtpLimite.Value = New Date(2024, 12, 12, 0, 0, 0, 0)
        '
        'txtinicial
        '
        Me.txtinicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinicial.ForeColor = System.Drawing.Color.White
        Me.txtinicial.Location = New System.Drawing.Point(69, 305)
        Me.txtinicial.Name = "txtinicial"
        Me.txtinicial.Size = New System.Drawing.Size(76, 24)
        Me.txtinicial.TabIndex = 38
        Me.txtinicial.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Costo"
        '
        'txtdiario
        '
        Me.txtdiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtdiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiario.ForeColor = System.Drawing.Color.White
        Me.txtdiario.Location = New System.Drawing.Point(206, 305)
        Me.txtdiario.Name = "txtdiario"
        Me.txtdiario.Size = New System.Drawing.Size(89, 24)
        Me.txtdiario.TabIndex = 39
        Me.txtdiario.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Inicial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(151, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Diario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(74, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Total:"
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.ForeColor = System.Drawing.Color.White
        Me.lbtotal.Location = New System.Drawing.Point(130, 349)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(26, 29)
        Me.lbtotal.TabIndex = 43
        Me.lbtotal.Text = "0"
        '
        'lbshowdias
        '
        Me.lbshowdias.AutoSize = True
        Me.lbshowdias.BackColor = System.Drawing.Color.Transparent
        Me.lbshowdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbshowdias.ForeColor = System.Drawing.Color.White
        Me.lbshowdias.Location = New System.Drawing.Point(65, 277)
        Me.lbshowdias.Name = "lbshowdias"
        Me.lbshowdias.Size = New System.Drawing.Size(0, 20)
        Me.lbshowdias.TabIndex = 44
        '
        'rbVes
        '
        Me.rbVes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbVes.AutoSize = True
        Me.rbVes.Location = New System.Drawing.Point(75, 381)
        Me.rbVes.Name = "rbVes"
        Me.rbVes.Size = New System.Drawing.Size(70, 17)
        Me.rbVes.TabIndex = 46
        Me.rbVes.Text = "Bolívares"
        Me.rbVes.UseVisualStyleBackColor = True
        '
        'rbDivisa
        '
        Me.rbDivisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDivisa.AutoSize = True
        Me.rbDivisa.Location = New System.Drawing.Point(16, 381)
        Me.rbDivisa.Name = "rbDivisa"
        Me.rbDivisa.Size = New System.Drawing.Size(54, 17)
        Me.rbDivisa.TabIndex = 45
        Me.rbDivisa.Text = "Divisa"
        Me.rbDivisa.UseVisualStyleBackColor = True
        '
        'FormInputPrestar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 462)
        Me.Controls.Add(Me.rbVes)
        Me.Controls.Add(Me.rbDivisa)
        Me.Controls.Add(Me.lbshowdias)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdiario)
        Me.Controls.Add(Me.txtinicial)
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormInputPrestar"
        Me.Text = "Alquiler de herramientas"
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
    Friend WithEvents txtinicial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdiario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbtotal As Label
    Friend WithEvents lbshowdias As Label
    Friend WithEvents rbVes As RadioButton
    Friend WithEvents rbDivisa As RadioButton
End Class
