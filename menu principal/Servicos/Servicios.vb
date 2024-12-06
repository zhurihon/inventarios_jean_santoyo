Public Class Servicios
    Public Sub Servicios_Load()
        tabla.DataSource = controller.sql.dataset_servicio().Tables(0)

    End Sub

    Private Sub btn_nuevo_prov_Click(sender As Object, e As EventArgs) Handles btn_nuevo_prov.Click
        Dim s As String = ""
        If Comprobaciones.txtmaxymin(txtdescripcion.Text, 45, 2) Then

            If Comprobaciones.txtmaxymin(txtprecio.Text, 16, 1) And Comprobaciones.txtnumero(txtprecio.Text) Then

                controller.sql.registrar_servicio(txtprecio.Text, txtdescripcion.Text)

            Else

                s += "el precio debe ser númerico o tener almenos un caracter"
            End If


        Else
            s += "Descripcion debe ser de 2 a 45 caracteres" & vbCrLf
        End If

        If Not s = "" Then
            MsgBox(s)
        End If

        tabla.DataSource = controller.sql.dataset_servicio.Tables(0)

    End Sub


End Class