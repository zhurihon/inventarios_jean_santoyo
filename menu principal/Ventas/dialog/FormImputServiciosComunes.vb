Public Class FormImputPrestar

    Public Property inputservicop As String
    Public Property inputprecio As Double


    Private Sub FormImputServiciosComunes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla.DataSource = controller.sql.dataset_servicio.Tables(0)
    End Sub


    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla.Rows(e.RowIndex)

            txtprecio.Text = row.Cells("precio").Value
            txtservicio.Text = row.Cells("descripcion").Value.ToString

            inputservicop = row.Cells("descripcion").Value.ToString

            inputprecio = row.Cells("precio").Value

        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If inputservicop <> "" Then

            DialogResult = DialogResult.OK
            Me.Close()

        Else
            MsgBox("Selecione un servicio común, o cancela la operción")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class