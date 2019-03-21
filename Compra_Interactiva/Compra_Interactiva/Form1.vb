Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbtnPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPC.CheckedChanged

        If (rbtnPC.Checked) Then
            picMac.Visible = False
            picLaptop.Visible = False
            picComputer.Visible = True

        ElseIf rbtnMac.Checked Then
            picComputer.Visible = False
            picLaptop.Visible = False
            picMac.Visible = True

        ElseIf rbtnPortatil.Checked Then
            picComputer.Visible = False
            picMac.Visible = False
            picLaptop.Visible = True

        End If

    End Sub

    Private Sub rbtnPortatil_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPortatil.CheckedChanged

        If (rbtnPC.Checked) Then
            picMac.Visible = False
            picLaptop.Visible = False
            picComputer.Visible = True

        ElseIf rbtnMac.Checked Then
            picComputer.Visible = False
            picLaptop.Visible = False
            picMac.Visible = True

        ElseIf rbtnPortatil.Checked Then
            picComputer.Visible = False
            picMac.Visible = False
            picLaptop.Visible = True

        End If
    End Sub

    Private Sub chkContestador_CheckedChanged(sender As Object, e As EventArgs) Handles chbContestador.CheckedChanged
        If chbContestador.Checked Then
            picContestador.Visible = True
        Else
            picContestador.Visible = False
        End If

    End Sub

    Private Sub chbCalculadora_CheckedChanged(sender As Object, e As EventArgs) Handles chbCalculadora.CheckedChanged
        If chbCalculadora.Checked Then
            picCalculadora.Visible = True
        Else
            picCalculadora.Visible = False
        End If

    End Sub

    Private Sub chbFotocopia_CheckedChanged(sender As Object, e As EventArgs) Handles chbFotocopia.CheckedChanged
        If chbFotocopia.Checked Then
            picFotocopia.Visible = True
        Else
            picFotocopia.Visible = False
        End If

    End Sub

    Private Sub lsbPerifericos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbPerifericos.SelectedIndexChanged

        If lsbPerifericos.SelectedIndex = 0 Then
            picDiscoDuro.Visible = True
            picImpresora.Visible = False
            picAntena.Visible = False
        End If

        If lsbPerifericos.SelectedIndex = 1 Then
            picDiscoDuro.Visible = False
            picImpresora.Visible = True
            picAntena.Visible = False

        End If

        If lsbPerifericos.SelectedIndex = 2 Then
            picDiscoDuro.Visible = False
            picImpresora.Visible = False
            picAntena.Visible = True

        End If

    End Sub

    Private Sub cmbPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPago.SelectedIndexChanged

        If cmbPago.SelectedIndex = 0 Then
            picDolar.Visible = True
        Else picDolar.Visible = False

        End If

        If cmbPago.SelectedIndex = 1 Then
            picEfectivo.Visible = True
        Else picEfectivo.Visible = False

        End If

        If cmbPago.SelectedIndex = 2 Then
            picCheque.Visible = True
        Else picCheque.Visible = False

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
        MsgBox("Adiós ¡¡¡")

    End Sub
End Class
