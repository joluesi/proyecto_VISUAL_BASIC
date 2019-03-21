Public Class Form1
    Private Sub rbtnPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPC.CheckedChanged

        If rbtnPC.Checked Then
            picPC.Visible = True
            picMac.Visible = False
            picPortatil.Visible = False

            precioPC = 700
            totalEqNecesario = "EQUIPO NECESARIO ----- PC: " & precioPC & " €"
            totalEquipos = precioPC
        End If

    End Sub

    Private Sub rbtnMac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMac.CheckedChanged

        If rbtnMac.Checked Then
            picMac.Visible = True
            picPC.Visible = False
            picPortatil.Visible = False

            precioMAC = 1000
            totalEqNecesario = "EQUIPO NECESARIO ----- MACINTOSH: " & precioMAC & " €"
            totalEquipos = precioMAC
        End If

    End Sub

    Private Sub rbtnPortatil_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPortatil.CheckedChanged
        If rbtnPortatil.Checked Then
            picPortatil.Visible = True
            picPC.Visible = False
            picMac.Visible = False

            precioPORTATIL = 500
            totalEqNecesario = "EQUIPO NECESARIO ----- PORTATIL: " & precioPORTATIL & " €"
            totalEquipos = precioPORTATIL
        End If

    End Sub

    Private Sub chkContestador_CheckedChanged(sender As Object, e As EventArgs) Handles chkContestador.CheckedChanged

        If chkContestador.Checked Then
            picContestador.Visible = True

            precioCONTESTADOR = 50
            textoCONTESTADOR = "EQUIPOS OPCIONALES ----- CONTESTADOR: " & precioCONTESTADOR & " €"
            textoOpcionales += textoCONTESTADOR & vbCrLf
            totalOpcionales += precioCONTESTADOR
        Else
            picContestador.Visible = False

        End If

    End Sub

    Private Sub chkCalculadora_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalculadora.CheckedChanged

        If chkCalculadora.Checked Then
            picCalculadora.Visible = True

            precioCALCULADORA = 20
            textoCALCULADORA = "EQUIPOS OPCIONALES ----- CALCULADORA: " & precioCALCULADORA & " €"
            textoOpcionales += textoCALCULADORA & vbCrLf
            totalOpcionales += precioCALCULADORA
        Else
            picCalculadora.Visible = False

        End If

    End Sub

    Private Sub chkFotocopiadora_CheckedChanged(sender As Object, e As EventArgs) Handles chkFotocopiadora.CheckedChanged

        If chkFotocopiadora.Checked Then
            picFotocopiadora.Visible = True

            precioFOTOCOPIADORA = 100
            textoFOTOCOPIADORA = "EQUIPOS OPCIONALES ----- FOTOCOPIADORA: " & precioFOTOCOPIADORA & " €"
            textoOpcionales += textoFOTOCOPIADORA & vbCrLf
            totalOpcionales += precioFOTOCOPIADORA
        Else
            picFotocopiadora.Visible = False

        End If

    End Sub

    Private Sub lstPerifericos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPerifericos.SelectedIndexChanged

        If lstPerifericos.SelectedIndex = 0 Then
            picHDD.Visible = True

            precioHDD = 75
            textoPerifericos = "EQUIPOS PERIFÉRICOS ----- HDD: " & precioHDD & " €"
            totalPerifericos = precioHDD
        Else
            picHDD.Visible = False
        End If

        If lstPerifericos.SelectedIndex = 1 Then
            picImpresora.Visible = True

            precioIMPRESORA = 90
            textoPerifericos = "EQUIPOS PERIFÉRICOS ----- IMPRESORA: " & precioIMPRESORA & " €"
            totalPerifericos = precioIMPRESORA
        Else
            picImpresora.Visible = False
        End If

        If lstPerifericos.SelectedIndex = 2 Then
            picAntena.Visible = True

            precioANTENA = 50
            textoPerifericos = "EQUIPOS PERIFÉRICOS ----- ANTENA: " & precioANTENA & " €"
            totalPerifericos = precioANTENA
        Else
            picAntena.Visible = False
        End If

    End Sub

    Private Sub cboPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPago.SelectedIndexChanged

        If cboPago.SelectedIndex = 0 Then
            picDolares.Visible = True
            medioPAGO = "Pago en Dólares"
        Else
            picDolares.Visible = False
        End If

        If cboPago.SelectedIndex = 1 Then
            picCheque.Visible = True
            medioPAGO = "Pago mediante cheque bancario"
        Else
            picCheque.Visible = False
        End If

        If cboPago.SelectedIndex = 2 Then
            picBolsa.Visible = True
            medioPAGO = "Pago en metálico"
        Else
            picBolsa.Visible = False
        End If

    End Sub

    Private Sub btnPresupuesto_Click(sender As Object, e As EventArgs) Handles btnPresupuesto.Click

        totalPresupuesto = totalEquipos + totalOpcionales + totalPerifericos

        totalPresu = vbCrLf & "TOTAL PRESUPUESTO DETALLADO: "

        Presupuesto.Show()
        Presupuesto.rtxbPresupuesto.Text = totalEqNecesario & vbCrLf &
                                           "TOTAL EQUIPOS NECESARIOS: " & totalEquipos & vbCrLf &
                                           textoOpcionales & vbCrLf &
                                           "TOTAL EQUIPOS OPCIONALES: " & totalOpcionales & vbCrLf &
                                           textoPerifericos & vbCrLf &
                                           "TOTAL PERIFÉRICOS: " & totalPerifericos & vbCrLf &
                                           totalPresu & totalPresupuesto & vbCrLf & vbCrLf & "Nota: " & medioPAGO & vbCrLf & vbCrLf &
                                           "Gracias por su compra"


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("Gracias por su compra. Adiós")
        Application.Exit()

    End Sub


End Class
