Public Class ConsultaDVD


    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsultaCancelar.Click
        Me.Hide()
        Form1.Show()
        borrarConsulta()
    End Sub

    Private Sub btnVolverConsultar_Click(sender As Object, e As EventArgs) Handles btnVolverConsultar.Click

        Dim opcion As String = InputBox("Introduce otro codigo/titulo del dvd a consultar")

        If opcion <> "" Then

            If coleccionDVD.Contains(opcion) Or ifExisteTitulo(opcion) Then

                If coleccionDVD.Contains(opcion) Then
                    mostrarDvdPorCodigo(opcion)
                Else
                    mostrarDvdPorTitulo(opcion)
                End If


            Else
                MessageBox.Show("No existe el codigo/titulo", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub
End Class