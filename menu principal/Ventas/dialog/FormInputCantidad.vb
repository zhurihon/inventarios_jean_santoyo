Public Class FormInputCantidad
    Private Sub FormInputCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property nCantidad As Decimal

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Validar la entrada
        Dim cantidad As Decimal
        If Decimal.TryParse(txtCantidad.Text, cantidad) Then
            nCantidad = cantidad
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


    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRegistrar_Click(Nothing, Nothing)
            e.SuppressKeyPress = True
        End If
    End Sub
End Class