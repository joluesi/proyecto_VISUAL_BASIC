Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If IsNumeric(txtNumero.Text) Then
            Dim sumaCifras As Integer, sumaImpares As Integer, sumaPares As Integer
            Dim cifraMayor As Integer, cifraMenor As Integer
            Dim cadDivisores As String
            Dim cantCifras As Integer, contador As Integer
            Dim N, M As Long
            N = CLng(txtNumero.Text)
            M = CLng(txtNumero.Text)
            cadDivisores = “”
            cantCifras = 0
            contador = 1
            sumaCifras = sumaPares = sumaImpares = 0

            For contador = 1 To N
                If (N Mod contador = 0) Then
                    cadDivisores = cadDivisores & contador & vbCrLf
                End If
            Next contador

            While (N > 0)
                If ((N Mod 10) Mod 2) = 0 Then
                    sumaPares = sumaPares + (N Mod 10)
                Else
                    sumaImpares = sumaImpares + (N Mod 10)
                End If

                sumaCifras = sumaCifras + (N Mod 10)
                N = N \ 10
                cantCifras = cantCifras + 1
            End While

            cifraMayor = Mid(txtNumero.Text, 1, 1)
            cifraMenor = cifraMayor

            While (M > 0)
                If cifraMayor < (M Mod 10) Then
                    cifraMayor = M Mod 10
                End If
                If cifraMenor > (M Mod 10) Then
                    cifraMenor = M Mod 10
                End If
                M = M \ 10
            End While

            txtCifras.Text = Str(cantCifras)
            txtSumaCifrasImpares.Text = Str(sumaImpares)
            txtSumaCifrasPares.Text = Str(sumaPares)
            txtTotalCifras.Text = Str(sumaCifras)
            txtCifraMayor.Text = Str(cifraMayor)
            txtCifraMenor.Text = Str(cifraMenor)
            txtDivisores.Text = cadDivisores

        Else
            MsgBox(“Debe introducir un número”, vbCritical, “Mensaje”)
            txtNumero.Focus()

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNumero.Text = ""
        txtCifras.Text = ""
        txtSumaCifrasImpares.Text = ""
        txtSumaCifrasPares.Text = ""
        txtTotalCifras.Text = ""
        txtCifraMayor.Text = ""
        txtCifraMenor.Text = ""
        txtDivisores.Text = ""

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        If MsgBox("¿Desea cerrar la aplicación? ", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            MsgBox("Adiós!!!")
            Application.Exit()
        Else
            btnLimpiar.PerformClick()
            txtNumero.Focus()
        End If

    End Sub

End Class
