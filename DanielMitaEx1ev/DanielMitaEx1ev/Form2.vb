Public Class Form2



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nombre As String = txtNombre.Text

        If (ifExiste(nombre)) Then
            If (ifBloqueado(nombre)) Then
                MsgBox("Cliente Bloqueado, primero lo tiene que desbloquear")
                Me.Hide()
                Form1.Show()
            Else ' todo ha ido bien si entra en este else y pasamos a formulario3
                Me.Hide()
                Form3.Show()

            End If

        Else
            MsgBox("Cliente no existe, Adios")
            Me.Hide()
            Form1.Show()
        End If



    End Sub

    Private Sub btnCancelar2_Click(sender As Object, e As EventArgs) Handles btnCancelar2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class