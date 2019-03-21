Public Class Form3
    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        If Not IsNumeric(txtNumero.Text) Then
            MsgBox("Introduzca número entero")

        ElseIf (txtNumero.Text >= 8) Then
            MsgBox("Introduzca entero menor de 8")

        End If

    End Sub

    Public Function Factorial(num As Single) As Single

        Dim resultado As Single

        For index = 0 To num
            If num = 0 Then
                resultado = 1
            Else
                resultado = num * Factorial(num - 1)
            End If

        Next

        Return resultado

    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Dim resultado As Single
        resultado = Factorial(CSng(txtNumero.Text))
        txtFactorial.Text = resultado

    End Sub



End Class