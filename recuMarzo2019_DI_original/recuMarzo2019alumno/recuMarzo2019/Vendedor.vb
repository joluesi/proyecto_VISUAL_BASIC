Public Class Vendedor
    Private cod_vendedor As String
    Private zona As String
    Private comision As Single


    Public Sub New()

    End Sub


    'CREAR CONSTRUCTOR CON ARGUMENTOS
    Public Sub New(codVendedor As String, zona As String, comision As Single)
        Me.cod_vendedor = codVendedor
        Me.zona = zona
        Me.comision = comision
    End Sub


    Public Property Pcod_vendedor() As String
        Get
            Return cod_vendedor
        End Get
        Set(ByVal value As String)
            cod_vendedor = value
        End Set
    End Property

    Public Property Pzona() As String
        Get
            Return zona
        End Get
        Set(ByVal value As String)
            zona = value
        End Set
    End Property

    Public Property Pcomision() As Single
        Get
            Return comision
        End Get
        Set(ByVal value As Single)
            comision = value
        End Set
    End Property


End Class
