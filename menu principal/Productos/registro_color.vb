Public Class registro_color
    Private Sub btn_nuevo_productos_Click(sender As Object, e As EventArgs) Handles btn_nuevo_color.Click

        If btn_nuevo_color.Text = "REGISTRA NUEVO COLOR" Then
            controller.sql.registrar_color(color.Text)
            Productos.tabla_productos.DataSource = controller.sql.consulta_color().Tables(0)
            color.Clear()

        Else
            btn_nuevo_color.Text = "REGISTRA NUEVO COLOR"
            btn_modif.Enabled = 0
            btn_delete.Enabled = 0
            Productos.tabla_productos.DataSource = controller.sql.consulta_color().Tables(0)
            color.Clear()
        End If

    End Sub

    Private Sub btn_modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click

        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar el color '" & color.Text & "' a " & pk & "?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "No", salir de la función
        If resultado = DialogResult.Yes Then
            btn_modif.Enabled = 0
            btn_delete.Enabled = 0
            controller.sql.actualizar_color(pk, color.Text)
            Productos.tabla_productos.DataSource = controller.sql.consulta_color().Tables(0)


            btn_nuevo_productos_Click(Nothing, Nothing)
        End If


    End Sub


    Public pk As String

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el color '" & pk & "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "No", salir de la función
        If resultado = DialogResult.Yes Then

            controller.sql._eliminar_color(pk)


            btn_modif.Enabled = 0
            btn_delete.Enabled = 0
            Productos.tabla_productos.DataSource = controller.sql.consulta_color().Tables(0)
            color.Clear()


        End If
        btn_nuevo_color.Text = "REGISTRA NUEVO COLOR"


    End Sub
End Class