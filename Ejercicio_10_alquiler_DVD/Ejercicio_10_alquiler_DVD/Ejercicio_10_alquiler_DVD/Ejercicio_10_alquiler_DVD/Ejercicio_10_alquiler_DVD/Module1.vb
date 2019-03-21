Module Module1
    Public contador As Integer = 0

    Public Structure DVDalquilado
        Dim codDvdAlqui As String
        Dim fechaAlquiler As Date
        Dim fechaDevolucion As Date
        Dim codClienAlqui As String

    End Structure

    'colecciones de las clases y las inicializo
    Public coleccionDVD As New Collection
    Public coleccionClientes As New Collection

    'array de Dvd alquilado
    Public arrayDvd() As DVDalquilado

    Public Sub borrarTextAlta()
        AltaDvd.txtCodigoDVD.Clear()
        AltaDvd.txtDiasAlquilerDVD.Clear()
        AltaDvd.txtTituloDVD.Clear()
        AltaDvd.txtCodigoDVD.Focus()

    End Sub

    Public Sub borrarTextConsulta()
        ConsultaDVD.txtConsultaCodigoDVD.Clear()
        ConsultaDVD.txtConsultaDiasAlquiler.Clear()
        ConsultaDVD.txtConsultaTituloDVD.Clear()
        ConsultaDVD.txtConsultaTituloDVD.Focus()
        ConsultaDVD.txtConsultaAlquilado.Clear()
    End Sub

    Public Sub Si_o_No()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro DVD?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            borrarTextAlta()
            AltaDvd.txtCodigoDVD.Focus()
        Else
            borrarTextAlta()
            AltaDvd.Hide()
            Form1.Show()
        End If
    End Sub

    Public Function ifExisteTitulo(titulo As String) As Boolean
        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).GetSet_TituloDvd() = titulo Then
                Return True
            End If
        Next

        Return False

    End Function


    Public Sub mostrarDvdPorCodigo(codigo As String)

        ConsultaDVD.txtConsultaCodigoDVD.Text = coleccionDVD(codigo).GetSet_CodigoDvd()
        ConsultaDVD.txtConsultaTituloDVD.Text = coleccionDVD(codigo).GetSet_TituloDvd()
        ConsultaDVD.txtConsultaDiasAlquiler.Text = coleccionDVD(codigo).GetSet_DiasAlquilerDvd()
        ConsultaDVD.txtConsultaAlquilado.Text = coleccionDVD(codigo).GetSet_AlquiladoDvd()

    End Sub


    Public Sub mostrarDvdPorTitulo(titulo As String)

        'Dim posicionDentroDeLaColeccion As Integer

        'For i As Integer = 1 To coleccionDVD.Count
        '    If coleccionDVD(i).GetSet_TituloDvd() = titulo Then
        '        posicionDentroDeLaColeccion = i
        '    End If
        'Next

        'ConsultaDVD.txtConsultaCodigoDVD.Text = coleccionDVD(posicionDentroDeLaColeccion).GetSet_CodigoDvd()
        'ConsultaDVD.txtConsultaTituloDVD.Text = coleccionDVD(posicionDentroDeLaColeccion).GetSet_TituloDvd()
        'ConsultaDVD.txtConsultaDiasAlquiler.Text = coleccionDVD(posicionDentroDeLaColeccion).GetSet_DiasAlquilerDvd()
        'ConsultaDVD.txtConsultaAlquilado.Text = coleccionDVD(posicionDentroDeLaColeccion).GetSet_AlquiladoDvd()


        Dim encontrado = False
        For Each disco In coleccionDVD
            If disco.GetSet_TituloDvd() = titulo Then
                encontrado = True

                ConsultaDVD.txtConsultaCodigoDVD.Text = disco.GetSet_CodigoDvd()
                ConsultaDVD.txtConsultaTituloDVD.Text = disco.GetSet_TituloDvd()
                ConsultaDVD.txtConsultaDiasAlquiler.Text = disco.GetSet_DiasAlquilerDvd()
                ConsultaDVD.txtConsultaAlquilado.Text = disco.GetSet_AlquiladoDvd()

            End If
        Next

    End Sub

    Public Function isNumeric(text As String) As Boolean
        Try
            Dim num = CInt(text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ifExisteCodDvdEnColeccionDvd(codigo As String) As Boolean

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).GetSet_CodigoDvd() = codigo Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function ifExisteCodCliEnColeccionClientes(codigo As String) As Boolean

        For i As Integer = 1 To coleccionClientes.Count
            If coleccionClientes(i).GetSet_codigoCli() = codigo Then
                Return True
            End If
        Next

        Return False


    End Function

End Module
