Public Class Form1


    Dim dvd As DVD = New DVD("D1", "D1", 0, False)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coleccionDvds.Add(dvd, dvd.codigo)


    End Sub

    Private Sub ListaDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDVDToolStripMenuItem.Click
        Dim formListaDvd As New Lista
        formListaDvd.Name = "Lista de DVDs"
        formListaDvd.Text = "Lista de DVDs"
        formListaDvd.MdiParent = Me
        For Each dvd In coleccionDvds
            formListaDvd.rtbTexto.Text += dvd.imprimirDVD & vbCrLf
        Next

        formListaDvd.Show()
    End Sub

    Private Sub ListaClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListaClienteToolStripMenuItem2.Click
        Dim formListaClientes As New Lista
        formListaClientes.Name = "Lista de Clientes"
        formListaClientes.Text = "Lista de Clientes"
        formListaClientes.MdiParent = Me
        For Each cliente In coleccionClientes
            formListaClientes.rtbTexto.Text += cliente.imprimirCliente() & vbCrLf
        Next

        formListaClientes.Show()
    End Sub

    Private Sub ListaAlquiladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaAlquiladosToolStripMenuItem.Click
        Dim formListaAlquilados As New Lista
        formListaAlquilados.Name = "Lista Alquilados"
        formListaAlquilados.Text = "Lista Alquilados"
        formListaAlquilados.MdiParent = Me
        For i = 0 To arrayAlquilados.Length
            formListaAlquilados.rtbTexto.Text += coleccionDvds(arrayAlquilados(i).codDvdAlqui).imprimirDVD()
        Next
    End Sub

    Private Sub ListaDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDisponiblesToolStripMenuItem.Click
        Dim formListaDisponibles As New Lista
        formListaDisponibles.Name = "Lista Alquilados"
        formListaDisponibles.Text = "Lista Alquilados"
        formListaDisponibles.MdiParent = Me
        For Each dvd In coleccionDvds
            Dim alquilado = False
            For i = 0 To arrayAlquilados.Length
                If dvd.codigo = arrayAlquilados(i).codDvdAlqui Then
                    alquilado = True
                    Exit For
                End If
            Next
            If alquilado Then
                formListaDisponibles.rtbTexto.Text += dvd.imprimirDVD
            End If
        Next
    End Sub

    Private Sub ConsultaDVDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaDVDToolStripMenuItem1.Click
        Dim formConsultaDvd As New Consulta
        formConsultaDvd.Name = "Consulta DVD"
        formConsultaDvd.Text = "Consulta DVD"
        formConsultaDvd.MdiParent = Me
        formConsultaDvd.Show()
    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Dim numCliente As String = coleccionClientes.Count + 1
        Dim codClie As String = "C" & numCliente
        Dim dirClie As String = "Direc." & numCliente
        Dim emailClie As String = "email" & numCliente & "@cliente.es"
        codClie = codClie.Replace(" ", "")
        dirClie = dirClie.Replace(" ", "")
        emailClie = emailClie.Replace(" ", "")
        Dim cliente As New Cliente(codClie, dirClie, numCliente, emailClie, 0)
        MessageBox.Show(cliente.imprimirCliente, "Cliente añadido")

        coleccionClientes.Add(cliente, codClie)
    End Sub

    Private Sub ConsultaClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaClienteToolStripMenuItem1.Click
        Dim text = InputBox("Introduce código de cliente", "Consulta Cliente", "")
        Dim encontrado = False
        For Each cli In coleccionClientes
            If cli.codigo = text Then
                MessageBox.Show("Código: " & cli.codigo & vbCrLf & "Direccion: " & cli.direccion & vbCrLf & "Teléfono: " & cli.telefono & vbCrLf & "Email: " & cli.email & vbCrLf & "Alquileres: " & cli.alquileres, "CLIENTE")
                encontrado = True
            End If
        Next

        If encontrado = False Then
            MessageBox.Show("No se encuentra")
        End If
    End Sub

    Private Sub AltaDvdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDvdToolStripMenuItem.Click
        Alta.txtCodigo.Text = ""
        Alta.txtTitulo.Text = ""
        Alta.txtDiasAlquiler.Text = ""
        Alta.Show()

    End Sub

    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarToolStripMenuItem.Click
        Alquilar.Show()

    End Sub

    Private Sub devolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles devolverToolStripMenuItem.Click
        Devolver.Show()

    End Sub


End Class
