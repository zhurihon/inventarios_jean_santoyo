<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(factura))
        Me.fecha = New System.Windows.Forms.Label()
        Me.ubicacion = New System.Windows.Forms.Label()
        Me.rif = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tCod = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tPrecio = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tDescripcion = New System.Windows.Forms.Label()
        Me.tCantidad = New System.Windows.Forms.Label()
        Me.p4 = New System.Windows.Forms.Label()
        Me.p3 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.dgv_tabla = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Location = New System.Drawing.Point(526, 30)
        Me.fecha.Margin = New System.Windows.Forms.Padding(0)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(34, 13)
        Me.fecha.TabIndex = 44
        Me.fecha.Text = "fecha"
        '
        'ubicacion
        '
        Me.ubicacion.AutoSize = True
        Me.ubicacion.Location = New System.Drawing.Point(207, 54)
        Me.ubicacion.Margin = New System.Windows.Forms.Padding(0)
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.Size = New System.Drawing.Size(267, 13)
        Me.ubicacion.TabIndex = 43
        Me.ubicacion.Text = "Urb Boyaca iv Barcelona Anzoátegui Zona postal 6001"
        '
        'rif
        '
        Me.rif.AutoSize = True
        Me.rif.Location = New System.Drawing.Point(298, 83)
        Me.rif.Margin = New System.Windows.Forms.Padding(0)
        Me.rif.Name = "rif"
        Me.rif.Size = New System.Drawing.Size(118, 13)
        Me.rif.TabIndex = 42
        Me.rif.Text = "Rif: J.3504578746-CRL"
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Location = New System.Drawing.Point(298, 118)
        Me.titulo.Margin = New System.Windows.Forms.Padding(0)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(43, 13)
        Me.titulo.TabIndex = 40
        Me.titulo.Text = "Factura"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(287, 30)
        Me.nombre.Margin = New System.Windows.Forms.Padding(0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(150, 13)
        Me.nombre.TabIndex = 39
        Me.nombre.Text = "Emprendimiento Jean Santoyo"
        '
        'logo
        '
        Me.logo.BackgroundImage = CType(resources.GetObject("logo.BackgroundImage"), System.Drawing.Image)
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Location = New System.Drawing.Point(9, 9)
        Me.logo.Margin = New System.Windows.Forms.Padding(0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(179, 156)
        Me.logo.TabIndex = 38
        Me.logo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(781, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "_________________________________________________________________________________" &
    "________________________________________________"
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.Location = New System.Drawing.Point(522, 118)
        Me.cliente.Margin = New System.Windows.Forms.Padding(0)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(39, 13)
        Me.cliente.TabIndex = 46
        Me.cliente.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(578, 391)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Monto:"
        '
        'p1
        '
        Me.p1.AutoSize = True
        Me.p1.Location = New System.Drawing.Point(130, 194)
        Me.p1.Margin = New System.Windows.Forms.Padding(0)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(43, 13)
        Me.p1.TabIndex = 48
        Me.p1.Text = "Factura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 208)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Factura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 221)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Factura"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 260)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Factura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 247)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Factura"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(130, 234)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Factura"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(130, 299)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Factura"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(130, 286)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Factura"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(130, 273)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Factura"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(130, 338)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Factura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(130, 325)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Factura"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(130, 312)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Factura"
        '
        'tCod
        '
        Me.tCod.AutoSize = True
        Me.tCod.Location = New System.Drawing.Point(130, 165)
        Me.tCod.Margin = New System.Windows.Forms.Padding(0)
        Me.tCod.Name = "tCod"
        Me.tCod.Size = New System.Drawing.Size(40, 13)
        Me.tCod.TabIndex = 62
        Me.tCod.Text = "Código"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(130, 364)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Factura"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(130, 351)
        Me.Label20.Margin = New System.Windows.Forms.Padding(0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Factura"
        '
        'tPrecio
        '
        Me.tPrecio.AutoSize = True
        Me.tPrecio.Location = New System.Drawing.Point(522, 165)
        Me.tPrecio.Margin = New System.Windows.Forms.Padding(0)
        Me.tPrecio.Name = "tPrecio"
        Me.tPrecio.Size = New System.Drawing.Size(37, 13)
        Me.tPrecio.TabIndex = 77
        Me.tPrecio.Text = "Precio"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(522, 364)
        Me.Label22.Margin = New System.Windows.Forms.Padding(0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "Factura"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(522, 351)
        Me.Label23.Margin = New System.Windows.Forms.Padding(0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 75
        Me.Label23.Text = "Factura"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(522, 338)
        Me.Label24.Margin = New System.Windows.Forms.Padding(0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 74
        Me.Label24.Text = "Factura"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(522, 325)
        Me.Label25.Margin = New System.Windows.Forms.Padding(0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "Factura"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(522, 312)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 72
        Me.Label26.Text = "Factura"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(522, 299)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "Factura"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(522, 286)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 13)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "Factura"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(522, 273)
        Me.Label29.Margin = New System.Windows.Forms.Padding(0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(43, 13)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "Factura"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(522, 260)
        Me.Label30.Margin = New System.Windows.Forms.Padding(0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 13)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Factura"
        '
        'tDescripcion
        '
        Me.tDescripcion.AutoSize = True
        Me.tDescripcion.Location = New System.Drawing.Point(175, 165)
        Me.tDescripcion.Margin = New System.Windows.Forms.Padding(0)
        Me.tDescripcion.Name = "tDescripcion"
        Me.tDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.tDescripcion.TabIndex = 67
        Me.tDescripcion.Text = "Descripción"
        '
        'tCantidad
        '
        Me.tCantidad.AutoSize = True
        Me.tCantidad.Location = New System.Drawing.Point(460, 165)
        Me.tCantidad.Margin = New System.Windows.Forms.Padding(0)
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(49, 13)
        Me.tCantidad.TabIndex = 66
        Me.tCantidad.Text = "Cantidad"
        '
        'p4
        '
        Me.p4.AutoSize = True
        Me.p4.Location = New System.Drawing.Point(517, 194)
        Me.p4.Margin = New System.Windows.Forms.Padding(0)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(43, 13)
        Me.p4.TabIndex = 65
        Me.p4.Text = "Factura"
        '
        'p3
        '
        Me.p3.AutoSize = True
        Me.p3.Location = New System.Drawing.Point(460, 194)
        Me.p3.Margin = New System.Windows.Forms.Padding(0)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(43, 13)
        Me.p3.TabIndex = 64
        Me.p3.Text = "Factura"
        '
        'p2
        '
        Me.p2.AutoSize = True
        Me.p2.Location = New System.Drawing.Point(175, 194)
        Me.p2.Margin = New System.Windows.Forms.Padding(0)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(43, 13)
        Me.p2.TabIndex = 63
        Me.p2.Text = "Factura"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'dgv_tabla
        '
        Me.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod})
        Me.dgv_tabla.Location = New System.Drawing.Point(181, 476)
        Me.dgv_tabla.Name = "dgv_tabla"
        Me.dgv_tabla.Size = New System.Drawing.Size(360, 39)
        Me.dgv_tabla.TabIndex = 78
        '
        'cod
        '
        Me.cod.DataPropertyName = "cod"
        Me.cod.HeaderText = "cod"
        Me.cod.Name = "cod"
        '
        'factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 644)
        Me.Controls.Add(Me.dgv_tabla)
        Me.Controls.Add(Me.tPrecio)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.tDescripcion)
        Me.Controls.Add(Me.tCantidad)
        Me.Controls.Add(Me.p4)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.tCod)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.ubicacion)
        Me.Controls.Add(Me.rif)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.logo)
        Me.Name = "factura"
        Me.Text = "factura"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fecha As Label
    Friend WithEvents ubicacion As Label
    Friend WithEvents rif As Label
    Friend WithEvents titulo As Label
    Friend WithEvents nombre As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cliente As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents p1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tCod As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tPrecio As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents tDescripcion As Label
    Friend WithEvents tCantidad As Label
    Friend WithEvents p4 As Label
    Friend WithEvents p3 As Label
    Friend WithEvents p2 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents dgv_tabla As DataGridView
    Friend WithEvents cod As DataGridViewTextBoxColumn
End Class
