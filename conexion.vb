Imports MySql.Data.MySqlClient

Module conexion
    Public Class bdd
        Private comando As New MySqlCommand
        'Dim datos_servidor As String = "server=localhost; user id=root; password=25032003"
        Dim datos_servidor As String = "server=localhost; user id=root; password=30p1drd3; database =santoyo"

        Public miconexion As MySqlConnection = New MySqlConnection(datos_servidor)

        Public Sub login(name, pass)
            miconexion.Open()
            Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.usuario WHERE usuario='" & name & "' AND clave='" & pass & "'", miconexion)

            Dim datos_recebidos As New DataSet

            llamada.Fill(datos_recebidos, "usuario")

            If datos_recebidos.Tables("usuario").Rows.Count() = 0 Then

                MsgBox("los datos están incorrectos, inténtelo de nuevo")
                miconexion.Close()
            Else

                For Each roww As DataRow In datos_recebidos.Tables("usuario").Rows
                    'MsgBox("Bienvenido," & roww("usuario"))

                    Form1.Hide()


                    menuprincipal.Show()
                    miconexion.Close()

                Next


                miconexion.Close()

            End If

        End Sub






        Public Function consulta_usuarios() As DataSet
            miconexion.Open()

            Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.usuario", miconexion)


            Dim datos_recebidos As New DataSet


            llamada.Fill(datos_recebidos, "prov")


            miconexion.Close()

            Return datos_recebidos
        End Function




        Public Function consulta_proveedores() As DataSet
            miconexion.Open()

            Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.proveedor", miconexion)


            Dim datos_recebidos As New DataSet


            llamada.Fill(datos_recebidos, "prov")


            miconexion.Close()

            Return datos_recebidos
        End Function


        Public Function consulta_productos() As DataSet
            miconexion.Open()

            Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.producto", miconexion)

            Dim datos_recebidos As New DataSet

            llamada.Fill(datos_recebidos, "prod")

            miconexion.Close()

            Return datos_recebidos
        End Function

        Public Function buscar_productostxt(txt As String) As DataSet
            miconexion.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM producto where cod like @txt or nombre like @txt or tipo like @txt", miconexion)
            cmd.Parameters.AddWithValue("@txt", "%" & txt & "%")

            Dim llamada As New MySqlDataAdapter(cmd)

            Dim datos_recebidos As New DataSet

            llamada.Fill(datos_recebidos, "prod")

            miconexion.Close()

            Return datos_recebidos
        End Function

        Public Function buscar_facturastxt(txt As String) As DataSet
            miconexion.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM ventas where id like @txt or cliente like @txt or fechaventa like @txt or descripcion like @txt", miconexion)
            cmd.Parameters.AddWithValue("@txt", "%" & txt & "%")

            Dim llamada As New MySqlDataAdapter(cmd)

            Dim datos_recebidos As New DataSet

            llamada.Fill(datos_recebidos, "prod")

            miconexion.Close()

            Return datos_recebidos
        End Function

        Public Function consulta_productos_Indexid(id As String) As DataSet

            Try

                miconexion.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM santoyo.producto WHERE cod LIKE @busqueda", miconexion)
                cmd.Parameters.AddWithValue("@busqueda", "%" & id & "%")

                Dim llamada As New MySqlDataAdapter(cmd)

                Dim datos_recebidos As New DataSet

                llamada.Fill(datos_recebidos, "prod")

                miconexion.Close()

                Return datos_recebidos

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try



        End Function


        Public Function InfoProductoId(id As String) As DataSet

            Try

                miconexion.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM santoyo.producto WHERE cod = @busqueda", miconexion)
                cmd.Parameters.AddWithValue("@busqueda", id)

                Dim llamada As New MySqlDataAdapter(cmd)

                Dim datos_recebidos As New DataSet

                llamada.Fill(datos_recebidos, "prod")

                miconexion.Close()

                Return datos_recebidos

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try



        End Function


        Public Function consulta_cliente() As DataSet
            miconexion.Open()

            Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.cliente", miconexion)

            Dim datos_recebidos As New DataSet

            llamada.Fill(datos_recebidos, "prod")

            miconexion.Close()

            Return datos_recebidos
        End Function


        Public Function registrar_producto(cod As String, nombre As String, precio As Double, tipo As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO santoyo.producto (cod, nombre, precio, tipo) VALUES (@cod, @nombre, @precio, @tipo)", miconexion)
                comando.Parameters.AddWithValue("@cod", cod)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@precio", precio)
                comando.Parameters.AddWithValue("@tipo", tipo)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                If filas_afectadas > 0 Then
                    registrar_producto_id(tipo)
                End If

                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function



        Public Function registrar_cliente(id As Integer, nombre As String, telefono As String, direccion As String, mail As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO cliente (id, Nombre, Telefono, Direccion, Mail) VALUES (@id, @nombre, @telefono, @direccion, @mail)", miconexion)
                comando.Parameters.AddWithValue("@id", id)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@telefono", telefono)
                comando.Parameters.AddWithValue("@direccion", direccion)
                comando.Parameters.AddWithValue("@mail", mail)

                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()

                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function


        Public Function registrar_usuario(usuario As String, nombre As String, clave As String, cargo As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO usuario (usuario, nombre, clave, cargo) VALUES (@usuario, @nombre, @clave, @cargo)", miconexion)
                comando.Parameters.AddWithValue("@usuario", usuario)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@clave", clave)
                comando.Parameters.AddWithValue("@cargo", cargo)

                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()

                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function actualizar_producto(pk As String, cod As String, nombre As String, precio As Single, tipo As String, proveedor As String, marca As String, color As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("UPDATE santoyo.producto SET cod = @codg, nombre = @nombre, precio = @precio, tipo = @tipo, proveedor = @proveedor, marca = @marca, color = @color WHERE cod = @cod", miconexion)
                comando.Parameters.AddWithValue("@cod", pk)
                comando.Parameters.AddWithValue("@codg", cod)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@precio", precio)
                comando.Parameters.AddWithValue("@tipo", tipo)
                comando.Parameters.AddWithValue("@proveedor", proveedor)
                comando.Parameters.AddWithValue("@marca", marca)
                comando.Parameters.AddWithValue("@color", color)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function
        Public Function eliminar_producto(cod As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("DELETE FROM santoyo.producto WHERE cod = @cod", miconexion)

                ' Agregar el parámetro
                comando.Parameters.AddWithValue("@cod", cod)

                ' Ejecutar el comando
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()

                ' Retornar verdadero si se eliminó al menos un registro
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function registrar_producto_id(cat As String) As Boolean
            Try
                Dim comando As New MySqlCommand("Update santoyo.categorias set id = id + 1 Where Categoria = @cat", miconexion)
                comando.Parameters.AddWithValue("@cat", cat)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            End Try
        End Function


        Public Function comprar_producto_STOCK(pk As String, cantidad As Double) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("UPDATE santoyo.producto SET cantidad = cantidad + @cantidad WHERE cod = @cod", miconexion)
                comando.Parameters.AddWithValue("@cod", pk)
                comando.Parameters.AddWithValue("@cantidad", cantidad)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function comprar_producto_historial(codigo As String, cantidad As Double, precio_compra As String, proveedor As String) As Boolean

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO santoyo.compra (codigo,cantidad, precio, idproveedor, fecha) VALUES (@codigo, @cantidad, @precio, @idproveedor, @fecha)", miconexion)
                comando.Parameters.AddWithValue("@codigo", codigo)
                comando.Parameters.AddWithValue("@cantidad", cantidad)
                comando.Parameters.AddWithValue("@precio", precio_compra)
                comando.Parameters.AddWithValue("@idproveedor", proveedor)
                comando.Parameters.AddWithValue("@fecha", DateTime.Now)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()

                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function




        Public Function modificar_proveedores(id As String, nombre As String, numero As String, direccion As String, email As String, des As String) As DataSet

            miconexion.Open()

            Dim cmb As New MySqlCommand("UPDATE santoyo.proveedor SET Identificacion='" & id & "',Nombre='" & nombre & "',Numero='" & numero & "',Direccion='" & direccion & "',Email='" & email & "' WHERE Identificacion='" & id & "'", miconexion)

            cmb.ExecuteNonQuery()


            miconexion.Close()

        End Function





        Public Function registrar_producto() As Boolean



        End Function




        Public Function registrar_macar(marca As String) As Boolean
            Try
                miconexion.Open()

                Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM santoyo.marca WHERE Marca = @marca", miconexion)
                checkCommand.Parameters.AddWithValue("@marca", marca)

                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MsgBox("Marca:" & marca & " ya está registrada")
                    Return 0
                End If

                Dim insertCommand As New MySqlCommand("INSERT INTO santoyo.marca (Marca) VALUES (@marca)", miconexion)
                insertCommand.Parameters.AddWithValue("@marca", marca)
                insertCommand.ExecuteNonQuery()

                Return 1
            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function consulta_marcas() As DataSet
            miconexion.Open()

            Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.marca", miconexion)

            Dim datos_recebidos As New DataSet

            llamada.Fill(datos_recebidos, "prod")

            miconexion.Close()

            Return datos_recebidos
        End Function


        Public Function actualizar_marca(marca As String, pk As String) As Boolean
            Try
                miconexion.Open()
                Dim updateCommand As New MySqlCommand("UPDATE santoyo.marca SET Marca = @marca WHERE Marca = @pk", miconexion)
                updateCommand.Parameters.AddWithValue("@marca", marca)
                updateCommand.Parameters.AddWithValue("@pk", pk)
                updateCommand.ExecuteNonQuery()

                MsgBox("Marca: " & marca & " actualizada correctamente")
                Return True
            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function eliminar_marca(marca As String) As Boolean
            Try
                miconexion.Open()

                ' Comprobar si la marca existe antes de intentar eliminarla
                Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM santoyo.marca WHERE Marca = @marca", miconexion)
                checkCommand.Parameters.AddWithValue("@marca", marca)

                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count = 0 Then
                    MsgBox("Marca: " & marca & " no está registrada")
                    Return False
                End If

                ' Realizar la eliminación
                Dim deleteCommand As New MySqlCommand("DELETE FROM santoyo.marca WHERE Marca = @marca", miconexion)
                deleteCommand.Parameters.AddWithValue("@marca", marca)
                deleteCommand.ExecuteNonQuery()

                MsgBox("Marca: " & marca & " eliminada correctamente")
                Return True
            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function











        Public Function consulta_index(cat As String) As Int16
            miconexion.Open()
            Dim cmd As New MySqlCommand("SELECT id FROM santoyo.categorias WHERE Categoria = @cate", miconexion)
            cmd.Parameters.AddWithValue("@cate", cat)

            Dim llamada As New MySqlDataAdapter(cmd)
            Dim datos_recebidos As New DataSet
            llamada.Fill(datos_recebidos, "prod")
            Dim nint As Integer = datos_recebidos.Tables(0).Rows(0).Item(0)
            miconexion.Close()
            Return nint
        End Function







        Public Function consulta_color() As DataSet
            Try
                miconexion.Open()

                Dim llamada As New MySqlDataAdapter("SELECT * FROM santoyo.colormaterial", miconexion)

                Dim datos_recebidos As New DataSet

                llamada.Fill(datos_recebidos, "prod")

                miconexion.Close()

                Return datos_recebidos

            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function registrar_color(color As String) As DataSet
            Try
                miconexion.Open()

                Dim cmd As New MySqlCommand("INSERT INTO santoyo.colormaterial (colormaterial) VALUES (@color)", miconexion)
                cmd.Parameters.AddWithValue("@color", color)
                Dim llamada As New MySqlDataAdapter(cmd)

                Dim datos_recebidos As New DataSet

                llamada.Fill(datos_recebidos, "prod")

                miconexion.Close()

                Return datos_recebidos

            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function actualizar_color(color_antiguo As String, color_nuevo As String) As Boolean
            Try
                miconexion.Open()
                Dim cmd As New MySqlCommand("UPDATE santoyo.colormaterial SET colormaterial = @color_nuevo WHERE colormaterial = @color_antiguo", miconexion)
                cmd.Parameters.AddWithValue("@color_antiguo", color_antiguo)
                cmd.Parameters.AddWithValue("@color_nuevo", color_nuevo)
                Dim filas_afectadas As Integer = cmd.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function _eliminar_color(color As String) As Boolean

            Try
                miconexion.Open()

                ' Comprobar si la marca existe antes de intentar eliminarla
                Dim checkCommand As New MySqlCommand("SELECT COUNT(*) FROM santoyo.colormaterial WHERE colormaterial = @marca", miconexion)
                checkCommand.Parameters.AddWithValue("@marca", color)

                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count = 0 Then
                    MsgBox("Color/Material: " & color & " no está registrada")
                    Return False
                End If

                ' Realizar la eliminación
                Dim deleteCommand As New MySqlCommand("DELETE FROM santoyo.colormaterial WHERE colormaterial = @marca", miconexion)
                deleteCommand.Parameters.AddWithValue("@marca", color)
                deleteCommand.ExecuteNonQuery()

                MsgBox("Color/Material: " & color & " eliminada correctamente")
                Return True
            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try




        End Function





        Public Function dataset_servicio() As DataSet
            Try
                miconexion.Open()

                Dim llamada As New MySqlDataAdapter("SELECT * FROM servicios", miconexion)

                Dim datos_recebidos As New DataSet

                llamada.Fill(datos_recebidos, "prod")

                miconexion.Close()

                Return datos_recebidos

            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_servicioTxt(txt As String) As DataSet
            Try
                miconexion.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM servicios where descripcion like @txt or id like @txt", miconexion)

                cmd.Parameters.AddWithValue("@txt", "%" & txt & "%")

                Dim llamada As New MySqlDataAdapter(cmd)

                Dim datos_recebidos As New DataSet

                llamada.Fill(datos_recebidos, "prod")

                miconexion.Close()

                Return datos_recebidos

            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function



        Public Function registrar_servicio(precio As Double, descripcion As String) As Boolean
            Try
                miconexion.Open()

                Dim cmd As New MySqlCommand("INSERT INTO servicios (precio, descripcion) VALUES (@precio,@descripcion)", miconexion)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@descripcion", descripcion)
                cmd.ExecuteNonQuery()

                miconexion.Close()


            Catch ex As Exception
                ' Manejo de errores (puedes registrar el error o mostrar un mensaje)
                MsgBox("Error: " & ex.Message)
            Finally
                ' Asegurarse de cerrar la conexión
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function




        Public Function registrar_proveedor(id As String, nombre As String, numero As String, direccion As String, mail As String, descripcion As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO santoyo.proveedor (Identificacion, Nombre, Numero, Email, Direccion,Descripcion) VALUES (@id, @nombre, @n, @m, @d, @desc)", miconexion)
                comando.Parameters.AddWithValue("@id", id)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@n", numero)
                comando.Parameters.AddWithValue("@d", direccion)
                comando.Parameters.AddWithValue("@m", mail)
                comando.Parameters.AddWithValue("@desc", descripcion)

                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()

                If filas_afectadas > 0 Then

                End If

                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function actualizar_proveedor(pk As String, id As String, nombre As String, tlfn As String, correo As String, direccion As String, descripcion As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("UPDATE santoyo.proveedor SET Identificacion = @id, Nombre = @nombre, Numero = @telef, Email = @correo, Descripcion = @Descripcion, Direccion = @direccion WHERE Identificacion = @pk", miconexion)
                comando.Parameters.AddWithValue("@pk", pk)
                comando.Parameters.AddWithValue("@id", id)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@telef", tlfn)
                comando.Parameters.AddWithValue("@correo", correo)
                comando.Parameters.AddWithValue("@direccion", direccion)
                comando.Parameters.AddWithValue("@Descripcion", descripcion)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function eliminar_proveedor(cod As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("UPDATE proveedor 
SET Estado = CASE 
                WHEN Estado = 'activo' THEN 'inactivo' 
                WHEN Estado = 'inactivo' THEN 'activo' 
                ELSE Estado  -- Esto mantiene el estado actual si no es 'activo' ni 'inactivo'
             END 
WHERE Identificacion = @cod", miconexion)

                ' Agregar el parámetro
                comando.Parameters.AddWithValue("@cod", cod)

                ' Ejecutar el comando
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()

                ' Retornar verdadero si se eliminó al menos un registro
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function




        Public Function vender_STOCK(pk As String, cantidad As Double) As Boolean


            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("UPDATE producto SET cantidad = cantidad - @cantidad WHERE cod = @cod", miconexion)
                comando.Parameters.AddWithValue("@cod", pk)
                comando.Parameters.AddWithValue("@cantidad", cantidad)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function vender_HISTORIAL(idproducto As String, valor As Double, cantidad As Double) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO ventas (idproducto, valor, fechaventa, cantidad) VALUE (@idproducto, @valor, @fechaventa, @cantidad)", miconexion)
                comando.Parameters.AddWithValue("@idproducto", idproducto)
                comando.Parameters.AddWithValue("@valor", valor)
                comando.Parameters.AddWithValue("@fechaventa", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                comando.Parameters.AddWithValue("@cantidad", cantidad)
                Dim filas_afectadas As Integer = comando.ExecuteNonQuery()
                Return filas_afectadas > 0
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return False
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Sub vender(idproducto As String, valor As Double, cantidad As Double)

            vender_HISTORIAL(idproducto, valor, cantidad)

            vender_STOCK(idproducto, cantidad)

        End Sub


        Public Function search_dataset_productos2(busquera, tipo, f_inicio, f_fin) As DataSet

            Dim consulta As String


            Try



                Select Case tipo
                    Case 1
                        consulta = "SELECT 
    producto.cod, 
    producto.nombre, 
    producto.cantidad, 
    producto.precio,  
    producto.tipo,  
    producto.marca, 
    producto.color 
FROM 
    producto 
WHERE producto.nombre LIKE @buscarTexto 
    OR producto.cod LIKE @buscarTexto;"
                    Case 2
                        consulta =
"SELECT v.id, v.idproducto, p.nombre, v.valor, v.fechaventa, v.cantidad 
FROM ventas v
INNER JOIN producto p ON v.idproducto = p.cod
WHERE p.cod LIKE @buscarTexto OR p.nombre LIKE @buscarTexto"
                    Case 3

                    Case Else
                        Error ("sc not type")
                End Select




                miconexion.Open()
                Dim comando As New MySqlCommand(consulta, miconexion)

                comando.Parameters.AddWithValue("@buscarTexto", "%" & busquera & "%")

                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")

                miconexion.Close()
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function


        Public Function search_dataset_productos(busquera As String, tipo As Integer, bfinicio As Boolean, f_inicio As DateTime?, bffinas As Boolean, f_fin As DateTime?) As DataSet
            Dim consulta As String
            Try
                Select Case tipo
                    Case 1
                        consulta = "SELECT 
                                producto.cod, 
                                producto.nombre, 
                                producto.cantidad, 
                                producto.precio,  
                                producto.tipo,  
                                producto.marca, 
                                producto.color 
                            FROM 
                                producto 
                            WHERE 
                                producto.nombre LIKE @buscarTexto 
                                OR producto.cod LIKE @buscarTexto;"
                    Case 2
                        consulta = "SELECT 
                                v.id, 
                                v.idproducto, 
                                p.nombre, 
                                v.valor, 
                                v.fechaventa, 
                                v.cantidad 
                            FROM 
                                ventas v
                            INNER JOIN 
                                producto p ON v.idproducto = p.cod
                            WHERE "

                        If bfinicio And bffinas Then
                            consulta += "
                                (p.cod LIKE @buscarTexto OR p.nombre LIKE @buscarTexto) " &
                                        "AND (DATE(v.fechaventa) >= @f_inicio AND DATE(v.fechaventa) <= @f_fin);"
                        Else            'DATE(v.fechaventa) >= @f_inicio AND DATE(v.fechaventa) <= @f_fin
                            If bfinicio Then

                                consulta += "
                                (p.cod LIKE @buscarTexto OR p.nombre LIKE @buscarTexto) " &
                                        "AND (DATE(v.fechaventa) >= @f_inicio);"
                            Else
                                If bffinas Then
                                    consulta += "
                                (p.cod LIKE @buscarTexto OR p.nombre LIKE @buscarTexto) " &
                                        "AND (DATE(v.fechaventa) <= @f_fin);"
                                Else
                                    consulta += "
                                (p.cod LIKE @buscarTexto OR p.nombre LIKE @buscarTexto);"
                                End If
                            End If
                        End If


                    Case 3

                        consulta = "SELECT 
                                c.id, 
                                c.codigo, 
                                c.precio, 
                                p.Nombre AS NombreProveedor, 
                                c.fecha, 
                                c.cantidad 
                            FROM 
                                compra c 
                            INNER JOIN 
                                proveedor p ON c.idproveedor = p.Identificacion 
                            WHERE "

                        If bfinicio And bffinas Then
                            consulta += "
                                (c.codigo LIKE @buscarTexto) " &
                                "AND (DATE(c.fecha) >= @f_inicio AND DATE(c.fecha) <= @f_fin);"
                        Else
                            If bfinicio Then
                                consulta += "(c.codigo LIKE @buscarTexto) " &
                                "AND (DATE(c.fecha) >= @f_inicio);"
                            Else
                                If bffinas Then
                                    consulta += "(c.codigo LIKE @buscarTexto) " &
                                "AND (DATE(c.fecha) <= @f_fin);"
                                Else
                                    consulta += "(c.codigo LIKE @buscarTexto);"
                                End If
                            End If
                        End If




                    Case Else
                        Throw New Exception("Tipo de búsqueda no válido")
                End Select

                miconexion.Open()
                Dim comando As New MySqlCommand(consulta, miconexion)

                comando.Parameters.AddWithValue("@buscarTexto", "%" & busquera & "%")

                ' Solo agrega los parámetros de fecha si no son Nothing
                If f_inicio.HasValue And bfinicio Then
                    comando.Parameters.AddWithValue("@f_inicio", f_inicio.Value.Date)
                End If

                If f_fin.HasValue And bffinas Then
                    comando.Parameters.AddWithValue("@f_fin", f_fin.Value.Date)
                End If

                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")

                miconexion.Close()
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function



        Public Function stock_leve_normal() As Integer()

            Dim data(2) As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call stock_bajo();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                data(0) = dt.Tables(0).Rows(0).Item(0)
                data(1) = dt.Tables(0).Rows(0).Item(1)
                miconexion.Close()
                Return data

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function


        Public Function dataset_stock_bajo() As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("select cod,nombre,cantidad from producto where cantidad <=5;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function
        Public Function dataset_clientes() As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("select * from cliente;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function



        Public Function consulta_clienteId(id As String) As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("select * from cliente where id= @id;", miconexion)
                comando.Parameters.AddWithValue("@id", id)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function


        Public Function buscar_clientetxt(id As String) As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("select * from cliente where id like @id or Nombre like @nombre ;", miconexion)
                comando.Parameters.AddWithValue("@id", "%" & id & "%")
                comando.Parameters.AddWithValue("@nombre", "%" & id & "%")
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function

        Public Function dataset_VentasAnno() As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call VentasAnno();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function
        Public Function dataset_VentasMes() As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call VentasMesUltimo();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function

        Public Function consulta_cantidadRegistrados() As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call cantidadProd();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt.Tables(0).Rows(0).Item(0)

            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function

        Public Function consultaCantidadUsuarios() As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT COUNT(*) FROM usuario;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt.Tables(0).Rows(0).Item(0)

            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function




        Public Function consultaCantidadProveedores() As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT COUNT(*) FROM proveedor;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt.Tables(0).Rows(0).Item(0)

            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function


        Public Function consultaCantidadClientes() As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT COUNT(*) FROM cliente;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt.Tables(0).Rows(0).Item(0)

            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function


        Public Function consulta_valorMercancia() As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call valorMercancia();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt.Tables(0).Rows(0).Item(0)

            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function


        Public Function consulta_stockTotalInv() As Integer

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call stockTotal();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt.Tables(0).Rows(0).Item(0)

            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function

        Public Function dataset_10ProductosMasVendidos() As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call p10ProductosMasVendidos();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function
        Public Function dataset_facturas() As DataSet

            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT 
    v.id AS id_venta,
    c.Nombre AS nombre_cliente,
    c.Telefono AS telefono_cliente,
    v.descripcion AS descripcion_venta,
    v.valor AS valor_venta,
    v.fechaventa AS fecha_venta
FROM 
    ventas v
INNER JOIN 
    cliente c ON v.cliente = c.id;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try

        End Function

        Public Function dataset_10ProductosMenosVendidos() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("call p10productosMenosVendidos();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "r")
                miconexion.Close()
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_VentasHoy() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM ventas WHERE DATE(fechaventa) = CURRENT_DATE();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "VentasHoy")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_VentasMesTotal() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM ventas WHERE MONTH(fechaventa) = MONTH(CURRENT_DATE()) AND YEAR(fechaventa) = YEAR(CURRENT_DATE());", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "VentasMes")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_VentasAnio() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM ventas WHERE YEAR(fechaventa) = YEAR(CURRENT_DATE());", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "VentasAnio")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_MesConMasVentas() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT MONTH(fechaventa) AS mes_numero, MONTHNAME(fechaventa) AS mes_nombre, COUNT(*) AS total_ventas 
FROM ventas 
WHERE YEAR(fechaventa) = YEAR(CURRENT_DATE())  -- Filtra solo el año actual
GROUP BY mes_numero, mes_nombre 
ORDER BY total_ventas DESC;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "MesConMasVentas")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_ComprasHoy() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM compra WHERE DATE(fecha) = CURRENT_DATE();", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ComprasHoy")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_ComprasMes() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM compra WHERE MONTH(fecha) = MONTH(CURRENT_DATE()) AND YEAR(fecha) = YEAR(CURRENT_DATE());", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ComprasMes")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function



        Public Function dataset_ComprasAnio() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM compra WHERE YEAR(fecha) = YEAR(CURRENT_DATE());", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ComprasAnio")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_ContactoProveedores() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT Nombre, Numero, Direccion, Email FROM proveedor;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ContactosProveedores")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_ProveedoresTxt(txt As String) As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM proveedor WHERE Nombre like @txt or Identificacion like @txt;", miconexion)
                comando.Parameters.AddWithValue("@txt", "%" & txt & "%")
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ContactosProveedores")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_InfoProveedores() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM proveedor;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "InfoProveedores")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_ProveedoresMasComprados() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT p.Identificacion, p.Nombre, COUNT(c.id) AS total_compras FROM proveedor p INNER JOIN compra c ON p.Identificacion = c.idproveedor GROUP BY p.Identificacion, p.Nombre ORDER BY total_compras DESC;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ProveedoresMasComprados")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_ProveedoresMenosComprados() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT p.Identificacion, p.Nombre, COUNT(c.id) AS total_compras FROM proveedor p LEFT JOIN compra c ON p.Identificacion = c.idproveedor GROUP BY p.Identificacion, p.Nombre ORDER BY total_compras ASC;", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "ProveedoresMenosComprados")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_UltimaCompraPorProveedorConProducto() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("
            SELECT 
                p.Identificacion AS ProveedorID, 
                p.Nombre AS ProveedorNombre, 
                c.id AS CompraID, 
                c.fecha AS FechaCompra, 
                c.cantidad AS CantidadComprada, 
                c.precio AS PrecioCompra, 
                pr.cod AS ProductoCodigo, 
                pr.nombre AS ProductoNombre, 
                pr.marca AS ProductoMarca, 
                pr.color AS ProductoColor
            FROM 
                proveedor p 
            INNER JOIN 
                compra c ON p.Identificacion = c.idproveedor 
            INNER JOIN 
                producto pr ON c.codigo = pr.cod 
            WHERE 
                c.fecha = (
                    SELECT MAX(fecha) 
                    FROM compra 
                    WHERE idproveedor = p.Identificacion
                );", miconexion)

                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "UltimaCompraPorProveedorConProducto")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function






        Public Function Facturacion(suplies As DataSet,
                                    cliente As Integer,
                                    servicio As Double,
                                    descripcion As String,
                                    valor As Double
                                    ) As Boolean
            Try
                miconexion.Open()



                Dim comandoVenta As New MySqlCommand("INSERT INTO santoyo.ventas (cliente,valor, fechaventa,descripcion) VALUES (@cliente, @valor, @fechaventa, @descripcion); SELECT LAST_INSERT_ID() AS NewID;", miconexion)
                comandoVenta.Parameters.AddWithValue("@cliente", cliente)
                comandoVenta.Parameters.AddWithValue("@valor", valor)
                comandoVenta.Parameters.AddWithValue("@fechaventa", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                comandoVenta.Parameters.AddWithValue("@descripcion", descripcion)
                Dim idventa As Integer = Convert.ToInt32(comandoVenta.ExecuteScalar())

                For Each row As DataRow In suplies.Tables(0).Rows
                    ' Recorrer cada columna de la fila

                    Dim comandoDetalle As New MySqlCommand("INSERT INTO detalleventa (idproducto, idventa, cantidad) VALUES (@idproducto, @idventa, @cantidad);", miconexion)
                        comandoDetalle.Parameters.AddWithValue("@idproducto", row(0).ToString())
                        comandoDetalle.Parameters.AddWithValue("@idventa", idventa)
                        comandoDetalle.Parameters.AddWithValue("@cantidad", row(3))
                        comandoDetalle.ExecuteNonQuery()
                    Next

                Return 1
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function




        Public Function dataset_herramientas() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM producto where tipo = 'Herramienta';", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "VentasAnio")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function dataset_prestamos() As DataSet
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("SELECT * FROM prestamos", miconexion)
                Dim llamada As New MySqlDataAdapter(comando)
                Dim dt As New DataSet
                llamada.Fill(dt, "pres")
                Return dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function
        Public Function prestar_herramientas(cod As String, cantidad As Double, clienteid As String, fechaLimite As Date, Cinicial As Double, Cdiario As Double, dias As Integer) As Long
            Dim idPrestamo As Long = 0 ' Variable para almacenar el ID del préstamo
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("INSERT INTO prestamos (codherramienta,cantidad,clienteid,fechalimite,fechaprestamo,inicial,diario,dias) VALUES (@codh,@cantidad,@cliente,@limite,@fprestamo,@inicial,@diario,@dias)", miconexion)
                comando.Parameters.AddWithValue("@codh", cod)
                comando.Parameters.AddWithValue("@cantidad", cantidad)
                comando.Parameters.AddWithValue("@cliente", clienteid)
                comando.Parameters.AddWithValue("@limite", fechaLimite.ToString("yyyy-MM-dd"))
                comando.Parameters.AddWithValue("@fprestamo", DateTime.Today.ToString("yyyy-MM-dd"))
                comando.Parameters.AddWithValue("@inicial", Cinicial)
                comando.Parameters.AddWithValue("@diario", Cdiario)
                comando.Parameters.AddWithValue("@dias", dias)

                ' Ejecutar la inserción
                comando.ExecuteNonQuery()

                ' Obtener el ID del último registro insertado
                Dim idComando As New MySqlCommand("SELECT LAST_INSERT_ID()", miconexion)
                idPrestamo = Convert.ToInt64(idComando.ExecuteScalar())

                Return idPrestamo ' Devolver el ID del préstamo
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return -1 ' Devolver -1 en caso de error
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function

        Public Function prestamo_recibido(id As String) As Boolean
            Try
                miconexion.Open()
                Dim comando As New MySqlCommand("DELETE FROM prestamos where id = @id;", miconexion)
                comando.Parameters.AddWithValue("@id", id)

                Return comando.ExecuteNonQuery
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
                Return Nothing
            Finally
                If miconexion IsNot Nothing AndAlso miconexion.State = ConnectionState.Open Then
                    miconexion.Close()
                End If
            End Try
        End Function






    End Class
End Module
