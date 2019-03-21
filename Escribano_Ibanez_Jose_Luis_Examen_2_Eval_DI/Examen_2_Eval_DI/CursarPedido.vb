Public Class CursarPedido

    Private Sub btnCursarPedido_Click(sender As Object, e As EventArgs) Handles btnCursarPedido.Click

        If txtcodPedCursar.Text <> "" Then
            If coleccionPEDIDOS.Contains(txtcodPedCursar.Text) Then
                If coleccionPEDIDOS.Contains(txtCliPedCursar.Text) Then
                    coleccionPEDIDOS(txtCliPedCursar.Text).GetSet_clientePedido()

                    ReDim Preserve arrayDetallePedido(cont)
                    arrayDetallePedido(cont).codPedido_detal = txtcodPedCursar.Text
                    arrayDetallePedido(cont).codProducto_detal = coleccionPRODUCTOS(cont).GetSet_precioProducto()
                    arrayDetallePedido(cont).canti_detal = coleccionPRODUCTOS(cont).GetSet_stockProducto()
                    arrayDetallePedido(cont).descu_detal = coleccionPRODUCTOS(cont).GetSet_precioProducto()
                    cont += 1

                    MessageBox.Show("Ha cursado el pedido " & coleccionPEDIDOS(txtcodPedCursar.Text).GetSet_codPedido() & " correctamente", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCliPedCursar.Clear()
                    txtcodPedCursar.Clear()
                    txtCliPedCursar.Focus()


                Else
                    MessageBox.Show("No existe este cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCliPedCursar.Clear()
                    txtcodPedCursar.Clear()
                    txtCliPedCursar.Focus()
                End If
            Else
                MessageBox.Show("No existe el codigo del pedido", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCliPedCursar.Clear()
                txtcodPedCursar.Clear()
                txtCliPedCursar.Focus()
            End If


        Else
            MessageBox.Show("Introduzca tolos los datos en los campos", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class