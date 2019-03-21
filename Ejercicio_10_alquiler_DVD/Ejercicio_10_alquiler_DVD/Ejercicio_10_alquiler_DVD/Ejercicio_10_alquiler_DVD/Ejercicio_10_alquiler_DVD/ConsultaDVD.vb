Public Class ConsultaDVD
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()
        borrarTextConsulta()

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim opcion As String = InputBox("Introduzca código o titulo del dvd a consultar")

        If opcion <> "" Then

            If coleccionDVD.Contains(opcion) Or ifExisteTitulo(opcion) Then

                If coleccionDVD.Contains(opcion) Then
                    mostrarDvdPorCodigo(opcion)
                Else
                    mostrarDvdPorTitulo(opcion)
                End If


            Else
                MessageBox.Show("No existe el código o título", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

End Class