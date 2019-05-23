Public Class Class_CLIENTE
    Private codigoCli As String
    Private nombreCli As String
    Private historiaCli() As Integer
    Private telefonoCli As Double

    Public Sub New(codigo As String, nombre As String, telefono As Integer)
        Me.codigoCli = codigo
        Me.nombreCli = nombre
        Me.telefonoCli = telefono
        Me.historiaCli = {}

    End Sub

    Public Property P_CodigoCli As String
        Get
            Return codigoCli
        End Get
        Set(value As String)
            codigoCli = value
        End Set
    End Property

    Public Property P_NombreCli As String
        Get
            Return nombreCli
        End Get
        Set(value As String)
            nombreCli = value
        End Set
    End Property

    Public Property P_HistoriaCli As Integer()
        Get
            Return historiaCli
        End Get
        Set(value As Integer())
            historiaCli = value
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

End Class
