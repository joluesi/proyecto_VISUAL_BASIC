Public Class Form1
    Private Sub ALTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTAToolStripMenuItem.Click

        For i As Integer = 1 To 5
            Dim aux As String = "PROD" & i
            coleccionPEDIDOS.Add(New Producto(aux, "MISPRODUCTOS", 100, 5), aux)
        Next

        MsgBox("Se han dado de alta 5 productos")

    End Sub

    Private Sub ALTACLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTACLIENTESToolStripMenuItem.Click

        For i As Integer = 0 To 4
            arrayClientes(i) = i
        Next

        MsgBox("Se han dado de alta 5 clientes")

    End Sub

    Private Sub ALTAPEDIDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTAPEDIDOSToolStripMenuItem.Click
        Me.Hide()
        AltaPedidos.Show()
        AltaPedidos.txtCodPedido.Focus()

    End Sub

    Private Sub CURSARPEDIDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CURSARPEDIDOToolStripMenuItem.Click
        Me.Hide()
        CursarPedido.Show()
    End Sub

    Private Sub CONSULTACLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTACLIENTESToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el codigo del cliente")

        If opcion <> "" Then
            If arrayClientes.Contains(opcion) Then
                MsgBox("Código producto: " & coleccionPRODUCTOS(opcion).GetSet_codProducto() & vbCrLf &
                       "Nombre del producto: " & coleccionPRODUCTOS(opcion).GetSet_nomProducto() & vbCrLf &
                       "Precio del producto: " & coleccionPRODUCTOS(opcion).GetSet_precioProducto() & vbCrLf &
                       "Email cliente: " & coleccionPRODUCTOS(opcion).GetSet_stockProducto())

            Else
                MessageBox.Show("No existe el código del cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CONSULTASLISTADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTASLISTADOSToolStripMenuItem.Click
        Me.Hide()
        Listados.Show()
    End Sub
End Class
