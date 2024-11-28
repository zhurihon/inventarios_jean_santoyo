<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmt_Reporte = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerReporteSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosMásVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasVendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenosVendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeHoyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelUltimoMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDelAñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesConMasVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeHoyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDelAñoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltimasComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresMasCompradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresMenosCompradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoDeTodosLosProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónDeTodosLosProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panel_excel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rb_inv = New System.Windows.Forms.RadioButton()
        Me.cb_ffin = New System.Windows.Forms.CheckBox()
        Me.cb_finicio = New System.Windows.Forms.CheckBox()
        Me.rb_compras = New System.Windows.Forms.RadioButton()
        Me.rb_ventas = New System.Windows.Forms.RadioButton()
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.cmt_Reporte.SuspendLayout()
        Me.panel_excel.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tabla)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(141, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 477)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.panel_excel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rb_inv)
        Me.GroupBox1.Controls.Add(Me.cb_ffin)
        Me.GroupBox1.Controls.Add(Me.cb_finicio)
        Me.GroupBox1.Controls.Add(Me.rb_compras)
        Me.GroupBox1.Controls.Add(Me.rb_ventas)
        Me.GroupBox1.Controls.Add(Me.dtp_fin)
        Me.GroupBox1.Controls.Add(Me.dtp_desde)
        Me.GroupBox1.Controls.Add(Me.txtBuscador)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 52)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.ContextMenuStrip = Me.cmt_Reporte
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(328, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 20)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Reporte"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmt_Reporte
        '
        Me.cmt_Reporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerReporteSelecionadoToolStripMenuItem})
        Me.cmt_Reporte.Name = "cmt_Reporte"
        Me.cmt_Reporte.Size = New System.Drawing.Size(132, 26)
        Me.cmt_Reporte.Text = "Reportar"
        '
        'VerReporteSelecionadoToolStripMenuItem
        '
        Me.VerReporteSelecionadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosMásVendidosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ProveedorToolStripMenuItem})
        Me.VerReporteSelecionadoToolStripMenuItem.Name = "VerReporteSelecionadoToolStripMenuItem"
        Me.VerReporteSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.VerReporteSelecionadoToolStripMenuItem.Text = "Ver reporte"
        '
        'ProductosMásVendidosToolStripMenuItem
        '
        Me.ProductosMásVendidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasVendidoToolStripMenuItem, Me.MenosVendidoToolStripMenuItem})
        Me.ProductosMásVendidosToolStripMenuItem.Name = "ProductosMásVendidosToolStripMenuItem"
        Me.ProductosMásVendidosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosMásVendidosToolStripMenuItem.Text = "Productos"
        '
        'MasVendidoToolStripMenuItem
        '
        Me.MasVendidoToolStripMenuItem.Name = "MasVendidoToolStripMenuItem"
        Me.MasVendidoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MasVendidoToolStripMenuItem.Text = "Mas vendido"
        '
        'MenosVendidoToolStripMenuItem
        '
        Me.MenosVendidoToolStripMenuItem.Name = "MenosVendidoToolStripMenuItem"
        Me.MenosVendidoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenosVendidoToolStripMenuItem.Text = "Menos vendido"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeHoyToolStripMenuItem, Me.DelUltimoMesToolStripMenuItem, Me.TotalDelAñoToolStripMenuItem, Me.MesConMasVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'DeHoyToolStripMenuItem
        '
        Me.DeHoyToolStripMenuItem.Name = "DeHoyToolStripMenuItem"
        Me.DeHoyToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DeHoyToolStripMenuItem.Text = "De hoy"
        '
        'DelUltimoMesToolStripMenuItem
        '
        Me.DelUltimoMesToolStripMenuItem.Name = "DelUltimoMesToolStripMenuItem"
        Me.DelUltimoMesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DelUltimoMesToolStripMenuItem.Text = "Del ultimo mes"
        '
        'TotalDelAñoToolStripMenuItem
        '
        Me.TotalDelAñoToolStripMenuItem.Name = "TotalDelAñoToolStripMenuItem"
        Me.TotalDelAñoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TotalDelAñoToolStripMenuItem.Text = "Total del año"
        '
        'MesConMasVentasToolStripMenuItem
        '
        Me.MesConMasVentasToolStripMenuItem.Name = "MesConMasVentasToolStripMenuItem"
        Me.MesConMasVentasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MesConMasVentasToolStripMenuItem.Text = "Mes con mas ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeHoyToolStripMenuItem1, Me.DelMesToolStripMenuItem, Me.TotalDelAñoToolStripMenuItem1})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'DeHoyToolStripMenuItem1
        '
        Me.DeHoyToolStripMenuItem1.Name = "DeHoyToolStripMenuItem1"
        Me.DeHoyToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.DeHoyToolStripMenuItem1.Text = "De hoy"
        '
        'DelMesToolStripMenuItem
        '
        Me.DelMesToolStripMenuItem.Name = "DelMesToolStripMenuItem"
        Me.DelMesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.DelMesToolStripMenuItem.Text = "Del mes"
        '
        'TotalDelAñoToolStripMenuItem1
        '
        Me.TotalDelAñoToolStripMenuItem1.Name = "TotalDelAñoToolStripMenuItem1"
        Me.TotalDelAñoToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.TotalDelAñoToolStripMenuItem1.Text = "Total del año"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UltimasComprasToolStripMenuItem, Me.ProveedoresMasCompradosToolStripMenuItem, Me.ProveedoresMenosCompradosToolStripMenuItem, Me.ContactoDeTodosLosProveedoresToolStripMenuItem, Me.InformaciónDeTodosLosProveedoresToolStripMenuItem})
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'UltimasComprasToolStripMenuItem
        '
        Me.UltimasComprasToolStripMenuItem.Name = "UltimasComprasToolStripMenuItem"
        Me.UltimasComprasToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.UltimasComprasToolStripMenuItem.Text = "Ultima compra por proveedor"
        '
        'ProveedoresMasCompradosToolStripMenuItem
        '
        Me.ProveedoresMasCompradosToolStripMenuItem.Name = "ProveedoresMasCompradosToolStripMenuItem"
        Me.ProveedoresMasCompradosToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.ProveedoresMasCompradosToolStripMenuItem.Text = "Proveedores mas comprados"
        '
        'ProveedoresMenosCompradosToolStripMenuItem
        '
        Me.ProveedoresMenosCompradosToolStripMenuItem.Name = "ProveedoresMenosCompradosToolStripMenuItem"
        Me.ProveedoresMenosCompradosToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.ProveedoresMenosCompradosToolStripMenuItem.Text = "Proveedores menos comprados"
        '
        'ContactoDeTodosLosProveedoresToolStripMenuItem
        '
        Me.ContactoDeTodosLosProveedoresToolStripMenuItem.Name = "ContactoDeTodosLosProveedoresToolStripMenuItem"
        Me.ContactoDeTodosLosProveedoresToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.ContactoDeTodosLosProveedoresToolStripMenuItem.Text = "Contacto de todos los proveedores"
        '
        'InformaciónDeTodosLosProveedoresToolStripMenuItem
        '
        Me.InformaciónDeTodosLosProveedoresToolStripMenuItem.Name = "InformaciónDeTodosLosProveedoresToolStripMenuItem"
        Me.InformaciónDeTodosLosProveedoresToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.InformaciónDeTodosLosProveedoresToolStripMenuItem.Text = "Información de todos los proveedores"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.SantoyoSys.My.Resources.Resources.excel
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(378, 27)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 20)
        Me.Panel3.TabIndex = 48
        '
        'panel_excel
        '
        Me.panel_excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panel_excel.Controls.Add(Me.Label1)
        Me.panel_excel.ForeColor = System.Drawing.Color.White
        Me.panel_excel.Location = New System.Drawing.Point(328, 27)
        Me.panel_excel.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_excel.Name = "panel_excel"
        Me.panel_excel.Size = New System.Drawing.Size(77, 20)
        Me.panel_excel.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exportar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.BackgroundImage = Global.SantoyoSys.My.Resources.Resources.lupa2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Location = New System.Drawing.Point(293, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 28)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rb_inv
        '
        Me.rb_inv.AutoSize = True
        Me.rb_inv.BackColor = System.Drawing.Color.Transparent
        Me.rb_inv.Location = New System.Drawing.Point(3, 2)
        Me.rb_inv.Name = "rb_inv"
        Me.rb_inv.Size = New System.Drawing.Size(91, 17)
        Me.rb_inv.TabIndex = 43
        Me.rb_inv.Text = "INVENTARIO"
        Me.rb_inv.UseVisualStyleBackColor = False
        '
        'cb_ffin
        '
        Me.cb_ffin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_ffin.AutoSize = True
        Me.cb_ffin.BackColor = System.Drawing.Color.Transparent
        Me.cb_ffin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cb_ffin.Location = New System.Drawing.Point(490, 6)
        Me.cb_ffin.Name = "cb_ffin"
        Me.cb_ffin.Size = New System.Drawing.Size(66, 20)
        Me.cb_ffin.TabIndex = 42
        Me.cb_ffin.Text = "Hasta:"
        Me.cb_ffin.UseVisualStyleBackColor = False
        '
        'cb_finicio
        '
        Me.cb_finicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_finicio.AutoSize = True
        Me.cb_finicio.BackColor = System.Drawing.Color.Transparent
        Me.cb_finicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cb_finicio.Location = New System.Drawing.Point(413, 6)
        Me.cb_finicio.Name = "cb_finicio"
        Me.cb_finicio.Size = New System.Drawing.Size(71, 20)
        Me.cb_finicio.TabIndex = 41
        Me.cb_finicio.Text = "Desde:"
        Me.cb_finicio.UseVisualStyleBackColor = False
        '
        'rb_compras
        '
        Me.rb_compras.AutoSize = True
        Me.rb_compras.BackColor = System.Drawing.Color.Transparent
        Me.rb_compras.Location = New System.Drawing.Point(3, 34)
        Me.rb_compras.Name = "rb_compras"
        Me.rb_compras.Size = New System.Drawing.Size(78, 17)
        Me.rb_compras.TabIndex = 40
        Me.rb_compras.Text = "COMPRAS"
        Me.rb_compras.UseVisualStyleBackColor = False
        '
        'rb_ventas
        '
        Me.rb_ventas.AutoSize = True
        Me.rb_ventas.BackColor = System.Drawing.Color.Transparent
        Me.rb_ventas.Location = New System.Drawing.Point(3, 18)
        Me.rb_ventas.Name = "rb_ventas"
        Me.rb_ventas.Size = New System.Drawing.Size(68, 17)
        Me.rb_ventas.TabIndex = 39
        Me.rb_ventas.Text = "VENTAS"
        Me.rb_ventas.UseVisualStyleBackColor = False
        '
        'dtp_fin
        '
        Me.dtp_fin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fin.Location = New System.Drawing.Point(491, 27)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(78, 20)
        Me.dtp_fin.TabIndex = 37
        '
        'dtp_desde
        '
        Me.dtp_desde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(413, 27)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(77, 20)
        Me.dtp_desde.TabIndex = 35
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.BackColor = System.Drawing.Color.White
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.ForeColor = System.Drawing.Color.Black
        Me.txtBuscador.Location = New System.Drawing.Point(160, 15)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(132, 28)
        Me.txtBuscador.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar:"
        '
        'tabla
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla.DefaultCellStyle = DataGridViewCellStyle3
        Me.tabla.GridColor = System.Drawing.Color.Maroon
        Me.tabla.Location = New System.Drawing.Point(6, 60)
        Me.tabla.Name = "tabla"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tabla.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabla.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla.Size = New System.Drawing.Size(572, 405)
        Me.tabla.TabIndex = 8
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cmt_Reporte.ResumeLayout(False)
        Me.panel_excel.ResumeLayout(False)
        Me.panel_excel.PerformLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tabla As DataGridView
    Friend WithEvents dtp_fin As DateTimePicker
    Friend WithEvents dtp_desde As DateTimePicker
    Friend WithEvents rb_compras As RadioButton
    Friend WithEvents rb_ventas As RadioButton
    Friend WithEvents cb_ffin As CheckBox
    Friend WithEvents cb_finicio As CheckBox
    Friend WithEvents rb_inv As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmt_Reporte As ContextMenuStrip
    Friend WithEvents VerReporteSelecionadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosMásVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasVendidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenosVendidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeHoyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelUltimoMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalDelAñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panel_excel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DeHoyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DelMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalDelAñoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MesConMasVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UltimasComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresMasCompradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresMenosCompradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoDeTodosLosProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónDeTodosLosProveedoresToolStripMenuItem As ToolStripMenuItem
End Class
