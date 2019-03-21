Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Hide()
        Form2.lblUsu.Text = txtUsuario.Text
        Form2.Show()
    End Sub
End Class
