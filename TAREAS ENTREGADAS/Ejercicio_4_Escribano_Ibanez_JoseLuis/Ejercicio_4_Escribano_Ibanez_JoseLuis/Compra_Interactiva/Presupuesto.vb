Public Class Presupuesto

    Public Sub rtbPresu_TextChanged(sender As Object, e As EventArgs) Handles rtbPresu.TextChanged


    End Sub

    Public Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

        Form1.chbContestador.Checked = False
        Form1.chbCalculadora.Checked = False
        Form1.chbFotocopia.Checked = False
        presuOficina = 0

    End Sub

    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class