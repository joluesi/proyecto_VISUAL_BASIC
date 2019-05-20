Public Class Class_ALUMNO

    Private cod_alum As String
    Private cod_ciclo As String
    Private nom_alum As String
    Private direcc_alum As String
    Private telef_alum As Single
    Private email_alum As String

    'constructor
    Public Sub New(cod_alum As String, cod_ciclo As String, nom_alum As String, direcc_alum As String, telef_alum As Single, email_alum As String)
        Me.cod_alum = cod_alum
        Me.cod_ciclo = cod_ciclo
        Me.nom_alum = nom_alum
        Me.direcc_alum = direcc_alum
        Me.telef_alum = telef_alum
        Me.email_alum = email_alum
    End Sub

    Public Property P_cod_alum As String
        Get
            Return cod_alum
        End Get
        Set(value As String)
            cod_alum = value
        End Set
    End Property

    Public Property P_cod_ciclo As String
        Get
            Return cod_ciclo
        End Get
        Set(value As String)
            cod_ciclo = value
        End Set
    End Property

    Public Property P_nom_alum As String
        Get
            Return nom_alum
        End Get
        Set(value As String)
            nom_alum = value
        End Set
    End Property

    Public Property P_direcc_alum As String
        Get
            Return direcc_alum
        End Get
        Set(value As String)
            direcc_alum = value
        End Set
    End Property

    Public Property P_telef_alum As Single
        Get
            Return telef_alum
        End Get
        Set(value As Single)
            telef_alum = value
        End Set
    End Property

    Public Property P_email_alum As String
        Get
            Return email_alum
        End Get
        Set(value As String)
            email_alum = value
        End Set
    End Property
End Class
