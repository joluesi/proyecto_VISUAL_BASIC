Module Module1

    Public Structure DVDalquilado
        Dim codDvdAlqui As String
        Dim codClienAlqui As String
        Dim fechaAlquiler As Date
        Dim fechaDevolucion As Date


    End Structure

    'colecciones de las respectivas clases, LAS INICIALIZAMOS AQUI
    Public coleccionDVD As New Collection
    Public coleccionClientes As New Collection

    'array de DVDalquilado iniciado a 1, para mas adelante, redimensionarlo (ReDim Preserve)
    'importantisomo iniciarlo a 1, si lo iniciamos a nada () no funcionará
    Public array(1) As DVDalquilado



    Public Sub borrarAlta()
        AltaDVD.txtCodigoDVD.Clear()
        AltaDVD.txtDiasMaxDVD.Clear()
        AltaDVD.txtTituloDVD.Clear()
        AltaDVD.txtCodigoDVD.Focus()

    End Sub

    Public Sub borrarConsulta()
        ConsultaDVD.txtConsultaCodigoDVD.Clear()
        ConsultaDVD.txtConsultaDiasDVD.Clear()
        ConsultaDVD.txtConsultaSiAlquiladoDVD.Clear()
        ConsultaDVD.txtConsultaTituloDVD.Focus()
    End Sub

    Public Sub Si_o_No()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro DVD?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            borrarAlta()
            AltaDVD.txtCodigoDVD.Focus()
        Else
            borrarAlta()
            AltaDVD.Hide()
            Form1.Show()
        End If
    End Sub

    Public Function ifExisteTitulo(titulo As String) As Boolean
        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).DvdTitulo = titulo Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Sub mostrarDvdPorTitulo(titulo As String)

        Dim posicionDentroDeLaColeccion As Integer

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).DvdTitulo = titulo Then
                posicionDentroDeLaColeccion = i
            End If
        Next

        ConsultaDVD.txtConsultaCodigoDVD.Text = coleccionDVD(posicionDentroDeLaColeccion).DvdCodigo()
        ConsultaDVD.txtConsultaTituloDVD.Text = coleccionDVD(posicionDentroDeLaColeccion).DvdTitulo()
        ConsultaDVD.txtConsultaDiasDVD.Text = coleccionDVD(posicionDentroDeLaColeccion).DvdDiasAlquiler()
        ConsultaDVD.txtConsultaSiAlquiladoDVD.Text = coleccionDVD(posicionDentroDeLaColeccion).DvdAlquilado()


    End Sub


    Public Function ifExisteCodDvdEnColeccionDvd(codigo As String) As Boolean

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).DvdCodigo() = codigo Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function ifExisteCodCliEnColeccionClientes(codigo As String) As Boolean

        For i As Integer = 1 To coleccionClientes.Count
            If coleccionClientes(i).CliCodigo() = codigo Then
                Return True
            End If
        Next

        Return False


    End Function


    Public Sub mostrarDvdPorCodigo(codigo As String)
        ConsultaDVD.txtConsultaCodigoDVD.Text = coleccionDVD(codigo).DvdCodigo()
        ConsultaDVD.txtConsultaTituloDVD.Text = coleccionDVD(codigo).DvdTitulo()
        ConsultaDVD.txtConsultaDiasDVD.Text = coleccionDVD(codigo).DvdDiasAlquiler()
        ConsultaDVD.txtConsultaSiAlquiladoDVD.Text = coleccionDVD(codigo).DvdAlquilado()
    End Sub



End Module
