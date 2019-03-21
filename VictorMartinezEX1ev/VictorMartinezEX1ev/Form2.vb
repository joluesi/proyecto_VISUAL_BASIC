Public Class Form2
    Function numero(ByVal num As Integer)

        If cuatroNum = 4 Then

            MsgBox("Solo cuatro dígitos")

        Else

            txtClave.Text += CStr(num)

            cuatroNum = cuatroNum + 1
        End If

    End Function

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        numero(1)

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        numero(2)

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        numero(3)

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        numero(4)

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        numero(5)

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        numero(6)

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        numero(7)

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        numero(8)

    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        numero(9)

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        numero(0)

    End Sub

    Private Sub btnClave_Click(sender As Object, e As EventArgs) Handles btnClave.Click

        If variableCli(numCli).bloqueoCli = True Then

            MsgBox("Este cliente está bloqueado")

        Else

            If variableCli(numCli).claveCli = CInt(txtClave.Text) Then

                MsgBox("La clave es correcta")

                Me.Hide()
                Form3.Show()

            Else

                intentos = intentos - 1

                MsgBox("La clave es incorrecta, le quedan " + CStr(intentos) + " intentos")

                txtClave.Text = ""
                cuatroNum = 0

                If intentos = 0 Then

                    MsgBox("Lo siento, no le quedan intentos, se le ha bloqueado la cuenta")

                    variableCli(numCli).bloqueoCli = True


                End If

            End If

        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        intentos = 3
        cuatroNum = 0

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class