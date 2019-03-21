Public Class AlquilarDVD

    Private Sub btnAlquilar_Click(sender As Object, e As EventArgs) Handles btnAlquilar.Click

        If txtCodigoAlquilarDVD.Text <> "" And txtCodAlquilarCliente.Text <> "" Then
            If coleccionDVD.Contains(txtCodigoAlquilarDVD.Text) Then
                If coleccionClientes.Contains(txtCodAlquilarCliente.Text) Then
                    If coleccionClientes(txtCodAlquilarCliente.Text).GetSet_alquileresCli() < 5 Then
                        If coleccionDVD(txtCodigoAlquilarDVD.Text).GetSet_AlquiladoDvd() = False Then

                            ReDim Preserve arrayDvd(contador)
                            arrayDvd(contador).codDvdAlqui = txtCodigoAlquilarDVD.Text
                            arrayDvd(contador).codClienAlqui = txtCodAlquilarCliente.Text
                            arrayDvd(contador).fechaAlquiler = Today.Date
                            arrayDvd(contador).fechaDevolucion = "11/11/1111"
                            contador += 1

                            coleccionDVD(txtCodigoAlquilarDVD.Text).GetSet_AlquiladoDvd() = True
                            coleccionClientes(txtCodAlquilarCliente.Text).GetSet_alquileresCli() += 1

                            MessageBox.Show("Ha alquilado " & coleccionDVD(txtCodigoAlquilarDVD.Text).GetSet_TituloDvd() & " correctamente", "Gracias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodAlquilarCliente.Clear()
                            txtCodigoAlquilarDVD.Clear()
                            txtCodigoAlquilarDVD.Focus()
                        Else
                            MessageBox.Show("No se puede alquilar, este DVD ya se encuentra alquilado", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtCodAlquilarCliente.Clear()
                            txtCodigoAlquilarDVD.Clear()
                            txtCodigoAlquilarDVD.Focus()
                        End If


                    Else
                        MessageBox.Show("El cliente " & coleccionClientes(txtCodAlquilarCliente.Text).GetSet_codigoCli() & " ha alcanzado el maximo de alquileres", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCodAlquilarCliente.Clear()
                        txtCodigoAlquilarDVD.Clear()
                        txtCodigoAlquilarDVD.Focus()
                    End If
                Else
                    MessageBox.Show("No existe el codigo del cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCodAlquilarCliente.Clear()
                    txtCodAlquilarCliente.Focus()
                End If
            Else
                MessageBox.Show("No existe el codigo del DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodigoAlquilarDVD.Clear()
                txtCodigoAlquilarDVD.Focus()
            End If


        Else
            MessageBox.Show("Introduzca datos en los casilleros", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AlquilarDVD_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblFecha.Text = Today.Date

    End Sub

    'Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click
    '    lblFecha.Text = Today.Date
    'End Sub
End Class