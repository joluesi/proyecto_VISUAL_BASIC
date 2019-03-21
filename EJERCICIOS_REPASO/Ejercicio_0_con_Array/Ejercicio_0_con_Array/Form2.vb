Public Class Form2
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If contador = 0 Then

            If (txtCodigo.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "" Or txtCodigo.Text = "") Then
                MsgBox("Antes debe introducir todos los datos de los Alumnos")

            ElseIf Not (IsNumeric(txtCodigo.Text)) Then
                MsgBox("Código ha de ser valor numérico")
                txtCodigo.Clear()

            ElseIf Not (IsNumeric(txtTelefono.Text)) Then
                MsgBox("Teléfono ha de ser valor numérico")
                txtTelefono.Clear()

            Else
                varAlumno(0).codAlum = CInt(txtCodigo.Text)
                varAlumno(0).nomAlum = txtNombre.Text
                varAlumno(0).apellAlum = txtApellido.Text
                varAlumno(0).telfAlum = CDbl(txtTelefono.Text)
                varAlumno(0).emailAlum = txtEmail.Text
                varAlumno(0).cursoAlum = txtCurso.Text

                MsgBox("Código: " & varAlumno(0).codAlum & vbCrLf & "Nombre: " & varAlumno(0).nomAlum & vbCrLf & "Apellido: " & varAlumno(0).apellAlum & vbCrLf &
                       "Teléfono: " & varAlumno(0).telfAlum & vbCrLf & "Email: " & varAlumno(0).emailAlum & vbCrLf & "Curso: " & varAlumno(0).cursoAlum)

            End If
        End If


        If contador = 1 Then

            If (txtCodigo.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "" Or txtCodigo.Text = "") Then
                MsgBox("Antes debe introducir todos los datos de los Alumnos")

            ElseIf Not (IsNumeric(txtCodigo.Text)) Then
                MsgBox("Código ha de ser valor numérico")
                txtCodigo.Clear()

            ElseIf Not (IsNumeric(txtTelefono.Text)) Then
                MsgBox("Teléfono ha de ser valor numérico")
                txtTelefono.Clear()

            Else
                varAlumno(1).codAlum = CInt(txtCodigo.Text)
                varAlumno(1).nomAlum = txtNombre.Text
                varAlumno(1).apellAlum = txtApellido.Text
                varAlumno(1).telfAlum = CDbl(txtTelefono.Text)
                varAlumno(1).emailAlum = txtEmail.Text
                varAlumno(1).cursoAlum = txtCurso.Text

                MsgBox("Código: " & varAlumno(1).codAlum & vbCrLf & "Nombre: " & varAlumno(1).nomAlum & vbCrLf & "Apellido: " & varAlumno(1).apellAlum & vbCrLf &
                       "Teléfono: " & varAlumno(1).telfAlum & vbCrLf & "Email: " & varAlumno(1).emailAlum & vbCrLf & "Curso: " & varAlumno(1).cursoAlum)

            End If
        End If


        If contador = 2 Then

            If (txtCodigo.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "" Or txtCodigo.Text = "") Then
                MsgBox("Antes debe introducir todos los datos de los Alumnos")

            ElseIf Not (IsNumeric(txtCodigo.Text)) Then
                MsgBox("Código ha de ser valor numérico")
                txtCodigo.Clear()

            ElseIf Not (IsNumeric(txtTelefono.Text)) Then
                MsgBox("Teléfono ha de ser valor numérico")
                txtTelefono.Clear()

            Else
                varAlumno(2).codAlum = CInt(txtCodigo.Text)
                varAlumno(2).nomAlum = txtNombre.Text
                varAlumno(2).apellAlum = txtApellido.Text
                varAlumno(2).telfAlum = CDbl(txtTelefono.Text)
                varAlumno(2).emailAlum = txtEmail.Text
                varAlumno(2).cursoAlum = txtCurso.Text

                MsgBox("Código: " & varAlumno(2).codAlum & vbCrLf & "Nombre: " & varAlumno(2).nomAlum & vbCrLf & "Apellido: " & varAlumno(2).apellAlum & vbCrLf &
                       "Teléfono: " & varAlumno(2).telfAlum & vbCrLf & "Email: " & varAlumno(2).emailAlum & vbCrLf & "Curso: " & varAlumno(2).cursoAlum)
            End If
        End If

        contador += 1
        btnLimpiar.PerformClick()

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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If Not (IsNumeric(txtNumAlumno.Text)) Then
            MsgBox("Introduzca número de alumno a consultar")
            'End If

        ElseIf txtNumAlumno.Text = 0 Then
            txtCodigo.Text = varAlumno(0).codAlum
            txtNombre.Text = varAlumno(0).nomAlum
            txtApellido.Text = varAlumno(0).apellAlum
            txtTelefono.Text = varAlumno(0).telfAlum
            txtEmail.Text = varAlumno(0).emailAlum
            txtCurso.Text = varAlumno(0).cursoAlum

            'End If

        ElseIf txtNumAlumno.Text = 1 Then
            txtCodigo.Text = varAlumno(1).codAlum
            txtNombre.Text = varAlumno(1).nomAlum
            txtApellido.Text = varAlumno(1).apellAlum
            txtTelefono.Text = varAlumno(1).telfAlum
            txtEmail.Text = varAlumno(1).emailAlum
            txtCurso.Text = varAlumno(1).cursoAlum

            'End If

        ElseIf txtNumAlumno.Text = 2 Then
            txtCodigo.Text = varAlumno(2).codAlum
            txtNombre.Text = varAlumno(2).nomAlum
            txtApellido.Text = varAlumno(2).apellAlum
            txtTelefono.Text = varAlumno(2).telfAlum
            txtEmail.Text = varAlumno(2).emailAlum
            txtCurso.Text = varAlumno(2).cursoAlum

        End If

        txtNumAlumno.Clear()

    End Sub
End Class