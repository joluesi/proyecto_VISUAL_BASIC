Public Class PEDIDOS

    Private codPedido As String
    Private clientePedido As Integer
    Private fechaPedido As Date
    Private direcPedido As String

    Public Sub New(codigo As String, codCliente As Integer, fecha As Date, direccion As String)
        codPedido = codigo
        clientePedido = codCliente
        fechaPedido = fecha
        direcPedido = direccion

    End Sub

    Public Property P_codPedido() As String
        Get
            Return codPedido
        End Get
        Set(value As String)
            codPedido = value
        End Set
    End Property

    Public Property P_clientePedido() As Integer
        Get
            Return clientePedido
        End Get
        Set(value As Integer)
            clientePedido = value
        End Set
    End Property

    Public Property P_fechaPedido() As Date
        Get
            Return fechaPedido
        End Get
        Set(value As Date)
            fechaPedido = value
        End Set
    End Property

    Public Property P_direcPedido() As String
        Get
            Return direcPedido
        End Get
        Set(value As String)
            direcPedido = value
        End Set
    End Property

End Class
