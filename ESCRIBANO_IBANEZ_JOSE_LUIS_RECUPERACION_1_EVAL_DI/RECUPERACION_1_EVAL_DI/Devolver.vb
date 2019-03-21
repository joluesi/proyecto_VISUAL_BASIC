Public Class Devolver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            'Busco por código de DVD
            If Val(txtcodigoDevolver.Text) < 0 Or Val(txtcodigoDevolver.Text) > (arrayDvd.Length - 1) Then
                MsgBox("El DVD con código " & txtcodigoDevolver.Text & " no existe")

            Else
                Form1.txtcodigo.Text = arrayDvd(Val(txtcodigoDevolver.Text)).codDvd
                Form1.txtTitulo.Text = arrayDvd(Val(txtcodigoDevolver.Text)).tituloDvd
                Form1.txtDias.Text = arrayDvd(Val(txtcodigoDevolver.Text)).diasDvd
                Form1.txtcodcli.Text = arrayDvd(Val(txtcodigoDevolver.Text)).codCliAlquila = 0
                Form1.txtfechaalquiler.Text = arrayDvd(Val(txtcodigoDevolver.Text)).fechaAlquila
                Form1.txtfechadevuelve.Text = arrayDvd(Val(txtcodigoDevolver.Text)).fechaDevuelve = Today.Date

            End If

            Dim dias As Integer = DateDiff(DateInterval.Day, Today, arrayDvd(Val(txtcodigoDevolver.Text)).fechaAlquila)

            If (dias > arrayDvd(Val(txtcodigoDevolver.Text)).diasDvd) Then
                MsgBox("Ha superado el plazo de alquiler.")
            End If

        Catch ex As Exception
            MsgBox("Introduzca todos los casilleros")
        End Try

    End Sub


End Class