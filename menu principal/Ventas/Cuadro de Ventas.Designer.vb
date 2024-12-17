<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cuadro_de_Ventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMontoServicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmontopagar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.rbVes = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCidview = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCnombreView = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbDivisa = New System.Windows.Forms.RadioButton()
        Me.ticket = New System.Windows.Forms.DataGridView()
        Me.ccod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtigtf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.lbiva = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Código = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla.Location = New System.Drawing.Point(3, 361)
        Me.tabla.MultiSelect = False
        Me.tabla.Name = "tabla"
        Me.tabla.ReadOnly = True
        Me.tabla.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.tabla.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla.Size = New System.Drawing.Size(572, 104)
        Me.tabla.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tabla)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(141, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 477)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "BUSCAR"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(83, 329)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(246, 26)
        Me.txtBuscar.TabIndex = 25
        Me.txtBuscar.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtmontopagar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.rbVes)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.rbDivisa)
        Me.GroupBox1.Controls.Add(Me.ticket)
        Me.GroupBox1.Controls.Add(Me.txtigtf)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtiva)
        Me.GroupBox1.Controls.Add(Me.lbiva)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 320)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMULARIO DE SERVICIOS"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Controls.Add(Me.txtMontoServicio)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(6, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 148)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Servicio"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(173, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 26)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "SERVICIOS COMUNES"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(10, 47)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(326, 68)
        Me.txtDescripcion.TabIndex = 35
        '
        'txtMontoServicio
        '
        Me.txtMontoServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtMontoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoServicio.ForeColor = System.Drawing.Color.White
        Me.txtMontoServicio.Location = New System.Drawing.Point(218, 121)
        Me.txtMontoServicio.Name = "txtMontoServicio"
        Me.txtMontoServicio.Size = New System.Drawing.Size(118, 26)
        Me.txtMontoServicio.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "MONTO SERVICIO:"
        '
        'txtmontopagar
        '
        Me.txtmontopagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtmontopagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontopagar.ForeColor = System.Drawing.Color.White
        Me.txtmontopagar.Location = New System.Drawing.Point(466, 300)
        Me.txtmontopagar.Name = "txtmontopagar"
        Me.txtmontopagar.Size = New System.Drawing.Size(100, 20)
        Me.txtmontopagar.TabIndex = 47
        Me.txtmontopagar.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(369, 300)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "TOTAL A PAGAR:"
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.Color.White
        Me.btn_modificar.Location = New System.Drawing.Point(230, 282)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(118, 30)
        Me.btn_modificar.TabIndex = 29
        Me.btn_modificar.Text = "Facturar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'rbVes
        '
        Me.rbVes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbVes.AutoSize = True
        Me.rbVes.Location = New System.Drawing.Point(65, 290)
        Me.rbVes.Name = "rbVes"
        Me.rbVes.Size = New System.Drawing.Size(70, 17)
        Me.rbVes.TabIndex = 41
        Me.rbVes.Text = "Bolívares"
        Me.rbVes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.txtCidview)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtCnombreView)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 98)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cliente selecionado:"
        '
        'txtCidview
        '
        Me.txtCidview.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCidview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidview.ForeColor = System.Drawing.Color.White
        Me.txtCidview.Location = New System.Drawing.Point(124, 66)
        Me.txtCidview.Name = "txtCidview"
        Me.txtCidview.Size = New System.Drawing.Size(212, 26)
        Me.txtCidview.TabIndex = 45
        Me.txtCidview.Text = "No selecionado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "DOCUMENTO"
        '
        'txtCnombreView
        '
        Me.txtCnombreView.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCnombreView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnombreView.ForeColor = System.Drawing.Color.White
        Me.txtCnombreView.Location = New System.Drawing.Point(124, 41)
        Me.txtCnombreView.Name = "txtCnombreView"
        Me.txtCnombreView.Size = New System.Drawing.Size(212, 26)
        Me.txtCnombreView.TabIndex = 43
        Me.txtCnombreView.Text = "No selecionado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "NOMBRE:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(173, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 25)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "SELECIONAR CLIENTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rbDivisa
        '
        Me.rbDivisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDivisa.AutoSize = True
        Me.rbDivisa.Location = New System.Drawing.Point(6, 290)
        Me.rbDivisa.Name = "rbDivisa"
        Me.rbDivisa.Size = New System.Drawing.Size(54, 17)
        Me.rbDivisa.TabIndex = 40
        Me.rbDivisa.Text = "Divisa"
        Me.rbDivisa.UseVisualStyleBackColor = True
        '
        'ticket
        '
        Me.ticket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ticket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ticket.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ticket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccod, Me.cnombre, Me.cprecio, Me.ccantidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ticket.DefaultCellStyle = DataGridViewCellStyle2
        Me.ticket.Location = New System.Drawing.Point(369, 19)
        Me.ticket.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.ticket.MultiSelect = False
        Me.ticket.Name = "ticket"
        Me.ticket.ReadOnly = True
        Me.ticket.RowHeadersVisible = False
        Me.ticket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ticket.Size = New System.Drawing.Size(197, 227)
        Me.ticket.TabIndex = 9
        '
        'ccod
        '
        Me.ccod.DataPropertyName = "cod"
        Me.ccod.HeaderText = "Código"
        Me.ccod.Name = "ccod"
        Me.ccod.ReadOnly = True
        Me.ccod.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cnombre
        '
        Me.cnombre.DataPropertyName = "nombre"
        Me.cnombre.HeaderText = "Nombre"
        Me.cnombre.Name = "cnombre"
        Me.cnombre.ReadOnly = True
        Me.cnombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cnombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cprecio
        '
        Me.cprecio.DataPropertyName = "precio"
        Me.cprecio.HeaderText = "Precio"
        Me.cprecio.Name = "cprecio"
        Me.cprecio.ReadOnly = True
        Me.cprecio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cprecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ccantidad
        '
        Me.ccantidad.DataPropertyName = "cantidad"
        Me.ccantidad.HeaderText = "Cantidad"
        Me.ccantidad.Name = "ccantidad"
        Me.ccantidad.ReadOnly = True
        Me.ccantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ccantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtigtf
        '
        Me.txtigtf.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtigtf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigtf.ForeColor = System.Drawing.Color.White
        Me.txtigtf.Location = New System.Drawing.Point(466, 282)
        Me.txtigtf.Margin = New System.Windows.Forms.Padding(0)
        Me.txtigtf.Name = "txtigtf"
        Me.txtigtf.Size = New System.Drawing.Size(100, 20)
        Me.txtigtf.TabIndex = 45
        Me.txtigtf.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(369, 285)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "IGTF:"
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.White
        Me.txtiva.Location = New System.Drawing.Point(466, 263)
        Me.txtiva.Margin = New System.Windows.Forms.Padding(0)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(100, 20)
        Me.txtiva.TabIndex = 43
        Me.txtiva.Text = "0"
        '
        'lbiva
        '
        Me.lbiva.AutoSize = True
        Me.lbiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbiva.ForeColor = System.Drawing.Color.White
        Me.lbiva.Location = New System.Drawing.Point(369, 266)
        Me.lbiva.Margin = New System.Windows.Forms.Padding(0)
        Me.lbiva.Name = "lbiva"
        Me.lbiva.Size = New System.Drawing.Size(27, 13)
        Me.lbiva.TabIndex = 42
        Me.lbiva.Text = "IVA:"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(466, 246)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 39
        Me.txt_total.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(369, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "TOTAL:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Me.Código)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 170)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUCTO SELECIONADO:"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(77, 139)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(63, 26)
        Me.txtPrecio.TabIndex = 27
        Me.txtPrecio.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "PRECIO:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(77, 109)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(63, 26)
        Me.txtCantidad.TabIndex = 25
        Me.txtCantidad.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "STOCK:"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.White
        Me.txtnombre.Location = New System.Drawing.Point(5, 83)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(185, 26)
        Me.txtnombre.TabIndex = 22
        Me.txtnombre.TabStop = False
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.Location = New System.Drawing.Point(5, 35)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(114, 26)
        Me.id.TabIndex = 23
        Me.id.TabStop = False
        '
        'Código
        '
        Me.Código.AutoSize = True
        Me.Código.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Código.Location = New System.Drawing.Point(3, 17)
        Me.Código.Name = "Código"
        Me.Código.Size = New System.Drawing.Size(142, 20)
        Me.Código.TabIndex = 20
        Me.Código.Text = "IDENTIFICACIÓN:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "NOMBRE:"
        '
        'Cuadro_de_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Cuadro_de_Ventas"
        Me.Text = "Cuadro_de_Ventas"
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ticket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_modificar As Button
    Friend WithEvents id As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Código As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabla As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ticket As DataGridView
    Friend WithEvents txtMontoServicio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ccod As DataGridViewTextBoxColumn
    Friend WithEvents cnombre As DataGridViewTextBoxColumn
    Friend WithEvents cprecio As DataGridViewTextBoxColumn
    Friend WithEvents ccantidad As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCidview As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCnombreView As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbVes As RadioButton
    Friend WithEvents rbDivisa As RadioButton
    Friend WithEvents txtmontopagar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtigtf As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtiva As TextBox
    Friend WithEvents lbiva As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBuscar As TextBox
End Class
