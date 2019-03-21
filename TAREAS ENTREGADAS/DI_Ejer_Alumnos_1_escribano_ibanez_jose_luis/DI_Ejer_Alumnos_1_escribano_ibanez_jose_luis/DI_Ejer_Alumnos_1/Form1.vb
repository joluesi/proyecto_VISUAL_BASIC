Public Class Form1
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

        If (txtUsuario.Text = "" Or txtClave.Text = "") Then
            MsgBox("Antes debe introducir Usuario y contraseña")

        Else
            Me.Hide()
            Form2.Show()
            Form2.lblUsuLog.Text = txtUsuario.Text

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("¡¡¡Que tengas un buen día!!!")
        Me.Hide()

    End Sub
End Class
