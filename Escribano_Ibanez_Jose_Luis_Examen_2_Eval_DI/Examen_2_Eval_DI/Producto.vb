Public Class Producto
    Private codProducto As String
    Private nomProducto As String
    Private precioProducto As Single
    Private stockProducto As Integer

    'constructor
    Public Sub New(codigo As String, nombre As String, precio As Single, stock As Integer)
        codProducto = codigo
        nomProducto = nombre
        precioProducto = precio
        stockProducto = stock

    End Sub

    'getter and setters
    Public Property GetSet_codProducto() As String
        Get
            Return codProducto
        End Get

        Set(value As String)
            codProducto = value
        End Set
    End Property

    Public Property GetSet_nomProducto() As String
        Get
            Return nomProducto
        End Get

        Set(value As String)
            nomProducto = value
        End Set
    End Property

    Public Property GetSet_precioProducto() As Single
        Get
            Return precioProducto
        End Get

        Set(value As Single)
            precioProducto = value
        End Set
    End Property

    Public Property GetSet_stockProducto() As Integer
        Get
            Return stockProducto
        End Get

        Set(value As Integer)
            stockProducto = value
        End Set
    End Property



End Class
