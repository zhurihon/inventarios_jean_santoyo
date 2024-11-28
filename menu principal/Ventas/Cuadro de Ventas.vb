Public Class Cuadro_de_Ventas







    Private total As Double = 0
    Private servicio As Double = 0
    Private suplies As Double = 0












    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()

    End Sub

    Private Sub Cuadro_de_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'no funcional
    End Sub

    Public Sub load_ventas()
        tabla.DataSource = controller.sql.consulta_productos.Tables(0)
        cb_clientes.DataSource = controller.sql.consulta_cliente.Tables(0)
    End Sub

    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellContentClick

    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla.Rows(e.RowIndex)
            tabla.Rows(e.RowIndex).Selected = True

            id.Text = row.Cells("cod").Value.ToString
            txtnombre.Text = row.Cells("nombre").Value.ToString
            txtCantidad.Text = row.Cells("cantidad").Value.ToString
            txtPrecio.Text = row.Cells("precio").Value.ToString

            Dim inputForm As New FormInputCantidad()

            If inputForm.ShowDialog() = DialogResult.OK Then
                Dim cantidad As Decimal = inputForm.nCantidad
                MessageBox.Show("Cantidad registrada: " & cantidad, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                suplies += cantidad * row.Cells("precio").Value

                txt_total.Text = suplies + servicio
                ' Agregar una fila al DataGridView
                ticket.Rows.Add(row.Cells("cod").Value.ToString, row.Cells("nombre").Value.ToString, row.Cells("precio").Value.ToString, cantidad)

            Else
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If


    End Sub

    Private b As Boolean = 0

    Private Sub cb_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_clientes.SelectedIndexChanged

        If b Then
            MsgBox("se selecionó el cliente " & cb_clientes.SelectedValue.ToString)
        Else
            b = True
        End If

    End Sub



    Private Sub txtMontoServicio_TextChanged(sender As Object, e As EventArgs) Handles txtMontoServicio.TextChanged
        If Comprobaciones.txtnumero(txtMontoServicio.Text) Then

            servicio = CDbl(txtMontoServicio.Text)
            total = servicio + suplies
            txt_total.Text = total
        Else
            servicio = 0

            total = servicio + suplies
            txt_total.Text = total
        End If

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click



        ' Suponiendo que ya tienes un DataSet llamado "miDataSet" y una DataTable dentro de él
        Dim miDataSet As New DataSet()
        Dim miDataTable As New DataTable("MiTabla")
        miDataSet.Tables.Add(miDataTable)

        ' Agregar columnas a la DataTable (esto debe coincidir con las columnas del DataGridView)
        For Each column As DataGridViewColumn In ticket.Columns
            Dim columnType As Type = GetType(String) ' Tipo predeterminado

            ' Determinar el tipo de datos de la columna
            If column.ValueType IsNot Nothing Then
                columnType = column.ValueType
            End If

            ' Agregar la columna al DataTable
            miDataTable.Columns.Add(column.Name, columnType)
        Next

        ' Copiar filas del DataGridView al DataTable
        For Each row As DataGridViewRow In ticket.Rows
            ' Ignorar la fila de nuevo (si no se requiere)
            If Not row.IsNewRow Then
                Dim dataRow As DataRow = miDataTable.NewRow()
                For Each column As DataGridViewColumn In ticket.Columns
                    dataRow(column.Name) = If(row.Cells(column.Name).Value, DBNull.Value) ' Manejar valores nulos
                Next
                miDataTable.Rows.Add(dataRow)
            End If
        Next

        controller.sql.Facturacion(miDataSet, cb_clientes.SelectedIndex, servicio, txtDescripcion.Text, total)










    End Sub
End Class