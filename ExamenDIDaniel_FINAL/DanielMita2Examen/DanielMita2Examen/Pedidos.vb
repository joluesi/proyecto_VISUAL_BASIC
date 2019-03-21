Public Class Pedidos

    Private codPedido As String
    Private clientePedido As Integer
    Private fechaPedido As Date
    Private direcPedido As String


    Public Sub New(codigo As String, cliPedido As Integer, fecha As Date, direccion As String)
        codPedido = codigo
        clientePedido = cliPedido
        fechaPedido = fecha
        direcPedido = direccion

    End Sub


    'getters y setters
    Public Property GSCodPedido() As String
        Get
            Return codPedido
        End Get
        Set(value As String)
            codPedido = value
        End Set
    End Property

    Public Property GSClientePedido() As Integer
        Get
            Return clientePedido
        End Get
        Set(value As Integer)
            clientePedido = value
        End Set
    End Property

    Public Property GSFechaPedido() As Date
        Get
            Return fechaPedido
        End Get
        Set(value As Date)
            fechaPedido = value
        End Set
    End Property

    Public Property GSDireccionPedido As String
        Get
            Return direcPedido
        End Get
        Set(value As String)
            direcPedido = value
        End Set
    End Property



End Class
