Public Class iniciogerente
    Public Sub iniciogerente_Load()

        lbStockBajo.Text = controller.sql.stock_leve_normal()(0)
        lbusers.Text = controller.sql.consultaCantidadUsuarios().ToString
        lbProveedores.Text = controller.sql.consultaCantidadProveedores.ToString
        lbClientes.Text = controller.sql.consultaCantidadClientes.ToString

        tabla.DataSource = controller.sql.dataset_stock_bajo.Tables(0)

    End Sub
End Class