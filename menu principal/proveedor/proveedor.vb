Imports La_nena.Comprobaciones

Public Class proveedor

    Public pk As String



    Public Sub mostrar_proveedores()
        tabla_proveedores.DataSource = menuprincipal.mostrar_proveedores().Tables(0)
    End Sub

    Public Sub clear()
        id.Text = ""
        nombre.Text = ""
        tlfno.Text = ""
        direccion.Text = ""
        mail.Text = ""
        descripcion.Text = ""
    End Sub

    Private Sub btn_nuevo_productos_Click(sender As Object, e As EventArgs) Handles btn_nuevo_prov.Click


        If btn_nuevo_prov.Text = "REGISTRA NUEVO PROVEEDOR" Then
            If control_proveedor.comprobar() Then

                controller.sql.registrar_proveedor(id.Text, nombre.Text, tlfno.Text, direccion.Text, mail.Text, descripcion.Text)
                clear()
                mostrar_proveedores()
            Else
                MsgBox("Compruebe los campos ingresados")
            End If

        Else
            btn_nuevo_prov.Text = "REGISTRA NUEVO PROVEEDOR"
            clear()
            mostrar_proveedores()

            btn_eliminar.Enabled = 0
            btn_modificar.Enabled = 0
        End If



    End Sub

    Private Sub tabla_proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_proveedores.CellContentClick

    End Sub

    Private Sub tabla_proveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_proveedores.CellClick


        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla_proveedores.Rows(e.RowIndex)
            tabla_proveedores.Rows(e.RowIndex).Selected = True

            id.Text = row.Cells("Identificacion").Value.ToString
            nombre.Text = row.Cells("Nombre").Value.ToString
            tlfno.Text = row.Cells("Numero").Value.ToString
            direccion.Text = row.Cells("Direccion").Value.ToString
            mail.Text = row.Cells("Email").Value.ToString
            descripcion.Text = row.Cells("Descripcion").Value.ToString

            pk = row.Cells("Identificacion").Value.ToString

            If row.Cells("Estado").Value.ToString = "activo" Then
                btn_eliminar.Text = "inactivo"
            Else
                btn_eliminar.Text = "activo"
            End If

            btn_nuevo_prov.Text = "CANCELAR MODIFICAR"
                btn_eliminar.Enabled = 1
                btn_modificar.Enabled = 1

            End If


    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click


        controller.sql.eliminar_proveedor(id.Text)

        If btn_eliminar.Text = "inactivo" Then
            btn_eliminar.Text = "activo"
        Else
            btn_eliminar.Text = "inactivo"
        End If

        btn_eliminar.Enabled = 0
            btn_modificar.Enabled = 0
            clear()
        btn_nuevo_prov.Text = "REGISTRA NUEVO PROVEEDOR"

        mostrar_proveedores()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click


        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar el proveedor '" & pk & "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "No", salir de la función
        If resultado = DialogResult.Yes Then

            controller.sql.actualizar_proveedor(pk, id.Text, nombre.Text, tlfno.Text, mail.Text, direccion.Text, descripcion.Text)

            btn_eliminar.Enabled = 0
            btn_modificar.Enabled = 0
            clear()
            btn_nuevo_prov.Text = "REGISTRA NUEVO PROVEEDOR"
        End If

        mostrar_proveedores()
    End Sub

    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged

        If Comprobaciones.txtmax(nombre.Text, 45) And Comprobaciones.txtmin(nombre.Text, 4) Then
            nombre.BackColor = Color.White
            control_proveedor.nombre = 1
        Else
            control_proveedor.nombre = 0
            nombre.BackColor = Color.Red
        End If
    End Sub

    Private Sub tlfno_TextChanged(sender As Object, e As EventArgs) Handles tlfno.TextChanged
        If Comprobaciones.txtmax(tlfno.Text, 11) And Comprobaciones.txtmin(tlfno.Text, 4) And Comprobaciones.txtnumero(tlfno.Text) Then
            tlfno.BackColor = Color.White
            control_proveedor.telefono = 1
        Else
            control_proveedor.telefono = 0
            tlfno.BackColor = Color.Red
        End If
    End Sub

    Private Sub mail_TextChanged(sender As Object, e As EventArgs) Handles mail.TextChanged
        If Comprobaciones.txtmail(mail.Text) And Comprobaciones.txtmin(mail.Text, 4) And Comprobaciones.txtmax(mail.Text, 45) Or Comprobaciones.txtvacio(mail.Text) Then
            mail.BackColor = Color.White
            control_proveedor.mail = 1
        Else
            control_proveedor.mail = 0
            mail.BackColor = Color.Red
        End If
    End Sub

    Private Sub direccion_TextChanged(sender As Object, e As EventArgs) Handles direccion.TextChanged
        If Comprobaciones.txtmax(direccion.Text, 45) And Comprobaciones.txtmin(direccion.Text, 4) Then
            direccion.BackColor = Color.White
            control_proveedor.direccion = 1
        Else
            control_proveedor.direccion = 0
            direccion.BackColor = Color.Red
        End If
    End Sub

    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        If Comprobaciones.txtmax(id.Text, 10) And Comprobaciones.txtmin(id.Text, 4) And Comprobaciones.txtnumero(id.Text) Then
            id.BackColor = Color.White
            control_proveedor.id = 1
        Else
            id.BackColor = Color.Red
            control_proveedor.id = False
        End If
    End Sub

    Private Sub descripcion_TextChanged(sender As Object, e As EventArgs) Handles descripcion.TextChanged
        If Comprobaciones.txtmin(descripcion.Text, 2) And Comprobaciones.txtmax(descripcion.Text, 45) Or Comprobaciones.txtvacio(descripcion.Text) Then
            descripcion.BackColor = Color.White
            control_proveedor.descripcion = 1
        Else
            Comprobaciones.control_proveedor.descripcion = 0
            descripcion.BackColor = Color.Red
        End If
    End Sub
End Class