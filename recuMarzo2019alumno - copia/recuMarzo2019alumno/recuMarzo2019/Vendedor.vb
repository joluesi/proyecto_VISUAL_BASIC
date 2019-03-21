Public Class Vendedor
    Private cod_vendedor As String
    Private zona As String
    Private comision As Single

    'CREAR CONSTRUCTOR CON ARGUMENTOS
    Public Sub New(codVend As String, zonaVend As String, comisionVend As Single)
        cod_vendedor = codVend
        zona = zonaVend
        comision = comisionVend

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
