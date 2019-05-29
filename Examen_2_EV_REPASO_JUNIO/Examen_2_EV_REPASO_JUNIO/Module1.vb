Module Module1

    'colección para clase PRODUCTOS
    Public colecPRODUCTOS As New Collection

    'colección para clase PEDIDOS
    Public colecPEDIDOS As New Collection

    Public Structure DETALLE_PEDIDO
        Dim codPedido_detal As String
        Dim codProducto_detal As String
        Dim canti_detal As Integer
        Dim descu_detal As Single
    End Structure

    Public array_detalle() As DETALLE_PEDIDO

    Public array_clientes(4) As Integer

    'variables
    Public cont_cod_pedido As Integer = 1
    Public cont As Integer = 0


    'Definir función para añadir o no detalle de pedidos 
    Public Sub AnadirDetallePedido()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro detalle de pedido?", "Atención", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then

            AltaPedidos.cmbCodProducto.Text = ""
            AltaPedidos.txtCantidadProDetalles.Text = ""
            AltaPedidos.txtDescuentoDetalles.Text = ""
        Else
            AltaPedidos.cmbCodProducto.Items.Clear()
            AltaPedidos.txtCantidadProDetalles.Text = ""
            AltaPedidos.txtDescuentoDetalles.Text = ""
            AltaPedidos.grbDetalles.Hide()
            AltaPedidos.Hide()
            Form1.Show()

        End If
    End Sub


End Module
