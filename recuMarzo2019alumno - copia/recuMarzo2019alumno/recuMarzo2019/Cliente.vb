Public Class Cliente

    Private cod_cliente As Integer
    Private cod_vendedorCli As String
    Private compras_mes As Single

    'CREAR CONSTRUCTOR CON ARGUMENTOS
    Public Sub New(codCliente As Integer, codVendedor As String, comprasMes As Single)
        cod_cliente = codCliente
        cod_vendedorCli = codVendedor
        compras_mes = 0

    End Sub

    Public Property Pcodcliente() As Integer
        Get
            Return cod_cliente
        End Get
        Set(ByVal value As Integer)
            cod_cliente = value
        End Set
    End Property

    Public Property PcodVendedorCli() As String
        Get
            Return cod_vendedorCli
        End Get
        Set(ByVal value As String)
            cod_vendedorCli = value
        End Set
    End Property

    Public Property Pcompras_mes() As Single
        Get
            Return compras_mes
        End Get
        Set(ByVal value As Single)
            compras_mes = value
        End Set
    End Property
End Class
