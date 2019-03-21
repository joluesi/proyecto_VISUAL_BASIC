Public Class Articulo
    'Atributos de clase
    Private codigoArticulo As String
    Private nombreArticulo As String
    Private categoriaArticulo As String
    Private precioArticulo As Double
    Private existenciasArticulo As Integer

    'Constructor vacío
    Public Sub New()
        Me.codigoArticulo = Nothing
        Me.nombreArticulo = Nothing
        Me.categoriaArticulo = Nothing
        Me.precioArticulo = Nothing
        Me.existenciasArticulo = Nothing

    End Sub

    'Constructor con parámetros
    Public Sub New(codigoArticulo As String, nombreArticulo As String, categoriaArticulo As String, precioArticulo As Double, existenciasArticulo As Integer)
        Me.codigoArticulo = codigoArticulo
        Me.nombreArticulo = nombreArticulo
        Me.categoriaArticulo = categoriaArticulo
        Me.precioArticulo = precioArticulo
        Me.existenciasArticulo = existenciasArticulo

    End Sub

    'Getters and Setters
    Public Property codigo() As String
        Get
            Return codigoArticulo
        End Get
        Set(value As String)
            codigoArticulo = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombreArticulo
        End Get
        Set(value As String)
            nombreArticulo = value
        End Set
    End Property

    Public Property categoria() As String
        Get
            Return categoriaArticulo
        End Get
        Set(value As String)
            categoriaArticulo = value
        End Set
    End Property

    Public Property precio() As Double
        Get
            Return precioArticulo
        End Get
        Set(value As Double)
            precioArticulo = value
        End Set
    End Property

    Public Property existencias() As Integer
        Get
            Return existenciasArticulo
        End Get
        Set(value As Integer)
            existenciasArticulo = value
        End Set
    End Property


End Class
