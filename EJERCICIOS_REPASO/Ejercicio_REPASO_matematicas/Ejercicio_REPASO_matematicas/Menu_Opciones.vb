Public Class Menu_Opciones
    Private Sub txt_Opcion_TextChanged(sender As Object, e As EventArgs) Handles txt_Opcion.TextChanged

        Dim opcion As Integer
        opcion = CInt(txt_Opcion.Text)

        If Not (IsNumeric(txt_Opcion.Text)) Then
            MsgBox("Por favor, introduzca una de las opciones")

        Else
            Select Case opcion
                Case 1
                    Me.Hide()
                    Calculadora.Show()

                Case 2
                    Me.Hide()
                    Areas.Show()

                Case 3
                    Me.Hide()
                    FactFibo.Show()

                Case 4
                    MsgBox("Adiós")
                    Application.Exit()

            End Select

        End If
    End Sub
End Class
