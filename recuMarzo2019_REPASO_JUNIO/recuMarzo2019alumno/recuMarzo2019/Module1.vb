Module Module1
    'Definir COLECCIÓN de la clase ComprasCliente con clave cod_cliente.
    Public colecComprasCliente As New Collection

    'Definir COLECCIÓN de la clase Vendedor con clave cod_vendedor.
    Public colecVendedor As New Collection

    'Definir array ComprasMes
    Public comprasMes(4, 1) As Single

    'variable contadora de código de clientes (se inicializa en 1 y se incrementa de forma automática)
    Public cont_cod_cliente As Integer = 1


    'Función para rellenar combobox de vendedores
    Public Function SeleccionaCombobox(combo As ComboBox)

        combo.Items.Clear()
        For Each vend In colecVendedor
            combo.Items.Add(vend.Pcod_vendedor())
        Next

        Return combo

    End Function


    'Definir función para crear lista de vendedores
    Public Sub Si_o_No_V()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro vendedor?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then

            Form1.txtCodVendedor.Focus()
        Else
            Form1.GroupBox2.Hide()
            Form1.Show()
        End If
    End Sub


    'Definir función para crear lista de clientes
    Public Sub Si_o_No_C()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro cliente?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then

            Form1.txtCodCliente.Focus()
        Else
            Form1.GroupBox1.Hide()
            Form1.Show()
        End If
    End Sub


    'Función comprobar campos numéricos
    Public Function isNumeric(text As String) As Boolean
        Try
            Dim num = CInt(text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Module
