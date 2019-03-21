Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tablaNumero, multiplicadores As Integer
        Dim resultado As String = ""

        For tablaNumero = 1 To 10

            For multiplicadores = 1 To 10
                resultado = resultado & " " & (tablaNumero * multiplicadores)
            Next multiplicadores

            resultado = resultado & " " & "Tabla del " & tablaNumero & vbCrLf

        Next tablaNumero

        'muestra las tablas en formulario
        lblTabla.Text = resultado



    End Sub
End Class
