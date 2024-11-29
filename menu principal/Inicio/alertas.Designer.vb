<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alertas
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Alerta = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panel_grafico1 = New System.Windows.Forms.Panel()
        Me.lb_stockBajo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_stockBajoCANTIDAD = New System.Windows.Forms.Label()
        Me.lb_stockNormalCANTIDAD = New System.Windows.Forms.Label()
        Me.tabla_stockBajo = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel_barVentas = New System.Windows.Forms.Panel()
        Me.lb_titulo2 = New System.Windows.Forms.Label()
        Me.lb_titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_NVentasMes = New System.Windows.Forms.Label()
        Me.lb_ventasValorMes = New System.Windows.Forms.Label()
        Me.lb_prodTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_stockDis = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_valorMercancia = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_valorVenta = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Alerta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla_stockBajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Alerta
        '
        Me.Alerta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Alerta.AutoScroll = True
        Me.Alerta.AutoScrollMargin = New System.Drawing.Size(0, 877)
        Me.Alerta.BackColor = System.Drawing.Color.White
        Me.Alerta.Controls.Add(Me.GroupBox2)
        Me.Alerta.Controls.Add(Me.Panel5)
        Me.Alerta.Controls.Add(Me.Panel4)
        Me.Alerta.Controls.Add(Me.GroupBox1)
        Me.Alerta.Controls.Add(Me.Panel3)
        Me.Alerta.Controls.Add(Me.Panel2)
        Me.Alerta.Controls.Add(Me.Panel1)
        Me.Alerta.Controls.Add(Me.panel_barVentas)
        Me.Alerta.Controls.Add(Me.lb_titulo2)
        Me.Alerta.Controls.Add(Me.lb_titulo)
        Me.Alerta.Cursor = System.Windows.Forms.Cursors.Default
        Me.Alerta.Location = New System.Drawing.Point(141, 50)
        Me.Alerta.Margin = New System.Windows.Forms.Padding(0)
        Me.Alerta.Name = "Alerta"
        Me.Alerta.Size = New System.Drawing.Size(578, 477)
        Me.Alerta.TabIndex = 12
        Me.Alerta.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.lb_ventasValorMes)
        Me.GroupBox2.Controls.Add(Me.lb_NVentasMes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 159)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ventas último mes"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel5.Controls.Add(Me.lb_valorVenta)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(375, 3)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 58)
        Me.Panel5.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel4.Controls.Add(Me.lb_valorMercancia)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 58)
        Me.Panel4.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.panel_grafico1)
        Me.GroupBox1.Controls.Add(Me.lb_stockBajo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_stockBajoCANTIDAD)
        Me.GroupBox1.Controls.Add(Me.lb_stockNormalCANTIDAD)
        Me.GroupBox1.Controls.Add(Me.tabla_stockBajo)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(3, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 183)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stocks"
        '
        'panel_grafico1
        '
        Me.panel_grafico1.Location = New System.Drawing.Point(6, 15)
        Me.panel_grafico1.Name = "panel_grafico1"
        Me.panel_grafico1.Size = New System.Drawing.Size(164, 158)
        Me.panel_grafico1.TabIndex = 1
        '
        'lb_stockBajo
        '
        Me.lb_stockBajo.AutoSize = True
        Me.lb_stockBajo.BackColor = System.Drawing.Color.Red
        Me.lb_stockBajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stockBajo.ForeColor = System.Drawing.Color.Black
        Me.lb_stockBajo.Location = New System.Drawing.Point(171, 40)
        Me.lb_stockBajo.Name = "lb_stockBajo"
        Me.lb_stockBajo.Size = New System.Drawing.Size(59, 13)
        Me.lb_stockBajo.TabIndex = 2
        Me.lb_stockBajo.Text = "Stock Bajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(171, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Stock Normal"
        '
        'lb_stockBajoCANTIDAD
        '
        Me.lb_stockBajoCANTIDAD.AutoSize = True
        Me.lb_stockBajoCANTIDAD.BackColor = System.Drawing.Color.White
        Me.lb_stockBajoCANTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lb_stockBajoCANTIDAD.Location = New System.Drawing.Point(174, 53)
        Me.lb_stockBajoCANTIDAD.Name = "lb_stockBajoCANTIDAD"
        Me.lb_stockBajoCANTIDAD.Size = New System.Drawing.Size(29, 31)
        Me.lb_stockBajoCANTIDAD.TabIndex = 4
        Me.lb_stockBajoCANTIDAD.Text = "0"
        '
        'lb_stockNormalCANTIDAD
        '
        Me.lb_stockNormalCANTIDAD.AutoSize = True
        Me.lb_stockNormalCANTIDAD.BackColor = System.Drawing.Color.White
        Me.lb_stockNormalCANTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lb_stockNormalCANTIDAD.Location = New System.Drawing.Point(174, 120)
        Me.lb_stockNormalCANTIDAD.Name = "lb_stockNormalCANTIDAD"
        Me.lb_stockNormalCANTIDAD.Size = New System.Drawing.Size(29, 31)
        Me.lb_stockNormalCANTIDAD.TabIndex = 5
        Me.lb_stockNormalCANTIDAD.Text = "0"
        '
        'tabla_stockBajo
        '
        Me.tabla_stockBajo.AllowUserToAddRows = False
        Me.tabla_stockBajo.AllowUserToDeleteRows = False
        Me.tabla_stockBajo.AllowUserToResizeColumns = False
        Me.tabla_stockBajo.AllowUserToResizeRows = False
        Me.tabla_stockBajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabla_stockBajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_stockBajo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tabla_stockBajo.BackgroundColor = System.Drawing.Color.White
        Me.tabla_stockBajo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabla_stockBajo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.tabla_stockBajo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tabla_stockBajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla_stockBajo.DefaultCellStyle = DataGridViewCellStyle8
        Me.tabla_stockBajo.GridColor = System.Drawing.Color.Silver
        Me.tabla_stockBajo.Location = New System.Drawing.Point(247, 15)
        Me.tabla_stockBajo.Name = "tabla_stockBajo"
        Me.tabla_stockBajo.ReadOnly = True
        Me.tabla_stockBajo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tabla_stockBajo.RowHeadersVisible = False
        Me.tabla_stockBajo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabla_stockBajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_stockBajo.Size = New System.Drawing.Size(302, 158)
        Me.tabla_stockBajo.TabIndex = 9
        Me.tabla_stockBajo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(189, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 61)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.lb_stockDis)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(375, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 60)
        Me.Panel2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.lb_prodTotal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(2, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 60)
        Me.Panel1.TabIndex = 13
        '
        'panel_barVentas
        '
        Me.panel_barVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_barVentas.AutoSize = True
        Me.panel_barVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_barVentas.Location = New System.Drawing.Point(177, 318)
        Me.panel_barVentas.Name = "panel_barVentas"
        Me.panel_barVentas.Size = New System.Drawing.Size(381, 159)
        Me.panel_barVentas.TabIndex = 12
        '
        'lb_titulo2
        '
        Me.lb_titulo2.AutoSize = True
        Me.lb_titulo2.Location = New System.Drawing.Point(247, 34)
        Me.lb_titulo2.Name = "lb_titulo2"
        Me.lb_titulo2.Size = New System.Drawing.Size(52, 13)
        Me.lb_titulo2.TabIndex = 11
        Me.lb_titulo2.Text = "Resumen"
        '
        'lb_titulo
        '
        Me.lb_titulo.AutoSize = True
        Me.lb_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_titulo.Location = New System.Drawing.Point(200, 10)
        Me.lb_titulo.Name = "lb_titulo"
        Me.lb_titulo.Size = New System.Drawing.Size(172, 24)
        Me.lb_titulo.TabIndex = 10
        Me.lb_titulo.Text = "Jorge Henech C.A."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventas concretadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(este mes) :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Valor total"
        '
        'lb_NVentasMes
        '
        Me.lb_NVentasMes.AutoSize = True
        Me.lb_NVentasMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_NVentasMes.ForeColor = System.Drawing.Color.White
        Me.lb_NVentasMes.Location = New System.Drawing.Point(47, 61)
        Me.lb_NVentasMes.Name = "lb_NVentasMes"
        Me.lb_NVentasMes.Size = New System.Drawing.Size(29, 31)
        Me.lb_NVentasMes.TabIndex = 2
        Me.lb_NVentasMes.Text = "0"
        Me.lb_NVentasMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_ventasValorMes
        '
        Me.lb_ventasValorMes.AutoSize = True
        Me.lb_ventasValorMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ventasValorMes.ForeColor = System.Drawing.Color.White
        Me.lb_ventasValorMes.Location = New System.Drawing.Point(47, 112)
        Me.lb_ventasValorMes.Name = "lb_ventasValorMes"
        Me.lb_ventasValorMes.Size = New System.Drawing.Size(29, 31)
        Me.lb_ventasValorMes.TabIndex = 3
        Me.lb_ventasValorMes.Text = "0"
        Me.lb_ventasValorMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_prodTotal
        '
        Me.lb_prodTotal.AutoSize = True
        Me.lb_prodTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_prodTotal.ForeColor = System.Drawing.Color.White
        Me.lb_prodTotal.Location = New System.Drawing.Point(78, 29)
        Me.lb_prodTotal.Name = "lb_prodTotal"
        Me.lb_prodTotal.Size = New System.Drawing.Size(29, 31)
        Me.lb_prodTotal.TabIndex = 4
        Me.lb_prodTotal.Text = "0"
        Me.lb_prodTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Productos registrados"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_stockDis
        '
        Me.lb_stockDis.AutoSize = True
        Me.lb_stockDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stockDis.ForeColor = System.Drawing.Color.White
        Me.lb_stockDis.Location = New System.Drawing.Point(78, 29)
        Me.lb_stockDis.Name = "lb_stockDis"
        Me.lb_stockDis.Size = New System.Drawing.Size(29, 31)
        Me.lb_stockDis.TabIndex = 6
        Me.lb_stockDis.Text = "0"
        Me.lb_stockDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stock registrado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_valorMercancia
        '
        Me.lb_valorMercancia.AutoEllipsis = True
        Me.lb_valorMercancia.AutoSize = True
        Me.lb_valorMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_valorMercancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_valorMercancia.ForeColor = System.Drawing.Color.White
        Me.lb_valorMercancia.Location = New System.Drawing.Point(77, 24)
        Me.lb_valorMercancia.Name = "lb_valorMercancia"
        Me.lb_valorMercancia.Size = New System.Drawing.Size(29, 31)
        Me.lb_valorMercancia.TabIndex = 6
        Me.lb_valorMercancia.Text = "0"
        Me.lb_valorMercancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Valor mercancia"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_valorVenta
        '
        Me.lb_valorVenta.AutoSize = True
        Me.lb_valorVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_valorVenta.ForeColor = System.Drawing.Color.White
        Me.lb_valorVenta.Location = New System.Drawing.Point(78, 24)
        Me.lb_valorVenta.Name = "lb_valorVenta"
        Me.lb_valorVenta.Size = New System.Drawing.Size(27, 31)
        Me.lb_valorVenta.TabIndex = 8
        Me.lb_valorVenta.Text = "x"
        Me.lb_valorVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Valor de venta(invertido)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(80, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "x"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 527)
        Me.Controls.Add(Me.Alerta)
        Me.Name = "alertas"
        Me.Text = "alertas"
        Me.Alerta.ResumeLayout(False)
        Me.Alerta.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tabla_stockBajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Alerta As Panel
    Friend WithEvents panel_grafico1 As Panel
    Friend WithEvents lb_stockNormalCANTIDAD As Label
    Friend WithEvents lb_stockBajoCANTIDAD As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_stockBajo As Label
    Friend WithEvents tabla_stockBajo As DataGridView
    Friend WithEvents lb_titulo2 As Label
    Friend WithEvents lb_titulo As Label
    Friend WithEvents panel_barVentas As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lb_NVentasMes As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_ventasValorMes As Label
    Friend WithEvents lb_valorVenta As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lb_valorMercancia As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_stockDis As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_prodTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
