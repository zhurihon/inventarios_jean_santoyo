Imports SystemInformation.HorizontalScrollBarHeight
Imports SystemInformation.VerticalScrollBarWidth
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing

Public Class alertas


    Private Sub fpinta_grafico_porcentajes(panel As Panel, num1 As Integer, num2 As Integer)
        ' Asegúrate de que el panel se limpie antes de dibujar
        panel.Invalidate()
        panel.Refresh()
        ' Calcula el total
        Dim total As Integer = num1 + num2
        If total = 0 Then
            'MessageBox.Show("El total no puede ser cero.")
            Return
        End If
        ' Calcula los ángulos para el gráfico
        Dim angle1 As Single = (num1 / total) * 360
        Dim angle2 As Single = (num2 / total) * 360
        ' Crea un objeto Graphics para el panel
        Dim g As Graphics = panel.CreateGraphics()
        ' Dibuja el gráfico circular
        Dim rect As New Rectangle(0, 0, panel.Width, panel.Height)
        ' Dibuja la primera porción

        Dim highlightBrush As New SolidBrush(SystemColors.MenuHighlight)

        g.FillPie(Brushes.Green, rect, 0, angle1)
        ' Dibuja la segunda porción
        g.FillPie(Brushes.Red, rect, angle1, angle2)
        ' Libera los recursos
        g.Dispose()
    End Sub

    Public Sub load_alertas()
        Dim stocks() As Integer = controller.sql.stock_leve_normal()
        fpinta_grafico_porcentajes(panel_grafico1, stocks(0), stocks(1))
        lb_stockBajoCANTIDAD.Text = stocks(1)
        lb_stockNormalCANTIDAD.Text = stocks(0)
        tabla_stockBajo.DataSource = controller.sql.dataset_stock_bajo().Tables(0)

        fbarVentas(panel_barVentas)

        Dim dtmes As DataSet = controller.sql.dataset_VentasMes()
        lb_NVentasMes.Text = dtmes.Tables(0).Rows(0).Item(0)
        lb_ventasValorMes.Text = dtmes.Tables(0).Rows(0).Item(1).ToString + "$"

        lb_prodTotal.Text = controller.sql.consulta_cantidadRegistrados()

        lb_valorMercancia.Text = controller.sql.consulta_valorMercancia().ToString + "$"
        lb_valorMercancia.Left = (Panel4.Width - lb_valorMercancia.Width) / 2

        lb_stockDis.Text = controller.sql.consulta_cantidadRegistrados
        lb_stockDis.Left = (Panel2.Width - lb_stockDis.Width) / 2



    End Sub



    Private Sub Alerta_Paint(sender As Object, e As PaintEventArgs) Handles Alerta.Paint
        Alerta.AutoScroll = True
        Alerta.VerticalScroll.Visible = 1
        load_alertas()
        Dim scrollbarWidth As Integer = SystemInformation.VerticalScrollBarWidth
        'MsgBox(scrollbarWidth)
    End Sub

    Private Sub alertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Alerta_Resize(sender As Object, e As EventArgs) Handles Alerta.Resize
        lb_titulo.Left = (Alerta.Width - lb_titulo.Width - 17) / 2
        lb_titulo2.Left = (Alerta.Width - lb_titulo2.Width - 17) / 2
    End Sub


    Private Sub fbarVentas(panel As Panel)
        ' Limpiar el panel
        panel.Controls.Clear()

        ' Crear un nuevo Chart
        Dim chart As New Chart()
        chart.Dock = DockStyle.Fill

        ' Crear un área de gráfico
        Dim chartArea As New ChartArea()
        chart.ChartAreas.Add(chartArea)

        ' Crear una serie de datos
        Dim series As New Series()
        series.Name = "Ventas"
        series.ChartType = SeriesChartType.Column ' Tipo de gráfico (Column, Line, Pie, etc.)



        Dim dt As DataSet = controller.sql.dataset_VentasAnno


        For j = 0 To 11 Step 1


            ' Agregar datos a la serie
            series.Points.AddXY(dt.Tables(0).Rows(j).Item(0), dt.Tables(0).Rows(j).Item(1))
            'series.Points.AddXY("Febrero", 20)
            'series.Points.AddXY("Marzo", 30)
            'series.Points.AddXY("Abril", 25)
            'series.Points.AddXY("Mayo", 15)
            'series.Points.AddXY("Junio", 35)
            'series.Points.AddXY("Julio", 40)
            'series.Points.AddXY("Agosto", 30)
            'series.Points.AddXY("Septiembre", 20)
            'series.Points.AddXY("Octubre", 50)
            'series.Points.AddXY("Noviembre", 45)
            'series.Points.AddXY("Diciembre", 60)
        Next

        chart.ChartAreas(0).AxisX.LabelStyle.Angle = -45 ' Rotar las etiquetas 45 grados
        chart.ChartAreas(0).AxisX.Interval = 1 '

        ' Agregar la serie al gráfico
        chart.Series.Add(series)

        ' Agregar el gráfico al panel
        panel.Controls.Add(chart)
    End Sub

    Private Sub panel_grafico1_Paint(sender As Object, e As PaintEventArgs) Handles panel_grafico1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class