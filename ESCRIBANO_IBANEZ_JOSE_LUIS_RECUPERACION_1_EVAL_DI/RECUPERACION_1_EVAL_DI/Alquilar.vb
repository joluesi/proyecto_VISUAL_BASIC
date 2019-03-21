Public Class Alquilar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            Dim correcto As Boolean = False

        If txtcodigoAlquilar.Text = "" Or txtcodcliAlquilar.Text = "" Then
            MsgBox("Antes debe completar los casilleros")

        Else
            For i = 0 To arrayDvd.Length - 1
                    If txtcodigoAlquilar.Text = arrayDvd(i).codDvd Then
                        MsgBox("Código de Dvd y de cliente correctos")

                        correcto = True

                        If Not (arrayDvd(i).codCliAlquila <> 0) Then
                            MsgBox("Este DVD ya se encuentra alquilado")

                        Else
                            MsgBox("Este DVD se encuentra disponible")
                            'txtfechaalquiler.Text = Today.Date
                            arrayDvd(i).fechaAlquila = Today.Date

                        End If

                    End If
                Next

            If correcto = False Then
                MsgBox("Código de DVD o de cliente incorrectos")
                txtfechaalquiler.Text = ""
            End If


        End If

        Catch ex As Exception
            MsgBox("Introduzca todos los casilleros")
        End Try


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()


    End Sub
End Class