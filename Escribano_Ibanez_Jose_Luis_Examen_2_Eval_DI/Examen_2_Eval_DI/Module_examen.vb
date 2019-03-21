Module Module_examen

    Public Structure DETALLE_PEDIDO
        Dim codPedido_detal As String
        Dim codProducto_detal As String
        Dim canti_detal As Integer
        Dim descu_detal As Single

    End Structure

    'colecciones de las clases y las inicializo
    Public coleccionPEDIDOS As New Collection
    Public coleccionPRODUCTOS As New Collection

    'array de detalle pedido
    Public arrayDetallePedido() As DETALLE_PEDIDO
    'array de clientes
    Public arrayClientes() As Integer
    'para redimensionar array de pedidos
    Public cont As Integer = 0

    Public Sub DarOtraAlta()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro pedido?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            borrarTextAlta()
            AltaPedidos.txtCodPedido.Focus()
        Else
            borrarTextAlta()
            'AltaPedidos.Hide()
            AltaPedidos.gbdetallePedido.Visible = True


        End If
    End Sub

    Public Sub borrarTextAlta()
        AltaPedidos.txtCodPedido.Clear()
        AltaPedidos.txtClientePedido.Clear()
        AltaPedidos.txtFechaPedido.Clear()
        AltaPedidos.txtDirecPedido.Focus()

    End Sub

    Public Sub mostrarProductoPorCodigo(codigo As String)

        ConsultaProductos.txtConsultaCodProd.Text = coleccionPRODUCTOS(codigo).GetSet_codProducto()
        ConsultaProductos.txtConsultaNombreProd.Text = coleccionPRODUCTOS(codigo).GetSet_nomProducto()
        ConsultaProductos.txtConsultaPrecioProd.Text = coleccionPRODUCTOS(codigo).GetSet_precioProducto()
        ConsultaProductos.txtConsultaStockProd.Text = coleccionPRODUCTOS(codigo).GetSet_stockProducto()

    End Sub

    Public Function ifExisteCodPedEnColeccionPedido(codigo As String) As Boolean

        For i As Integer = 1 To coleccionPEDIDOS.Count
            If coleccionPEDIDOS(i).GetSet_codPedido() = codigo Then
                Return True
            End If
        Next

        Return False

    End Function


End Module
