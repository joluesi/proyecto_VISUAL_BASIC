Public Class Alquilar

    Private Sub btnBuscarAlquilar_Click(sender As Object, e As EventArgs) Handles btnBuscarAlquilar.Click
        'Si existe en la colección se comprueba que no este en False la propiedad alquilado
        If coleccionDvds.Contains(txtCodigo.Text) Then
            If coleccionDvds(txtCodigo.Text).alquilado Then
                MsgBox("El dvd ya está alquilado")
            Else
                txtFecha.Text = Today.Date
                gbAlquiler.Visible = True
                txtCodigo.ReadOnly = True
            End If
        Else
            MsgBox("No existe un dvd con ese código")

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Si el cliente existe en la colección y tiene menos de 5 alquileres..
        If coleccionClientes.Contains(txtCliente.Text) Then
            If coleccionClientes(txtCliente.Text).alquileres < 5 Then
                registrarAlquiler(Me)
                Dim result = MessageBox.Show("Disfruta del DVD! " & vbCrLf & "¿Quieres seguir alquilando?", "Alquilado", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    vaciarAlquiler(Me)
                Else
                    vaciarAlquiler(Me)
                    Me.Close()

                End If
            Else
                MsgBox("El cliente tiene 5 DVDs alquilados")
            End If
        Else
            MsgBox("No se encuentra el cliente")

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        vaciarAlquiler(Me)
    End Sub

    Private Sub btnBuscarDevolver_Click(sender As Object, e As EventArgs)

    End Sub
End Class