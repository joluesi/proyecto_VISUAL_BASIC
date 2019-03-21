Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function Suma(num1 As Single, num2 As Single) As Single

        Suma = num1 + num2

    End Function

    Public Function Resta(num1 As Single, num2 As Single) As Single

        Resta = num1 - num2

    End Function

    Public Function Multiplicacion(num1 As Single, num2 As Single) As Single

        Multiplicacion = num1 * num2

    End Function

    Public Function Division(num1 As Single, num2 As Single) As Single

        If (num2 = 0) Then
            MsgBox("Error. No se puede dividor por '0'. Introduzca número distinto de '0'")

        Else
            Division = num1 / num2

        End If

    End Function


    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

        If (Not IsNumeric(txtNum1.Text)) Then
            MsgBox("Error. Introduzca un número entero positivo")
        End If

    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged

        If (Not IsNumeric(txtNum2.Text)) Then
            MsgBox("Error. Introduzca un número entero positivo")
        End If

    End Sub



    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes debe introducir los números a sumar")
        Else
            Dim resultado As Single
            resultado = Suma(num1:=txtNum1.Text, num2:=txtNum2.Text)
            txtSolucion.Text = resultado

        End If

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes debe introducir los números a restar")
        Else
            Dim resultado As Single
            resultado = Resta(num1:=txtNum1.Text, num2:=txtNum2.Text)
            txtSolucion.Text = resultado

        End If

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes debe introducir los números a multiplicar")
        Else
            Dim resultado As Single
            resultado = Multiplicacion(num1:=txtNum1.Text, num2:=txtNum2.Text)
            txtSolucion.Text = resultado

        End If

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        If (txtNum1.Text = "" Or txtNum2.Text = "") Then
            MsgBox("Antes debe introducir los números a dividir")
        Else
            Dim resultado As Single
            resultado = Division(num1:=txtNum1.Text, num2:=txtNum2.Text)
            txtSolucion.Text = resultado

        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Inicio.Show()

    End Sub
End Class