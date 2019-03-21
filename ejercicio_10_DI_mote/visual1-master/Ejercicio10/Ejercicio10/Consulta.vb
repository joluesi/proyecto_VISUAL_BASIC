Public Class Consulta
    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim dvd As DVD
        Dim encontrado = False

        'Búsqueda
        If rbTitulo.Checked Then
            For Each d In coleccionDvds
                dvd = d
                If dvd.titulo = txtConsulta.Text Then
                    encontrado = True
                    Exit For
                End If
            Next
        Else
            If coleccionDvds.Contains(txtConsulta.Text) Then
                encontrado = True
                dvd = coleccionDvds(txtConsulta.Text)
            End If
        End If

        'Mostrar datos
        If encontrado = False Then
            MsgBox("No se encuentra el DVD")
            vaciarConsulta(Me)
        Else
            txtTitulo.Text = dvd.titulo
            txtCodigo.Text = dvd.codigo
            txtAlquilado.Text = dvd.alquilado
            txtDiasAlquiler.Text = dvd.diasAlquiler
            gbDatos.Visible = True


        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        vaciarConsulta(Me)
        Me.Close()
    End Sub


End Class