Public Class Form4
    Public codigoReal As Integer

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Dim encontrado As Boolean = False
        If txtNuAlum.Text = "" Then
            MsgBox("Introduce el nombre de un alumno")
            txtConsCodigo.Clear()
            txtConsNombre.Clear()
            txtConsApel.Clear()
            txtConsTelef.Clear()
            txtConsEmail.Clear()
            txtConsCurso.Clear()
        Else
            For index = 0 To alumnos.Length - 1
                If txtNuAlum.Text = alumnos(index).nomAlumno Then
                    codigoReal = alumnos(index).codAlumno
                    encontrado = True
                End If
            Next
        End If

        If encontrado = False Then
            MsgBox("Nombre de alumno no encontrado")
            txtConsCodigo.Clear()
            txtConsNombre.Clear()
            txtConsApel.Clear()
            txtConsTelef.Clear()
            txtConsEmail.Clear()
            txtConsCurso.Clear()
        Else
            For i = 0 To alumnos.Length - 1
                If alumnos(i).codAlumno = codigoReal Then
                    txtConsCodigo.Text = alumnos(i).codAlumno
                    txtConsNombre.Text = alumnos(i).nomAlumno
                    txtConsApel.Text = alumnos(i).apelAlumno
                    txtConsTelef.Text = alumnos(i).telAlumno
                    txtConsEmail.Text = alumnos(i).emailAlumno
                    txtConsCurso.Text = alumnos(i).cursoAlumno
                End If
            Next
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If IsNothing(alumnos(txtConsCodigo.Text)) Then
            MsgBox("El código no es correcto. Los datos no han sido guardados")
            txtConsCodigo.Clear()
        Else
            If txtConsNombre.Text = "" Then
                MsgBox("Introduce un nombre. Los datos no han sido guardados")
                txtConsNombre.Clear()
            ElseIf IsNumeric(txtConsNombre.Text) Then
                MsgBox("Introduce un nombre correcto. Los datos no han sido guardados")
                txtConsNombre.Clear()
            Else
                If txtConsApel.Text = "" Then
                    MsgBox("Introduce un apellido. Los datos no han sido guardados")
                    txtConsApel.Clear()
                ElseIf IsNumeric(txtConsApel.Text) Then
                    MsgBox("Introduce un apellido correcto. Los datos no han sido guardados")
                    txtConsApel.Clear()
                Else
                    If txtConsTelef.Text = "" Then
                        MsgBox("Introduce un teléfono. Los datos no han sido guardados")
                        txtConsTelef.Clear()
                    ElseIf IsNumeric(txtConsTelef.Text) Then

                        If txtConsEmail.Text = "" Then
                            MsgBox("Introduce un email. Los datos no han sido guardados")
                            txtConsEmail.Clear()
                        ElseIf IsNumeric(txtConsEmail.Text) Then
                            MsgBox("Introduce un email correcto. Los datos no han sido guardados")
                            txtConsEmail.Clear()
                        Else
                            If txtConsCurso.Text = "" Then
                                MsgBox("Introduce un curso. Los datos no han sido guardados")
                                txtConsCurso.Clear()
                            ElseIf IsNumeric(txtConsCurso.Text) Then
                                alumnos(txtConsCodigo.Text).nomAlumno = txtConsNombre.Text
                                alumnos(txtConsCodigo.Text).apelAlumno = txtConsApel.Text
                                alumnos(txtConsCodigo.Text).telAlumno = txtConsTelef.Text
                                alumnos(txtConsCodigo.Text).emailAlumno = txtConsEmail.Text
                                alumnos(txtConsCodigo.Text).cursoAlumno = txtConsCurso.Text

                                MsgBox("Datos guardados correctamente.")
                            Else
                                MsgBox("Introduce un curso correcto. Los datos no han sido guardados")
                                txtConsCurso.Clear()
                            End If
                        End If
                    Else
                        MsgBox("Introduce un teléfono correcto. Los datos no han sido guardados")
                        txtConsTelef.Clear()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        txtNuAlum.Clear()
        txtConsCodigo.Clear()
        txtConsNombre.Clear()
        txtConsApel.Clear()
        txtConsTelef.Clear()
        txtConsEmail.Clear()
        txtConsCurso.Clear()
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtConsCodigo_Click(sender As Object, e As EventArgs) Handles txtConsCodigo.Click
        txtConsCodigo.Text = codigoReal
        MsgBox("No puedes cambiar el código del alumno")

    End Sub
End Class