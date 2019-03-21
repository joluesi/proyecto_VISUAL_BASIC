Public Class Clientes

    Private codigoCli As String
    Private direccionCli As String
    Private telefonoCli As Double
    Private emailCli As String
    Private alquileresCli As Integer

    'constructores
    Public Sub New(codigo As String, direccion As String, telefono As Double, email As String)
        codigoCli = codigo
        direccionCli = direccion
        telefonoCli = telefono
        emailCli = email
        alquileresCli = 0
    End Sub


    'getters y setters
    Public Property CliCodigo() As String
        Get
            Return codigoCli
        End Get

        Set(value As String)
            codigoCli = value
        End Set
    End Property



    Public Property CliDireccion() As String
        Get
            Return direccionCli
        End Get

        Set(value As String)
            direccionCli = value
        End Set
    End Property

    Public Property CliTelefono() As Double
        Get
            Return telefonoCli
        End Get

        Set(value As Double)
            telefonoCli = value
        End Set
    End Property

    Public Property CliEmail() As String
        Get
            Return emailCli
        End Get

        Set(value As String)
            emailCli = value
        End Set
    End Property

    Public Property CliAlquileres() As Integer
        Get
            Return alquileresCli
        End Get

        Set(value As Integer)
            alquileresCli = value
        End Set
    End Property



End Class
