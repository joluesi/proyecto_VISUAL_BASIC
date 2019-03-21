Public Class Form1

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

        If (txtUsuario.Text = "") Or (txtClave.Text = "") Then
            MsgBox("Antes debe introducir Usuario y contraseña")
        Else
            Form2.Show()
            Me.Hide()
            Form2.lblUsuLog.Text = txtUsuario.Text

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        MessageBox.Show("Adios")
        Me.Close()


    End Sub
End Class
