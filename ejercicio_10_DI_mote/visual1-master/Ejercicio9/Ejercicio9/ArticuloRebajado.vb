Public Class ArticuloRebajado
    Inherits Articulo

    Private rebaja As Integer

    Public Sub New(codigo As String, nombre As String, categoriaArticulo As String, precio As Double, existencias As Integer, descuento As Integer)

        MyBase.New(codigo, nombre, categoriaArticulo, precio, existencias)
        rebaja = descuento
    End Sub

    Public Sub New()
        MyBase.New()
        rebaja = Nothing
    End Sub

    Public Property rebajaArticulo() As Integer
        Get
            Return rebajaArticulo
        End Get
        Set(value As Integer)
            rebaja = value
        End Set
    End Property

    Public Overrides Function imprimirArticulo() As String

        Dim text = MyBase.imprimirArticulo() & vbTab & Str(rebaja)
        Return text

    End Function
End Class
