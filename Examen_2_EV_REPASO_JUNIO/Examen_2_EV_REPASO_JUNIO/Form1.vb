Imports System.IO

Public Class Form1
    Private Sub ProductosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosClientesToolStripMenuItem.Click

        'añado 5 productos a la colección de Productos
        colecPRODUCTOS.Add(New PRODUCTOS("1", "monitor", 120, 10), "1")
        colecPRODUCTOS.Add(New PRODUCTOS("2", "teclado", 20, 15), "2")
        colecPRODUCTOS.Add(New PRODUCTOS("3", "torre", 600, 12), "3")
        colecPRODUCTOS.Add(New PRODUCTOS("4", "altavoces", 60, 8), "4")
        colecPRODUCTOS.Add(New PRODUCTOS("5", "ratón", 10, 25), "5")

        'array de 5 clientes con código de cliente
        For i = 0 To 4
            array_clientes(i) = i
        Next

        MsgBox("Creada colección con 5 productos y array de clientes")

    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Me.Hide()
        AltaPedidos.Show()

        AltaPedidos.txtCodPedido.Text = CStr(cont_cod_pedido)
        AltaPedidos.txtFechaPedido.Text = Date.Today.ToString()
        AltaPedidos.txtDireccionPedido.Text = "C/ Murcia - " & cont_cod_pedido
        cont_cod_pedido += 1

        'código de pedido detalle = codigo de pedido
        AltaPedidos.txtCodDetalle.Text = AltaPedidos.txtCodPedido.Text

        'creo combobox con productos de la colección
        For Each produc In colecPRODUCTOS
            AltaPedidos.cmbCodProducto.Items.Add(produc.P_CodProducto())
        Next

        AltaPedidos.cmbCodProducto.Text = ""

    End Sub

    Private Sub ProductosDeClienteMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosDeClienteMesToolStripMenuItem.Click

        Dim opcion = InputBox("Introduce el código del cliente")

        Dim encontrado As Boolean = False

        For Each pedido In colecPEDIDOS
            If pedido.P_clientePedido() = opcion Then
                encontrado = True
            End If
        Next

        If encontrado Then
            MsgBox("Este cliente si tiene pedidos")
            ConsultaProductosCliente.Show()
            ConsultaProductosCliente.codigoOpcion = opcion
        Else
            MsgBox("El cliente o no existe o no tiene pedidos")

        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CursarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursarPedidoToolStripMenuItem.Click

        Dim opcion = InputBox("Introduce el codigo del pedido")

        Dim encontrado As Boolean = False

        For Each pedido In colecPEDIDOS
            If pedido.P_codPedido() = opcion Then
                encontrado = True
            End If
        Next

        If encontrado Then
            CursarPedido.Show()
            CursarPedido.richtxtb_CursarPedido.Clear()

            CursarPedido.richtxtb_CursarPedido.Text = "Nº DE PEDIDO: " & opcion & "     CLIENTE PEDIDO: " & colecPEDIDOS(opcion).P_clientePedido() & "   FECHA PEDIDO: " & colecPEDIDOS(opcion).P_fechaPedido() & vbNewLine
            CursarPedido.richtxtb_CursarPedido.Text += "Nombre " & "     Cantidad " & "      Precio " & "     Descuento " & "     Total Parcial " & vbNewLine

            Dim totalFactura = 0

            For i = 0 To array_detalle.Length - 1

                If array_detalle(i).codPedido_detal = colecPEDIDOS(opcion).P_codPedido() Then
                    'creo una variable auxiliar para almacenar el código de producto (CLAVE en colección PRODUCTOS y existente en array de DETALLE_PEDIDO)
                    Dim codigoProducto = array_detalle(i).codProducto_detal

                    If colecPRODUCTOS(codigoProducto).P_StockProducto() >= array_detalle(i).canti_detal Then
                        colecPRODUCTOS(codigoProducto).P_StockProducto() -= array_detalle(i).canti_detal

                        Dim PrecioAux = 0
                        Dim totalParcial = 0

                        PrecioAux = array_detalle(i).canti_detal * colecPRODUCTOS(codigoProducto).P_PrecioProducto()
                        totalParcial = PrecioAux - (PrecioAux * array_detalle(i).descu_detal / 100)

                        CursarPedido.richtxtb_CursarPedido.Text += colecPRODUCTOS(codigoProducto).P_NomProducto() & "           "
                        CursarPedido.richtxtb_CursarPedido.Text += array_detalle(i).canti_detal & "                "
                        CursarPedido.richtxtb_CursarPedido.Text += CStr(colecPRODUCTOS(codigoProducto).P_PrecioProducto()) & "                 "
                        CursarPedido.richtxtb_CursarPedido.Text += array_detalle(i).descu_detal & "                 "
                        CursarPedido.richtxtb_CursarPedido.Text += totalParcial & "                " & vbNewLine
                        totalFactura += totalParcial

                    Else
                        MsgBox("No se puede cursar el pedido por falta de stock")
                        MsgBox("Crear orden de compra a almacén por actualización de stock")
                    End If

                End If

            Next

            CursarPedido.richtxtb_CursarPedido.Text += "Total Factura: " & totalFactura

        Else
            MsgBox("No existe el pedido introducido")
        End If

    End Sub

    Private Sub ClientesDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesDeProductoToolStripMenuItem.Click

        Dim opcion = InputBox("Introduce el codigo de producto")

        Dim encontrado As Boolean = False

        For Each produc In colecPRODUCTOS
            If produc.P_CodProducto() = opcion Then
                encontrado = True
            End If
        Next

        If encontrado Then
            ClientesProducto.Show()
            ClientesProducto.richtxt_clientesProduc.Clear()

            ClientesProducto.richtxt_clientesProduc.Text = "CODIGO DE PRODUCTO: " & opcion & "     NOMBRE DE PRODUCTO: " & colecPRODUCTOS(opcion).P_NomProducto() & vbNewLine
            ClientesProducto.richtxt_clientesProduc.Text += vbNewLine
            Dim totalParcial = 0
            Dim totalUds = 0

            For i = 0 To array_detalle.Length - 1

                If array_detalle(i).codProducto_detal = colecPRODUCTOS(opcion).P_CodProducto() Then

                    For Each ped In colecPEDIDOS

                        If ped.P_codPedido() = array_detalle(i).codPedido_detal Then

                            ClientesProducto.richtxt_clientesProduc.Text += "Código de cliente: " & CStr(ped.P_clientePedido()) & vbNewLine
                            ClientesProducto.richtxt_clientesProduc.Text += "Fecha pedido: " & ped.P_fechaPedido() & "      " & "Uds. pedidas: " & CStr(array_detalle(i).canti_detal) & vbNewLine

                            totalParcial = array_detalle(i).canti_detal
                            ClientesProducto.richtxt_clientesProduc.Text += "                                                           Total: " & totalParcial & vbNewLine
                            ClientesProducto.richtxt_clientesProduc.Text += vbNewLine

                        End If

                    Next
                    totalUds += totalParcial

                End If

            Next

            ClientesProducto.richtxt_clientesProduc.Text += vbNewLine
            ClientesProducto.richtxt_clientesProduc.Text += "TOTAL PEDIDO DEL PRODUCTO: " & totalUds & vbNewLine

        Else
            MsgBox("No existe el producto introducido")
        End If

    End Sub

    Private Sub AbrirListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirListadoToolStripMenuItem.Click

        Dim hijo As ClientesProducto = New ClientesProducto
        Dim cajadi As New OpenFileDialog()
        cajadi.InitialDirectory = "%USERPROFILE%\Desktop"
        cajadi.Title = “Seleccione un Fichero… “
        cajadi.FileName = ""
        cajadi.Filter = "Text documents (.txt)|*.txt"
        Dim result As DialogResult = cajadi.ShowDialog()

        If result = DialogResult.OK Then
            Dim pathfilename As String = cajadi.FileName.ToString
            Dim filename As String = cajadi.SafeFileName.ToString
            Dim cadenaReader As StreamReader = New StreamReader(pathfilename)
            hijo.richtxt_clientesProduc.Text = cadenaReader.ReadToEnd
            cadenaReader.Close()
            hijo.Show()

        End If

    End Sub

    Private Sub ConsultasListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasListadosToolStripMenuItem.Click

    End Sub
End Class
