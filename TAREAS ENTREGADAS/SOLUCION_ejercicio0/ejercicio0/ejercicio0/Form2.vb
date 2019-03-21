Public Class Form2
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Static cont As Integer
        If cont = 0 Then
            varAlumno0.codAlum = CInt(txtCodigo.Text)
            varAlumno0.nomAlum = txtNombre.Text
            MsgBox("Codigo: " & varAlumno0.codAlum & vbCrLf & "Nombre: " & varAlumno0.nomAlum)
        End If
        If cont = 1 Then
            varAlumno1.codAlum = CInt(txtCodigo.Text)
            varAlumno1.nomAlum = txtNombre.Text
            MsgBox("Codigo: " & varAlumno1.codAlum & vbCrLf & "Nombre: " & varAlumno1.nomAlum)
        End If
        If cont = 2 Then
            varAlumno2.codAlum = CInt(txtCodigo.Text)
            varAlumno2.nomAlum = txtNombre.Text
            MsgBox("Codigo: " & varAlumno2.codAlum & vbCrLf & "Nombre: " & varAlumno2.nomAlum)
        End If
        btnLimpiar.PerformClick()
        cont += 1
        grpConsulta.Visible = True
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtCodigo.Clear()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If Val(txtNumAlu.Text) >= 0 And Val(txtNumAlu.Text) < 3 Then

            If txtNumAlu.Text = 0 Then
                txtCodigo.Text = varAlumno0.codAlum
                txtNombre.Text = varAlumno0.nomAlum
            End If
            If txtNumAlu.Text = 1 Then
                txtCodigo.Text = varAlumno1.codAlum
                txtNombre.Text = varAlumno1.nomAlum
            End If
            If txtNumAlu.Text = 2 Then
                txtCodigo.Text = varAlumno2.codAlum
                txtNombre.Text = varAlumno2.nomAlum
            End If

        Else
            MsgBox("datos incorrecto")
            btnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNumAlu_TextChanged(sender As Object, e As EventArgs) Handles txtNumAlu.TextChanged

    End Sub
End Class