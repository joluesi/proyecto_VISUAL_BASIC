Public Class Cliente
    Private cod_cliente As String
    Private cod_vendedorCli As String
    Private compras_mes As Single


    Public Sub New()

    End Sub

    'CREAR CONSTRUCTOR CON ARGUMENTOS
    Public Sub New(codCliente As String, codVendedor As String, comprasMes As Single)
        Me.cod_cliente = codCliente
        Me.cod_vendedorCli = codVendedor
        Me.compras_mes = 0

    End Sub

    Public Property P_codcliente As String
        Get
            Return cod_cliente
        End Get
        Set(ByVal value As String)
            cod_cliente = value
        End Set
    End Property

    Public Property P_codVendedorCli As String
        Get
            Return cod_vendedorCli
        End Get
        Set(ByVal value As String)
            cod_vendedorCli = value
        End Set
    End Property

    Public Property P_compras_mes As Single
        Get
            Return compras_mes
        End Get
        Set(ByVal value As Single)
            compras_mes = value
        End Set
    End Property
End Class
