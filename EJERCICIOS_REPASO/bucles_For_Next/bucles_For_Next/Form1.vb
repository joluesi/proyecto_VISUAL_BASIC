Public Class Form1



    Private Sub txtNombres_MouseEnter(sender As Object, e As EventArgs) Handles txtNombres.MouseEnter
        Dim nombres(4) As String
        Dim posicion As Integer

        nombres(0) = "Pepe"
        nombres(1) = "Juan"
        nombres(2) = "Antonio"
        nombres(3) = "Luis"
        nombres(4) = "Rosa"

        For posicion = 0 To 4
            MessageBox.Show(nombres(posicion))

        Next
    End Sub
End Class
