Public Class Clientes
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
        alquileresCli = 0

    End Sub

    'Getter y Setters
    Public Property GetSet_codigoCli() As String
        Get
            Return codigoCli
        End Get

        Set(value As String)
            codigoCli = value
        End Set
    End Property

    Public Property GetSet_direccionCli() As String
        Get
            Return direccionCli
        End Get

        Set(value As String)
            direccionCli = value
        End Set
    End Property

    Public Property GetSet_telefonoCli() As Double
        Get
            Return telefonoCli
        End Get

        Set(value As Double)
            telefonoCli = value
        End Set
    End Property

    Public Property GetSet_emailCli() As String
        Get
            Return emailCli
        End Get

        Set(value As String)
            emailCli = value
        End Set
    End Property

    Public Property GetSet_alquileresCli() As Integer
        Get
            Return alquileresCli
        End Get

        Set(value As Integer)
            alquileresCli = value
        End Set
    End Property

End Class
