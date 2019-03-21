Public Class Form1
    Private Sub btnAzar_Click(sender As Object, e As EventArgs) Handles btnAzar.Click

        Dim azar As Integer
        Randomize()
        azar = Int(10 * Rnd()) + 1
        txtNumeroAzar.Text = azar

    End Sub

    Private Sub btnAzarRangos_Click(sender As Object, e As EventArgs) Handles btnAzarRangos.Click

        Dim azar As Integer
        Dim rangoInferior As Integer
        Dim rangoSuperior As Integer
        Randomize()
        rangoInferior = CInt(txtInferior.Text)
        rangoSuperior = CInt(txtSuperior.Text)
        azar = Int((rangoSuperior - rangoInferior + 1) * Rnd() + rangoInferior)
        txtAzarRangos.Text = azar

    End Sub

    Private Sub btnEjecutarRaiz_Click(sender As Object, e As EventArgs) Handles btnEjecutarRaiz.Click

        Dim numero As Integer
        Dim raiz As Integer
        raiz = CInt(txtRaiz.Text)
        numero = CInt(txtNumeroRaiz.Text)
        txtEjecutarRaiz.Text = numero ^ (1 / raiz)

    End Sub

    Private Sub btnEjecutarDecimal_Click(sender As Object, e As EventArgs) Handles btnEjecutarDecimal.Click

        Dim numero As Single
        Dim decimales As Integer

        numero = txtNumeroDecimal.Text
        decimales = txtDecimales.Text
        txtEjecutarDecimales.Text = Math.Round(numero, decimales)

    End Sub
End Class
