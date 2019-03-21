Public Class AlquilarDVD
    Private Sub btnAlquilar_Click(sender As Object, e As EventArgs) Handles btnAlquilar.Click

        If txtCodigoAlquilarDVD.Text <> "" And txtCodAlquilarCliente.Text <> "" Then 'para que no queden vacios los txt
            If coleccionDVD.Contains(txtCodigoAlquilarDVD.Text) Then            'comprobamos que existe el dvd en la coleccion
                If coleccionClientes.Contains(txtCodAlquilarCliente.Text) Then 'comprobamos que existe el cliente en la coleccion
                    If coleccionClientes(txtCodAlquilarCliente.Text).GetSet_alquileresCli() < 5 Then 'comprobamos que cliente no tiene mas de 5 dvd
                        If coleccionDVD(txtCodigoAlquilarDVD.Text).GetSet_AlquiladoDvd() = False Then    'comprobamos que dvd no se encuentre alquilado


                            ReDim Preserve arrayDvd(contador)
                            arrayDvd(contador).codDvdAlqui = txtCodigoAlquilarDVD.Text
                            arrayDvd(contador).codClienAlqui = txtCodAlquilarCliente.Text
                            arrayDvd(contador).fechaAlquiler = Today.Date
                            arrayDvd(contador).fechaDevolucion = "11/11/1111"
                            contador += 1

                            coleccionDVD(txtCodigoAlquilarDVD.Text).GetSet_AlquiladoDvd() = True
                            coleccionClientes(txtCodAlquilarCliente.Text).GetSet_alquileresCli() += 1

                            MessageBox.Show("Ha alquilado " & coleccionDVD(txtCodigoAlquilarDVD.Text).GetSet_TituloDvd() & " satisfactoriamente", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodAlquilarCliente.Clear()
                            txtCodigoAlquilarDVD.Clear()
                            txtCodigoAlquilarDVD.Focus()
                        Else
                            MessageBox.Show("No se puede alquilar, el DVD se encuentra alquilado actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Introduzca datos en las cajas de texto", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Alquiler_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblFecha.Text = Today.Date

    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click
        lblFecha.Text = Today.Date
    End Sub
End Class