Module Module1
    Public usuarios(3, 1) As String

    Public Structure Alumno
        Public codAlumno As Integer
        Public nomAlumno As String
        Public apelAlumno As String
        Public telAlumno As Single
        Public emailAlumno As String
        Public cursoAlumno As String

    End Structure
    Public alumnos() As Alumno
    Public cont As Integer = 0

End Module
