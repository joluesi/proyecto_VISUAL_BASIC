Public Class Form3


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = cont
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim alumnoGuardado As Boolean = False
        If txtNombre.Text = "" Then
            MsgBox("Introduce un nombre. Los datos no han sido guardados")
            txtNombre.Clear()
            txtNombre.Select()
        ElseIf IsNumeric(txtNombre.Text) Then
            MsgBox("Introduce un nombre correcto. Los datos no han sido guardados")
            txtNombre.Clear()
            txtNombre.Select()
        Else
            If txtApellidos.Text = "" Then
                MsgBox("Introduce un apellido. Los datos no han sido guardados")
                txtApellidos.Clear()
                txtApellidos.Select()
            ElseIf IsNumeric(txtApellidos.Text) Then
                MsgBox("Introduce un apellido correcto. Los datos no han sido guardados")
                txtApellidos.Clear()
                txtApellidos.Select()
            Else
                If txtTelefono.Text = "" Then
                    MsgBox("Introduce un teléfono. Los datos no han sido guardados")
                    txtTelefono.Text = ""
                    txtTelefono.Select()
                ElseIf IsNumeric(txtTelefono.Text) Then

                    If txtEmail.Text = "" Then
                        MsgBox("Introduce un email. Los datos no han sido guardados")
                        txtEmail.Clear()
                        txtEmail.Select()
                    ElseIf IsNumeric(txtEmail.Text) Then
                        MsgBox("Introduce un email correcto. Los datos no han sido guardados")
                        txtEmail.Clear()
                        txtEmail.Select()
                    Else
                        If txtCurso.Text = "" Then
                            MsgBox("Introduce un curso. Los datos no han sido guardados")
                            txtCurso.Text = ""
                            txtCurso.Select()
                        ElseIf Not txtCurso.Text = "" Then
                            ReDim Preserve alumnos(cont)
                            alumnos(cont).codAlumno = cont.ToString
                            alumnos(cont).nomAlumno = txtNombre.Text
                            alumnos(cont).apelAlumno = txtApellidos.Text
                            alumnos(cont).telAlumno = txtTelefono.Text
                            alumnos(cont).emailAlumno = txtEmail.Text
                            alumnos(cont).cursoAlumno = txtCurso.Text
                            alumnoGuardado = True
                            MsgBox("Datos guardados correctamente.")
                        Else
                            MsgBox("Introduce un curso correcto. Los datos no han sido guardados")
                            txtCurso.Clear()
                            txtCurso.Select()
                        End If
                    End If
                Else
                    MsgBox("Introduce un teléfono correcto. Los datos no han sido guardados")
                    txtTelefono.Text = ""
                    txtTelefono.Select()
                End If
            End If
        End If

        If alumnoGuardado Then
            cont += 1
            Dim respuesta As Integer = MsgBox("Quieres introducir otro alumno?", vbYesNo)


            If respuesta = vbYes Then
                btnLimpiar.PerformClick()
                txtNombre.Select()
            Else
                btnLimpiar.PerformClick()
                Me.Hide()
                Form2.Show()
            End If
        End If




    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCurso.Clear()

    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class