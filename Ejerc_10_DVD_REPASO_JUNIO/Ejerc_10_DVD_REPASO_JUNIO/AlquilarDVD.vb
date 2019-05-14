Public Class AlquilarDVD
    Private Sub btnAlquilar_Click(sender As Object, e As EventArgs) Handles btnAlquilar.Click

        lblFecha.Text = Today.Date
        If txtCodigoAlquilarDVD.Text <> "" And txtCodAlquilarCliente.Text <> "" Then
            If coleccionDVD.Contains(txtCodigoAlquilarDVD.Text) Then
                If coleccionCLIENTES.Contains(txtCodAlquilarCliente.Text) Then
                    If coleccionCLIENTES(txtCodAlquilarCliente.Text).P_AlquileresCli < 5 Then
                        If coleccionDVD(txtCodigoAlquilarDVD.Text).P_AlquiladoDvd = False Then

                            ReDim Preserve arrayDVD(contador)
                            arrayDVD(contador).codDvdAlqui = txtCodigoAlquilarDVD.Text
                            arrayDVD(contador).fechaAlquiler = Today.Date
                            arrayDVD(contador).fechaDevolucion = "11/11/1111"
                            arrayDVD(contador).codClienAlqui = txtCodAlquilarCliente.Text
                            contador += 1

                            coleccionDVD(txtCodigoAlquilarDVD.Text).P_AlquiladoDvd = True
                            coleccionCLIENTES(txtCodAlquilarCliente.Text).P_AlquileresCli += 1
                            MsgBox("DVD alquilado. Gracias.")
                            txtCodigoAlquilarDVD.Text = ""
                            txtCodAlquilarCliente.Clear()


                        Else
                            MsgBox("Ese DVD ya se encuentra alquilado")

                        End If

                    Else
                        MsgBox("Ese Cliente ha excedido del número de alquileres permitidos")

                    End If

                Else
                    MsgBox("No existe ese Cliente")

                End If

            Else
                MsgBox("No existe ese DVD")

            End If

        Else
            MsgBox("Antes rellene casilleros")

        End If


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class