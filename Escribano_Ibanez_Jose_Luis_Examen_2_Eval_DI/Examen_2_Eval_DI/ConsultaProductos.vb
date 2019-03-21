Public Class ConsultaProductos

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim opcion As String = InputBox("Introduzca código del producto a consultar")

        If opcion <> "" Then

            If coleccionPRODUCTOS.Contains(opcion) Then

                mostrarProductoPorCodigo(opcion)

            End If

        Else
            MessageBox.Show("No existe el código de producto", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class