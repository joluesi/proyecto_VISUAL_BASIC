Public Class Form2
    Public Class Form2

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            ReDim Preserve Alumno(cont)
            Alumno(cont).codAlumno = CInt(txtCodigo.Text)
            Alumno(cont).nomAlumno = txtNombre.Text
            Alumno(cont).apellAlumno = txtApellido.Text
            Alumno(cont).telfAlumno = txtTelefono.Text
            Alumno(cont).emailAlumno = txtEmail.Text
            Alumno(cont).cursoAlumno = txtCurso.Text

            MsgBox("Código: " & Alumno(cont).codAlumno & vbCrLf & "Nombre: " & Alumno(cont).nomAlumno & vbCrLf & "Apellido: " & Alumno(cont).apellAlumno & vbCrLf &
                   "Teléfono: " & Alumno(cont).telfAlumno & vbCrLf & "Email: " & Alumno(cont).emailAlumno & vbCrLf & "Curso: " & Alumno(cont).cursoAlumno)

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
            txtNumAlum.Clear()


        End Sub

        Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
            Me.Hide()
            Form1.Show()

        End Sub

        Private Sub lblNomUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblNomUsuario.TextChanged
            lblNomUsuario.Text = nomUsuario

        End Sub

        Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

            txtCodigo.Text = Alumno(Val(txtNumAlum.Text)).codAlumno
            txtNombre.Text = Alumno(Val(txtNumAlum.Text)).nomAlumno
            txtApellido.Text = Alumno(Val(txtNumAlum.Text)).apellAlumno
            txtTelefono.Text = Alumno(Val(txtNumAlum.Text)).telfAlumno
            txtEmail.Text = Alumno(Val(txtNumAlum.Text)).emailAlumno
            txtCurso.Text = Alumno(Val(txtNumAlum.Text)).cursoAlumno

            btnLimpiar.PerformClick()

        End Sub


    End Class