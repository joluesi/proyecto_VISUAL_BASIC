Public Class Form2
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        ReDim Preserve varAlumno(cont)

        If (txtCodigo.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "" Or txtCodigo.Text = "") Then
            MsgBox("Antes debe introducir todos los datos de los Alumnos")

        ElseIf Not (IsNumeric(txtCodigo.Text)) Then
            MsgBox("Código ha de ser valor numérico")
            txtCodigo.Clear()

        ElseIf Not (IsNumeric(txtTelefono.Text)) Then
            MsgBox("Teléfono ha de ser valor numérico")
            txtTelefono.Clear()

        Else
            varAlumno(cont).codAlum = CInt(txtCodigo.Text)
            varAlumno(cont).nomAlum = txtNombre.Text
            varAlumno(cont).apellAlum = txtApellido.Text
            varAlumno(cont).telfAlum = CDbl(txtTelefono.Text)
            varAlumno(cont).emailAlum = txtEmail.Text
            varAlumno(cont).cursoAlum = txtCurso.Text

            MsgBox("Código: " & varAlumno(cont).codAlum & vbCrLf & "Nombre: " & varAlumno(cont).nomAlum & vbCrLf & "Apellido: " & varAlumno(cont).apellAlum & vbCrLf &
                   "Teléfono: " & varAlumno(cont).telfAlum & vbCrLf & "Email: " & varAlumno(cont).emailAlum & vbCrLf & "Curso: " & varAlumno(cont).cursoAlum)

        End If

        cont += 1
        btnLimpiar.PerformClick()
        gbxConsulta.Visible = True

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

        If rbtn_NºAlum.Checked Then

            If Not (IsNumeric(txtAlumno.Text)) Then
                MsgBox("Introduzca número de alumno a consultar")

            ElseIf (Val(txtAlumno.text) < 0 Or (Val(txtAlumno.text) > varAlumno.Length - 1)) Then
                MsgBox("El Alumno con número de orden " & txtAlumno.Text & " no existe")

            Else
                txtCodigo.Text = varAlumno(Val(txtAlumno.Text)).codAlum
                txtNombre.Text = varAlumno(Val(txtAlumno.Text)).nomAlum
                txtApellido.Text = varAlumno(Val(txtAlumno.Text)).apellAlum
                txtTelefono.Text = varAlumno(Val(txtAlumno.Text)).telfAlum
                txtEmail.Text = varAlumno(Val(txtAlumno.Text)).emailAlum
                txtCurso.Text = varAlumno(Val(txtAlumno.Text)).cursoAlum

            End If

        Else
            alumnoEncontrado = False

            For Each alumno As ALUMNO In varAlumno

                If txtAlumno.Text = alumno.nomAlum Then

                    txtCodigo.Text = alumno.codAlum
                    txtNombre.Text = alumno.nomAlum
                    txtApellido.Text = alumno.apellAlum
                    txtTelefono.Text = alumno.telfAlum
                    txtEmail.Text = alumno.emailAlum
                    txtCurso.Text = alumno.cursoAlum

                    alumnoEncontrado = True

                End If

            Next

            If alumnoEncontrado = False Then
                MsgBox("El alumno con nombre " & txtAlumno.Text & " no ha sido encontrado")

            End If

        End If

        txtAlumno.Clear()

    End Sub

    Private Sub rbtn_NºAlum_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_NºAlum.CheckedChanged

        If rbtn_NºAlum.Checked Then
            lblXConsulta.Text = "Número Alumno: "

        ElseIf rbtn_NombreAlum.Checked Then
            lblXConsulta.Text = "Nombre Alumno: "

        End If

    End Sub
End Class