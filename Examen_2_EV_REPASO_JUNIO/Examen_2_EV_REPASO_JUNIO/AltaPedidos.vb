Public Class AltaPedidos
    Private Sub btnAceptarAltaPedido_Click(sender As Object, e As EventArgs) Handles btnAceptarAltaPedido.Click
        Try
            If Me.ValidateChildren And txtCodCliente.Text <> "" And txtDireccionPedido.Text <> "" Then

                Dim existeCliente As Boolean = False
                For i = 0 To array_clientes.Length - 1
                    If array_clientes(i) = txtCodCliente.Text Then
                        existeCliente = True
                    End If
                Next

                If existeCliente Then
                    colecPEDIDOS.Add(New PEDIDOS(txtCodPedido.Text, txtCodCliente.Text, txtFechaPedido.Text, txtDireccionPedido.Text), txtCodPedido.Text)
                    MsgBox("Añadido pedido")
                    grbDetalles.Visible = True

                Else
                    MsgBox("No existe ese código de cliente")
                End If

            Else
                MsgBox("Antes debe introducir todos los datos")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnGuardarDetalles_Click(sender As Object, e As EventArgs) Handles btnGuardarDetalles.Click

        Try
            If Me.ValidateChildren And cmbCodProducto.SelectedItem <> "" Then

                If txtCantidadProDetalles.Text <> "" Then

                    If CInt(txtCantidadProDetalles.Text) > 0 And CInt(txtCantidadProDetalles.Text) <= colecPRODUCTOS(cmbCodProducto.SelectedItem).P_StockProducto() Then

                        If txtDescuentoDetalles.Text <> "" Then

                            If CSng(txtDescuentoDetalles.Text) >= 0 Then

                                ReDim Preserve array_detalle(cont)
                                array_detalle(cont).codPedido_detal = CInt(txtCodPedido.Text)
                                array_detalle(cont).codProducto_detal = cmbCodProducto.SelectedItem
                                array_detalle(cont).canti_detal = CSng(txtCantidadProDetalles.Text)
                                array_detalle(cont).descu_detal = CDbl(txtDescuentoDetalles.Text)
                                cont += 1

                                MsgBox("Detalle de pedido dados de alta")

                                AnadirDetallePedido()

                            Else
                                MsgBox("Descuento ha de ser 0 o positivo")

                            End If

                        Else
                            MsgBox("Antes debe introducir descuento")

                        End If

                    Else
                        MsgBox("Cantidad de productos negativa o no hay stock")

                    End If
                Else
                    MsgBox("Seleccione cantidad")

                End If

            Else
                MsgBox("Seleccione producto en desplegable")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub btnVolverAltaPedido_Click(sender As Object, e As EventArgs) Handles btnVolverAltaPedido.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnVolverDetalle_Click(sender As Object, e As EventArgs) Handles btnVolverDetalle.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub AltaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ToolTipCodCliente = New ToolTip
        Dim ToolTipCantidad = New ToolTip
        Dim ToolTipDescuento = New ToolTip

        ToolTipCodCliente.SetToolTip(Me.txtCodCliente, "tipo entero")
        ToolTipCantidad.SetToolTip(Me.txtCantidadProDetalles, "tipo entero")
        ToolTipDescuento.SetToolTip(Me.txtDescuentoDetalles, "tipo entero")

    End Sub

    Private Sub txtCodCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo entero")
        End If
    End Sub

    Private Sub txtCantidadProDetalles_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCantidadProDetalles.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo entero")
        End If
    End Sub

    Private Sub txtDescuentoDetalles_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescuentoDetalles.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo entero")
        End If
    End Sub

End Class