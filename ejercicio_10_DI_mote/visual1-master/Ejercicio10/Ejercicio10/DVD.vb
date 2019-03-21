Public Class DVD
    Private codigoDvd As String
    Private tituloDvd As String
    Private diasAlquilerDvd As Short
    Private alquiladoDvd As Boolean

    Public Sub New(codigoDvd As String, tituloDvd As String, diasAlquilerDvd As Short, alquiladoDvd As Boolean)
        Me.codigoDvd = codigoDvd
        Me.tituloDvd = tituloDvd
        Me.diasAlquilerDvd = diasAlquilerDvd
        Me.alquiladoDvd = alquiladoDvd
    End Sub

    Public Property codigo() As String
        Get
            Return codigoDvd
        End Get
        Set(value As String)
            codigoDvd = value
        End Set
    End Property

    Public Property titulo() As String
        Get
            Return tituloDvd
        End Get
        Set(value As String)
            tituloDvd = value
        End Set
    End Property

    Public Property diasAlquiler() As Short
        Get
            Return diasAlquilerDvd
        End Get
        Set(value As Short)
            diasAlquilerDvd = value
        End Set
    End Property

    Public Property alquilado() As Boolean
        Get
            Return alquiladoDvd
        End Get
        Set(value As Boolean)
            alquiladoDvd = value
        End Set
    End Property

    Public Function imprimirDVD() As String
        Dim text = "Código: " & codigo & vbCrLf & "Título: " & titulo & vbCrLf & "Días Alquiler: " & diasAlquiler & vbCrLf & "Alquilado: " & alquilado & vbCrLf & "---------------"
        Return text
    End Function
End Class
