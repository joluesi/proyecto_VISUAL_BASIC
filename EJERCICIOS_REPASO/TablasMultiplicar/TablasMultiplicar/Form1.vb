Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_NumeroTabla.TextChanged

        If IsNumeric(txt_NumeroTabla.Text) Then

            Dim tablaNumero, producto, multiplicadores As Integer
            Dim resultado As String = ""

            tablaNumero = Val(txt_NumeroTabla.Text)

            For multiplicadores = 0 To 10

                producto = tablaNumero * multiplicadores

                resultado = resultado & tablaNumero & " * " & multiplicadores & " = " & producto & vbCrLf

            Next multiplicadores

            'Muestra la tabla en cuadro de texto
            rtbx_tablas.Text = resultado

        ElseIf txt_NumeroTabla.Text = "" Or Not (IsNumeric(txt_NumeroTabla.Text)) Then
            MsgBox("Introduzca un número para obtener su tabla de multiplicar")

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txt_NumeroTabla.Clear()

    End Sub

End Class
