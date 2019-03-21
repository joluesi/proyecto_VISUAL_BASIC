
Public Class ArticuloRebajado
    Inherits Articulo

    'Atributos de clase
    Private rebajaArticulo As Short

    'constructor vacío
    Public Sub New()

    End Sub

    'constructor con parámetros
    Public Sub New(codigoArticulo As String, nombreArticulo As String, categoriaArticulo As String, precioArticulo As Double,
                   existenciasArticulo As Integer, rebajaArticulo As Short)
        'constructor de la clase base
        MyBase.New(codigoArticulo, nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo)
        Me.rebajaArticulo = rebajaArticulo

    End Sub

    'getters and setters
    Public Property GetSet_rebaja() As String
        Get
            Return rebajaArticulo
        End Get
        Set(value As String)
            rebajaArticulo = value
        End Set
    End Property


    Public Overrides Function actualizacionExistencias() As Double

        Dim valorPedido As Double = MyBase.actualizacionExistencias()
        Return valorPedido - (valorPedido * (Me.GetSet_rebaja / 100))

    End Function


    Public Overrides Function imprimirArticulo() As String

        Return MyBase.imprimirArticulo() & vbTab & vbTab & "  " & Me.GetSet_rebaja

    End Function

End Class
