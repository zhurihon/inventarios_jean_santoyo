Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography.X509Certificates

Imports La_nena.controller






Public Class menuprincipal


    Dim sql As New bdd

    Public ventana_usuarios As Panel = usuarios.Panel1
    Public ventana_proveedor As Panel = proveedor.Panel1
    Public ventana_producto As Panel = Productos.Panel1
    Public ventana_ventas As Panel = Cuadro_de_Ventas.Panel1
    Public ventana_compras As Panel = CuadroCompras.Panel1
    Public ventana_inventario As Panel = Inventario.Panel1
    Public ventana_alertar As Panel = alertas.Alerta
    Public ventana_reporte As Panel = Report.Panel1
    Public ventana_clientes As Panel = clientes.Panel1


    Public Function ocultar_paneles()
        ventana_usuarios.Visible = 0
        Panel1.Visible = 0

        ventana_proveedor.Visible = 0
        ventana_producto.Visible = 0

        ventana_ventas.Visible = 0
        ventana_compras.Visible = 0
        ventana_inventario.Visible = 0

        ventana_alertar.Visible = 0
        ventana_reporte.Visible = 0
        ventana_clientes.Visible = 0

    End Function

    Private Sub menuprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Controls.Add(ventana_usuarios)
        Me.Controls.Add(ventana_proveedor)

        Me.Controls.Add(ventana_producto)

        Me.Controls.Add(ventana_ventas)

        Me.Controls.Add(ventana_compras)

        Me.Controls.Add(ventana_inventario)

        Me.Controls.Add(ventana_alertar)

        Me.Controls.Add(ventana_reporte)

        Me.Controls.Add(ventana_clientes)

        Me.ControlBox = False
        Me.Text = ""

        ocultar_paneles()

        'ventana_alertar.Visible = 1
        'alertas.load_alertas()


    End Sub


    Public Function mostrar_usuarios() As DataSet
        Return sql.consulta_usuarios()
    End Function

    Public Function mostrar_proveedores() As DataSet
        Return sql.consulta_proveedores()
    End Function

    Public Function mostrar_Productos() As DataSet
        Return sql.consulta_productos
    End Function




    Public Function consulta_categoria_index(cat As String) As Integer
        Return sql.consulta_index(cat)
    End Function



    Public Function Visualizar_productos_control(gb As Control)
        ventana_producto.Controls.Add(gb)
    End Function






















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











    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
        Productos.Show()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim pregunta As String

        pregunta = MsgBox("¿Desea Salir del programa?", vbYesNo + vbQuestion)

        If pregunta = vbNo Then

            MsgBox("Ok")
            Exit Sub
        Else
            MsgBox("Cerrando Programa ")


        End If


        Me.Close()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs)

        Dim pregunta As String
        pregunta = MsgBox("¿Deseas Cerrar la Sesión?", vbYesNo + vbQuestion
                          )
        If pregunta = vbNo Then
            MsgBox("OK")
            Exit Sub
        Else
            MsgBox("Cerrando Sesión")

        End If


        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btnsesion_Click(sender As Object, e As EventArgs)
        Me.Close()
        Report.Show()

    End Sub

    Private Sub btnpro_Click(sender As Object, e As EventArgs)
        Cuadro_de_Ventas.Show()

    End Sub


    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Application.Exit()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs)
        ocultar_paneles()
        ventana_usuarios.Visible = 1
        usuarios.mostrar_usuarios()
    End Sub

    Private Sub btn_proveedores_Click(sender As Object, e As EventArgs) Handles btn_proveedores.Click
        ocultar_paneles()
        ventana_proveedor.Visible = 1
        proveedor.mostrar_proveedores()
    End Sub


    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        ocultar_paneles()
        ventana_producto.Visible = 1
        Productos.cargar_produtos(mostrar_Productos())
        Productos.load_panel()

    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click

        If Me.WindowState = 2 Then
            Me.WindowState = 0
        Else
            Me.WindowState = 2
        End If
    End Sub


    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Me.WindowState = 1
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        ocultar_paneles()
        ventana_ventas.Visible = 1
        Cuadro_de_Ventas.load_ventas()
    End Sub

    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        ocultar_paneles()
        ventana_compras.Visible = 1
        CuadroCompras.load_compras()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ocultar_paneles()
        ventana_inventario.Visible = 1
        Inventario.load_inventario()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs)

        ocultar_paneles()

        ventana_alertar.Visible = 1
        alertas.load_alertas()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ocultar_paneles()
        ventana_reporte.Visible = 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ocultar_paneles()
        ventana_usuarios.Visible = 1
        usuarios.Usuarios_Load()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ocultar_paneles()
        ventana_clientes.Visible = 1
        clientes.clientes_Load()
    End Sub
End Class