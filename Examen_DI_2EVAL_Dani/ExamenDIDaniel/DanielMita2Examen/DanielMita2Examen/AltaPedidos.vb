Public Class AltaPedidos

    Private Sub btnAceptarAltaPedido_Click(sender As Object, e As EventArgs) Handles btnAceptarAltaPedido.Click


        Dim bool As Boolean = True

        If txtCodCliente.Text <> "" Then
            For i As Integer = 0 To 4
                If array_clientes(i) = CInt(txtCodCliente.Text) Then
                    bool = False
                End If
            Next


            If bool Then

                MsgBox("No existe el codigo del cliente")

            Else 'existe cliente en array de clientes

                colPedidos.Add(New Pedidos(txtCodPedido.Text, txtCodCliente.Text, txtFechaPedido.Text, txtDireccionPedido.Text), txtCodPedido.Text)
                grbDetalles.Visible = True



            End If


        Else
            MsgBox("tiene que introducir algo en el codigo de cliente")
        End If





    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged

    End Sub

    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AltaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load






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

                        If txtDescuentoDetalles.Text <> "" Then 'no hay descuento

                            array(array.Length - 1).codPedido_detal = txtCodPedido.Text
                            array(array.Length - 1).codProducto_detal = comboCodProductoDetalle.SelectedItem
                            array(array.Length - 1).canti_detal = CInt(txtCantidadProDetalles.Text)
                            array(array.Length - 1).descu_detal = CDbl(txtDescuentoDetalles.Text)
                            ReDim Preserve array(array.Length)

                            MsgBox("detalles dados de alta")

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


                        Else 'si hay descuento
                            array(array.Length - 1).codPedido_detal = txtCodPedido.Text
                            array(array.Length - 1).codProducto_detal = comboCodProductoDetalle.SelectedItem
                            array(array.Length - 1).canti_detal = CInt(txtCantidadProDetalles.Text)
                            array(array.Length - 1).descu_detal = 0
                            ReDim Preserve array(array.Length)

                            MsgBox("detalles dados de alta")

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
                        MsgBox("No hay stock")
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
            MsgBox("Seleciona codigo producto")

        End If

    End Sub

    Private Sub comboCodProductoDetalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCodProductoDetalle.SelectedIndexChanged

    End Sub
End Class