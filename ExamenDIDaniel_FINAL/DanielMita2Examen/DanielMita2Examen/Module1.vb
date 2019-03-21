Module Module1

    Public Structure detalle_pedido
        Dim codPedido_detal As String
        Dim codProducto_detal As String
        Dim canti_detal As Integer
        Dim descu_detal As Double
    End Structure

    'colecciones
    Public colProductos As New Collection
    Public colPedidos As New Collection

    'arrays
    Public array_detalle() As detalle_pedido
    Public array_clientes(4) As Integer


    'propiedades
    Public contadorCodPedido As Integer = 1
    Public cont As Integer = 0



End Module
