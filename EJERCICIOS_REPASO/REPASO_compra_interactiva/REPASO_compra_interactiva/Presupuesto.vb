Public Class Presupuesto
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Me.Hide()
        Form1.Show()

        Form1.chkContestador.Checked = False
        Form1.chkCalculadora.Checked = False
        Form1.chkFotocopiadora.Checked = False

        textoCONTESTADOR = ""
        textoCALCULADORA = ""
        textoFOTOCOPIADORA = ""
        textoOpcionales = ""
        totalOpcionales = 0

    End Sub
End Class