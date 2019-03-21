Public Class Cliente
    Private codigoCli As String
    Private direccionCli As String
    Private telefonoCli As Double
    Private emailCli As String
    Private alquileresCli As Integer


    Public Sub New(codigoCli As String, direccionCli As String, telefonoCli As Double, emailCli As String, alquileresCli As Integer)
        Me.codigoCli = codigoCli
        Me.direccionCli = direccionCli
        Me.telefonoCli = telefonoCli
        Me.emailCli = emailCli
        Me.alquileresCli = alquileresCli

    End Sub

    Public Property codigo() As String
        Get
            Return codigoCli
        End Get
        Set(value As String)
            codigoCli = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return direccionCli
        End Get
        Set(value As String)
            direccionCli = value
        End Set
    End Property

    Public Property telefono() As Double
        Get
            Return telefonoCli
        End Get
        Set(value As Double)
            telefonoCli = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return emailCli
        End Get
        Set(value As String)
            emailCli = value
        End Set
    End Property

    Public Property alquileres() As Integer
        Get
            Return alquileresCli
        End Get
        Set(value As Integer)
            alquileresCli = value
        End Set
    End Property


    Public Function imprimirCliente() As String
        Dim text As String = "Código: " & codigo & vbCrLf & "Dirección: " & direccion & vbCrLf & "Teléfono: " & telefono & vbCrLf & "Email: " & email & vbCrLf & "Alquileres: " & alquileresCli & vbCrLf & "-------------"
        Return text
    End Function

End Class
