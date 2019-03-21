Public Class Form1
    Private Sub btnCrearArray_Click(sender As Object, e As EventArgs) Handles btnCrearArray.Click

        If (txtCodigo.Text = "" Or txtNombre.Text = "" Or txtBloqueo.Text = "" Or txtClave.Text = "" Or txtSaldo.Text = "") Then
            MsgBox("Antes debe introducir todos los datos de los clientes")

        ElseIf Not (IsNumeric(txtClave.Text) Or IsNumeric(txtSaldo.Text)) Then
            MsgBox("Clave y saldo han de ser valores numéricos")
            txtClave.Clear()
            txtSaldo.Clear()

        Else

            For i = 0 To 4
                ReDim Preserve arrayCliente(i)
                arrayCliente(i).codCli = i
                arrayCliente(i).nombreCli = "pepe0" & i
                arrayCliente(i).bloqueoCli = False
                arrayCliente(3).claveCli = "1230" & i
                arrayCliente(4).saldoCli = 0

            Next



            'arrayCliente(0, 0).codCli = txtCodigo.Text
            'arrayCliente(0, 1).nombreCli = "pepe"
            'arrayCliente(0, 2).bloqueoCli = txtBloqueo.Text = False
            'arrayCliente(0, 3).claveCli = "0000"
            'arrayCliente(0, 4).saldoCli = txtSaldo.Text = 0

            'arrayCliente(1, 0).codCli = txtCodigo.Text
            'arrayCliente(1, 1).nombreCli = "juan"
            'arrayCliente(1, 2).bloqueoCli = txtBloqueo.Text = False
            'arrayCliente(1, 3).claveCli = "1111"
            'arrayCliente(1, 4).saldoCli = txtSaldo.Text = 0

            'arrayCliente(2, 0).codCli = txtCodigo.Text
            'arrayCliente(2, 1).nombreCli = "antonio"
            'arrayCliente(2, 2).bloqueoCli = txtBloqueo.Text = False
            'arrayCliente(2, 3).claveCli = "2222"
            'arrayCliente(2, 4).saldoCli = txtSaldo.Text = 0

            'arrayCliente(3, 0).codCli = txtCodigo.Text
            'arrayCliente(3, 1).nombreCli = "luis"
            'arrayCliente(3, 2).bloqueoCli = txtBloqueo.Text = False
            'arrayCliente(3, 3).claveCli = "3333"
            'arrayCliente(3, 4).saldoCli = txtSaldo.Text = 0

            'arrayCliente(4, 0).codCli = txtCodigo.Text
            'arrayCliente(4, 1).nombreCli = "ana"
            'arrayCliente(4, 2).bloqueoCli = txtBloqueo.Text = False
            'arrayCliente(4, 3).claveCli = "4444"
            'arrayCliente(4, 4).saldoCli = txtSaldo.Text = 0

        End If

        gbxConsultar.Visible = True
        btnLimpiar.PerformClick()


    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim encontradoCliente As Boolean = False

        For Each cliente As CLIENTE In arrayCliente

            If txtNombre.Text = cliente.nombreCli Then

                txtCodigo.Text = cliente.codCli
                txtNombre.Text = cliente.nombreCli
                txtBloqueo.Text = cliente.bloqueoCli
                txtClave.Text = cliente.claveCli
                txtSaldo.Text = cliente.saldoCli

                encontradoCliente = True
                gbxBanco.Visible = True
            End If

        Next

        If encontradoCliente = False Then
            MsgBox("Nombre de cliente no encontrado")
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtCodigo.Clear()
        txtNombre.Clear()
        txtBloqueo.Clear()
        txtClave.Clear()
        txtSaldo.Clear()


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuClientes.Show()

    End Sub

    Private Sub txtIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles txtIdentificacion.TextChanged

        Dim encontradaClave As Boolean = False

        For Each cliente As CLIENTE In arrayCliente

            If txtIdentificacion.Text = cliente.claveCli Then
                txtClave.Text = cliente.claveCli

                encontradaClave = True

                MenuRegistrados.Visible = True


            End If

        Next

        If encontradaClave = False Then
            MsgBox("Error. Clave no encontrado")
            MsgBox("Vuelva a introducir la clave")

            For contador = 0 To 2
                If encontradaClave = False Then
                    txtBloqueo.Text = True
                    MsgBox("Cliente bloqueado. Pase por su oficina")
                End If

            Next
        End If

    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Hide()
        MenuClientes.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
End Class