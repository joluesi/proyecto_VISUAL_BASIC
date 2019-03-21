Public Class MenuClientes
    Private Sub txtOpcion_TextChanged(sender As Object, e As EventArgs) Handles txtOpcion.TextChanged

        Dim opcion As Integer
        opcion = CInt(txtOpcion.Text)
        Select Case opcion

            Case 1
                Me.Hide()
                Form1.Show()


            Case 2
                Me.Hide()
                Form1.Show()

            Case 3
                Me.Hide()
                Form1.Show()

            Case 4
                Me.Hide()
                Form1.Show()

            Case 5
                MsgBox("Que pase un buen día!!!")
                Application.Exit()

        End Select


    End Sub
End Class
