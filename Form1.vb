Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset








Public Class Form1





    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtcontrasena.TextChanged

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Dim Usuario As String = txtUsuario.Text


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtcontrasena.PasswordChar = ""
        Else
            txtcontrasena.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim sql As New bdd

        sql.login(txtUsuario.Text, txtcontrasena.Text)

    End Sub



    Private MouseIsDown As Boolean = False
    Private MouseIsDownLoc As Point = Nothing
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove

        If e.Button = MouseButtons.Left Then
            If MouseIsDown = False Then
                MouseIsDown = True
                MouseIsDownLoc = New Point(e.X, e.Y)
            End If

            Me.Location = New Point(Me.Location.X + e.X - MouseIsDownLoc.X, Me.Location.Y + e.Y - MouseIsDownLoc.Y)
        End If
    End Sub
    Private Sub PPanel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        MouseIsDown = False
    End Sub


    Private Sub Panel3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class
