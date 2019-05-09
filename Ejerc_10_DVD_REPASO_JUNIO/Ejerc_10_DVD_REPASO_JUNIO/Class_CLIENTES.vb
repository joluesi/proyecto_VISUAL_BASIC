Public Class Class_CLIENTES
    Private codigoCli As String
    Private direccionCli As String
    Private telefonoCli As Double
    Private emailCli As String
    Private alquileresCli As Integer

    'método constructor
    Public Sub New(codigo As String, direccion As String, telefono As Double, email As String)
        codigoCli = codigo
        direccionCli = direccion
        telefonoCli = telefono
        emailCli = email
        alquileresCli = 0 'por defecto inicializo a '0'

    End Sub

    Public Property P_CodigoCli As String
        Get
            Return codigoCli
        End Get
        Set(value As String)
            codigoCli = value
        End Set
    End Property

    Public Property P_TelefonoCli As Double
        Get
            Return telefonoCli
        End Get
        Set(value As Double)
            telefonoCli = value
        End Set
    End Property

    Public Property P_DireccionCli As String
        Get
            Return direccionCli
        End Get
        Set(value As String)
            direccionCli = value
        End Set
    End Property

    Public Property P_EmailCli As String
        Get
            Return emailCli
        End Get
        Set(value As String)
            emailCli = value
        End Set
    End Property

    Public Property P_AlquileresCli As Integer
        Get
            Return alquileresCli
        End Get
        Set(value As Integer)
            alquileresCli = value
        End Set
    End Property
End Class
