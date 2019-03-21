Public Class FactFibo
    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        If Not (IsNumeric(txtNumero.Text)) Then
            MsgBox("Por favor, introduzca número entero positivo")

        End If

    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click

        If (txtNumero.Text = "" Or txtNumero.Text >= 8 Or txtNumero.Text < 0) Then
            MsgBox("Por favor, para Factorial introduzca número entero positivo menor de 8")
        Else
            txtFactorial.Text = Factorial(numero:=txtNumero.Text)

        End If

    End Sub

    Public Function Factorial(numero As Integer) As Integer

        If numero = 0 Then
            Factorial = 1
        ElseIf numero = 1 Then
            Factorial = 1
        ElseIf numero > 1 Then
            Factorial = numero * Factorial(numero - 1)
        End If

        Return Factorial

    End Function

    Public Function Fibonacci(numero As Integer) As Integer

        If numero = 0 Then
            Fibonacci = 0
        ElseIf numero = 1 Then
            Fibonacci = 1
        ElseIf numero >= 2 Then
            Fibonacci = Fibonacci(numero - 1) + Fibonacci(numero - 2)
        End If

        Return Fibonacci

    End Function

    Private Sub btnFibonacci_Click(sender As Object, e As EventArgs) Handles btnFibonacci.Click

        If (txtNumero.Text = "") Then
            MsgBox("Por favor, introducir número entero positivo")
        Else
            txtFibonacci.Text = Fibonacci(numero:=txtNumero.Text)
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Menu_Opciones.Show()

    End Sub
End Class