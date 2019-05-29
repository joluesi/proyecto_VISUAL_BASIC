Module Module1
    'Definir COLECCIÓN de la clase ComprasCliente con clave cod_cliente.
    Public colecComprasCliente As New Collection

    'Definir COLECCIÓN de la clase Vendedor con clave cod_vendedor.
    Public colecVendedor As New Collection

    'Definir array ComprasMes
    Public comprasMes(4, 1) As Single

    'Definir variables las necesarias  
    Public cont_cliente As Integer = 1


    'Definir función para crear lista de vendedores en Combobox
    Public Function comboVendedores(combo As ComboBox) As ComboBox

        combo.Items.Clear()
        For Each vende In colecVendedor
            combo.Items.Add(vende.Pcod_vendedor())
        Next

        Return combo

    End Function


    'Procedimiento para solicitar si se dan de alta más vendedores
    Public Sub AnadirVendedor()

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro VENDEDOR?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            Form1.txtCodVendedor.Clear()
            Form1.txtComision.Clear()
            Form1.txtCodVendedor.Focus()
        Else
            Form1.txtCodVendedor.Clear()
            Form1.txtComision.Clear()
            Form1.GroupBox2.Hide()
            Form1.Show()
        End If
    End Sub


    'Procedimiento para solicitar si se dan de alta más clientes
    Public Sub AnadirCliente()

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro CLIENTE?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            Form1.txtCodCliente.Clear()
            Form1.txtCodCliente.Focus()
        Else
            Form1.txtCodCliente.Clear()
            Form1.GroupBox1.Hide()
            Form1.Show()
        End If
    End Sub


End Module
