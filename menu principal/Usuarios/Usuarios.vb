Imports System.Data.SqlClient

Public Class usuarios
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_usuarios.CellContentClick

    End Sub

    Private Sub Btnactualizar_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Usuarios_Load()
        tabla_usuarios.DataSource = controller.sql.consulta_usuarios.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()


    End Sub


    Public Sub mostrar_usuarios()
        tabla_usuarios.DataSource = menuprincipal.mostrar_usuarios().Tables(0)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        If Comprobaciones.txtmaxymin(txtuser.Text, 16, 8) Then
            txtuser.BackColor = Color.FromArgb(75, 7, 12)

            If Comprobaciones.txtmaxymin(txtnombre.Text, 32, 4) Then
                txtnombre.BackColor = Color.FromArgb(75, 7, 12)

                If Comprobaciones.txtmaxymin(txtpass.Text, 16, 8) Then
                    txtpass.BackColor = Color.FromArgb(75, 7, 12)

                    If cb_cargo.SelectedIndex <> -1 Then
                        cb_cargo.BackColor = Color.FromArgb(75, 7, 12)

                        controller.sql.registrar_usuario(txtuser.Text, txtnombre.Text, txtpass.Text, cb_cargo.Text)
                        tabla_usuarios.DataSource = controller.sql.consulta_usuarios.Tables(0)

                        txtnombre.Clear()
                        txtpass.Clear()
                        txtuser.Clear()
                        cb_cargo.SelectedIndex = -1


                    Else
                        cb_cargo.BackColor = Color.Red

                    End If

                Else
                    txtpass.BackColor = Color.Red


                End If


            Else
                    txtnombre.BackColor = Color.Red
            End If

        Else
            txtuser.BackColor = Color.Red
        End If




    End Sub
End Class