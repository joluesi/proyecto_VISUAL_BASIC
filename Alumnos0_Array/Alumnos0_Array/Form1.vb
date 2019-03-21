Public Class Form1

    Public Class Form1

        Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
            Me.Hide()
            'Otra forma de introducir el usuario logueadO'
            'Form2.lblNomUsuario.Text = txtUsuario.Text'
            Form2.Show()
        End Sub

        Private Sub Hide()
        Throw New NotImplementedException()
    End Sub
End Class

Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
    nomUsuario = txtUsuario.Text
End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class