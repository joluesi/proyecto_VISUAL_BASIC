Public Class Class_NOTAS

    Private cod_alumno As String
    Private cod_curso As String
    Private array_nota(4) As Integer
    Private array_recu(4) As Integer

    'constructor
    Public Sub New(cod_alumno As String, cod_curso As String, array_nota() As Integer, array_recu() As Integer)
        Me.cod_alumno = cod_alumno
        Me.cod_curso = cod_curso
        Me.array_nota = array_nota
        Me.array_recu = array_recu
    End Sub

    Public Property P_cod_alumno As String
        Get
            Return cod_alumno
        End Get
        Set(value As String)
            cod_alumno = value
        End Set
    End Property

    Public Property P_cod_curso As String
        Get
            Return cod_curso
        End Get
        Set(value As String)
            cod_curso = value
        End Set
    End Property

    Public Property P_Array_nota As Integer()
        Get
            Return array_nota
        End Get
        Set(value As Integer())
            array_nota = value
        End Set
    End Property

    Public Property P_Array_recu As Integer()
        Get
            Return array_recu
        End Get
        Set(value As Integer())
            array_recu = value
        End Set
    End Property




End Class
