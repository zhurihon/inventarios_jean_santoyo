Public Class registro_producto
    Public Sub registro_producto_Load()

    End Sub


    Public bprecio As Boolean
    Public bnombre As Boolean
    Public btipo As Boolean

    Public pk_cod As String

    Private Sub tipos_SelectedValueChanged(sender As Object, e As EventArgs)

        codigo.Text = (get_code(tipos.Text, menuprincipal.consulta_categoria_index(tipos.Text)))

    End Sub

    Private Sub nombre_TextChanged(sender As Object, e As EventArgs)

        If nombre.Text.Length <= 64 Then
            bnombre = 1
        Else
            bnombre = 0
        End If

    End Sub




    Private Sub registro_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipos.SelectedIndexChanged
        codigo.Text = get_code(tipos.Text, controller.sql.consulta_index(tipos.Text))
        btipo = 1
    End Sub

    Private Sub btn_nuevo_productos_Click(sender As Object, e As EventArgs) Handles btn_nuevo_productos.Click



        If btn_nuevo_productos.Text = "REGISTRAR" Then

            If btipo And bnombre And bprecio Then
                controller.sql.registrar_producto(codigo.Text, nombre.Text, CDbl(precio.Text), tipos.Text)
                codigo.Clear()
                nombre.Clear()
                precio.Clear()
                Productos.cargar_produtos(controller.sql.consulta_productos())
                bnombre = 0
                bprecio = 0
                btipo = 0
                MsgBox("Registrado exitosamente")

            Else
                Dim s As String = "Datos no aceptados"
                If Not btipo Then
                    s += vbNewLine & "Selecione una categoria"
                End If
                If Not bnombre Then
                    s += vbNewLine & "El nombre de ser de 4 a 12 dígitos"
                End If
                If Not bprecio Then
                    s += vbNewLine & "Debe ser un número potisivo"
                End If
                MsgBox(s)
                btn_modificar.Enabled = 0
                btn_eliminar.Enabled = 0

                Productos.cargar_produtos(controller.sql.consulta_productos())
            End If



        End If




    End Sub

    Private Sub precio_TextChanged(sender As Object, e As EventArgs) Handles precio.TextChanged

        Dim numero As Double

        If Double.TryParse(precio.Text, numero) Then
            'Console.WriteLine("La cadena es un número entero.")
            bprecio = 1
        Else
            'Console.WriteLine("La cadena NO es un número entero.")
            bprecio = 0
        End If

    End Sub

    Private Sub nombre_TextChanged_1(sender As Object, e As EventArgs) Handles nombre.TextChanged

        If nombre.Text = "" Or nombre.Text.Length >= 32 Then
            bnombre = 0
        Else
            bnombre = 1
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 


        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar el producto '" & nombre.Text & "' a " & pk_cod & "?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "No", salir de la función
        If resultado = DialogResult.Yes Then

            btn_modificar.Enabled = 0
            btn_eliminar.Enabled = 0
            btn_nuevo_productos.Enabled = 1
            controller.sql.actualizar_producto(pk_cod, codigo.Text, nombre.Text, CDbl(precio.Text), tipos.Text, proveedor.Text, "", "")


            codigo.Clear()
            nombre.Clear()
            precio.Clear()
            Productos.cargar_produtos(controller.sql.consulta_productos())
            bnombre = 0
            bprecio = 0
            btipo = 0
        End If


    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) 

        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el producto " & pk_cod & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            btn_modificar.Enabled = 0
            btn_eliminar.Enabled = 0
            controller.sql.eliminar_producto(pk_cod)

            codigo.Clear()
            nombre.Clear()
            precio.Clear()
            Productos.cargar_produtos(controller.sql.consulta_productos())
            bnombre = 0
            bprecio = 0
            btipo = 0


            btn_nuevo_productos_Click(Nothing, Nothing)
        End If


    End Sub

    Private Sub codigo_TextChanged(sender As Object, e As EventArgs) Handles codigo.TextChanged

    End Sub
End Class