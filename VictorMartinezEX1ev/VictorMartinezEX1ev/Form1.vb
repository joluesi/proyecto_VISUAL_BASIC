Public Class Form1
    Private Sub CrearArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearArrayToolStripMenuItem.Click


        variableCli(0).codCli = CStr(0)
        variableCli(0).nombreCli = "Victor"
        variableCli(0).bloqueoCli = False
        variableCli(0).claveCli = 1234
        variableCli(0).saldoCli = 0.0

        variableCli(1).codCli = CStr(1)
        variableCli(1).nombreCli = "Jose"
        variableCli(1).bloqueoCli = False
        variableCli(1).claveCli = 5678
        variableCli(1).saldoCli = 0.0

        variableCli(2).codCli = CStr(2)
        variableCli(2).nombreCli = "Manuel"
        variableCli(2).bloqueoCli = False
        variableCli(2).claveCli = 9101
        variableCli(2).saldoCli = 0.0

        variableCli(3).codCli = CStr(3)
        variableCli(3).nombreCli = "Fran"
        variableCli(3).bloqueoCli = False
        variableCli(3).claveCli = 1213
        variableCli(3).saldoCli = 0.0

        variableCli(4).codCli = CStr(4)
        variableCli(4).nombreCli = "Juan"
        variableCli(4).bloqueoCli = False
        variableCli(4).claveCli = 1415
        variableCli(4).saldoCli = 0.0

        MsgBox("Se han introducudo los datos satisfactoriamente")

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim existe As Boolean = False

        For i = 0 To variableCli.Length - 1

            If variableCli(i).nombreCli = CStr(txtCliente.Text) Then

                If variableCli(i).bloqueoCli = False Then

                    Me.Hide()
                    Form2.Show()

                    existe = True
                    numCli = i
                Else

                    MsgBox("El cliente está bloqueado, no puedes acceder a él")

                    existe = True

                End If

            End If

        Next

        If existe = False Then

            MsgBox("Ese cliente no existe")

        End If

    End Sub

    Private Sub CajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajeroToolStripMenuItem.Click

        pcbBanco.Visible = True
        lblIntroduce.Visible = True
        txtCliente.Visible = True
        btnAceptar.Visible = True

    End Sub

    Private Sub DesbloquearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesbloquearToolStripMenuItem.Click

        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

        MsgBox("Nombre: Victor Martinez Martinez" & vbCrLf & "NºOrdenador: 20")

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()

    End Sub


End Class
