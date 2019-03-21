Public Class formCursarPedido
    Private Sub btnVolverCursar_Click(sender As Object, e As EventArgs) Handles btnVolverCursar.Click

        richCursar.Text = ""
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub formCursarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class