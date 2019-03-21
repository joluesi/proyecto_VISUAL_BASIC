Public Class formListadoProductos
    Private Sub btnVolverListado_Click(sender As Object, e As EventArgs) Handles btnVolverListado.Click

        richListado.Text = ""
        Me.Hide()
        Form1.Show()

    End Sub
End Class