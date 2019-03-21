Public Class Form3
    Function dinero(ByVal din As Integer)

        txtSaldo.Text = CStr(din)

    End Function

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click

        MsgBox("Tiene " + CStr(variableCli(numCli).saldoCli) + "€ en su cuenta")

    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click

        variableCli(numCli).saldoCli += CInt(txtSaldo.Text)
        MsgBox("Usted ha ingresado " + CStr(txtSaldo.Text) + "€ a su cuenta")

        txtSaldo.Text = ""

    End Sub

    Private Sub btnReintegro_Click(sender As Object, e As EventArgs) Handles btnReintegro.Click

        If variableCli(numCli).saldoCli >= CInt(txtSaldo.Text) Then

            variableCli(numCli).saldoCli -= CInt(txtSaldo.Text)
            MsgBox("Usted ha sacado " + CStr(txtSaldo.Text) + "€ de su cuenta")

            txtSaldo.Text = ""

        Else

            MsgBox("Tiene " + CStr(variableCli(numCli).saldoCli) + "€ en la cuenta, no tiene suficiente saldo")

            txtSaldo.Text = ""

        End If

    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click

        dinero(20)

    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click

        dinero(50)

    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click

        dinero(100)

    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click

        dinero(200)

    End Sub

    Private Sub Form3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        Select Case (e.KeyChar.ToString)

            Case 0

                txtSaldo.Text += "0"

            Case 1

                txtSaldo.Text += "1"
            Case 2

                txtSaldo.Text += "2"
            Case 3

                txtSaldo.Text += "3"
            Case 4

                txtSaldo.Text += "4"
            Case 5

                txtSaldo.Text += "5"
            Case 6

                txtSaldo.Text += "6"
            Case 7

                txtSaldo.Text += "7"

            Case 8

                txtSaldo.Text += "8"
            Case 9

                txtSaldo.Text += "9"

        End Select
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyData = Keys.Back Then

            txtSaldo.Clear()

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Hide()
        Form1.Show()

    End Sub
End Class