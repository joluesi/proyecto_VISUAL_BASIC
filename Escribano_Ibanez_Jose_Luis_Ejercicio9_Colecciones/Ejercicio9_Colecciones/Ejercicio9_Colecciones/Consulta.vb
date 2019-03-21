Public Class Consulta
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
        txtRebajaConsulta.Text = ""

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Seguro que desea eliminar el artículo " & txtNombreConsulta.Text & "?", "ATENCION", MessageBoxButtons.YesNoCancel)


        If opcion = DialogResult.Yes Then
            coleccionArticulo.Remove(txtCodigoConsulta.Text)
            Me.Hide()
            Form1.Show()
            MsgBox("El artículo " & txtNombreConsulta.Text & " ha sido borrado")
        Else
            Me.Hide()
            Form1.Show()

        End If

    End Sub
End Class