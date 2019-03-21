Public Class Form1
    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click

        Dim salarioBruto As Double
        Dim salarioNeto As Double
        Dim horasTrab As Integer
        Dim pagoXHora As Double
        Dim descuento As Double

        If (txt_Nombre.Text = "" Or txt_HorasTrab.Text = "" Or txt_PagoHora.Text = "") Then
            MsgBox("Antes debe introducir todos los datos en formulario de entrada")
        ElseIf Not (IsNumeric(txt_HorasTrab.Text) And (IsNumeric(txt_PagoHora.Text))) Then
            MsgBox("Horas trabajadas y pago por hora han de ser numéricos")

        Else
            horasTrab = Val(txt_HorasTrab.Text)
            pagoXHora = Val(txt_PagoHora.Text)
            salarioBruto = horasTrab * pagoXHora
            txt_SalarioBruto.Text = Str(salarioBruto)

            descuento = 0.2 * salarioBruto
            txt_Descuento.Text = Str(descuento)

            salarioNeto = salarioBruto - descuento
            txt_SalarioNeto.Text = Str(salarioNeto)

        End If

    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click

        txt_Nombre.Text = ""
        txt_HorasTrab.Text = ""
        txt_PagoHora.Text = ""
        txt_SalarioBruto.Text = ""
        txt_SalarioNeto.Text = ""
        txt_Descuento.Text = ""


    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        MsgBox("Gracias y adiós !!!")
        Application.Exit()


    End Sub
End Class
