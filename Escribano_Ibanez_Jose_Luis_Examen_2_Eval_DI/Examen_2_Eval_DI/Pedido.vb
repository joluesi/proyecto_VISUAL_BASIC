Public Class Pedido

    Private codPedido As String
    Private clientePedido As Integer
    Private fechaPedido As Date
    Private direcPedido As String

    'constructor
    Public Sub New(codigo As String, clientePed As Integer, fecha As Date, direcPed As String)
        codPedido = codigo
        clientePedido = clientePed
        fechaPedido = fecha
        direcPedido = direcPed

    End Sub

    'getter and setters
    Public Property GetSet_codPedido() As String
        Get
            Return codPedido
        End Get

        Set(value As String)
            codPedido = value
        End Set
    End Property

    Public Property GetSet_clientePedido() As Integer
        Get
            Return clientePedido
        End Get

        Set(value As Integer)
            clientePedido = value
        End Set
    End Property

    Public Property GetSet_fechaPedido() As Date
        Get
            Return fechaPedido
        End Get

        Set(value As Date)
            fechaPedido = value
        End Set
    End Property

    Public Property GetSet_direcPedido() As String
        Get
            Return direcPedido
        End Get

        Set(value As String)
            direcPedido = value
        End Set
    End Property

End Class
