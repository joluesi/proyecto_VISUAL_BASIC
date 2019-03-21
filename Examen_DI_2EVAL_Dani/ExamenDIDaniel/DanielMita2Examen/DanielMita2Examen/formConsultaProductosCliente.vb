Public Class formConsultaProductosCliente

    Public codigoCliente As Integer

    Private Sub formConsultaProductosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConsultarMes_Click(sender As Object, e As EventArgs) Handles btnConsultarMes.Click

        'si llegamos a este formulario, es porque el cliente ya tiene hecho algun pedido

        Dim mesSeleccionado As Integer = CInt(cmbMes.SelectedItem)



        For i As Integer = 1 To colPedidos.Count

            If colPedidos(i).GSClientePedido = codigoCliente Then 'buscamos el pedido en la coleccion

                Dim mesPedido As Integer = colPedidos(i).GSFechaPedido.Month 'tenemos el mes del pedido de ese cliente

                If mesPedido = mesSeleccionado Then

                    For j As Integer = 0 To array.Length - 1 ' buscamos todos los datelles de ese pedido


                        If array(j).codPedido_detal = colPedidos(i).GSCodPedido() Then

                            Dim codigoProducto As String = array(j).codProducto_detal

                            richMes.Text += "Nombre producto: " + colProductos(codigoProducto).GSNomProducto() + vbNewLine
                            richMes.Text += "Cantidad pedida: " + CStr(array(j).canti_detal) + vbNewLine


                        End If

                    Next


                Else
                    MsgBox("El cliente no ha realizado pedidos en esta fecha")
                End If



            End If

        Next





    End Sub

    Private Sub btnVolverConsulta_Click(sender As Object, e As EventArgs) Handles btnVolverConsulta.Click
        richMes.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class