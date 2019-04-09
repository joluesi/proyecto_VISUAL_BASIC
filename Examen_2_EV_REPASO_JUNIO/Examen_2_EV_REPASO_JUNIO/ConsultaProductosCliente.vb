Public Class ConsultaProductosCliente

    Public codigoOpcion As Integer

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If cmbMes.Text <> "" Then
            For Each pedido In colecPEDIDOS
                If pedido.P_fechaPedido().Month = cmbMes.Text Then
                    If pedido.P_clientePedido() = codigoOpcion Then
                        For i = 0 To array_detalle.Length - 1
                            If array_detalle(i).codPedido_detal = pedido.P_codPedido() Then
                                'A partir de aquí no necesito recorrer la colección de PRODUCTOS para obtener el nombre del producto, ya que su clave es el codProducto,
                                'y puedo obtener dicho código desde el array de DETALLE_PRODUCTOS(que estoy recorriendo). 
                                'Por tanto, creo una variable donde almaceno el código.
                                Dim codigoProducto = array_detalle(i).codProducto_detal
                                'Ahora accedo a la colección PRODUCTOS con dicho código y obtengo el nombre del producto con la variable pública
                                richtxtbConsulta.Text += "Nombre producto: " & colecPRODUCTOS(codigoProducto).P_NomProducto() & vbNewLine
                                richtxtbConsulta.Text += "Cantidades: " & CStr(array_detalle(i).canti_detal) & vbNewLine

                            End If
                        Next

                    End If

                Else
                    MsgBox("Este cliente no tiene pedidos en el mes seleccionado")
                End If
            Next

        Else
            MsgBox("Antes seleccione mes a consultar")

        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        cmbMes.Text = ""
        richtxtbConsulta.Clear()

        Me.Hide()
        Form1.Show()

    End Sub
End Class