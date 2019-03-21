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

        Dim alumnoGuardado As Boolean = False
        ReDim Preserve alumnos(cont)
        alumnos(cont).codAlumno = cont

        If (txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "" Or txtCurso.Text = "") Then
            MsgBox("Antes debe completar todos los casilleros")

        ElseIf (IsNumeric(txtNombre.Text) Or IsNumeric(txtApellido.Text) Or IsNumeric(txtEmail.Text) Or IsNumeric(txtCurso.Text)) Then
            MsgBox("Error. Nombre, apellidos, Email y Curso no pueden ser valores numéricos")

        ElseIf Not IsNumeric(txtTelefono.Text) Then
            MsgBox("Error. Teléfono debe ser valores numéricos")
            txtTelefono.Clear()

        Else
            alumnoGuardado = True

        End If

        If (alumnoGuardado) Then

            'alumnos(cont).codAlumno = CInt(txtCodigo.Text)
            alumnos(cont).nomAlumno = txtNombre.Text
            alumnos(cont).apellAlumno = txtApellido.Text
            alumnos(cont).telfAlumno = CInt(txtTelefono.Text)
            alumnos(cont).emailAlumno = txtEmail.Text
            alumnos(cont).cursoAlumno = txtCurso.Text


            MsgBox("Código: " & alumnos(cont).codAlumno &
           ", Nombre: " & alumnos(cont).nomAlumno &
           ", Apellidos: " & alumnos(cont).apellAlumno &
           ", Teléfono: " & alumnos(cont).telfAlumno &
           ", Email: " & alumnos(cont).emailAlumno &
           ", Curso: " & alumnos(cont).cursoAlumno)

            cont += 1

            Dim respuesta = MsgBox("¿Desea introducir otro alumno?", vbYesNo)
            If (respuesta = vbYes) Then
                btnLimpiar.PerformClick()
                txtNombre.Select()
            Else
                Me.Hide()
                frmAlumnos.Show()

            End If

            GroupBox1.Visible = True

        End If

    End Sub



    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

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


    End Sub

    Private Sub btn_Salir_Consultas_Click(sender As Object, e As EventArgs) Handles btn_Salir_Consultas.Click
        Me.Hide()
        frmAlumnos.Show()

    End Sub

    Private Sub btn_Fin_Click(sender As Object, e As EventArgs) Handles btn_Fin.Click
        MsgBox("¡¡¡Que tengas un buen día!!!")
        Me.Close()

    End Sub
End Class