Public Class Form1
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        gbDvd.Visible = True
        gbConsulta.Visible = False


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            ReDim Preserve arrayDvd(cont)
            arrayDvd(cont).codDvd = cont

            If (txtTitulo.Text = "" Or txtDias.Text = "") Then
                MsgBox("Antes debe introducir todos los casilleros")

            ElseIf Not (IsNumeric(txtcodigo.Text) Or IsNumeric(txtDias.Text)) Then
                MsgBox("Código y Días alquiler han de ser valor numérico")
                txtcodigo.Clear()
                txtDias.Clear()

            Else
                'arrayDvd(cont).codDvd = CInt(txtcodigo.Text)
                arrayDvd(cont).tituloDvd = txtTitulo.Text
                arrayDvd(cont).diasDvd = txtDias.Text
                arrayDvd(cont).codCliAlquila = 0
                arrayDvd(cont).fechaAlquila = "1/1/1"
                arrayDvd(cont).fechaDevuelve = "1/1/1"
                cont += 1
            End If

            Dim respuesta = MsgBox("¿Desea introducir otro DVD?", vbYesNo)
            If (respuesta = vbYes) Then
                btnLimpiar.PerformClick()
                txtTitulo.Select()
            Else
                gbConsulta.Visible = True

            End If

        Catch ex As Exception
            MsgBox("Introduzca código y días numéricos")
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtcodigo.Clear()
        txtTitulo.Clear()
        txtDias.Clear()
        txtcodcli.Clear()
        txtfechaalquiler.Clear()
        txtfechadevuelve.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        gbDvd.Visible = False

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        gbDvd.Visible = True
        gbConsulta.Visible = True

    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click

        Try

            Dim dvdencontrado As Boolean = False

            For Each dvd As DVD In arrayDvd

                If txtTituloConsulta.Text = dvd.tituloDvd Then

                    txtcodigo.Text = dvd.codDvd
                    txtTitulo.Text = dvd.tituloDvd
                    txtDias.Text = dvd.diasDvd
                    txtcodcli.Text = dvd.codCliAlquila
                    txtfechaalquiler.Text = dvd.fechaAlquila
                    txtfechadevuelve.Text = dvd.fechaDevuelve

                    dvdencontrado = True

                End If

            Next

            If dvdencontrado = False Then
                MsgBox("Título de DVD no encontrado")
            End If

        Catch ex As Exception
            MsgBox("Introduzca todos los casilleros")
        End Try

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        gbConsulta.Visible = False
        gbDvd.Visible = True


    End Sub

    Private Sub AlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilerToolStripMenuItem.Click
        Alquilar.Show()

        Alquilar.gbAlquilar.Visible = True


    End Sub

    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click
        Devolver.Show()

        Devolver.gbDevolver.Visible = True



    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Listado.Show()

        Listado.gbListado.Visible = True


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        MsgBox("Que pase un buen día")
    End Sub
End Class
