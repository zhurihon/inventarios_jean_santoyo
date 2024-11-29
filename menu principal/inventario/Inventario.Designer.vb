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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.cb_typo = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.cmt_Reporte.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cb_typo)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tabla)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtBuscador)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(141, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 477)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
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
        Me.ProductosMásVendidosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ProductosMásVendidosToolStripMenuItem.Text = "Productos"
        '
        'MasVendidoToolStripMenuItem
        '
        Me.MasVendidoToolStripMenuItem.Name = "MasVendidoToolStripMenuItem"
        Me.MasVendidoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.MasVendidoToolStripMenuItem.Text = "Mas vendido"
        '
        'MenosVendidoToolStripMenuItem
        '
        Me.MenosVendidoToolStripMenuItem.Name = "MenosVendidoToolStripMenuItem"
        Me.MenosVendidoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.MenosVendidoToolStripMenuItem.Text = "Menos vendido"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeHoyToolStripMenuItem, Me.DelUltimoMesToolStripMenuItem, Me.TotalDelAñoToolStripMenuItem, Me.MesConMasVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
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
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
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
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Button1.BackgroundImage = Global.SantoyoSys.My.Resources.Resources.lupa2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(365, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 28)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.ForeColor = System.Drawing.Color.Black
        Me.txtBuscador.Location = New System.Drawing.Point(76, 10)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(283, 35)
        Me.txtBuscador.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar:"
        '
        'tabla
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.tabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla.DefaultCellStyle = DataGridViewCellStyle18
        Me.tabla.GridColor = System.Drawing.Color.Maroon
        Me.tabla.Location = New System.Drawing.Point(6, 51)
        Me.tabla.Name = "tabla"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.tabla.RowHeadersVisible = False
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabla.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla.Size = New System.Drawing.Size(572, 414)
        Me.tabla.TabIndex = 8
        '
        'cb_typo
        '
        Me.cb_typo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_typo.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.cb_typo.DisplayMember = "id"
        Me.cb_typo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_typo.ForeColor = System.Drawing.Color.White
        Me.cb_typo.FormattingEnabled = True
        Me.cb_typo.Items.AddRange(New Object() {"Stock", "Facturas"})
        Me.cb_typo.Location = New System.Drawing.Point(400, 10)
        Me.cb_typo.Name = "cb_typo"
        Me.cb_typo.Size = New System.Drawing.Size(175, 21)
        Me.cb_typo.TabIndex = 45
        Me.cb_typo.Text = "stock"
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
        Me.Panel1.PerformLayout()
        Me.cmt_Reporte.ResumeLayout(False)
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tabla As DataGridView
    Friend WithEvents Button1 As Button
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
    Friend WithEvents DeHoyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DelMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalDelAñoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MesConMasVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UltimasComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresMasCompradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresMenosCompradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoDeTodosLosProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónDeTodosLosProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cb_typo As ComboBox
End Class
