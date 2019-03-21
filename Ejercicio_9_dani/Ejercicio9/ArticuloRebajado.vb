Public Class ArticuloRebajado
    Inherits Articulo

    'atributos de clase
    Private rebajaArticulo As Short


    'constructor
    Public Sub New(codigoArticulo As String, nombreArticulo As String, categoriaArticulo As String, precioArticulo As Double,
                   existenciasArticulo As Integer, rebajaArticulo As Short)
        'mandamos los atributos al constructor de la clase padre
        MyBase.New(codigoArticulo, nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo)

        Me.rebajaArticulo = rebajaArticulo

    End Sub


    'getters y setter
    Public Property rebaja() As Short
        Get
            Return rebajaArticulo
        End Get

        Set(value As Short)
            rebajaArticulo = value
        End Set
    End Property

End Class
