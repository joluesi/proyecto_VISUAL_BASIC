' alta, dar de alta en la coleccion
'pedido, un nuevo form que permita hacer pedidos, se indica la cantidad, si hay suficientes existencias, hace el pedid, si no, no lo hace. 
'Hacer el pedido es simplemente restar la cantidad de existencias y decirle que ha comprado

'listado, las existencias de todos los productos

'daralta/dar baja, se consulta por el codigo de producto, y podremos eliminarlo. Es decir, pide codigo, y nos muestra luego todos sus datos
'Y mientras se nos muestre, podremos elegir si eliminarlo o no. Podemos INCLUIR (es opcional) un boton para modificar

'las funciones que pide, hay que hacerselas en la clase articulo y sobreescribirlas en la clase ArticuloRebajado



Public Class Articulo

    'atributos de clase
    Private codigoArticulo As String
    Private nombreArticulo As String
    Private categoriaArticulo As String
    Private precioArticulo As Double
    Private existenciasArticulo As Integer

    'constructores
    Public Sub New()
        Me.codigoArticulo = Nothing
        Me.nombreArticulo = Nothing
        Me.categoriaArticulo = Nothing
        Me.precioArticulo = Nothing
        Me.existenciasArticulo = Nothing

    End Sub

    Public Sub New(codigoArticulo As String, nombreArticulo As String, categoriaArticulo As String, precioArticulo As Double, existenciasArticulo As Integer)
        Me.codigoArticulo = codigoArticulo
        Me.nombreArticulo = nombreArticulo
        Me.categoriaArticulo = categoriaArticulo
        Me.precioArticulo = precioArticulo
        Me.existenciasArticulo = existenciasArticulo
    End Sub

    'funciones


    'setters y getters
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

    Public Property precio() As String
        Get
            Return precioArticulo
        End Get

        Set(value As String)
            precioArticulo = value
        End Set
    End Property

    Public Property existencias() As String
        Get
            Return existenciasArticulo
        End Get

        Set(value As String)
            existenciasArticulo = value
        End Set
    End Property






End Class
