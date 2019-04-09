Imports System.ComponentModel
Imports System.IO

Public Class ClientesProducto

    Public cadenaWriter As StreamWriter

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarComo()

    End Sub


    'función para guardar-como
    Public Function guardarComo()

        Dim dlgG As New SaveFileDialog()
            dlgG.Title = “Guardar como… “
            dlgG.Filter = "Text documents (*.txt)|*.txt"
            Dim result As DialogResult = dlgG.ShowDialog()

            If result = DialogResult.OK Then
                Dim pathfilename As String = dlgG.FileName.ToString
                cadenaWriter = New StreamWriter(pathfilename)
                cadenaWriter.Write(Me.richtxt_clientesProduc.Text)
                cadenaWriter.Close()
            End If

    End Function

End Class