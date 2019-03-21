
Public Class Form2


    Private Sub lblNomUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblNomUsuario.TextChanged
        lblNomUsuario.Text = nomUsuario

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ReDim Preserve Alumnos(cont)
        Alumnos(cont).codAlumno = CInt(txtCodigo.Text)
        Alumnos(cont).nomAlumno = txtNombre.Text
        Alumnos(cont).apellAlumno = txtApellido.Text
        Alumnos(cont).telfAlumno = txtTelefono.Text
        Alumnos(cont).emailAlumno = txtEmail.Text
        Alumnos(cont).cursoAlumno = txtCurso.Text

        MsgBox("Código: " & Alumnos(cont).codAlumno & vbCrLf & "Nombre: " & Alumnos(cont).nomAlumno & vbCrLf & "Apellido: " & Alumnos(cont).apellAlumno & vbCrLf &
           "Teléfono: " & Alumnos(cont).telfAlumno & vbCrLf & "Email: " & Alumnos(cont).emailAlumno & vbCrLf & "Curso: " & Alumnos(cont).cursoAlumno)

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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If Val(txtNumAlum.Text) > (Alumnos.Length - 1) Then  '-1 porque resto una posición al array'
            MsgBox("El alumno " & txtNombre.Text & "no existe.")

        End If

        txtCodigo.Text = Alumnos(Val(txtNumAlum.Text)).codAlumno
        txtNombre.Text = Alumnos(Val(txtNumAlum.Text)).nomAlumno
        txtApellido.Text = Alumnos(Val(txtNumAlum.Text)).apellAlumno
        txtTelefono.Text = Alumnos(Val(txtNumAlum.Text)).telfAlumno
        txtEmail.Text = Alumnos(Val(txtNumAlum.Text)).emailAlumno
        txtCurso.Text = Alumnos(Val(txtNumAlum.Text)).cursoAlumno


        btnLimpiar.PerformClick()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
