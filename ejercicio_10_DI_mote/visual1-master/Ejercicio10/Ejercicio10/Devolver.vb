Public Class Devolver
    Private Sub btnBuscarAlquilar_Click(sender As Object, e As EventArgs) Handles btnBuscarAlquilar.Click
        'Si existe en la colección se comprueba que no este en False la propiedad alquilado
        If coleccionDvds.Contains(txtCodigo.Text) Then
            If coleccionDvds(txtCodigo.Text).alquilado Then
                txtFecha.Text = Today.Date
                gbAlquiler.Visible = True
                txtCodigo.ReadOnly = True
            Else
                MsgBox("El dvd no está alquilado")

            End If
        Else
            MsgBox("No existe un dvd con ese código")

        End If
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        'Si el cliente existe en la colección y tiene menos de 5 alquileres..
        If coleccionClientes.Contains(txtCliente.Text) Then
            devolverAlquiler(Me)
        Else
            MsgBox("No se encuentra el cliente")

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        vaciarDevolver(Me)
    End Sub
End Class