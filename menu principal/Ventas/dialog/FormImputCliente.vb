Public Class FormImputCliente




    Public Property idcliente As String = ""
    Public Property nombrecliente As String = ""



    Private Sub FormImputCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla.DataSource = controller.sql.consulta_cliente().Tables(0)
    End Sub


    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla.Rows(e.RowIndex)
            tabla.Rows(e.RowIndex).Selected = True
            estado = 1
            txtid.Text = row.Cells("id").Value.ToString
            idcliente = row.Cells("id").Value.ToString
            txtNombre.Text = row.Cells("Nombre").Value.ToString
            nombrecliente = row.Cells("Nombre").Value.ToString


        End If

    End Sub

    Private estado As Boolean = 0


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Validar la entrada
        If estado And idcliente <> "" Then
            Me.DialogResult = DialogResult.OK ' Establecer el resultado del diálogo como OK
            Me.Close() ' Cerrar el formulario
        Else
            MessageBox.Show("Por favor, introduce una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel ' Establecer el resultado del diálogo como Cancel
        Me.Close() ' Cerrar el formulario
    End Sub
End Class