Public Class Cajero

    Private Sub btnReintegro_Click(sender As Object, e As EventArgs) Handles btnReintegro.Click
        Try
            Dim saldo As Double = clienteActivo.saldoCli
            Dim reintegro As Double = CDbl(txtPantalla.Text.ToString)

            If saldo < reintegro Then
                MsgBox("El saldo en su cuenta es insufiente para esa cantidad")
                txtPantalla.Text = ""
            Else
                clienteActivo.saldoCli = saldo - reintegro

                For i = 0 To 4 'Actualiza array
                    If clienteActivo.codCli.Equals(clientes(i).codCli) Then
                        clientes(i) = clienteActivo
                        MsgBox("Se ha retirado la cantidad de" & reintegro & " euros")
                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox("Introduce una cantidad")
        End Try
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Try
            Dim ingreso As Integer = CInt(txtPantalla.Text.ToString)
            Dim saldo As Double = clienteActivo.saldoCli
            clienteActivo.saldoCli = saldo + ingreso
            MsgBox("Se ha ingresado la cantidad de" & ingreso & " euros")
        Catch ex As Exception
            MsgBox("Introduce una cantidad")
        End Try

    End Sub


    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click
        Dim saldo As Double = clienteActivo.saldoCli
        txtPantalla.Text = saldo
    End Sub




    Private Function EscribeNum(ByVal text As String)
        Dim texto As String = txtPantalla.Text
        txtPantalla.Text = texto & text
    End Function

    Private Sub ButNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn20.Click, btn50.Click, btn100.Click, btn200.Click
        Dim esteBoton As Button = CType(sender, Button)
        txtPantalla.Text = ""
        EscribeNum(esteBoton.Text)
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Cajero_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then
            EscribeNum("1")
        End If
        If e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then
            EscribeNum("2")
        End If
        If e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then
            EscribeNum("3")
        End If
        If e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then
            EscribeNum("4")
        End If
        If e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then
            EscribeNum("5")
        End If
        If e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then
            EscribeNum("6")
        End If
        If e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then
            EscribeNum("7")
        End If
        If e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then
            EscribeNum("8")
        End If
        If e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then
            EscribeNum("9")
        End If
        If e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0 Then
            EscribeNum("0")
        End If
    End Sub
End Class