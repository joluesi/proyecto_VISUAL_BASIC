Public Class Alquiler


    Private Sub Alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Alquiler_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblFecha.Text = Today.Date

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtCodigoDvd.Text <> "" And txtCodigoCliente.Text <> "" Then 'para que no queden vacios los txt
            If coleccionDVD.Contains(txtCodigoDvd.Text) Then            'comprobamos que existe el dvd en la coleccion
                If coleccionClientes.Contains(txtCodigoCliente.Text) Then 'comprobamos que existe el cliente en la coleccion
                    If coleccionClientes(txtCodigoCliente.Text).CliAlquileres() < 5 Then 'comprobamos que cliente no tiene mas de 5 dvd
                        If coleccionDVD(txtCodigoDvd.Text).DvdAlquilado() = False Then    'comprobamos que dvd no se encuentre alquilado


                            ReDim Preserve array(array.Length)
                            array(array.Length - 1).codDvdAlqui = txtCodigoDvd.Text
                            array(array.Length - 1).codClienAlqui = txtCodigoCliente.Text
                            array(array.Length - 1).fechaAlquiler = Today.Date
                            array(array.Length - 1).fechaDevolucion = "11/11/1111"

                            coleccionDVD(txtCodigoDvd.Text).DvdAlquilado() = True
                            coleccionClientes(txtCodigoCliente.Text).CliAlquileres() += 1

                            MessageBox.Show("Ha alquilado " & coleccionDVD(txtCodigoDvd.Text).DvdTitulo() & " satisfactoriamente", "Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCodigoCliente.Clear()
                            txtCodigoDvd.Clear()
                            txtCodigoDvd.Focus()
                        Else
                            MessageBox.Show("No se puede alquilar, el DVD se encuentra alquilado actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtCodigoCliente.Clear()
                            txtCodigoDvd.Clear()
                            txtCodigoDvd.Focus()
                        End If


                    Else
                        MessageBox.Show("El cliente " & coleccionClientes(txtCodigoCliente.Text).CliCodigo() & " ha alcanzado el maximo de alquileres", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCodigoCliente.Clear()
                        txtCodigoDvd.Clear()
                        txtCodigoDvd.Focus()
                    End If
                Else
                    MessageBox.Show("No existe el codigo del cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCodigoCliente.Clear()
                    txtCodigoCliente.Focus()
                End If
            Else
                MessageBox.Show("No existe el codigo del DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodigoDvd.Clear()
                txtCodigoDvd.Focus()
            End If


        Else
            MessageBox.Show("Introduzca datos en las cajas de texto", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class