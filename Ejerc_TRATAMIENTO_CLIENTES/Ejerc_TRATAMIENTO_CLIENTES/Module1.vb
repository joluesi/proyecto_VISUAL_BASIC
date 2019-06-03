Module Module1
    Public Structure TRATAMIENTO
        Dim codigoTra As Integer
        Dim nombreTra As String
        Dim precioTra As Single
    End Structure

    'variables auxiliares
    Public precioAcumula = 0
    Public precioTotalTrat = 0

    'variable de estructura de 5 tratamiento
    Public array_tratamiento(4) As TRATAMIENTO 'array con 5 elementos

    'variable para recuperar el código de cliente
    Public codigoOpcion As String

    'array auxiliar para almacenar los códigos de tratamientos (y posteriormente pasarlo al histórico de cliente)
    Public mi_arrayTrat As Integer()


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
        For i = 0 To array_tratamiento.Length - 1
            Form1.cmbTratamientos.Items.Add(array_tratamiento(i).nombreTra)
        Next

        Return Form1.cmbTratamientos

    End Function

End Module
