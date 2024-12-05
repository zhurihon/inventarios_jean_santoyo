Public Class CuadroCompras
    Private Sub txtdebitar_TextChanged(sender As Object, e As EventArgs) Handles txtIngresar.TextChanged


        If Comprobaciones.txtnumero(txtValorComprado.Text) And Comprobaciones.txtnumero(txtIngresar.Text) Then

            If lbTotal.BackColor = Color.Red Then
                lbTotal.BackColor = Color.FromArgb(75, 7, 12)
                btn_modificar.Enabled = 1
            End If
            lbTotal.Text = txtValorComprado.Text * txtIngresar.Text

        Else
            lbTotal.BackColor = Color.Red
            btn_modificar.Enabled = 0
        End If

    End Sub

    Private Sub txtValorComprado_TextChanged(sender As Object, e As EventArgs) Handles txtValorComprado.TextChanged

        If Comprobaciones.txtnumero(txtValorComprado.Text) And Comprobaciones.txtnumero(txtIngresar.Text) Then

            If lbTotal.BackColor = Color.Red Then
                lbTotal.BackColor = Color.FromArgb(75, 7, 12)
                btn_modificar.Enabled = 1
            End If
            lbTotal.Text = txtValorComprado.Text * txtIngresar.Text

        Else
            lbTotal.BackColor = Color.Red
            btn_modificar.Enabled = 0
        End If
    End Sub

    Public Sub load_compras()
        tabla.DataSource = controller.sql.consulta_productos().Tables(0)

        cbxProveedores.DataSource = controller.sql.consulta_proveedores().Tables(0)
        cbxProveedores.DisplayMember = "Nombre"

        cbxProveedores.ValueMember = "Identificacion"


        AnalizarDataGridView()


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


    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellContentClick

    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        If e.RowIndex >= 0 Then
            id_mode = 0
            Dim row As DataGridViewRow = tabla.Rows(e.RowIndex)
            tabla.Rows(e.RowIndex).Selected = True

            id.Text = row.Cells("cod").Value.ToString
            txtnombre.Text = row.Cells("nombre").Value.ToString
            txtCantidad.Text = row.Cells("cantidad").Value.ToString
            txtPrecio.Text = row.Cells("precio").Value.ToString
            btn_modificar.Enabled = 1
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click


        Dim resultado As DialogResult = MessageBox.Show("¿Desea ingresar esta compra al inventacio?" & vbCrLf & txtIngresar.Text & " " & txtnombre.Text, "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "No", salir de la función
        If resultado = DialogResult.Yes Then


            If Comprobaciones.txtnumero(txtIngresar.Text) Then



                controller.sql.comprar_producto_STOCK(id.Text, txtIngresar.Text)
                tabla.DataSource = controller.sql.consulta_productos.Tables(0)

                controller.sql.comprar_producto_historial(id.Text, txtIngresar.Text, txtValorComprado.Text, cbxProveedores.SelectedValue.ToString)
                AnalizarDataGridView()

            Else
                If Not Comprobaciones.txtnumero(txtIngresar.Text) And Comprobaciones.txtnumero(txtValorComprado.Text) Then
                    MsgBox("solo se aceptan numeros")
                Else
                    MsgBox("no hay sufiente stock")
                End If
            End If


            txtValorComprado.Text = 0
            txtIngresar.Text = 0
        End If

    End Sub

    Private Sub CuadroCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged

        If id_mode Then



        End If

    End Sub

    Private id_mode As Boolean = 0

    Private Sub id_Click(sender As Object, e As EventArgs) Handles id.Click
        id_mode = 1
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If txtBuscar.Text = "" Then
            tabla.DataSource = controller.sql.consulta_productos().Tables(0)
        Else
            tabla.DataSource = controller.sql.consulta_productos_Indexid(txtBuscar.Text).Tables(0)
        End If


    End Sub






End Class