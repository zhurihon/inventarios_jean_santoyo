Public Class factura


    Dim printLine As Integer = 0
    Dim Contador As Integer = 0
    Private nombreCliente As String = "error"
    Private servicio As String = "_"
    Private precioservicio As Integer = 0
    Private total As Double = 0

    Public Sub factura_Load(dgv As DataGridView, montoTotal As Double, servicoINFO As String, servicioPRECIO As Double, scliente As String)
        'PrintLine = 0
        'Contador = 0

        'reporte_sdisponibles.lb_num_res.Text = "1"
        servicio = servicoINFO
        precioservicio = servicioPRECIO
        total = montoTotal
        'dgv_tabla = dgv
        'dgv_tabla.DataSource = dgv.DataSource

        cliente.Text = scliente

        ' Limpiar el DataGridView2 antes de copiar
        dgv_tabla.Rows.Clear()
        dgv_tabla.Columns.Clear()

        ' Copiar las columnas
        For Each column As DataGridViewColumn In dgv.Columns
            dgv_tabla.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next

        ' Copiar las filas
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then ' Ignorar la fila nueva
                Dim newRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)
                For i As Integer = 0 To row.Cells.Count - 1
                    newRow.Cells(i).Value = row.Cells(i).Value
                Next
                dgv_tabla.Rows.Add(newRow)
            End If
        Next










        PrintDialog1.Document = PrintDocument1

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim dt As New DataSet
        Dim FuenteTitulo As New Font("Microsoft Sans Serif", 10)
        Dim FuenteSubtitulo As New Font("Microsoft Sans Serif", 9)
        Dim FuenteNegrita As New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
        Dim FuenteDetalles As New Font("Microsoft Sans Serif", 9)

        e.Graphics.DrawString(Me.nombre.Text, FuenteTitulo, Brushes.Black, Me.nombre.Left, Me.nombre.Top)
        e.Graphics.DrawString(Me.ubicacion.Text, FuenteTitulo, Brushes.Black, Me.ubicacion.Left, Me.ubicacion.Top)
        e.Graphics.DrawString(Me.rif.Text, FuenteTitulo, Brushes.Black, Me.rif.Left, Me.rif.Top)

        e.Graphics.DrawString(Me.titulo.Text, FuenteTitulo, Brushes.Black, Me.titulo.Left, Me.titulo.Top)

        e.Graphics.DrawString(Me.cliente.Text, FuenteTitulo, Brushes.Black, Me.cliente.Left, Me.cliente.Top)


        e.Graphics.DrawString(Me.Label3.Text, FuenteTitulo, Brushes.Black, Me.Label3.Left, Me.Label3.Top)


        e.Graphics.DrawString(Me.tCod.Text, FuenteTitulo, Brushes.Black, Me.tCod.Left, Me.tCod.Top)
        e.Graphics.DrawString(Me.tDescripcion.Text, FuenteTitulo, Brushes.Black, Me.tDescripcion.Left, Me.tDescripcion.Top)
        e.Graphics.DrawString(Me.tCantidad.Text, FuenteTitulo, Brushes.Black, Me.tCantidad.Left, Me.tCantidad.Top)
        e.Graphics.DrawString(Me.tPrecio.Text, FuenteTitulo, Brushes.Black, Me.tPrecio.Left, Me.tPrecio.Top)


        e.Graphics.DrawString(DateTime.Today.ToString("d"), FuenteNegrita, Brushes.Black, Me.fecha.Left, Me.fecha.Top)

        Dim newImage As Image = Me.logo.BackgroundImage : e.Graphics.DrawImage(newImage, Me.logo.Left, Me.logo.Top, Me.logo.Width, Me.logo.Height)

        'e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, Me.p1.Top + Me.p1.Height + 10, e.MarginBounds.Right, Me.p1.Top + Me.p1.Height + 10)




        Dim startX As Integer = Me.p1.Left 'Tomamos la posicion horinzontal de la letra 'Punto1'
        Dim startY As Integer = Me.p1.Top 'Tomamos la posicion vertical de la letra 'Punto1'


        printLine = 0

        Do While printLine < Me.dgv_tabla.Rows.Count
            If startY + Me.p1.Height > e.MarginBounds.Bottom Then

                e.HasMorePages = True
                Exit Do
            End If


            If printLine < Me.dgv_tabla.Rows.Count - 1 Then

                e.Graphics.DrawString(Me.dgv_tabla.Rows(printLine).Cells("ccod").Value.ToString, FuenteDetalles, Brushes.Black, Me.p1.Left, startY)
                e.Graphics.DrawString(Me.dgv_tabla.Rows(printLine).Cells("cnombre").Value.ToString, FuenteDetalles, Brushes.Black, Me.p2.Left, startY)
                e.Graphics.DrawString(Me.dgv_tabla.Rows(printLine).Cells("ccantidad").Value.ToString, FuenteDetalles, Brushes.Black, Me.p3.Left, startY)
                e.Graphics.DrawString(Me.dgv_tabla.Rows(printLine).Cells("cprecio").Value.ToString, FuenteDetalles, Brushes.Black, Me.p4.Left, startY)

            End If


            startY += 20

            printLine += 1
            Contador += 1
        Loop

        e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, startY, e.MarginBounds.Right, startY)

        e.Graphics.DrawString("Servicio", FuenteNegrita, Brushes.Black, e.MarginBounds.Left, startY)
        startY += 20
        e.Graphics.DrawString(servicio, FuenteSubtitulo, Brushes.Black, e.MarginBounds.Left, startY)
        e.Graphics.DrawString(precioservicio, FuenteDetalles, Brushes.Black, Me.p4.Left, startY)
        startY += 20

        e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, startY, e.MarginBounds.Right, startY)

        e.Graphics.DrawString("Total", FuenteNegrita, Brushes.Black, e.MarginBounds.Left, startY)
        startY += 20
        e.Graphics.DrawString(total.ToString, FuenteDetalles, Brushes.Black, Me.p4.Left, startY)



        ''''''''''''''''el data gri
        '''
        'Dim startX As Integer = reporte_sdisponibles.p1.Left 'Tomamos la posicion horinzontal de la letra 'Punto1'
        ' Dim startY As Integer = reporte_sdisponibles.p1.Top 'Tomamos la posicion vertical de la letra 'Punto1'

        '''''''''''''''''''

    End Sub

    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class