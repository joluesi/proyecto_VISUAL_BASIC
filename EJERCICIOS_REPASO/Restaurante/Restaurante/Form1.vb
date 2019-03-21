Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuRestaurante(0, 0) = "Hamburguesa"
        MenuRestaurante(0, 1) = "2.50"
        MenuRestaurante(1, 0) = "Cerveza"
        MenuRestaurante(1, 1) = "4.00"
        MenuRestaurante(2, 0) = "Gaseosa"
        MenuRestaurante(2, 1) = "3.00"
        MenuRestaurante(3, 0) = "Ensalada"
        MenuRestaurante(3, 1) = "1.50"
        MenuRestaurante(4, 0) = "Salchichas"
        MenuRestaurante(4, 1) = "2.00"
        MenuRestaurante(5, 0) = "Refresco"
        MenuRestaurante(5, 1) = "1.00"
        MenuRestaurante(6, 0) = "Sopa"
        MenuRestaurante(6, 1) = "1.50"
        MenuRestaurante(7, 0) = "Postre"
        MenuRestaurante(7, 1) = "1.50"

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim ventaTotal As Double
        Dim impuestos As Double

        If Not ((IsNumeric(txthambur.Text) And IsNumeric(txtCerveza.Text) And IsNumeric(txtGaseosa.Text) And IsNumeric(txtEnsalada.Text) And IsNumeric(txtSalchicha.Text) And
                 IsNumeric(txtRefresco.Text) And IsNumeric(txtSopa.Text) And IsNumeric(txtPostre.Text))) Then

            MsgBox("Los menús han de ser valores numéricos")

        Else

            ventaTotal = (Val(txthambur.Text) * Val(MenuRestaurante(0, 1)) +
                      Val(txtCerveza.Text) * Val(MenuRestaurante(1, 1)) +
                      Val(txtGaseosa.Text) * Val(MenuRestaurante(2, 1)) +
                      Val(txtEnsalada.Text) * Val(MenuRestaurante(3, 1)) +
                      Val(txtSalchicha.Text) * Val(MenuRestaurante(4, 1)) +
                      Val(txtRefresco.Text) * Val(MenuRestaurante(5, 1)) +
                      Val(txtSopa.Text) * Val(MenuRestaurante(6, 1)) +
                      Val(txtPostre.Text) * Val(MenuRestaurante(7, 1)))

            txtVentas.Text = ventaTotal

            impuestos = ventaTotal * 0.18
            txtImpuestos.Text = impuestos

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txthambur.Text = ""
        txtCerveza.Text = ""
        txtGaseosa.Text = ""
        txtEnsalada.Text = ""
        txtSalchicha.Text = ""
        txtRefresco.Text = ""
        txtSopa.Text = ""
        txtPostre.Text = ""
        txtVentas.Text = ""
        txtImpuestos.Text = ""

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        MsgBox("Gracias por su consumición. Hasta pronto !!! ")
        Application.Exit()

    End Sub
End Class
