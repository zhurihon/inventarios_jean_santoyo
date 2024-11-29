Imports La_nena.Generador_de_código


Public Class Productos
    Public producto_gbproducto As GroupBox = registro_producto.GroupBox1
    Public producto_gbmarca As GroupBox = registro_marca.GroupBox1
    Public producto_gbcolor As GroupBox = registro_color.gb_color
    Public Sub farreglo()

        Panel1.Controls.Add(producto_gbproducto)
        producto_gbproducto.Visible = 1
    End Sub
    'FUNCIONES
    Public Sub load_panel()

        Static sload As Boolean = 0
        Static panel_rp As Boolean = 0
        If sload = 0 Then
            menuprincipal.Visualizar_productos_control(producto_gbproducto)
            menuprincipal.Visualizar_productos_control(producto_gbmarca)
            menuprincipal.Visualizar_productos_control(producto_gbcolor)

            sload = 1
        Else
            producto_gbmarca.Visible = 0
            producto_gbproducto.Visible = 0

        End If

        farreglo()

    End Sub

    Public Sub cargar_produtos(data As DataSet)
        tabla_productos.DataSource = data.Tables(0)
    End Sub





    ''' '''''''''''''''''''''''''''''''''''



    Private Sub btn_back1_Click(sender As Object, e As EventArgs)
        Me.Close()
        menuprincipal.Show()

    End Sub




    Private Sub btn_compras_Click_1(sender As Object, e As EventArgs)

        op = 1
        producto_gbproducto.Visible = 1

        registro_producto.registro_producto_Load()
        '.Controls.Add(producto_gbproducto)

    End Sub

    Private Sub gb_menuproducto_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        op = 2
        producto_gbmarca.Visible = 1
        tabla_productos.DataSource = controller.sql.consulta_marcas().Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        op = 3
        producto_gbcolor.Visible = 1
        tabla_productos.DataSource = controller.sql.consulta_color().Tables(0)
    End Sub

    Private Sub tabla_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_productos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tabla_productos.Rows(e.RowIndex)
            tabla_productos.Rows(e.RowIndex).Selected = True

            'Dim mensaje As String = ""
            'For Each cell As DataGridViewCell In row.Cells
            'mensaje &= cell.Value.ToString() & " "
            'Next
            'MessageBox.Show("Fila seleccionada: " & mensaje)

            'Dim nombre As String = row.Cells("nombre").Value.ToString()




            Select Case op
                Case 1
                    registro_producto.nombre.Text = row.Cells("nombre").Value.ToString()
                    registro_producto.precio.Text = row.Cells("precio").Value.ToString()

                    registro_producto.tipos.SelectedItem = row.Cells("tipo").Value.ToString()


                    registro_producto.codigo.Text = row.Cells("cod").Value.ToString()

                    registro_producto.pk_cod = row.Cells("cod").Value.ToString()

                    registro_producto.btn_nuevo_productos.Text = "CANCELAR MODIFICACIÓN"
                    registro_producto.btn_modificar.Enabled = 1
                    registro_producto.btn_eliminar.Enabled = 1
                Case 2
                    'Marca

                    registro_marca.marca.Text = row.Cells("Marca").Value.ToString()
                    registro_marca.btn_nuevo_productos.Text = "CANCELAR MODIFICACIÓN"
                    registro_marca.btn_delete.Enabled = 1
                    registro_marca.btn_update.Enabled = 1
                    registro_marca.pk = row.Cells("Marca").Value.ToString

                Case 3



                    registro_color.color.Text = row.Cells("colormaterial").Value.ToString
                    registro_color.btn_modif.Enabled = 1
                    registro_color.btn_delete.Enabled = 1
                    registro_color.btn_nuevo_color.Text = "CANCELAR MODIFICAR"

                    registro_color.pk = row.Cells("colormaterial").Value.ToString

                Case Else

            End Select


        End If
    End Sub

    Private Sub tabla_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_productos.CellContentClick

    End Sub

    Public op As Short = 0

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class