Public Class Productos

    Private codProducto As String
    Private nomProducto As String
    Private precioProducto As Double
    Private stockProducto As Integer


    Public Sub New(cod As String, nom As String, precio As Double, stock As Integer)
        codProducto = cod
        nomProducto = nom
        precioProducto = precio
        stockProducto = stock
    End Sub

    Public Property GSCodProducto() As String
        Get
            Return codProducto
        End Get
        Set(value As String)
            codProducto = value
        End Set
    End Property

    Public Property GSNomProducto() As String
        Get
            Return nomProducto
        End Get
        Set(value As String)
            nomProducto = value
        End Set
    End Property

    Public Property GSPrecioProducto() As Double
        Get
            Return precioProducto
        End Get
        Set(value As Double)
            precioProducto = value
        End Set
    End Property

    Public Property GSStockProducto() As Integer
        Get
            Return stockProducto
        End Get
        Set(value As Integer)
            stockProducto = value
        End Set
    End Property

End Class
