Module Module1

    Public Function isNumeric(texto As String) As Boolean
        Try
            Dim textoNum = CInt(texto)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function datosAltaDvdCorrectos(codigo As String, titulo As String, diasAlquiler As String) As Boolean
        Dim correcto = True
        Alta.ErrorProvider1.Clear()
        If codigo = "" Then
            correcto = False
            Alta.ErrorProvider1.SetError(Alta.txtCodigo, "Cadena de texto")
            Alta.txtCodigo.Text = ""
        ElseIf titulo = "" Or isNumeric(titulo) Then
            correcto = False
            Alta.ErrorProvider1.SetError(Alta.txtTitulo, "Cadena de texto")
            Alta.txtTitulo.Text = ""
        ElseIf diasAlquiler = "" Or diasAlquiler.Length > 2 Or isNumeric(diasAlquiler) = False Then
            correcto = False
            Alta.ErrorProvider1.SetError(Alta.txtDiasAlquiler, "Short")
            Alta.txtDiasAlquiler.Text = ""
        Else
            Alta.ErrorProvider1.Clear()
        End If

        Return correcto
    End Function

    Public Function devolverAlquiler(form As Devolver)
        Dim alquiler As DVDalquilado
        For i = 0 To arrayAlquilados.Length - 1
            If arrayAlquilados(i).codDvdAlqui = form.txtCodigo.Text Then
                Dim diasDeAlquiler = DateDiff(DateInterval.Day, arrayAlquilados(i).fechaAlquiler, Today.Date)
                form.txtDiasAlquiler.Text = diasDeAlquiler
                Dim diasExceso = diasDeAlquiler - coleccionDvds(arrayAlquilados(i).codDvdAlqui).diasAlquiler
                coleccionClientes(arrayAlquilados(i).codClienteAlqui).alquileres -= 1
                coleccionDvds(arrayAlquilados(i).codDvdAlqui).alquilado = False
                arrayAlquilados(i).codClienteAlqui = "0"

                If diasExceso > 0 Then
                    MsgBox("DVD devuelto." & vbCrLf & "Has excedido el número de días de alquiler. " & vbCrLf & diasExceso & " euros a pagar")
                    vaciarDevolver(form)
                    Exit For
                Else
                    MsgBox("Has devuelto el DVD a tiempo.")
                    vaciarDevolver(form)
                    Exit For
                End If
            End If
        Next

    End Function

    Public Function registrarAlquiler(form As Alquilar)
        Dim alquiler As DVDalquilado
        alquiler.codClienteAlqui = form.txtCliente.Text
        alquiler.codDvdAlqui = form.txtCodigo.Text
        alquiler.fechaAlquiler = form.txtFecha.Text
        alquiler.fechaDevolucion = "11/11/1111"

        coleccionDvds(form.txtCodigo.Text).alquilado = True
        coleccionClientes(form.txtCliente.Text).alquileres += 1
        ReDim Preserve arrayAlquilados(cont)
        arrayAlquilados(cont) = alquiler
        cont += 1

    End Function

    Public Function vaciarConsulta(consulta As Consulta)
        consulta.txtConsulta.Clear()
        consulta.txtTitulo.Clear()
        consulta.txtCodigo.Clear()
        consulta.txtAlquilado.Clear()
        consulta.txtDiasAlquiler.Clear()
        consulta.gbDatos.Visible = False

    End Function

    Public Function vaciarAlquiler(form As Alquilar)
        form.txtCliente.Clear()
        form.txtFecha.Clear()
        form.txtCodigo.ReadOnly = False
        form.txtCodigo.Clear()
        form.gbAlquiler.Visible = False
    End Function

    Public Function vaciarDevolver(form As Devolver)
        form.txtCliente.Clear()
        form.txtFecha.Clear()
        form.txtCodigo.ReadOnly = False
        form.txtCodigo.Clear()
        form.gbAlquiler.Visible = False
    End Function


    Public Structure DVDalquilado
        Dim codDvdAlqui As String
        Dim fechaAlquiler As Date
        Dim fechaDevolucion As Date
        Dim codClienteAlqui As String
    End Structure


    Public coleccionDvds As New Collection
    Public coleccionClientes As New Collection
    Public arrayAlquilados() As DVDalquilado
    Dim cont As Integer = 0

End Module
