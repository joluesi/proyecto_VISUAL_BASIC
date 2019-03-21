Public Class Form1
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

        If (txtUsuario.Text = "" Or txtClave.Text = "") Then
            MsgBox("Antes debe introducir Usuario y contraseña")

        Else
            Me.Hide()
            Form3.Show()
            Form3.lblUsuLog.Text = txtUsuario.Text

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("¡¡¡Que tengas un buen día!!!")
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
