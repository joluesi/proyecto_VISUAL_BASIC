Module Module1
    'Definir COLECCIÓN de la clase ComprasCliente con clave cod_cliente.
    Public colecCLIENTE As New Collection

    'Definir COLECCIÓN de la clase Vendedor con clave cod_vendedor.
    Public colecVENDEDOR As New Collection

    'Definir array ComprasMes
    Public comprasMes(4, 1) As Single

    'Definir variables las necesarias  
    Public cont_cliente As Integer = 1



    'Definir función para crear lista de vendedores en Combobox    
    Public Function SeleccionaCombobox(combo As ComboBox)

        combo.Items.Clear()
        For Each vend In colecVENDEDOR
            combo.Items.Add(vend.P_cod_vendedor)
        Next

        Return combo

    End Function


    'Definir función para crear lista de clientes
    Public Sub Si_o_No_C()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro cliente?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            Form1.txtCodCliente.Focus()
        Else
            Form1.gbxCliente.Hide()
            Form1.Show()
        End If
    End Sub

    'Definir función para crear lista de vendedores
    Public Sub Si_o_No_V()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro vendedor?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            Form1.txtCodVendedor.Text = ""
            Form1.txtCodVendedor.Focus()
        Else
            Form1.gbxVendedor.Hide()
            Form1.Show()
        End If
    End Sub


End Module
