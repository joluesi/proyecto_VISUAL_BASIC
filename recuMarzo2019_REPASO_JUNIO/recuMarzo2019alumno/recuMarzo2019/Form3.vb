﻿Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rtbVentas.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class