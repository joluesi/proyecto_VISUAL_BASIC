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
    Public Property GetSet_codigo() As String
        Get
            Return codigoArticulo
        End Get
        Set(value As String)
            codigoArticulo = value
        End Set
    End Property

    Public Property GetSet_nombre() As String
        Get
            Return nombreArticulo
        End Get
        Set(value As String)
            nombreArticulo = value
        End Set
    End Property

    Public Property GetSet_categoria() As String
        Get
            Return categoriaArticulo
        End Get
        Set(value As String)
            categoriaArticulo = value
        End Set
    End Property

    Public Property GetSet_precio() As String
        Get
            Return precioArticulo
        End Get
        Set(value As String)
            precioArticulo = value
        End Set
    End Property

    Public Property GetSet_existencias() As String
        Get
            Return existenciasArticulo
        End Get
        Set(value As String)
            existenciasArticulo = value
        End Set
    End Property


    Public Overridable Function actualizacionExistencias() As Double

        Dim cantidad As String
        Dim verifica As Boolean
        Dim aux As Integer = -1

        Do
            cantidad = InputBox("Introduce la cantidad de " & Me.GetSet_nombre & " que deseas comprar. Existencias disponibles: " & Me.GetSet_existencias)
            verifica = True
            For i As Integer = 0 To Len(cantidad) - 1 Step 1
                If Char.IsPunctuation(cantidad(i)) Or Char.IsLetter(cantidad(i)) Or cantidad(i) = "" Then
                    verifica = False
                End If
            Next

            If verifica And cantidad <> "" Then
                aux = CType(cantidad, Integer)
            Else
                aux = -1
            End If

        Loop Until (aux <= Me.GetSet_existencias And aux >= 0 And verifica)

        Me.GetSet_existencias -= cantidad
        Return cantidad * (Me.GetSet_precio)

    End Function


    Public Overridable Function imprimirArticulo() As String

        Dim cadena As String

        cadena = Me.GetSet_codigo & vbTab & Me.GetSet_nombre & vbTab & "   " & Me.GetSet_categoria & vbTab & "  " & Me.GetSet_precio & vbTab & "   " & Me.GetSet_existencias

        Return cadena

    End Function

End Class
