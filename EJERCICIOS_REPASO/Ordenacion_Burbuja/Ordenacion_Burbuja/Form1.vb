Public Class Form1
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click

        If IsNumeric(txtNumero.Text) Then

            lstNumeros.Items.Add(txtNumero.Text)
            txtNumero.Text = “”
            txtNumero.Focus()
        Else
            MsgBox(“Introduzca un número”, vbCritical, “Mensaje”)
            txtNumero.SelectionStart = 0
            txtNumero.SelectionLength = Len(txtNumero.Text)
            txtNumero.Focus()

        End If

    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click

        Dim I As Integer, J As Integer, T As Integer, N As Integer
        Dim A() As Integer
        N = lstNumeros.Items.Count
        ReDim A(N)

        For I = 0 To N - 1
            A(I) = lstNumeros.Items(I)
        Next I

        If rbtnAscend.Checked Then
            For I = 0 To N - 2
                For J = I + 1 To N - 1
                    If A(I) > A(J) Then
                        T = A(I)
                        A(I) = A(J)
                        A(J) = T
                    End If
                Next J
            Next I
        End If

        If rbtnDescend.Checked Then
            For I = 0 To N - 2
                For J = I + 1 To N - 1
                    If A(I) < A(J) Then
                        T = A(I)
                        A(I) = A(J)
                        A(J) = T
                    End If
                Next J
            Next I
        End If


        For I = 0 To N - 1
            lstNumeros.Items(I) = A(I)
        Next I

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        If MsgBox("¿Desea cerrar la aplicación? ", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            MsgBox("Adiós!!!")
            Application.Exit()
        Else
            btnLimpiar.PerformClick()
            txtNumero.Focus()
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumero.Clear()
        lstNumeros.ClearSelected()

    End Sub
End Class
