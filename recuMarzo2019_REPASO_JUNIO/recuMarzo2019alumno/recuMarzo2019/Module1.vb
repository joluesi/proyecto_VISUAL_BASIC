Module Module1
    'Definir COLECCIÓN de la clase ComprasCliente con clave cod_cliente.
    Public colecCompraClienete As New Collection

    'Definir COLECCIÓN de la clase Vendedor con clave cod_vendedor.
    Public colecVendedor As New Collection

    'Definir array ComprasMes
    Public comprasMes(4, 1) As Single


    'Definir variables las necesarias  
    Public cont_cod_cliente As Integer = 1


    'Definir función para crear lista de vendedores en Combobox
    Public Sub Si_o_No()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro vendedor?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then

            Form1.txtCodVendedor.Focus()
        Else
            Form1.GroupBox2.Hide()
            Form1.Show()
        End If
    End Sub



End Module
