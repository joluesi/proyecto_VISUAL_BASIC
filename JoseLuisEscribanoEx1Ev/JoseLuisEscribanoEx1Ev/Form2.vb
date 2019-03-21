Public Class Form2
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        For Each cliente As CLIENTE In arrayCliente

            If cliente.saldoCli >= txtReintegro.Text Then

                MsgBox("Su dinero. Gracias")

            Else
                MsgBox("No dispone de saldo suficiente")

            End If

        Next

    End Sub


    Private Sub txtReintegro_TextChanged(sender As Object, e As EventArgs) Handles txtReintegro.TextChanged


    End Sub
End Class