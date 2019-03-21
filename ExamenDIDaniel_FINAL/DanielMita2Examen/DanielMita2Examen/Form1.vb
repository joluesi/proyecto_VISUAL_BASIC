Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosClientesToolStripMenuItem.Click
        'llenamos la colección con 5 productos
        colProductos.Add(New Productos("1", "Lapiz", 10, 30), "1")
        colProductos.Add(New Productos("2", "Ordenador", 200, 11), "2")
        colProductos.Add(New Productos("3", "Pantalla", 110, 5), "3")
        colProductos.Add(New Productos("4", "Cargador", 25, 9), "4")
        colProductos.Add(New Productos("5", "Movil", 315, 10), "5")

        'llenamos el array de 5 clientes
        For i As Integer = 0 To 4
            array_clientes(i) = i
        Next

        MsgBox("Creada colección de productos y array de clientes con éxito")

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Me.Hide()
        AltaPedidos.Show()

        AltaPedidos.txtCodPedido.Text = CStr(contadorCodPedido)
        AltaPedidos.txtFechaPedido.Text = Today.Date.ToString
        AltaPedidos.txtDireccionPedido.Text = "Murcia - " & contadorCodPedido
        contadorCodPedido += 1
        AltaPedidos.grbDetalles.Visible = False

        'creamos combobox con los códigos de productos que existen en la colección productos
        For i As Integer = 1 To colProductos.Count
            AltaPedidos.comboCodProductoDetalle.Items.Add(colProductos(i).GSCodProducto())
        Next

        AltaPedidos.txtCodDetalle.Text = AltaPedidos.txtCodPedido.Text


    End Sub

    Private Sub CursarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursarPedidoToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el código del pedido")

        If opcion <> "" Then
            If colPedidos.Contains(opcion) Then ' existe ese pedido, nos metemos en Pedidos

                'Dim codigoClientePedido As Integer = colPedidos(opcion).GSClientePedido() 'obtenemos cod cliente

                'otra opcion
                'Dim p1 As Pedidos = colPedidos(opcion)
                'Dim codigoClientePedido2 = p1.GSClientePedido


                For i As Integer = 0 To array_detalle.Length - 1 ' buscamos todos los detalles de ese pedido

                    'que coincida el cod de la colecion Pedidos con el cod de la estructura
                    If array_detalle(i).codPedido_detal = colPedidos(opcion).GSCodPedido() Then

                        Dim codigoProducto As String = array_detalle(i).codProducto_detal 'cada vuelta, distintos codProducto

                        'actualizamos el stock
                        colProductos(codigoProducto).GSStockProducto -= array_detalle(i).canti_detal

                        'obtenemos el precio y cantidad pedida del producto
                        Dim precioProducto As Double = colProductos(codigoProducto).GSPrecioProducto()
                        Dim cantidadPedida As Integer = array_detalle(i).canti_detal


                        If array_detalle(i).descu_detal = 0 Then ' no hay descuento

                            Dim precioPedido As Double = precioProducto * cantidadPedida
                            Dim nombreProducto As String = colProductos(codigoProducto).GSNomProducto()

                            formCursarPedido.richCursar.Text += "Codigo del PEDIDO : " & opcion + vbNewLine
                            formCursarPedido.richCursar.Text += "Nombre producto : " & nombreProducto + vbNewLine
                            formCursarPedido.richCursar.Text += "Cantidad de productos : " & CStr(cantidadPedida) + vbNewLine
                            formCursarPedido.richCursar.Text += "Precio producto : " & CStr(precioProducto) + vbNewLine
                            formCursarPedido.richCursar.Text += "Descuento : " & CStr(array_detalle(i).descu_detal) + vbNewLine ' esto es 0
                            formCursarPedido.richCursar.Text += " Total factura: " & CStr(precioPedido) + vbNewLine

                            Me.Hide()
                            formCursarPedido.Show()


                        Else ' si hay descuento

                            Dim auxPrecioPedido As Double = precioProducto * cantidadPedida
                            Dim descuento As Double = auxPrecioPedido * array_detalle(i).descu_detal / 100

                            Dim precioPedido As Double = auxPrecioPedido - descuento ' calculamos el precio del pedido tras aplicar descuento
                            Dim nombreProducto As String = colProductos(codigoProducto).GSNomProducto()

                            formCursarPedido.richCursar.Text += "Codigo del PEDIDO : " & opcion + vbNewLine
                            formCursarPedido.richCursar.Text += "Nombre producto : " & nombreProducto + vbNewLine
                            formCursarPedido.richCursar.Text += "Cantidad de productos : " & CStr(cantidadPedida) + vbNewLine
                            formCursarPedido.richCursar.Text += "Precio producto : " & CStr(precioProducto) + vbNewLine
                            formCursarPedido.richCursar.Text += "Descuento : " & CStr(array_detalle(i).descu_detal) + vbNewLine
                            formCursarPedido.richCursar.Text += " Total factura: " & CStr(precioPedido) + vbNewLine

                            Me.Hide()
                            formCursarPedido.Show()

                        End If


                    End If

                Next


            Else
                MsgBox("No existe el pedido")
            End If


        Else
            MsgBox("Introduce el código del pedido")
        End If


    End Sub

    Private Sub ProductosDeClienteMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosDeClienteMesToolStripMenuItem.Click

        Dim opcion = InputBox("Introduce el codigo del cliente")
        Dim encontrado As Boolean = False
        If opcion <> "" Then

            If colPedidos.Count <> 0 Then
                For i As Integer = 1 To colPedidos.Count
                    If colPedidos(i).GSClientePedido() = CInt(opcion) Then 'buscamos en objeto pedidos el codigocliente 
                        'Nota: codigocliente = clientePedido
                        Me.Hide()
                        formConsultaProductosCliente.Show()
                        formConsultaProductosCliente.codigoCliente = CInt(opcion)
                        encontrado = True
                    End If
                Next

                If encontrado Then
                    MsgBox("Este cliente si tiene pedidos realizados")
                Else
                    MsgBox("Este cliente no tiene pedidos")

                End If
            Else
                MsgBox("No existen pedidos")
            End If


        Else
            MsgBox("Introduce código de cliente")
        End If

    End Sub

    Private Sub ClientesDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesDeProductoToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el codigo del producto")

        If opcion <> "" Then
            If colProductos.Contains(opcion) Then 'si en la colección productos existe ese código de producto, entramos

                Dim codigoClientePedido As Integer = colPedidos(opcion).GSClientePedido() ' obtengo el código del cliente

                    For j = 0 To array_detalle.Length - 1


                        If array_detalle(j).codProducto_detal = colProductos(opcion).GSCodProducto() Then

                            If array_detalle(j).codPedido_detal = colPedidos(codigoClientePedido).GSCodPedido() Then

                                Dim codigoProducto As String = array_detalle(j).codProducto_detal
                                Dim totalCliente As Integer = totalCliente + array_detalle(j).canti_detal

                                formListadoProductos.richListado.Text += "Código del cliente: " & CStr(codigoClientePedido) + vbNewLine
                                formListadoProductos.richListado.Text += "Fecha del pedido: " & CStr(colPedidos(codigoClientePedido).GSFechaPedido) + vbNewLine
                                formListadoProductos.richListado.Text += "Cantidad del pedido: " & CStr(array_detalle(j).canti_detal) + vbNewLine
                                formListadoProductos.richListado.Text += "  Total por cliente: " & CStr(totalCliente) + vbNewLine

                                Me.Hide()
                                formListadoProductos.Show()


                            End If

                        End If

                    Next


            Else
                MsgBox("No existe ese producto en la colección")
            End If

        Else
            MsgBox("Introduzca código del producto")

        End If


    End Sub

    Private Sub AbrirListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirListadoToolStripMenuItem.Click

    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
