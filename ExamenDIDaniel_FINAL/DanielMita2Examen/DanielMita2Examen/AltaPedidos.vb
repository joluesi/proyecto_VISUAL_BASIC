Public Class AltaPedidos

    Private Sub btnAceptarAltaPedido_Click(sender As Object, e As EventArgs) Handles btnAceptarAltaPedido.Click

        Dim existeCliente As Boolean = False

        If txtCodCliente.Text <> "" Then
            For i As Integer = 0 To 4
                If array_clientes(i) = CInt(txtCodCliente.Text) Then
                    existeCliente = True
                End If
            Next


            If existeCliente Then

                colPedidos.Add(New Pedidos(txtCodPedido.Text, txtCodCliente.Text, txtFechaPedido.Text, txtDireccionPedido.Text), txtCodPedido.Text)
                grbDetalles.Visible = True

            Else 'NO existe cliente en array de clientes

                MsgBox("No existe ese codigo del cliente")

            End If

        Else
            MsgBox("Tiene que introducir el codigo correcto de cliente")
        End If


    End Sub


    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub


    Private Sub AltaPedidos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub btnVolverAltaPedido_Click(sender As Object, e As EventArgs) Handles btnVolverAltaPedido.Click
        comboCodProductoDetalle.Items.Clear()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnGuardarDetalles_Click(sender As Object, e As EventArgs) Handles btnGuardarDetalles.Click

        If comboCodProductoDetalle.SelectedItem <> "" Then

            If txtCantidadProDetalles.Text <> "" Then

                If CInt(txtCantidadProDetalles.Text) > 0 Then

                    'si true, hay stock
                    If CInt(txtCantidadProDetalles.Text) <= colProductos(comboCodProductoDetalle.SelectedItem).GSStockProducto() Then

                        If txtDescuentoDetalles.Text <> "" Then 'si hay descuento

                            ReDim Preserve array_detalle(cont)
                            array_detalle(cont).codPedido_detal = txtCodPedido.Text
                            array_detalle(cont).codProducto_detal = comboCodProductoDetalle.SelectedItem
                            array_detalle(cont).canti_detal = CInt(txtCantidadProDetalles.Text)
                            array_detalle(cont).descu_detal = CDbl(txtDescuentoDetalles.Text)
                            cont += 1

                            MsgBox("detalles de pedido dados de alta")

                            Dim opcion As DialogResult
                            opcion = MessageBox.Show("¿Quieres dar de alta otro articulo?", "ATENCION", MessageBoxButtons.YesNo)


                            If opcion = DialogResult.Yes Then

                                txtCantidadProDetalles.Text = ""
                                txtDescuentoDetalles.Text = ""

                            Else
                                comboCodProductoDetalle.Items.Clear()
                                txtCodCliente.Text = ""
                                txtCantidadProDetalles.Text = ""
                                txtDescuentoDetalles.Text = ""
                                Me.Hide()
                                Form1.Show()

                            End If


                        Else 'no hay descuento

                            ReDim Preserve array_detalle(cont)
                            array_detalle(cont).codPedido_detal = txtCodPedido.Text
                            array_detalle(cont).codProducto_detal = comboCodProductoDetalle.SelectedItem
                            array_detalle(cont).canti_detal = CInt(txtCantidadProDetalles.Text)
                            array_detalle(cont).descu_detal = 0
                            cont += 1

                            MsgBox("detalles de pedidos dados de alta")

                            Dim opcion As DialogResult
                            opcion = MessageBox.Show("¿Quieres dar de alta otro articulo?", "ATENCION", MessageBoxButtons.YesNo)


                            If opcion = DialogResult.Yes Then

                                txtCantidadProDetalles.Text = ""
                                txtDescuentoDetalles.Text = ""

                            Else
                                txtCodCliente.Text = ""
                                txtCantidadProDetalles.Text = ""
                                txtDescuentoDetalles.Text = ""
                                Me.Hide()
                                Form1.Show()

                            End If


                        End If


                    Else 'no hay stock
                        MsgBox("No hay suficiente stock para ese producto")
                        txtCantidadProDetalles.Clear()
                        txtCantidadProDetalles.Focus()
                    End If


                Else
                    MsgBox("Introduce al menos un producto")
                End If

            Else
                MsgBox("Introduce una cantidad de productos")
            End If

        Else
            MsgBox("Selecciona codigo producto")

        End If

    End Sub

    Private Sub comboCodProductoDetalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCodProductoDetalle.SelectedIndexChanged

    End Sub
End Class