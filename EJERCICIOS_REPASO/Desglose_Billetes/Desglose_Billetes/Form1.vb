Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If (IsNumeric(txt_dinero.Text)) Then
            txt_billetes_500.Text = Int(txt_dinero.Text / 500)
            txt_billetes_200.Text = Int((txt_dinero.Text - (txt_billetes_500.Text * 500)) / 200)
            txt_billetes_100.Text = Int((txt_dinero.Text - ((txt_billetes_500.Text * 500) + (txt_billetes_200.Text * 200))) / 100)
            txt_billetes_50.Text = Int((txt_dinero.Text - (((txt_billetes_500.Text * 500) + (txt_billetes_200.Text * 200) + (txt_billetes_100.Text * 100)))) / 50)
            txt_billetes_20.Text = Int((txt_dinero.Text - ((((txt_billetes_500.Text * 500) + (txt_billetes_200.Text * 200) + (txt_billetes_100.Text * 100) + (txt_billetes_50.Text * 50))))) / 20)
            txt_billetes_10.Text = Int((txt_dinero.Text - (((((txt_billetes_500.Text * 500) + (txt_billetes_200.Text * 200) + (txt_billetes_100.Text * 100) + (txt_billetes_50.Text * 50) +
                                   (txt_billetes_20.Text * 20)))))) / 10)

            txt_billetes_5.Text = Int((txt_dinero.Text - ((((((txt_billetes_500.Text * 500) + (txt_billetes_200.Text * 200) + (txt_billetes_100.Text * 100) + (txt_billetes_50.Text * 50) +
                                   (txt_billetes_20.Text * 20) + txt_billetes_10.Text * 10)))))) / 5)

        Else
            MsgBox("Introduzca importe en número")

        End If

    End Sub
End Class
