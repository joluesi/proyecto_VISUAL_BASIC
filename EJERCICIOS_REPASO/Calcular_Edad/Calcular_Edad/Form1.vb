Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim fechaNacimiento As Date
        Dim edad As Integer

        fechaNacimiento = CDate(txtFecha.Text)
        edad = CInt(Today.Year - fechaNacimiento.Year)

        txtEdad.Text = Str(edad) & " años"


    End Sub

    'Public Function calcularEdad(ByVal nacimiento As Date) As Integer
    '    Dim edad As Integer
    '    edad = Today.Year - nacimiento.Year
    '    If (nacimiento > Today.AddYears(-edad)) Then edad -= 1
    '    Return edad
    'End Function

End Class
