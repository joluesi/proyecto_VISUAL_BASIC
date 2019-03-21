Public Class Form1
    Private Sub CrearArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearArrayToolStripMenuItem.Click

        arrayCliente(0).codCli = 0
        arrayCliente(0).nombreCli = "pepe"
        arrayCliente(0).bloqueocli = False
        arrayCliente(0).claveCli = "0000"
        arrayCliente(0).saldocli = 0

        arrayCliente(1).codCli = 1
        arrayCliente(1).nombreCli = "juan"
        arrayCliente(1).bloqueocli = False
        arrayCliente(1).claveCli = "1111"
        arrayCliente(1).saldocli = 0

        arrayCliente(2).codCli = 2
        arrayCliente(2).nombreCli = "luis"
        arrayCliente(2).bloqueocli = False
        arrayCliente(2).claveCli = "2222"
        arrayCliente(2).saldocli = 0

        arrayCliente(3).codCli = 3
        arrayCliente(3).nombreCli = "jose"
        arrayCliente(3).bloqueocli = False
        arrayCliente(3).claveCli = "3333"
        arrayCliente(3).saldocli = 0

        arrayCliente(4).codCli = 4
        arrayCliente(4).nombreCli = "rosa"
        arrayCliente(4).bloqueocli = False
        arrayCliente(4).claveCli = "4444"
        arrayCliente(4).saldocli = 0

        MsgBox("Creado array de clientes del banco")

    End Sub

    Private Sub CajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajeroToolStripMenuItem.Click
        pnlCajero.Visible = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim encontrado As Boolean = False

        If txtNombreCliente.Text = "" Then
            MsgBox("Antes debe introducir un cliente")

        Else

            For i = 0 To arrayCliente.Length - 1
                If arrayCliente(i).nombreCli = txtNombreCliente.Text Then
                    If arrayCliente(i).bloqueocli = False Then
                        encontrado = True
                        numOrden = i
                        MsgBox("Bienvenido a su banco Sr/a: " & txtNombreCliente.Text)
                        pnlBotonesCajero.Visible = True
                        contClave = 0

                    Else
                        MsgBox("Este cliente se encuentra bloqueado, pase por su oficina")
                        encontrado = True
                    End If
                End If
            Next

            If encontrado = False Then
                MsgBox("No existe ese cliente")
            End If

        End If

    End Sub

    Private Sub BotonesCajero_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click,
            btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim miBoton As Button = CType(sender, Button)

        If (contClave >= 0 And contClave < 4) Then

            txtClaveCliente.Text += miBoton.Text
            contClave += 1
        Else
            MsgBox("La clave tiene 4 dígitos")
            txtClaveCliente.Text = ""
            contClave = 0
        End If

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If txtClaveCliente.Text = "" Then
            MsgBox("Antes debe introducir la clave del cliente")

        Else

            If arrayCliente(numOrden).bloqueocli = True Then
                MsgBox("El cliente se encuentra bloqueado")

            Else
                If (arrayCliente(numOrden).claveCli = txtClaveCliente.Text) Then
                    MsgBox("Bienvenido cliente")
                    txtClaveCliente.Text = ""
                    pnlBotonesCajero.Visible = False
                    Me.Hide()
                    CajeroBilletes.Show()

                Else
                    intentos -= 1
                    MsgBox("Clave incorrecta. Le quedan " & intentos & " intentos")
                    txtClaveCliente.Text = ""
                    contClave = 0

                    If intentos = 0 Then
                        MsgBox("Ha agotado todos sus intentos. Cuenta bloqueada, pase por su oficina.")
                        txtClaveCliente.Text = ""
                        arrayCliente(numOrden).bloqueocli = True
                        intentos = 3
                        pnlBotonesCajero.Visible = False

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        pnlBotonesCajero.Visible = False

    End Sub

    Private Sub DesbloquearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesbloquearToolStripMenuItem.Click
        Me.Hide()
        pnlBotonesCajero.Visible = False
        Desbloquear.Show()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("José Luis Escribano Ibáñez - Ordenador Nº 24")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

End Class
