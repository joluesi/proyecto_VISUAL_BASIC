Module Module1
    Public Structure TRATAMIENTO
        Dim codigoTra As Integer
        Dim nombreTra As String
        Dim precioTra As Single
    End Structure

    Public precioAcumula = 0
    Public precioTotalTrat = 0

    'variable de estructura de 5 tratamiento
    Public array_tratamiento(5) As TRATAMIENTO 'array con 6 elementos
    'NOTA.- array_tratamiento(5) --> Son 5 tratamientos porque comienzo en el alta automática del form1 por i=1

    'colección de Clientes
    Public colecClientes As New Collection

    'función para pedir si añado o no añado más CLIENTES
    Public Sub AnadirCLIENTES()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro CLIENTE?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            Form1.txtNombreCli.Text = ""
            Form1.txtCodigoCli.Text = ""
            Form1.txtCodigoCli.Focus()
            Form1.txtTelefono.Text = ""

        Else
            Form1.txtNombreCli.Text = ""
            Form1.txtCodigoCli.Text = ""
            Form1.txtTelefono.Text = ""
            Form1.gbx_AltaClientes.Visible = False

        End If
    End Sub


    'función para crear combobox de tratamientos

    Public Function comboTratamientos(arrayTrat As Array) As ComboBox
        For i = 1 To array_tratamiento.Length - 1
            Form1.cmbTratamientos.Items.Add(array_tratamiento(i).nombreTra)
        Next

        Return Form1.cmbTratamientos

    End Function





End Module
