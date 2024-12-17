Public Class clientes
    Private vinotinto As Color = Color.FromArgb(75, 7, 12)


    Private Sub btn_nuevo_prov_Click(sender As Object, e As EventArgs) Handles btn_nuevo_prov.Click




        If Comprobaciones.txtnumero(id.Text) And Comprobaciones.txtmaxymin(id.Text, 16, 6) Then
            id.BackColor = vinotinto

            If Comprobaciones.txtmaxymin(nombre.Text, 16, 4) Then
                nombre.BackColor = vinotinto

                If Comprobaciones.txtnumero(tlfno.Text) And Comprobaciones.txtmaxymin(tlfno.Text, 12, 8) Then
                    tlfno.BackColor = vinotinto

                    If Comprobaciones.txtmaxymin(direccion.Text, 32, 3) Then
                        direccion.BackColor = vinotinto


                        If Comprobaciones.txtmail(mail.Text) And Comprobaciones.txtmaxymin(mail.Text, 32, 7) Then
                            mail.BackColor = vinotinto

                            If cbx_tid.SelectedIndex <> -1 Then

                                cbx_tid.BackColor = Color.White
                                If controller.sql.registrar_cliente(cbx_tid.Text & id.Text, nombre.Text, tlfno.Text, direccion.Text, mail.Text) Then

                                    id.Clear()
                                    nombre.Clear()
                                    tlfno.Clear()
                                    direccion.Clear()
                                    mail.Clear()

                                    tabla_clientes.DataSource = controller.sql.dataset_clientes().Tables(0)

                                End If
                            Else
                                cbx_tid.BackColor = Color.Red

                            End If

                        Else
                                mail.BackColor = Color.Red


                        End If

                    Else
                        direccion.BackColor = Color.Red
                    End If

                Else
                        tlfno.BackColor = Color.Red

                End If

            Else
                    nombre.BackColor = Color.Red
            End If

        Else
            id.BackColor = Color.Red

        End If


    End Sub

    Public Sub clientes_Load()
        tabla_clientes.DataSource = controller.sql.dataset_clientes.Tables(0)
        cbx_tid.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        id.Clear()
        nombre.Clear()
        tlfno.Clear()
        direccion.Clear()
        mail.Clear()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        tabla_clientes.DataSource = controller.sql.buscar_clientetxt(txtBuscar.Text).Tables(0)
    End Sub

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class