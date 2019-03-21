Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosClientesToolStripMenuItem.Click
        colProductos.Add(New Productos("1", "Lapiz", 10, 30), "1")
        colProductos.Add(New Productos("2", "Ordenador", 200, 11), "2")
        colProductos.Add(New Productos("3", "Pantalla", 110, 5), "3")
        colProductos.Add(New Productos("4", "Cargador", 25, 9), "4")
        colProductos.Add(New Productos("5", "Movil", 15, 310), "5")

        'llenamos el combobox



        'llenamos el array de clientes
        For i As Integer = 1 To 4
            array_clientes(i) = i
        Next

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Me.Hide()
        AltaPedidos.Show()

        AltaPedidos.txtCodPedido.Text = CStr(contadorCodPedido)
        AltaPedidos.txtFechaPedido.Text = Today.Date.ToString
        AltaPedidos.txtDireccionPedido.Text = "Murcia" & contadorCodPedido
        contadorCodPedido += 1
        AltaPedidos.grbDetalles.Visible = False

        'cargamos el groupbox

        For i As Integer = 1 To colProductos.Count
            AltaPedidos.comboCodProductoDetalle.Items.Add(colProductos(i).GSCodProducto())
        Next

        AltaPedidos.txtCodDetalle.Text = AltaPedidos.txtCodPedido.Text

    End Sub

    Private Sub CursarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursarPedidoToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el codigo del pedido")

        If opcion <> "" Then
            If colPedidos.Contains(opcion) Then ' existe ese pedido, nos metemos

                Dim codigoClientePedido As Integer = colPedidos(opcion).GSClientePedido() 'obtenemos cod cliente

                For i As Integer = 0 To array.Length - 1 ' buscamos todos los datelles de ese pedido








                    'que coincida el cod de la colecion con el cod de la estructura
                    If array(i).codPedido_detal = colPedidos(opcion).GSCodPedido() Then
                        '
                        Dim codigoProducto As String = array(i).codProducto_detal 'cada vuelta, distintos codProducto

                        'actualizamos el stock
                        colProductos(codigoProducto).GSStockProducto -= array(i).canti_detal

                        'obtenemos el precio y cantidad pedida del producto
                        Dim precioProducto As Double = colProductos(codigoProducto).GSPrecioProducto()
                        Dim cantidadPedida As Integer = array(i).canti_detal



                        If array(i).descu_detal = 0 Then ' no hay descuento

                            Dim precioPedido As Double = precioProducto * cantidadPedida
                            Dim nombreProducto As String = colProductos(codigoProducto).GSNomProducto()

                            formCursarPedido.richCursar.Text += "Codigo del PEDIDO : " & opcion + vbNewLine
                            formCursarPedido.richCursar.Text += "Nombre producto : " & nombreProducto + vbNewLine
                            formCursarPedido.richCursar.Text += "Cantidad de productos : " & CStr(cantidadPedida) + vbNewLine
                            formCursarPedido.richCursar.Text += "Precio producto : " & CStr(precioProducto) + vbNewLine
                            formCursarPedido.richCursar.Text += "Descuento : " & CStr(array(i).descu_detal) + vbNewLine
                            formCursarPedido.richCursar.Text += " Total del pedido : " & CStr(precioPedido) + vbNewLine

                            Me.Hide()
                            formCursarPedido.Show()


                        Else ' si hay descuento

                            Dim aux As Double = precioProducto * cantidadPedida
                            Dim descuento As Double = aux * array(i).descu_detal / 100

                            Dim precioPedido As Double = aux - descuento ' calculamos el precio del pedido
                            Dim nombreProducto As String = colProductos(codigoProducto).GSNomProducto()

                            formCursarPedido.richCursar.Text += "Codigo del PEDIDO : " & opcion + vbNewLine
                            formCursarPedido.richCursar.Text += "Nombre producto : " & nombreProducto + vbNewLine
                            formCursarPedido.richCursar.Text += "Cantidad de productos : " & CStr(cantidadPedida) + vbNewLine
                            formCursarPedido.richCursar.Text += "Precio producto : " & CStr(precioProducto) + vbNewLine
                            formCursarPedido.richCursar.Text += "Descuento : " & CStr(array(i).descu_detal) + vbNewLine
                            formCursarPedido.richCursar.Text += " Total del pedido : " & CStr(precioPedido) + vbNewLine

                            Me.Hide()
                            formCursarPedido.Show()

                        End If







                    End If

                Next



            Else
                MsgBox("No existe el pedido")
            End If



        Else
            MsgBox("Introduce algo")
        End If








    End Sub

    Private Sub ProductosDeClienteMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosDeClienteMesToolStripMenuItem.Click

        Dim opcion = InputBox("Introduce el codigo del cliente")
        Dim encontrado As Boolean = True
        If opcion <> "" Then

            If colPedidos.Count <> 0 Then
                For i As Integer = 1 To colPedidos.Count
                    If colPedidos(i).GSClientePedido() = CInt(opcion) Then 'buscamos en objeto pedidos el codigocliente
                        Me.Hide()
                        formConsultaProductosCliente.Show()
                        formConsultaProductosCliente.codigoCliente = CInt(opcion)
                        encontrado = False
                    End If
                Next

                If encontrado Then
                    MsgBox("Este cliente no tiene pedidos")
                End If
            Else
                MsgBox("No existen pedidos")
            End If


        Else
            MsgBox("Introduce algo")
        End If

    End Sub

    Private Sub ClientesDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesDeProductoToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el codigo del producto")
        Dim contador As Integer = 0


        If opcion <> "" Then




            Dim bool As Boolean = True

            For i As Integer = 0 To array.Length - 1

                If array(i).codProducto_detal = opcion Then
                    bool = False
                    contador += 1

                End If

            Next

            If bool Then
                MsgBox("No hay pedidos de ese producto")
            Else
                MsgBox("Existen " & CStr(contador) & " pedidos realizados de " & colProductos(opcion).GSNomProducto())
            End If






        Else
            MsgBox("Mete algo en la caja")
        End If


    End Sub

    Private Sub AbrirListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirListadoToolStripMenuItem.Click

    End Sub
End Class
