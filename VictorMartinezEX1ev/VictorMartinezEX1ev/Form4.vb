Public Class Form4
    Private Sub btnDesb_Click(sender As Object, e As EventArgs) Handles btnDesb.Click

        Dim ex As Boolean = False

        For i = 0 To variableCli.Length - 1

            If variableCli(i).codCli = txtCodigo.Text And variableCli(i).claveCli = CInt(txtClave.Text) Then

                If variableCli(i).bloqueoCli = True Then

                    MsgBox("El usuario a sido desbloqueado")
                    variableCli(i).bloqueoCli = False

                    ex = True

                Else

                    MsgBox("El usuario no se encuentra bloqueado")

                    ex = True

                End If

            End If

        Next

        If ex = False Then

            MsgBox("Usuario o contraseña incorrecto")

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class