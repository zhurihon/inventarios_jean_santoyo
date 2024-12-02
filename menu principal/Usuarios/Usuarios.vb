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



End Class