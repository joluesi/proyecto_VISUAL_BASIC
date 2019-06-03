Public Class Form1
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        gbx_AltaClientes.Visible = True

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtCodigoCli.Text <> "" And txtNombreCli.Text <> "" And txtTelefono.Text <> "" Then

                If colecClientes.Contains(txtCodigoCli.Text) Then
                    MsgBox("Ya existe ese cliente")
                    txtNombreCli.Text = ""
                    txtCodigoCli.Text = ""
                    txtTelefono.Text = ""
                Else
                    colecClientes.Add(New Class_CLIENTE(txtCodigoCli.Text, txtNombreCli.Text, txtTelefono.Text), txtCodigoCli.Text)
                    MsgBox("Añadido cliente a la colección")
                    AnadirCLIENTES()
                End If

            Else
                MsgBox("Rellene casilleros de forma correcta")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        txtNombreCli.Text = ""
        txtCodigoCli.Text = ""
        txtTelefono.Text = ""
        gbx_AltaClientes.Hide()

    End Sub

    Private Sub TratamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientosToolStripMenuItem.Click

        For i As Integer = 0 To array_tratamiento.Length - 1 ' de 0 a (5-1)
            array_tratamiento(i).codigoTra = i + 1
            array_tratamiento(i).nombreTra = "T" & CStr(i + 1)
            array_tratamiento(i).precioTra = (i + 1) * 10
        Next

        MsgBox("Creado 5 Tratamientos")

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click

        Dim opcion = InputBox("Introduzca el nombre del cliente")
        Dim encontrado As Boolean = False

        If opcion <> "" Then
            For Each cliente In colecClientes
                If cliente.P_NombreCli.contains(opcion) Then
                    gbx_ConsultaClientes.Visible = True
                    encontrado = True
                    txtConsulCodigoCli.Text = cliente.P_CodigoCli
                    txtConsulNombreCli.Text = opcion
                    txtConsulTelefono.Text = cliente.P_TelefonoCli
                End If
            Next
        Else
            MsgBox("Antes introduzca nombre del cliente a buscar")
        End If

        If Not encontrado Then
            MsgBox("No existe ese cliente")
        End If

    End Sub

    Private Sub btnSalirConsulta_Click(sender As Object, e As EventArgs) Handles btnSalirConsulta.Click
        gbx_ConsultaClientes.Hide()

    End Sub

    Private Sub TratamientosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TratamientosToolStripMenuItem1.Click

        Dim opcion = InputBox("Introduzca el código del Tratamiento")
        Dim encontrado As Boolean = False

        Try
            If opcion <> "" Then
                For i = 0 To array_tratamiento.Length - 1
                    If array_tratamiento(i).codigoTra = opcion Then
                        gbx_cons_Trat.Visible = True
                        encontrado = True
                        txtConsTratCodigo.Text = opcion
                        txtConsTratNombre.Text = array_tratamiento(i).nombreTra
                        txtConsTratPrecio.Text = array_tratamiento(i).precioTra
                    End If
                Next
            Else
                MsgBox("Antes introduzca el código del Tratamiento a buscar")
            End If

            If Not encontrado Then
                MsgBox("No existe ese tratamiento")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalirTratCons_Click(sender As Object, e As EventArgs) Handles btnSalirTratCons.Click
        gbx_cons_Trat.Visible = False

    End Sub



    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click

        rtxtb_factura.Clear()
        Dim opcion = InputBox("Introduzca el código del cliente")
        codigoOpcion = opcion
        Dim encontrado As Boolean = False
        cmbTratamientos.Items.Clear()
        cmbTratamientos.Text = ""
        precioAcumula = 0

        If opcion <> "" Then
            For Each cliente In colecClientes
                If cliente.P_CodigoCli = opcion Then
                    rtxtb_factura.Clear()
                    cmbTratamientos.Items.Clear()
                    gbx_Factura.Visible = True
                    rtxtb_factura.Visible = True
                    comboTratamientos(array_tratamiento)
                    encontrado = True
                    rtxtb_factura.Text += "NOMBRE DEL CLIENTE: " & colecClientes(opcion).P_NombreCli & "        CÓDIGO CLIENTE: " & colecClientes(opcion).P_CodigoCli & vbNewLine
                End If
            Next
        Else
            MsgBox("Antes introduzca código del cliente a buscar")
        End If

        If Not encontrado Then
            MsgBox("No existe ese cliente")
            cmbTratamientos.Items.Clear()
            cmbTratamientos.Text = ""
            rtxtb_factura.Clear()
            gbx_Factura.Visible = False

        End If

    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click

        Dim codTrat As Integer = 0
        Dim nomTrat As String = ""

        For Each cliente In colecClientes
            If cliente.P_CodigoCli = codigoOpcion Then
                For i = 0 To array_tratamiento.Length - 1
                    If cmbTratamientos.Text = array_tratamiento(i).nombreTra Then
                        codTrat = array_tratamiento(i).codigoTra
                        nomTrat = array_tratamiento(i).nombreTra
                        rtxtb_factura.Text += array_tratamiento(i).nombreTra & "                " & array_tratamiento(i).precioTra & vbNewLine
                        precioAcumula += array_tratamiento(i).precioTra

                        ReDim Preserve mi_arrayTrat(i)
                        mi_arrayTrat(i) = codTrat
                    End If
                Next
                colecClientes(codigoOpcion).P_HistoriaCli = mi_arrayTrat
                MsgBox("Añadido tratamiento " & nomTrat & " al historial del cliente " & codigoOpcion)

            End If
        Next

        rtxtb_factura.Text += "                         " & "Total: " & precioAcumula & vbNewLine

    End Sub

    Private Sub btnSalirFactura_Click(sender As Object, e As EventArgs) Handles btnSalirFactura.Click
        rtxtb_factura.Clear()
        cmbTratamientos.Text = ""
        gbx_Factura.Visible = False

    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click

        Dim opcion = InputBox("Introduzca el nombre del Tratamiento")
        Dim encontradoTrat As Boolean = False
        Dim codTrat As Integer
        rtxtb_listado.Clear()

        If opcion <> "" Then
            For i = 0 To array_tratamiento.Length - 1
                If array_tratamiento(i).nombreTra = opcion Then
                    codTrat = array_tratamiento(i).codigoTra
                    encontradoTrat = True
                End If
            Next
        Else
            MsgBox("Antes introduzca nombre del Tratamiento a buscar")
        End If

        If encontradoTrat Then
            For Each cliente In colecClientes
                For j = 0 To cliente.P_HistoriaCli.Length - 1
                    If cliente.P_HistoriaCli(j) = codTrat Then
                        gbx_ListadoCli.Visible = True
                        rtxtb_listado.Visible = True
                        rtxtb_listado.Text += opcion & " (" & codTrat & ")" & ":" & vbNewLine
                        rtxtb_listado.Text += cliente.P_CodigoCli & "           " & cliente.P_NombreCli & vbNewLine

                    End If
                Next
            Next

        Else
            MsgBox("No hay clientes con ese Tratamiento")
            rtxtb_listado.Clear()
            gbx_ListadoCli.Visible = False
        End If

    End Sub

    Private Sub btnSalirListado_Click(sender As Object, e As EventArgs) Handles btnSalirListado.Click
        gbx_ListadoCli.Hide()
        rtxtb_listado.Clear()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
