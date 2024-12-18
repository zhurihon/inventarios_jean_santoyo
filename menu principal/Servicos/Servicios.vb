Public Class Servicios
    Public Sub Servicios_Load()
        tabla.DataSource = controller.sql.dataset_servicio().Tables(0)
        btn_nuevo_prov.Text = "REGISTRAR SERVICIO COMÚN"
    End Sub

    Public pk As Integer = 0

    Private Sub btn_nuevo_prov_Click(sender As Object, e As EventArgs) Handles btn_nuevo_prov.Click


        If btn_nuevo_prov.Text = "MODIFICAR" Then


            Dim s As String = ""
            If Comprobaciones.txtmaxymin(txtdescripcion.Text, 45, 2) Then

                If Comprobaciones.txtmaxymin(txtprecio.Text, 16, 1) And Comprobaciones.txtnumero(txtprecio.Text) Then

                    controller.sql.modificar_servicio(txtprecio.Text, txtdescripcion.Text, pk)
                    txtprecio.Clear()
                    txtdescripcion.Clear()
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

            btn_nuevo_prov.Text = "REGISTRAR SERVICIO COMÚN"
        Else


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


        End If




    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        tabla.DataSource = controller.sql.dataset_servicioTxt(txtBuscar.Text).Tables(0)
    End Sub

    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellContentClick

    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla.Rows(e.RowIndex)
            btn_nuevo_prov.Text = "MODIFICAR"
            txtprecio.Text = row.Cells("precio").Value
            txtdescripcion.Text = row.Cells("descripcion").Value.ToString
            pk = row.Cells("id").Value
        End If
    End Sub
End Class