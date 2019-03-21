Public Class Devolucion

    Public indice As Integer

    Private Sub Devolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Devolucion_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub


    Private Sub btnVolverD_Click(sender As Object, e As EventArgs) Handles btnVolverD.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class