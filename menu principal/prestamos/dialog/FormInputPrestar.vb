Public Class FormInputPrestar




    Public Property nombre As String
    Public Property cod As String


    Public tipopago As Boolean


    Private Sub FormImputServiciosComunes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtHcod.Text = cod
        txtHnombre.Text = nombre

    End Sub

    Private Function comprobarAlquiler() As Boolean

    End Function




    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'factura.facturAlquiler_Load()



        If txtCnombre.Text <> "" Then

            Dim info As New factura.alquilerclass
            info.idfactura = controller.sql.prestar_herramientas(cod, 1, txtCid.Text, dtpLimite.Value, txtinicial.Text, txtdiario.Text, DateDiff(DateInterval.Day, DateTime.Now.Date, dtpLimite.Value.Date))
            info.codHerramienta = txtHcod.Text
            info.idCliente = txtCid.Text
            info.cantidad = 1
            info.inicial = txtinicial.Text
            info.costoDias = txtdiario.Text
            info.fechaLimite = dtpLimite.Value
            info.fechaRetiro = Date.Today
            info.tipopago = rbDivisa.Checked
            info.dias = DateDiff(DateInterval.Day, DateTime.Now.Date, dtpLimite.Value.Date)
            factura.facturAlquiler_Load(info)

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

    Private Sub txtinicial_TextChanged(sender As Object, e As EventArgs) Handles txtinicial.TextChanged
        costoAlquiler()
    End Sub






    Public Sub costoAlquiler()
        If Comprobaciones.txtnumero(txtinicial.Text) And Comprobaciones.txtnumero(txtdiario.Text) Then

            Dim diasFaltan As Integer = DateDiff(DateInterval.Day, DateTime.Now.Date, dtpLimite.Value.Date)
            ' Mostrar el resultado
            'MessageBox.Show("Faltan " & diasFaltan & " días y para llegar a la fecha seleccionada.")



            lbtotal.Text = (CDbl(txtinicial.Text) + (diasFaltan * CDbl(txtdiario.Text))).ToString

        End If

    End Sub

    Private Sub txtdiario_TextChanged(sender As Object, e As EventArgs) Handles txtdiario.TextChanged
        costoAlquiler()
    End Sub

    Private Sub dtpLimite_ValueChanged(sender As Object, e As EventArgs) Handles dtpLimite.ValueChanged
        lbshowdias.Text = "por " & DateDiff(DateInterval.Day, DateTime.Now.Date, dtpLimite.Value.Date) & " días"
        costoAlquiler()
    End Sub

End Class