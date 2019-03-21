Public Class Form3
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        For Each cliente As CLIENTE In arrayCliente

            If cliente.bloqueoCli = False Then

                MsgBox("Puede ingresar dinero. Gracias")

            Else
                MsgBox("Error. Cliente bloqueado")

            End If

        Next

    End Sub

End Class