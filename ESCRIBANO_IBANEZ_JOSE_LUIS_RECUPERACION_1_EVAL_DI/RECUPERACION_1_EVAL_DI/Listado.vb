Public Class Listado
    Private Sub txtListado_TextChanged(sender As Object, e As EventArgs) Handles txtListado.TextChanged

        If IsNothing(arrayDvd) Then
            MsgBox("No se han introducido DVD´s")

        Else
            Dim listado As String = ""

            For Each dvd As DVD In arrayDvd
                listado = listado & ("---------------------------------------------" & vbCrLf &
                                 "Código: " & dvd.codDvd &
                                 ", Título: " & dvd.tituloDvd &
                                 ", Días Alquiler: " & dvd.diasDvd &
                                 ", Código Cliente " & dvd.codCliAlquila &
                                 ", Fecha de Alquiler: " & dvd.fechaAlquila &
                                 ", Fecha Devolución " & dvd.fechaDevuelve & vbCrLf &
                                 "---------------------------------------------")
            Next

            txtListado.Text = listado
            gbListado.Visible = True

        End If

    End Sub
End Class