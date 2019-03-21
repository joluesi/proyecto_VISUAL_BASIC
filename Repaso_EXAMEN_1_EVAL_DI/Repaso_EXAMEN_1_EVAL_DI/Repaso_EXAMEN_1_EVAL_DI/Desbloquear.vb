Public Class Desbloquear
    Private Sub btnDesbloquear_Click(sender As Object, e As EventArgs) Handles btnDesbloquear.Click

        Try
            Dim correcto As Boolean = False

            If (txtCodDesblo.Text = "" Or txtClaveDesblo.Text = "") Then
                MsgBox("Antes debe introducir código y clave del cliente")

            Else
                For i = 0 To arrayCliente.Length - 1

                    If (txtCodDesblo.Text = arrayCliente(i).codCli) And (txtClaveDesblo.Text = arrayCliente(i).claveCli) Then

                        MsgBox("Código y clave correctos")
                        correcto = True

                        If arrayCliente(i).bloqueocli = True Then

                            arrayCliente(i).bloqueocli = False
                            MsgBox("El cliente ha sido desbloqueado")

                        Else
                            MsgBox("Este cliente no está bloqueado")

                        End If

                    End If

                Next

                If correcto = False Then

                    MsgBox("Código o clave incorrectos")

                End If

            End If

        Catch ex As Exception
            MsgBox("Introduzca clave numérica")
            txtClaveDesblo.Text = ""
        End Try

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class