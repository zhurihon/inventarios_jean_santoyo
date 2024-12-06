Imports System.Drawing.Printing

Public Class Cuadro_de_Ventas







    Private total As Double = 0
    Private servicio As Double = 0
    Private suplies As Double = 0



    Private tirrapCliente As Boolean = 0


    Public PrintLine As Integer = 0
    Public Contador As Integer = 0



    'datos cliente

    Private sidcliente As String = ""
    Private snombreCliente As String = ""


    ''' ''''''''''



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()

    End Sub

    Private Sub Cuadro_de_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'no funcional
    End Sub

    Public Sub load_ventas()
        tirrapCliente = 0
        tabla.DataSource = controller.sql.consulta_productos.Tables(0)
        AnalizarDataGridView()
        analizarDgv_litros()
        tirrapCliente = 1

    End Sub



    Private Sub AnalizarDataGridView()
        Dim cantidadColIndex As Integer = 2
        For Each row As DataGridViewRow In tabla.Rows
            If Not row.IsNewRow Then
                Dim cantidad As Integer
                If Integer.TryParse(row.Cells(cantidadColIndex).Value.ToString(), cantidad) Then
                    If cantidad <= 5 Then
                        row.DefaultCellStyle.BackColor = Color.Red
                    Else
                        row.DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            End If
        Next
    End Sub


    Private Sub analizarDgv_litros()
        ' Asumiendo que tu DataGridView se llama DataGridView1
        For Each col As DataGridViewColumn In tabla.Columns
            ' Verificamos que la fila no sea una fila nueva
            col.ValueType = GetType(String)
        Next


        ' Asumiendo que tu DataGridView se llama DataGridView1
        For Each row As DataGridViewRow In tabla.Rows
            ' Verificamos que la fila no sea una fila nueva
            If Not row.IsNewRow Then
                ' Modificamos el valor de la columna 2 (índice 1, ya que es cero basado)
                'row.Cells(2).Value = "lt"
            End If
        Next




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


        If rbDivisa.Checked Or rbVes.Checked Then


            controller.sql.Facturacion(miDataSet, CInt(sidcliente), servicio, txtDescripcion.Text, total)

            Dim datos_cliente As DataSet = controller.sql.consulta_clienteId(sidcliente)

            factura.factura_Load(ticket, CDbl(txt_total.Text), txtDescripcion.Text, CDbl(txtMontoServicio.Text), sidcliente, datos_cliente, rbDivisa.Checked)


            AnalizarDataGridView()


        End If




    End Sub


    Private Sub vaciar()

        rbDivisa.Checked = 0
        rbVes.Checked = 0
        txtCnombreView.Clear()
        txtCidview.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputForm As New FormImputCliente()

        If inputForm.ShowDialog() = DialogResult.OK Then
            Dim idclienteInput As String = inputForm.idcliente
            Dim nombreclienteInput As String = inputForm.nombrecliente
            sidcliente = idclienteInput
            snombreCliente = nombreclienteInput
            txtCidview.Text = sidcliente
            txtCnombreView.Text = snombreCliente
            ' MessageBox.Show("Cantidad registrada: " & idcliente, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'suplies += cantidad * row.Cells("precio").Value

            'txt_total.Text = suplies + servicio
            ' Agregar una fila al DataGridView
            'ticket.Rows.Add(row.Cells("cod").Value.ToString, row.Cells("nombre").Value.ToString, row.Cells("precio").Value.ToString, cantidad)

        Else
            MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class