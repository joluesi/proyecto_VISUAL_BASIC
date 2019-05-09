Public Class Form1
    Private Sub AltaDeDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeDVDToolStripMenuItem.Click
        AltaDVD.Show()
        Me.Hide()


    End Sub

    Private Sub AltaDeCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeCLIENTEToolStripMenuItem.Click
        For i As Integer = 1 To 3
            Dim aux As String = "C" & i
            coleccionCLIENTES.Add(New Class_CLIENTES(aux, "calle nueva", 56898956, "jlescribano@net.com"), aux)
        Next

        MsgBox("Se han dado de alta 3 clientes")
    End Sub

    Private Sub ConsultaDeDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDVDToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el codigo/titulo del DVD a consultar")

        Dim encontrado As Boolean = False

        If opcion <> "" Then
            For Each dvd In coleccionDVD
                If dvd.P_CodigoDvd = opcion Or dvd.P_TituloDvd = opcion Then
                    encontrado = True
                End If
            Next

            If encontrado Then
                Consulta_DVD.Show()
                Consulta_DVD.txtConsultaCodigoDVD.Text = 
            End If


        End If


    End Sub
End Class
