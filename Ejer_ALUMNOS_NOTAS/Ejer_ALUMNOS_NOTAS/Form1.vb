Public Class Form1
    Private Sub AltaDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeAlumnosToolStripMenuItem.Click
        AltaAlumnos.Show()

    End Sub

    Private Sub IntroducirNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirNotasToolStripMenuItem.Click
        AltaNotas.Show()
        borrarAltaNotas()
        AltaNotas.txtCodCurso.ReadOnly = False

    End Sub

    Private Sub ConsultarEditarNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEditarNotasToolStripMenuItem.Click
        ConsultaNotas.Show()
        borrarConsultaNotas()
        ConsultaNotas.txtCodAlumno.ReadOnly = False
        ConsultaNotas.btnConsultar.Visible = True
        ConsultaNotas.btnEditar.Visible = False
        ConsultaNotas.txtNotaMod5.Visible = False
        ConsultaNotas.txtNotaMod6.Visible = False
        ConsultaNotas.txtNotaMod7.Visible = False
        ConsultaNotas.txtNotaMod8.Visible = False

    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnoToolStripMenuItem.Click

        Dim opcion = InputBox("Introduzca el codigo del Alumno")

        Dim encontrado As Boolean = False

        For Each alum In coleccionALUMNOS
            If alum.P_cod_alum = opcion Then
                encontrado = True
            End If
        Next

        If encontrado Then
            NotasAlumno.Show()
            NotasAlumno.rtxtbox_NotasAlumno.Clear()

            NotasAlumno.rtxtbox_NotasAlumno.Text = "CURSO: " & coleccionAluNotas(opcion).P_cod_curso & "     CICLO: " & coleccionALUMNOS(opcion).P_cod_ciclo & "   CÓDIGO ALUMNO: " & opcion & "      NOMBRE: " & coleccionALUMNOS(opcion).P_nom_alum & vbNewLine
            NotasAlumno.rtxtbox_NotasAlumno.Text += "   MODULO " & "               NOTA " & "                RECUPERACIÓN " & vbNewLine

            'opción sin utilizar la función mostrarNotas()
            'modulos_ciclo(coleccionAluNotas(opcion).P_cod_curso)

            'For i = 0 To 3
            '    NotasAlumno.rtxtbox_NotasAlumno.Text += "           " & arrayModulos(i) & "                         " & coleccionAluNotas(opcion).P_Array_nota(i) & "                       " & coleccionAluNotas(opcion).P_Array_recu(i) & vbNewLine
            'Next
            'NotasAlumno.rtxtbox_NotasAlumno.Text += "NOTA MEDIA:            " & calMedia(coleccionAluNotas(opcion).P_Array_nota) & "                " & calMedia(coleccionAluNotas(opcion).P_Array_recu) & vbNewLine

            'otra opción, usando la función mostrarNotas()
            mostrarNotas(opcion)
            NotasAlumno.rtxtbox_NotasAlumno.Text += "NOTA MEDIA:            " & calMedia(coleccionAluNotas(opcion).P_Array_nota) & "                " & calMedia(coleccionAluNotas(opcion).P_Array_recu) & vbNewLine


        End If


    End Sub

    Private Sub CursoNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursoNotasToolStripMenuItem.Click
        NotasCurso.Visible = True

    End Sub
End Class
