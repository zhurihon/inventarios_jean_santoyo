Public Class Cuadro_de_Ventas
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()

    End Sub

    Private Sub Cuadro_de_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub load_ventas()
        tabla.DataSource = controller.sql.consulta_productos.Tables(0)
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

        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdebitar.TextChanged
        If Comprobaciones.txtnumero(txtdebitar.Text) Then
            If CDbl(txtdebitar.Text) <= CDbl(txtCantidad.Text) And CDbl(txtdebitar.Text) > 0 Then
                lbTotal.BackColor = Color.White
                lbTotal.Text = txtdebitar.Text * txtPrecio.Text
            Else
                If CDbl(txtdebitar.Text) <> 0 Then
                    lbTotal.BackColor = Color.Red
                End If

            End If

        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click



        If Comprobaciones.txtnumero(txtdebitar.Text) And CDbl(txtCantidad.Text) >= CDbl(txtdebitar.Text) Then

            controller.sql.vender(id.Text, txtPrecio.Text, txtdebitar.Text)

        Else
            If Not Comprobaciones.txtnumero(txtdebitar.Text) Then
                MsgBox("solo se aceptan numeros")
            Else
                MsgBox("no hay sufiente stock")
            End If
        End If

        tabla.DataSource = controller.sql.consulta_productos.Tables(0)

    End Sub
End Class