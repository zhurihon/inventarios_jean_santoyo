Public Class FormInputPrestar




    Public Property nombre As String
    Public Property cod As String





    Private Sub FormImputServiciosComunes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtHcod.Text = cod
        txtHnombre.Text = nombre

    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtCnombre.Text <> "" Then
            controller.sql.prestar_herramientas(cod, 1, txtCid.Text, dtpLimite.Value)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dialogt As New FormImputCliente
        dialogt.ShowDialog()

        If dialogt.DialogResult = DialogResult.OK Then

            txtCid.Text = dialogt.idcliente.ToString
            txtCnombre.Text = dialogt.nombrecliente.ToString


        End If



    End Sub
End Class