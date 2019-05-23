Public Class Form1
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        gbx_AltaClientes.Visible = True

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtCodigoCli.Text <> "" And txtNombreCli.Text <> "" And txtTelefono.Text <> "" Then

            If colecClientes.Contains(txtCodigoCli.Text) Then
                MsgBox("Ya existe ese cliente")
            Else
                colecClientes.Add(New Class_CLIENTE(txtNombreCli.Text, txtCodigoCli.Text, txtTelefono.Text), txtCodigoCli.Text)
                MsgBox("Añadido cliente a la colección")
                AnadirCLIENTES()
            End If

        Else
            MsgBox("Rellene casilleros de forma correcta")

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        txtNombreCli.Text = ""
        txtCodigoCli.Text = ""
        txtTelefono.Text = ""
        gbx_AltaClientes.Hide()

    End Sub

    Private Sub TratamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientosToolStripMenuItem.Click

        For i As Integer = 1 To 5
            array_tratamiento(i).codigoTra = i
            array_tratamiento(i).nombreTra = "T" & CStr(i)
            array_tratamiento(i).precioTra = i * 10
        Next

        MsgBox("Creado 5 Tratamientos")

    End Sub
End Class
