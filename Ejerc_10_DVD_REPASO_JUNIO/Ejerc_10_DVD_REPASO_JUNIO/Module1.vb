Module Module1

    Public Structure DVDalquilado
        Dim codDvdAlqui As String
        Dim fechaAlquiler As Date
        Dim fechaDevolucion As Date
        Dim codClienAlqui As String

    End Structure

    'colecciones de las clases
    Public coleccionDVD As New Collection
    Public coleccionCLIENTES As New Collection

    'array para DVDalquilado
    Public arrayDVD() As DVDalquilado


    'función para pedir si añado o no añado más DVD
    Public Sub AnadirDVD()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro DVD?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            borrarTextAlta()
            AltaDVD.txtCodigoDVD.Focus()
        Else
            borrarTextAlta()
            AltaDVD.Hide()
            Form1.Show()
        End If
    End Sub

    'función borrar casilleros alta DVD
    Public Sub borrarTextAlta()
        AltaDVD.txtCodigoDVD.Clear()
        AltaDVD.txtDiasAlquilerDVD.Clear()
        AltaDVD.txtTituloDVD.Clear()
        AltaDVD.txtCodigoDVD.Focus()

    End Sub






End Module
