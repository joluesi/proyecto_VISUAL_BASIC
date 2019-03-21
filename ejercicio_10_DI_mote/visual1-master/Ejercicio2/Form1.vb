Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarios(0, 0) = "alexmote"
        usuarios(0, 1) = "123"
        usuarios(1, 0) = "fran"
        usuarios(1, 1) = "321"
        usuarios(2, 0) = "jose"
        usuarios(2, 1) = "000"
        usuarios(3, 0) = "pepe"
        usuarios(3, 1) = "333"

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim encontrado As Boolean = False
        For index = 0 To 3
            If txtUsuario.Text = usuarios(index, 0) And txtContraseña.Text = usuarios(index, 1) Then
                encontrado = True
                Form3.EtiquetaNom.Text = usuarios(index, 0)
            End If
        Next

        If encontrado Then

            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Usuario o contraseña incorrectos")
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        End
    End Sub
End Class
