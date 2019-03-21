Public Class Listados
    Private Sub btnProductosXCliente_Click(sender As Object, e As EventArgs) Handles btnProductosXCliente.Click

        Dim opcion As String = InputBox("Introduzca el código del cliente")
        Dim cadenaPRODUCTO As String = ""
        Dim boolPRODUCTO As Boolean = True

        If opcion <> "" Then
            If ifExisteCodPedEnColeccionPedido(opcion) Then

                For i As Integer = 0 To arrayDetallePedido.Length - 1

                    If arrayDetallePedido(i).codPedido_detal = opcion Then
                        cadenaPRODUCTO += coleccionPEDIDOS(arrayDetallePedido(i).codPedido_detal).GetSet_codPedido() & vbCrLf
                        boolPRODUCTO = False
                    End If
                Next


                If boolPRODUCTO Then
                    MessageBox.Show("El cliente no tiene cursado ningún pedido", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox(cadenaPRODUCTO)
                End If
            Else
                MessageBox.Show("No existe ese cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub btnListadoTodosPEDIDOS_Click(sender As Object, e As EventArgs) Handles btnListadoTodosPEDIDOS.Click

        Dim cadenaPEDIDOS As String = "LISTADO DE PEDIDOS: " & vbCrLf
        Dim boolPEDIDO As Boolean = False

        For i As Integer = 1 To coleccionPEDIDOS.Count
            If coleccionPEDIDOS(i).GetSet_codPedido() Then
                boolPEDIDO = True
                cadenaPEDIDOS += coleccionPEDIDOS(i).GetSet_codPedido() & vbCrLf
            End If
        Next

        If boolPEDIDO Then
            MsgBox(cadenaPEDIDOS)
        Else
            MessageBox.Show("No hay pedidos cursados actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class