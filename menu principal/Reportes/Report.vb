Public Class Report
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_report.Click

        Select Case cb_tipo.Text
            Case "Stock"
                reportes.fexcel2(controller.sql.consulta_productos, "Stock")
                'MsgBox(2)
            Case "Ventas de hoy"
                reportes.fexcel2(controller.sql.dataset_VentasHoy, "Ventas de hoy")
            Case "Ventas del mes"
                reportes.fexcel2(controller.sql.dataset_VentasMes, "Ventas del mes")
            Case "Contactos de proveedores"
                reportes.fexcel2(controller.sql.dataset_ContactoProveedores, "Contactos de proveedores")
            Case "Stock bajo"
                reportes.fexcel2(controller.sql.dataset_stock_bajo, "Stock bajo")
            Case "Ventas por parámetros"
                Dim inf As New parametro
                inf.checkdesde = cb_Desde.Checked
                inf.desde = dtp_Desde.Value
                inf.checkhasta = cb_Hasta.Checked
                inf.hasta = dtp_hasta.Value

                inf.checkclienteproveedor = cb2.Checked
                inf.clienteid = cbpc.ValueMember.ToString
                tabla.DataSource = controller.sql.dataset_BusquedaVentas(inf).Tables(0)
                reportes.fexcel2(controller.sql.dataset_BusquedaVentas(inf), "Ventas específicas")
        End Select


    End Sub

    Private Sub cb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tipo.SelectedIndexChanged

        Select Case cb_tipo.Text
            Case "Stock"
                tabla.DataSource = controller.sql.consulta_productos.Tables(0)
                'MsgBox(2)
            Case "Ventas de hoy"
                tabla.DataSource = controller.sql.dataset_VentasHoy.Tables(0)
            Case "Ventas del mes"
                tabla.DataSource = controller.sql.dataset_VentasMes.Tables(0)
            Case "Contactos de proveedores"
                tabla.DataSource = controller.sql.dataset_ContactoProveedores.Tables(0)
            Case "Stock bajo"
                tabla.DataSource = controller.sql.dataset_stock_bajo.Tables(0)
            Case "Ventas por parámetros"
                cbpc.DataSource = controller.sql.dataset_clientes.Tables(0)
                cbpc.DisplayMember = "Nombre"
                cbpc.ValueMember = "id"
        End Select



    End Sub

    Private Sub cb_Desde_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Desde.CheckedChanged

    End Sub




    Public Class parametro
        Public tipo As String
        Public checkdesde As Boolean
        Public desde As Date
        Public checkhasta As Boolean
        Public hasta As Date
        Public checkclienteproveedor As Boolean
        Public clienteid As String
        Public proveedorid As String
    End Class









End Class