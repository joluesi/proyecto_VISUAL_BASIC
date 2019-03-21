Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim cadMes As String, numMes As Integer

        If (txtDia.Text = "" Or txtMes.Text = "" Or txtAnno.Text = "") Then
            MsgBox("Introduzca todos los datos")

        ElseIf Not (IsNumeric(txtDia.Text) Or IsNumeric(txtMes.Text) Or IsNumeric(txtAnno.Text)) Then
            MsgBox("Introducir sólo números")
            btnLimpiar.PerformClick()

        ElseIf (txtDia.Text < 0 Or txtDia.Text > 31) Then
            MsgBox("Día no puede ser negativo, o mayor de 31")
            btnLimpiar.PerformClick()

        Else
            numMes = Val(txtMes.Text)

            Select Case numMes
                Case 1 : cadMes = "Enero"
                Case 2 : cadMes = "Febrero"
                Case 3 : cadMes = “Marzo”
                Case 4 : cadMes = “Abril”
                Case 5 : cadMes = “Mayo”
                Case 6 : cadMes = “Junio”
                Case 7 : cadMes = “Julio”
                Case 8 : cadMes = “Agosto”
                Case 9 : cadMes = “Setiembre”
                Case 10 : cadMes = “Octubre”
                Case 11 : cadMes = “Noviembre”
                Case 12 : cadMes = “Diciembre”

                Case Else
                    MsgBox(“Datos erróneos...”, vbCritical, “Mensaje”)
                    btnLimpiar.PerformClick()

            End Select

            txtFechaFormato.Text = txtDia.Text & " de " & cadMes & " del año " & txtAnno.Text

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDia.Text = ""
        txtMes.Text = ""
        txtAnno.Text = ""
        txtFechaFormato.Text = ""

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        If MsgBox("¿Desea cerrar la aplicación? ", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            MsgBox("Adiós!!!")
            Application.Exit()

        Else
            btnLimpiar.PerformClick()

        End If

    End Sub
End Class
