Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub rbtnPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPC.CheckedChanged

        If (rbtnPC.Checked) Then
            picMac.Visible = False
            picLaptop.Visible = False
            picComputer.Visible = True
            PC = " Ordenador de sobremesa ----------------"
            pvpPC = 700

        ElseIf rbtnMac.Checked Then
            picComputer.Visible = False
            picLaptop.Visible = False
            picMac.Visible = True
            Mac = " Ordenador Macintosh ----------------"
            pvpMac = 1000

        ElseIf rbtnPortatil.Checked Then
            picComputer.Visible = False
            picMac.Visible = False
            picLaptop.Visible = True
            portatil = " Ordenador portátil ----------------"
            pvpPortatil = 500

        End If

    End Sub

    Public Sub rbtnPortatil_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPortatil.CheckedChanged

        If (rbtnPC.Checked) Then
            picMac.Visible = False
            picLaptop.Visible = False
            picComputer.Visible = True
            PC = " Ordenador de sobremesa ----------------"
            pvpPC = 700

        ElseIf rbtnMac.Checked Then
            picComputer.Visible = False
            picLaptop.Visible = False
            picMac.Visible = True
            Mac = " Ordenador Macintosh ----------------"
            pvpMac = 1000

        ElseIf rbtnPortatil.Checked Then
            picComputer.Visible = False
            picMac.Visible = False
            picLaptop.Visible = True
            portatil = " Ordenador portátil ----------------"
            pvpPortatil = 500

        End If

    End Sub

    Public Sub chbContestador_CheckedChanged(sender As Object, e As EventArgs) Handles chbContestador.CheckedChanged

        If chbContestador.Checked Then
            picContestador.Visible = True
            contestador = " Contestador ----------------"
            pvpContestador = 50
        Else
            picContestador.Visible = False
        End If

    End Sub

    Public Sub chbCalculadora_CheckedChanged(sender As Object, e As EventArgs) Handles chbCalculadora.CheckedChanged

        If chbCalculadora.Checked Then
            picCalculadora.Visible = True
            calculadora = " Calculadora ----------------"
            pvpCalculadora = 20
        Else
            picCalculadora.Visible = False
        End If

    End Sub

    Public Sub chbFotocopia_CheckedChanged(sender As Object, e As EventArgs) Handles chbFotocopia.CheckedChanged

        If chbFotocopia.Checked Then
            picFotocopia.Visible = True
            fotocopia = " Fotocopiadora ----------------"
            pvpFotocopia = 100
        Else
            picFotocopia.Visible = False
        End If

    End Sub

    Private Sub lsbPerifericos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbPerifericos.SelectedIndexChanged

        If lsbPerifericos.SelectedIndex = 0 Then
            picDiscoDuro.Visible = True
            picImpresora.Visible = False
            picAntena.Visible = False
            HDD = " Disco duro adicional ----------------"
            pvpHDD = 75
        End If

        If lsbPerifericos.SelectedIndex = 1 Then
            picDiscoDuro.Visible = False
            picImpresora.Visible = True
            picAntena.Visible = False
            impresora = " Impresora ----------------"
            pvpImpresora = 90
        End If

        If lsbPerifericos.SelectedIndex = 2 Then
            picDiscoDuro.Visible = False
            picImpresora.Visible = False
            picAntena.Visible = True
            antena = " Antena ----------------"
            pvpAntena = 50
        End If

    End Sub

    Private Sub cmbPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPago.SelectedIndexChanged


        If cmbPago.SelectedIndex = 0 Then
            picDolar.Visible = True
            medioPago = " Pago en dólares"
        Else picDolar.Visible = False

        End If

        If cmbPago.SelectedIndex = 1 Then
            picEfectivo.Visible = True
            medioPago = " Pago en efectivo"
        Else picEfectivo.Visible = False

        End If

        If cmbPago.SelectedIndex = 2 Then
            picCheque.Visible = True
            medioPago = " Pago mediante cheque"
        Else picCheque.Visible = False

        End If

    End Sub

    Public Sub btnPresupuesto_Click(sender As Object, e As EventArgs) Handles btnPresupuesto.Click

        If (rbtnPC.Checked) Then
            equipo = PC
            presuEquipo = pvpPC

        ElseIf (rbtnMac.Checked) Then
            equipo = Mac
            presuEquipo = pvpMac

        ElseIf (rbtnPortatil.Checked) Then
            equipo = portatil
            presuEquipo = pvpPortatil

        End If


        If (chbContestador.Checked And chbCalculadora.Checked And chbFotocopia.Checked) Then
            oficina = contestador + calculadora + fotocopia
            presuOficina = pvpContestador + pvpCalculadora + pvpFotocopia

        ElseIf (chbCalculadora.Checked And chbFotocopia.Checked) Then
            oficina = calculadora + fotocopia
            presuOficina = pvpCalculadora + pvpFotocopia

        ElseIf (chbContestador.Checked And chbCalculadora.Checked) Then
            oficina = contestador + calculadora
            presuOficina = pvpContestador + pvpCalculadora

        ElseIf (chbContestador.Checked And chbFotocopia.Checked) Then
            oficina = contestador + fotocopia
            presuOficina = pvpContestador + pvpFotocopia

        ElseIf (chbContestador.Checked And chbCalculadora.Checked = False And chbFotocopia.Checked = False) Then
            oficina = contestador
            presuOficina = pvpContestador

        ElseIf (chbCalculadora.Checked And chbContestador.Checked = False And chbFotocopia.Checked = False) Then
            oficina = calculadora
            presuOficina = pvpCalculadora

        ElseIf (chbFotocopia.Checked And chbContestador.Checked = False And chbCalculadora.Checked = False) Then
            oficina = fotocopia
            presuOficina = pvpFotocopia

        Else
            oficina = " Equipos de oficina ----------------"


        End If


        If (lsbPerifericos.SelectedIndex = 0) Then
            perifericos = HDD
            presuPerifericos = pvpHDD

        ElseIf (lsbPerifericos.SelectedIndex = 1) Then
            perifericos = impresora
            presuPerifericos = pvpImpresora

        ElseIf (lsbPerifericos.SelectedIndex = 2) Then
            perifericos = antena
            presuPerifericos = pvpAntena

        Else
            perifericos = " Equipos periféricos ----------------"

        End If



        If (cmbPago.SelectedIndex = 0) Then
            medioPago = vbCrLf & " Pago en dólares"

        ElseIf (cmbPago.SelectedIndex = 1) Then
            medioPago = vbCrLf & " Pago en efectivo"

        ElseIf (cmbPago.SelectedIndex = 2) Then
            medioPago = vbCrLf & " Pago mediante cheque"

        Else
            medioPago = vbCrLf & " Nota.- No ha seleccionado medio de pago"


        End If

        presuTotal = presuEquipo + presuOficina + presuPerifericos
        presu = vbCrLf & "TOTAL PRESUPUESTO: ----------------"

        Presupuesto.Show()
        Presupuesto.rtbPresu.Text = equipo & CStr(presuEquipo) & vbCrLf &
                                    oficina & CStr(presuOficina) & vbCrLf &
                                    perifericos & CStr(presuPerifericos) & vbCrLf &
                                    presu & presuTotal & vbCrLf &
                                    medioPago


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
        MsgBox("Adiós ¡¡¡")
    End Sub

End Class
