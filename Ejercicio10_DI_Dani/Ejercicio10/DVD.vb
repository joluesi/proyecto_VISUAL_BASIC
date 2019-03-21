Public Class DVD

    Private codigoDvd As String
    Private tituloDvd As String
    Private diasAlquilerDvd As Short
    Private alquiladoDvd As Boolean

    'constructor
    Public Sub New(codigo As String, titulo As String, diasAlquiler As Short)
        codigoDvd = codigo
        tituloDvd = titulo
        diasAlquilerDvd = diasAlquiler
        alquiladoDvd = False 'por defecto, false, por eso no lo pasamos como parametro.

    End Sub



    'getters y setters
    Public Property DvdCodigo() As String
        Get
            Return codigoDvd
        End Get

        Set(value As String)
            codigoDvd = value
        End Set

    End Property

    Public Property DvdTitulo() As String
        Get
            Return tituloDvd
        End Get
        Set(value As String)
            tituloDvd = value
        End Set
    End Property

    Public Property DvdDiasAlquiler() As Short
        Get
            Return diasAlquilerDvd
        End Get

        Set(value As Short)
            diasAlquilerDvd = value
        End Set
    End Property

    Public Property DvdAlquilado() As Boolean
        Get
            Return alquiladoDvd
        End Get

        Set(value As Boolean)
            alquiladoDvd = value
        End Set

    End Property

End Class
