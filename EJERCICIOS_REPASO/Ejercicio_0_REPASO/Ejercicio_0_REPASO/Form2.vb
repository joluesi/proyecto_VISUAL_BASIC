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
                varAlumno0.codAlum = CInt(txtCodigo.Text)
                varAlumno0.nomAlum = txtNombre.Text
                varAlumno0.apellAlum = txtApellido.Text
                varAlumno0.telfAlum = CDbl(txtTelefono.Text)
                varAlumno0.emailAlum = txtEmail.Text
                varAlumno0.cursoAlum = txtCurso.Text

                MsgBox("Código: " & varAlumno0.codAlum & vbCrLf & "Nombre: " & varAlumno0.nomAlum & vbCrLf & "Apellido: " & varAlumno0.apellAlum & vbCrLf &
                       "Teléfono: " & varAlumno0.telfAlum & vbCrLf & "Email: " & varAlumno0.emailAlum & vbCrLf & "Curso: " & varAlumno0.cursoAlum)

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
                varAlumno1.codAlum = CInt(txtCodigo.Text)
                varAlumno1.nomAlum = txtNombre.Text
                varAlumno1.apellAlum = txtApellido.Text
                varAlumno1.telfAlum = CDbl(txtTelefono.Text)
                varAlumno1.emailAlum = txtEmail.Text
                varAlumno1.cursoAlum = txtCurso.Text

                MsgBox("Código: " & varAlumno1.codAlum & vbCrLf & "Nombre: " & varAlumno1.nomAlum & vbCrLf & "Apellido: " & varAlumno1.apellAlum & vbCrLf &
                       "Teléfono: " & varAlumno1.telfAlum & vbCrLf & "Email: " & varAlumno1.emailAlum & vbCrLf & "Curso: " & varAlumno1.cursoAlum)

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
                varAlumno2.codAlum = CInt(txtCodigo.Text)
                varAlumno2.nomAlum = txtNombre.Text
                varAlumno2.apellAlum = txtApellido.Text
                varAlumno2.telfAlum = CDbl(txtTelefono.Text)
                varAlumno2.emailAlum = txtEmail.Text
                varAlumno2.cursoAlum = txtCurso.Text

                MsgBox("Código: " & varAlumno2.codAlum & vbCrLf & "Nombre: " & varAlumno2.nomAlum & vbCrLf & "Apellido: " & varAlumno2.apellAlum & vbCrLf &
                       "Teléfono: " & varAlumno2.telfAlum & vbCrLf & "Email: " & varAlumno2.emailAlum & vbCrLf & "Curso: " & varAlumno2.cursoAlum)
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

        If txtNumAlumno.Text = 0 Then
            txtCodigo.Text = varAlumno0.codAlum
            txtNombre.Text = varAlumno0.nomAlum
            txtApellido.Text = varAlumno0.apellAlum
            txtTelefono.Text = varAlumno0.telfAlum
            txtEmail.Text = varAlumno0.emailAlum
            txtCurso.Text = varAlumno0.cursoAlum

        End If

        If txtNumAlumno.Text = 1 Then
            txtCodigo.Text = varAlumno1.codAlum
            txtNombre.Text = varAlumno1.nomAlum
            txtApellido.Text = varAlumno1.apellAlum
            txtTelefono.Text = varAlumno1.telfAlum
            txtEmail.Text = varAlumno1.emailAlum
            txtCurso.Text = varAlumno1.cursoAlum

        End If

        If txtNumAlumno.Text = 2 Then
            txtCodigo.Text = varAlumno2.codAlum
            txtNombre.Text = varAlumno2.nomAlum
            txtApellido.Text = varAlumno2.apellAlum
            txtTelefono.Text = varAlumno2.telfAlum
            txtEmail.Text = varAlumno2.emailAlum
            txtCurso.Text = varAlumno2.cursoAlum

        End If

    End Sub
End Class