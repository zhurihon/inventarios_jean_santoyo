Public Class registro_marca

    Public pk As String

    Private Sub btn_nuevo_productos_Click(sender As Object, e As EventArgs) Handles btn_nuevo_productos.Click


        If btn_nuevo_productos.Text = "CANCELAR MODIFICACIÓN" Then

            btn_nuevo_productos.Text = "REGISTRA NUEVO MARCA"

            marca.Clear()
            btn_delete.Enabled = 0
            btn_update.Enabled = 0

        Else
            controller.sql.registrar_macar(marca.Text)
            Productos.tabla_productos.DataSource = controller.sql.consulta_marcas().Tables(0)
            marca.Clear()

        End If

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        controller.sql.actualizar_marca(marca.Text, pk)

        btn_nuevo_productos_Click(Nothing, Nothing)
        Productos.cargar_produtos(controller.sql.consulta_marcas())
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        controller.sql.eliminar_marca(marca.Text)

        btn_nuevo_productos_Click(Nothing, Nothing)
        Productos.cargar_produtos(controller.sql.consulta_marcas())

    End Sub

    Private Sub registro_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class