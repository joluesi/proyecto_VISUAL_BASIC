﻿Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtOpcion_TextChanged(sender As Object, e As EventArgs) Handles txtOpcion.TextChanged

        Dim opcion As Integer
        opcion = CInt(txtOpcion.Text)

        Select Case opcion
            Case 1
                Me.Hide()
                Form1.Show()

            Case 2
                Me.Hide()
                Form2.Show()

            Case 3
                Me.Hide()
                Form3.Show()

        End Select

    End Sub
End Class