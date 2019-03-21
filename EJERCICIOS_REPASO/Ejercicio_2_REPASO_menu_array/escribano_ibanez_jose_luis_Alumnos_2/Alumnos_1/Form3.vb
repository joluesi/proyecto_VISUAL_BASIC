Public Class Form3


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmAlumnos.Show()

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

        ReDim Preserve varAlumnos(cont)
        varAlumnos(cont).codAlumno = cont

        If (txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Or txtEmail.Text = "" Or txtCurso.Text = "") Then
            MsgBox("Antes debe introducir todos los datos de los Alumnos")

        ElseIf Not (IsNumeric(txtTelefono.Text)) Then
            MsgBox("Teléfono ha de ser valor numérico")
            txtTelefono.Clear()

        Else
            'varAlumnos(cont).codAlum = CInt(txtCodigo.Text)
            varAlumnos(cont).nomAlumno = txtNombre.Text
            varAlumnos(cont).apellAlumno = txtApellido.Text
            varAlumnos(cont).telfAlumno = CDbl(txtTelefono.Text)
            varAlumnos(cont).emailAlumno = txtEmail.Text
            varAlumnos(cont).cursoAlumno = txtCurso.Text

            MsgBox("Código: " & varAlumnos(cont).codAlumno & vbCrLf & "Nombre: " & varAlumnos(cont).nomAlumno & vbCrLf & "Apellido: " & varAlumnos(cont).apellAlumno & vbCrLf &
                   "Teléfono: " & varAlumnos(cont).telfAlumno & vbCrLf & "Email: " & varAlumnos(cont).emailAlumno & vbCrLf & "Curso: " & varAlumnos(cont).cursoAlumno)

        End If

        cont += 1
        GroupBox1.Visible = True

        Dim respuesta = MsgBox("¿Desea introducir otro alumno?", vbYesNo)
            If (respuesta = vbYes) Then
                btnLimpiar.PerformClick()
                txtNombre.Select()
            Else
                Me.Hide()
                frmAlumnos.Show()

            End If

    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        'Consulta por número de alumno (código)
        'If Val(txtNumAlu.Text) < 0 Or Val(txtNumAlu.Text) > (varAlumnos.Length - 1) Then
        '    MsgBox("El Alumno con código " & txtNumAlu.Text & " no existe")

        'Else
        '    txtCodigo.Text = varAlumnos(Val(txtNumAlu.Text)).codAlumno
        '    txtNombre.Text = varAlumnos(Val(txtNumAlu.Text)).nomAlumno
        '    txtApellido.Text = varAlumnos(Val(txtNumAlu.Text)).apellAlumno
        '    txtTelefono.Text = varAlumnos(Val(txtNumAlu.Text)).telfAlumno
        '    txtEmail.Text = varAlumnos(Val(txtNumAlu.Text)).emailAlumno
        '    txtCurso.Text = varAlumnos(Val(txtNumAlu.Text)).cursoAlumno

        'End If


        Dim encontrado As Boolean = False

        For Each alumno As ALUMNO In varAlumnos

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