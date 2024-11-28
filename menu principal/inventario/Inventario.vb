Public Class Inventario



    Public tipo_consulta As Short = 0


    Public Sub load_inventario()



    End Sub


    Public Sub fbuscar()

        If txtBuscador.BackColor = Color.White Then

            tabla.DataSource = controller.sql.search_dataset_productos(txtBuscador.Text, tipo_consulta, cb_finicio.Checked, dtp_desde.Value, cb_ffin.Checked, dtp_fin.Value).Tables(0)


        End If

    End Sub

    Private Sub txtBuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscador.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And tipo_consulta <> 0 Then

            fbuscar()

        End If
    End Sub


    Private Sub rb_ventas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ventas.CheckedChanged
        tipo_consulta = 2
        fbuscar()

        tabla.Columns.Item("cantidad").HeaderText = "Cantidad vendida"

    End Sub

    Private Sub rb_compras_CheckedChanged(sender As Object, e As EventArgs) Handles rb_compras.CheckedChanged
        tipo_consulta = 3
        fbuscar()

        tabla.Columns.Item("cantidad").HeaderText = "Cantidad comprada"
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged


        If Comprobaciones.txtmax(txtBuscador.Text, 15) Then
            txtBuscador.BackColor = Color.White

        Else
            txtBuscador.BackColor = Color.Red
        End If

    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fbuscar()
    End Sub

    Private Sub rb_inv_Click(sender As Object, e As EventArgs) Handles rb_inv.Click
        tipo_consulta = 1

        ' Antes de llenar la Grilla poner este codigo
        fbuscar()
        tabla.Columns.Item("cantidad").HeaderText = "Stock"


        'DataGridGrupo.Columns(DataGridGrupo.Columns.Count - 1).DisplayIndex = 0 ' Es para que la columna sea la primera en la grilla

        ' Luego esta propiedad para la grilla

        'DataGridGrupo.ReadOnly = False ' Esto para que toda la grilla sea editable
        'DataGridGrupo.DataSource = Nothing ' al inicio no va ningun enlaze de datos

    End Sub

    Public Function IsDataGridViewEmpty(dgv As DataGridView) As Boolean
        ' Verificar si el DataGridView tiene filas
        Return dgv.Rows.Count = 0
    End Function
    Private Function reportarExcel() As Boolean

        If Not IsDataGridViewEmpty(tabla) Then

            Dim dt As DataSet = reportes.ExtraerDataGridViewADataSet(tabla)
            reportes.fexcel(dt, "inventario")

        Else
            MsgBox("Reporte vacio")
        End If


    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        reportarExcel()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        reportarExcel()
    End Sub

    Private Sub MasVendidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasVendidoToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_10ProductosMasVendidos.Tables(0)
    End Sub

    Private Sub MenosVendidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenosVendidoToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_10ProductosMenosVendidos.Tables(0)
    End Sub

    Private Sub DeHoyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeHoyToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_VentasHoy.Tables(0)
    End Sub

    Private Sub DelUltimoMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelUltimoMesToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_VentasMesTotal.Tables(0)
    End Sub

    Private Sub TotalDelAñoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalDelAñoToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_VentasAnno.Tables(0)
    End Sub

    Private Sub MesConMasVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesConMasVentasToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_MesConMasVentas.Tables(0)
    End Sub

    Private Sub DeHoyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeHoyToolStripMenuItem1.Click
        tabla.DataSource = controller.sql.dataset_ComprasHoy.Tables(0)

    End Sub

    Private Sub DelMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DelMesToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_ComprasMes.Tables(0)
    End Sub

    Private Sub TotalDelAñoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TotalDelAñoToolStripMenuItem1.Click
        tabla.DataSource = controller.sql.dataset_ComprasAnio.Tables(0)
    End Sub

    Private Sub ContactoDeTodosLosProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactoDeTodosLosProveedoresToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_ContactoProveedores.Tables(0)
    End Sub

    Private Sub InformaciónDeTodosLosProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónDeTodosLosProveedoresToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_InfoProveedores.Tables(0)
    End Sub

    Private Sub ProveedoresMasCompradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresMasCompradosToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_ProveedoresMasComprados.Tables(0)
    End Sub

    Private Sub ProveedoresMenosCompradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresMenosCompradosToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_ProveedoresMenosComprados.Tables(0)
    End Sub

    Private Sub UltimasComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UltimasComprasToolStripMenuItem.Click
        tabla.DataSource = controller.sql.dataset_UltimaCompraPorProveedorConProducto.Tables(0)
    End Sub
End Class