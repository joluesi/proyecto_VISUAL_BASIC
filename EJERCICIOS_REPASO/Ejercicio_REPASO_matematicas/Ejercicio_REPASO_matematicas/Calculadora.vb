Public Class Calculadora

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

        If Not (IsNumeric(txtNum1.Text)) Then
            MsgBox("Por favor, introduzca valor numérico")
        End If
    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged
        If Not (IsNumeric(txtNum1.Text)) Then
            MsgBox("Por favor, introduzca valor numérico")
        End If
    End Sub

    Public Function Sumar(num1 As Single, num2 As Single) As Single
        Sumar = num1 + num2
    End Function

    Public Function Restar(num1 As Single, num2 As Single) As Single
        Restar = num1 - num2
    End Function

    Public Function Multiplicar(num1 As Single, num2 As Single) As Single
        Multiplicar = num1 * num2
    End Function

    Public Function Dividir(num1 As Single, num2 As Single) As Single
        If (num2 = 0) Then
            MsgBox("Para dividir elija número2 que sea distinto de '0'")
        Else
            Dividir = num1 / num2
        End If
    End Function

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes introduzca dos valores a sumar")
        Else
            txtSolucion.Text = Sumar(num1:=txtNum1.Text, num2:=txtNum2.Text)

        End If

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes introduzca dos valores a restar")
        Else
            txtSolucion.Text = Restar(num1:=txtNum1.Text, num2:=txtNum2.Text)

        End If

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes introduzca dos valores a multiplicar")
        Else
            txtSolucion.Text = Multiplicar(num1:=txtNum1.Text, num2:=txtNum2.Text)

        End If

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes introduzca dos valores a dividir")
        Else
            txtSolucion.Text = Dividir(num1:=txtNum1.Text, num2:=txtNum2.Text)

        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Me.Hide()
        Menu_Opciones.Show()

    End Sub
End Class