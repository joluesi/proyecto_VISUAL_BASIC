Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        ReDim Preserve varAlumno(cont)

        If (txtAlumno.Text = "" Or txtNota1.Text = "" Or txtNota2.Text = "" Or txtNota3.Text = "" Or txtNota4.Text = "") Then
            MsgBox("Antes debe introducir todos los datos del Alumno")

        ElseIf Not (IsNumeric(txtNota1.Text) And (IsNumeric(txtNota2.Text)) And (IsNumeric(txtNota3.Text)) And (IsNumeric(txtNota4.Text))) Then
            MsgBox("Las notas han de ser valores numéricos")

        ElseIf ((txtNota1.Text < 0 Or txtNota1.Text > 20) Or
               (txtNota2.Text < 0 Or txtNota2.Text > 20) Or
               (txtNota3.Text < 0 Or txtNota3.Text > 20) Or
               (txtNota4.Text < 0 Or txtNota4.Text > 20)) Then
            MsgBox("Las notas han de estar comprendidas entre 0 y 20")

        Else
            varAlumno(cont).nombreAlumno = txtAlumno.Text
            varAlumno(cont).nota1Alumno = Val(txtNota1.Text)
            varAlumno(cont).nota2Alumno = Val(txtNota2.Text)
            varAlumno(cont).nota3Alumno = Val(txtNota3.Text)
            varAlumno(cont).nota4Alumno = Val(txtNota4.Text)


            txtPromedio.Text = (Val(txtNota1.Text) + Val(txtNota2.Text) + Val(txtNota3.Text) + Val(txtNota4.Text)) / 4

            If Val(txtPromedio.Text) >= 0 And Val(txtPromedio.Text <= 5) Then
                txtPuntuacion.Text = "E"
            ElseIf Val(txtPromedio.Text) >= 6 And Val(txtPromedio.Text) <= 10 Then
                txtPuntuacion.Text = "D"
            ElseIf Val(txtPromedio.Text) >= 11 And Val(txtPromedio.Text) <= 15 Then
                txtPuntuacion.Text = "C"
            ElseIf Val(txtPromedio.Text) >= 16 And Val(txtPromedio.Text) <= 18 Then
                txtPuntuacion.Text = "B"
            ElseIf Val(txtPromedio.Text) >= 19 And Val(txtPromedio.Text) <= 20 Then
                txtPuntuacion.Text = "A"
            Else
                MsgBox("Datos erróneos")

            End If

            varAlumno(cont).promAlumno = Val(txtPromedio.Text)
            varAlumno(cont).puntAlumno = Val(txtPromedio.Text)


        End If

        cont += 1
        gbxConsulta.Visible = True

        Dim respuesta = MsgBox("¿Desea introducir otro alumno?", vbYesNo)

        If respuesta = vbYes Then
            btnLimpiar.PerformClick()
            txtAlumno.Select()
        Else
            MsgBox("OK")
            btnLimpiar.PerformClick()
        End If

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Dim alumnoEncontrado As Boolean

        alumnoEncontrado = False

        For Each alumno As ALUMNO In varAlumno

            If (txtConsulta.Text = alumno.nombreAlumno) Then

                txtAlumno.Text = alumno.nombreAlumno
                txtNota1.Text = alumno.nota1Alumno
                txtNota2.Text = alumno.nota2Alumno
                txtNota3.Text = alumno.nota3Alumno
                txtNota4.Text = alumno.nota4Alumno
                txtPromedio.Text = alumno.promAlumno
                txtPuntuacion.Text = alumno.puntAlumno

                alumnoEncontrado = True

            End If

        Next

        If alumnoEncontrado = False Then
            MsgBox("Alumno no encontrado")

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtAlumno.Text = ""
        txtNota1.Text = ""
        txtNota2.Text = ""
        txtNota3.Text = ""
        txtNota4.Text = ""
        txtPromedio.Text = ""
        txtPuntuacion.Text = ""

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        MsgBox("Adiós¡¡")
        Application.Exit()


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Menu_Alumnos.Show()

    End Sub
End Class
