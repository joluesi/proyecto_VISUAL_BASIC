Public Class PRODUCTOS

    Private codProducto As String
    Private nomProducto As String
    Private precioProducto As Single
    Private stockProducto As Integer

    Public Sub New(codigo As String, nombre As String, precio As String, stock As Integer)
        codProducto = codigo
        nomProducto = nombre
        precioProducto = precio
        stockProducto = stock

    End Sub


    Public Property P_CodProducto() As String
        Get
            Return codProducto
        End Get
        Set(value As String)
            codProducto = value
        End Set
    End Property

    Public Property P_NomProducto() As String
        Get
            Return nomProducto
        End Get
        Set(value As String)
            nomProducto = value
        End Set
    End Property

    Public Property P_PrecioProducto() As Single
        Get
            Return precioProducto
        End Get
        Set(value As Single)
            precioProducto = value
        End Set
    End Property

    Public Property P_StockProducto() As Integer
        Get
            Return stockProducto
        End Get
        Set(value As Integer)
            stockProducto = value
        End Set
    End Property

End Class
