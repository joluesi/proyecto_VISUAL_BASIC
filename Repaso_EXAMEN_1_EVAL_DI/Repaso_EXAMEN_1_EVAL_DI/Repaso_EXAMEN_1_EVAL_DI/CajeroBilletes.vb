Public Class CajeroBilletes
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        txtDisplay.Text = ""
        Me.Hide()
        Form1.Show()

    End Sub

    Private Function InsertaNumero(ByVal dinero As String)
        'display = txtDisplay.Text
        'txtDisplay.Text = display & dinero
        txtDisplay.Text += dinero

    End Function

    Private Sub BilletesBotones_Click(sender As Object, e As EventArgs) Handles btn20.Click, btn50.Click, btn100.Click, btn200.Click

        Dim miBillete As Button = CType(sender, Button)
        txtDisplay.Text = ""
        InsertaNumero(miBillete.Text)

    End Sub

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click

        txtDisplay.Text = arrayCliente(numOrden).saldocli
        MsgBox("Dispone de un saldo de " & arrayCliente(numOrden).saldocli & " € en su cuenta")

    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click

        Try
            If (txtDisplay.Text = "") Then
                MsgBox("No ha introducido ninguna cantidad a ingresar")
            Else
                MsgBox("Usted ha ingresado " & txtDisplay.Text & " € en su cuenta.")
                arrayCliente(numOrden).saldocli += txtDisplay.Text

            End If

        Catch ex As Exception
            txtDisplay.Text = ""
            MsgBox("Error. Introduzca una cantidad")
        End Try

    End Sub

    Private Sub btnReintegro_Click(sender As Object, e As EventArgs) Handles btnReintegro.Click

        Try
            If (txtDisplay.Text = "") Then
                MsgBox("No ha introducido ninguna cantidad a reintegrar")

            ElseIf arrayCliente(numOrden).saldocli < txtDisplay.Text Then
                MsgBox("Cantidad no disponible. Dispone de " & arrayCliente(numOrden).saldocli & " € en su cuenta")

            Else
                MsgBox("Usted ha retirado " & txtDisplay.Text & " € de su cuenta.")
                arrayCliente(numOrden).saldocli -= txtDisplay.Text

            End If

        Catch ex As Exception
            txtDisplay.Text = ""
            MsgBox("Error. Introduzca una cantidad")
        End Try

    End Sub

    Private Sub CajeroBilletes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode.ToString
            Case Keys.NumPad0, Keys.D0
                InsertaNumero("0")
            Case Keys.NumPad1, Keys.D1
                InsertaNumero("1")
            Case Keys.NumPad2, Keys.D2
                InsertaNumero("2")
            Case Keys.NumPad3, Keys.D3
                InsertaNumero("3")
            Case Keys.NumPad4, Keys.D4
                InsertaNumero("4")
            Case Keys.NumPad5, Keys.D5
                InsertaNumero("5")
            Case Keys.NumPad6, Keys.D6
                InsertaNumero("6")
            Case Keys.NumPad7, Keys.D7
                InsertaNumero("7")
            Case Keys.NumPad8, Keys.D8
                InsertaNumero("8")
            Case Keys.NumPad9, Keys.D9
                InsertaNumero("9")

        End Select

    End Sub


End Class