Public Class Articulo
    Private codigoArticulo As String
    Private nombreArticulo As String
    Private categoriaArticulo As String
    Private precioArticulo As Double
    Private existenciasArticulo As Integer

    Public Sub New()
        codigoArticulo = Nothing
        nombreArticulo = Nothing
        categoriaArticulo = Nothing
        precioArticulo = Nothing
        existenciasArticulo = Nothing
    End Sub

    Public Sub New(codigo As String, nombre As String, categoria As String, precio As Double, existencias As Integer)

        codigoArticulo = codigo
        nombreArticulo = nombre
        categoriaArticulo = categoria
        precioArticulo = precio
        existenciasArticulo = existencias

    End Sub

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

    Public Overridable Function imprimirArticulo() As String

        Dim text = codigo & vbTab & vbTab & nombre & vbTab & vbTab & categoria & vbTab & vbTab &
        Str(precio) & vbTab & vbTab & Str(existencias) & vbTab & vbTab
        Return text

    End Function
End Class
