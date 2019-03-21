Public Class Form1
    Public Class Form1
        Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
            Me.Hide()
            'Otra forma de introducir el usuario logueadO'
            'Form2.lblNomUsuario.Text = txtUsuario.Text'
            Form2.Show()
        End Sub

        Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
            nomUsuario = txtUsuario.Text
        End Sub


    End Class

