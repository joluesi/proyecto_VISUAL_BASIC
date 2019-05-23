Module Module1
    Public Structure TRATAMIENTO
        Dim codigoTra As Integer
        Dim nombreTra As String
        Dim precioTra As Single
    End Structure

    'variable de estructura de 5 tratamiento
    Public array_tratamiento(5) As TRATAMIENTO

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





End Module
