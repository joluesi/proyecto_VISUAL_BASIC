Public Class Form2

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If cont = 0 Then
            alumno0.codAlumno = CInt(txtCodigo.Text)
            alumno0.nomAlumno = txtNombre.Text
            alumno0.apellAlumno = txtApellido.Text
            alumno0.telfAlumno = txtTelefono.Text
            alumno0.emailAlumno = txtEmail.Text
            alumno0.cursoAlumno = txtCurso.Text

            MsgBox("Código: " & alumno0.codAlumno & vbCrLf & "Nombre: " & alumno0.nomAlumno & vbCrLf & "Apellido: " & alumno0.apellAlumno & vbCrLf &
                   "Teléfono: " & alumno0.telfAlumno & vbCrLf & "Email: " & alumno0.emailAlumno & vbCrLf & "Curso: " & alumno0.cursoAlumno)
        End If

        If cont = 1 Then
            alumno1.codAlumno = CInt(txtCodigo.Text)
            alumno1.nomAlumno = txtNombre.Text
            alumno1.apellAlumno = txtApellido.Text
            alumno1.telfAlumno = txtTelefono.Text
            alumno1.emailAlumno = txtEmail.Text
            alumno1.cursoAlumno = txtCurso.Text
            MsgBox("Código: " & alumno1.codAlumno & vbCrLf & "Nombre: " & alumno1.nomAlumno & vbCrLf & "Apellido: " & alumno1.apellAlumno & vbCrLf &
                   "Teléfono: " & alumno1.telfAlumno & vbCrLf & "Email: " & alumno1.emailAlumno & vbCrLf & "Curso: " & alumno1.cursoAlumno)
        End If

        If cont = 2 Then
            alumno2.codAlumno = CInt(txtCodigo.Text)
            alumno2.nomAlumno = txtNombre.Text
            alumno2.apellAlumno = txtApellido.Text
            alumno2.telfAlumno = txtTelefono.Text
            alumno2.emailAlumno = txtEmail.Text
            alumno2.cursoAlumno = txtCurso.Text
            MsgBox("Código: " & alumno2.codAlumno & vbCrLf & "Nombre: " & alumno2.nomAlumno & vbCrLf & "Apellido: " & alumno2.apellAlumno & vbCrLf &
                   "Teléfono: " & alumno2.telfAlumno & vbCrLf & "Email: " & alumno2.emailAlumno & vbCrLf & "Curso: " & alumno2.cursoAlumno)
        End If

        btnLimpiar.PerformClick()
        cont += 1
        GroupBox1.Visible = True


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCurso.Clear()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub lblNomUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblNomUsuario.TextChanged
        lblNomUsuario.Text = nomUsuario

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If txtNumAlum.Text = 0 Then
            txtCodigo.Text = alumno0.codAlumno
            txtNombre.Text = alumno0.nomAlumno
            txtApellido.Text = alumno0.apellAlumno
            txtTelefono.Text = alumno0.telfAlumno
            txtEmail.Text = alumno0.emailAlumno
            txtCurso.Text = alumno0.cursoAlumno
        End If

        If txtNumAlum.Text = 1 Then
            txtCodigo.Text = alumno1.codAlumno
            txtNombre.Text = alumno1.nomAlumno
            txtApellido.Text = alumno1.apellAlumno
            txtTelefono.Text = alumno1.telfAlumno
            txtEmail.Text = alumno1.emailAlumno
            txtCurso.Text = alumno1.cursoAlumno
        End If

        If txtNumAlum.Text = 2 Then
            txtCodigo.Text = alumno2.codAlumno
            txtNombre.Text = alumno2.nomAlumno
            txtApellido.Text = alumno2.apellAlumno
            txtTelefono.Text = alumno2.telfAlumno
            txtEmail.Text = alumno2.emailAlumno
            txtCurso.Text = alumno2.cursoAlumno
        End If

    End Sub

End Class