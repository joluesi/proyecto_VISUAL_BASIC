Public Class Form1
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

        If (txtUsuario.Text = "" Or txtClave.Text = "") Then
            MsgBox("Antes debe introducir Usuario y contraseña")

        End If

        Dim encontrado As Boolean = False

        For index = 0 To 3

            If (txtUsuario.Text = Usuarios(index, 0)) And txtClave.Text = Usuarios(index, 1) Then
                encontrado = True
            End If
        Next

        If encontrado Then

            Me.Hide()
            frmAlumnos.Show()

        Else
            MsgBox("Usuario o contraseña no válidos")

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("¡¡¡Que tengas un buen día!!!")
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Usuarios(0, 0) = "pepe"
        Usuarios(0, 1) = "0000"
        Usuarios(1, 0) = "jose"
        Usuarios(1, 1) = "1111"
        Usuarios(2, 0) = "juan"
        Usuarios(2, 1) = "2222"
        Usuarios(3, 0) = "ana"
        Usuarios(3, 1) = "3333"

    End Sub

End Class
