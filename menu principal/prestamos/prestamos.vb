Public Class prestamos

    Private id As Integer = -1


    Public Sub prestamos_Load()
        tabla_herramienta.DataSource = controller.sql.dataset_herramientas().Tables(0)

        tabla_prestamos.DataSource = controller.sql.dataset_prestamos().Tables(0)
    End Sub

    Private Sub prestamos_update()
        tabla_herramienta.DataSource = controller.sql.dataset_herramientas().Tables(0)

        tabla_prestamos.DataSource = controller.sql.dataset_prestamos().Tables(0)
    End Sub




    Private Sub tabla_herramienta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_herramienta.CellContentClick

    End Sub

    Private Sub tabla_herramienta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_herramienta.CellClick



        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla_herramienta.Rows(e.RowIndex)


            'MsgBox(row.Cells(0).Value.ToString)

            Dim dialogprestar As New FormInputPrestar

            dialogprestar.cod = row.Cells(0).Value.ToString
            dialogprestar.nombre = row.Cells("nombre").Value.ToString

            dialogprestar.ShowDialog()
            tabla_prestamos.DataSource = controller.sql.dataset_prestamos().Tables(0)

        End If

    End Sub

    Private Sub tabla_prestamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_prestamos.CellContentClick

    End Sub

    Private Sub tabla_prestamos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_prestamos.CellClick



        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = tabla_prestamos.Rows(e.RowIndex)
            id = CInt(row.Cells("id").Value)
            Dim dias As Integer = DiasHastaFecha(row.Cells("fechalimite").Value.ToString)

            If dias > 0 Then
                lbDias.Text = "Días restantes"
                txtdias.Text = dias & " días"
            ElseIf dias < 0 Then
                lbDias.Text = "Días de restraso"
                txtdias.Text = Math.Abs(dias) & " días"
            Else
                lbDias.Text = "hoy es el día límite"
                txtdias.Text = "Hoy"

            End If

        End If


    End Sub


    Public Function DiasHastaFecha(fechaProporcionada As String) As Integer
        ' Convierte la cadena de fecha proporcionada a un objeto DateTime
        Dim fechaObjetivo As DateTime
        If DateTime.TryParse(fechaProporcionada, fechaObjetivo) Then
            ' Obtiene la fecha actual
            Dim fechaActual As DateTime = DateTime.Now

            ' Calcula la diferencia en días
            Dim diferencia As TimeSpan = fechaObjetivo - fechaActual

            ' Devuelve la cantidad de días
            Return diferencia.Days
        Else
            ' Si la fecha proporcionada no es válida, puedes lanzar una excepción o devolver un valor especial
            Throw New ArgumentException("La fecha proporcionada no es válida.")
        End If
    End Function

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If id < 0 Then
            'nada
            MsgBox("selecione algún préstamo")
        Else
            'id eliminamos de los press
            controller.sql.prestamo_recibido(id)
            prestamos_update()
            id = -1
        End If
    End Sub
End Class