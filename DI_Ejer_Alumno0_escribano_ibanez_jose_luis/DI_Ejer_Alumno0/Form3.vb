Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCurso.Clear()
        txtNumAlu.Clear()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        ReDim Preserve alumnos(cont)

        alumnos(cont).codAlumno = CInt(txtCodigo.Text)
        alumnos(cont).nomAlumno = txtNombre.Text
        alumnos(cont).apellAlumno = txtApellido.Text
        alumnos(cont).telfAlumno = CInt(txtTelefono.Text)
        alumnos(cont).emailAlumno = txtEmail.Text
        alumnos(cont).cursoAlumno = txtCurso.Text

        MsgBox("Código: " & alumnos(cont).codAlumno & vbCrLf &
               "Nombre: " & alumnos(cont).nomAlumno & vbCrLf &
               "Apellidos: " & alumnos(cont).apellAlumno & vbCrLf &
               "Teléfono: " & alumnos(cont).telfAlumno & vbCrLf &
               "Email: " & alumnos(cont).emailAlumno & vbCrLf &
               "Curso: " & alumnos(cont).cursoAlumno)

        cont += 1
        btnLimpiar.PerformClick()
        GroupBox1.Visible = True

    End Sub

    Private Sub rbtnXNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnXNombre.CheckedChanged

        If (rbtnXNombre.Checked) Then
            lblNumAlu.Text = lblNombre.Text

        Else
            lblNumAlu.Text = lblCodigo.Text

        End If

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If (rbtnXNumero.Checked) Then

            If Val(txtNumAlu.Text) < 0 Or Val(txtNumAlu.Text) > (alumnos.Length - 1) Then
                MsgBox("El Alumno con código " & txtNumAlu.Text & " no existe")

            Else
                txtCodigo.Text = alumnos(Val(txtNumAlu.Text)).codAlumno
                txtNombre.Text = alumnos(Val(txtNumAlu.Text)).nomAlumno
                txtApellido.Text = alumnos(Val(txtNumAlu.Text)).apellAlumno
                txtTelefono.Text = alumnos(Val(txtNumAlu.Text)).telfAlumno
                txtEmail.Text = alumnos(Val(txtNumAlu.Text)).emailAlumno
                txtCurso.Text = alumnos(Val(txtNumAlu.Text)).cursoAlumno

            End If

        Else

            Dim encontrado As Boolean = False

            For Each alumno As ALUMNO In alumnos

                If txtNumAlu.Text = alumno.nomAlumno Then

                    txtCodigo.Text = alumno.codAlumno
                    txtNombre.Text = alumno.nomAlumno
                    txtApellido.Text = alumno.apellAlumno
                    txtTelefono.Text = alumno.telfAlumno
                    txtEmail.Text = alumno.emailAlumno
                    txtCurso.Text = alumno.cursoAlumno

                    encontrado = True

                End If

            Next

            If encontrado = False Then
                MsgBox("Nombre de alumno no encontrado")
            End If

        End If

    End Sub

End Class