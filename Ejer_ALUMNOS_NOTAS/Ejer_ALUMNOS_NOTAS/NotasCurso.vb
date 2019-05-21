Public Class NotasCurso

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Dim encontrado As Boolean = False

        Dim codCurso As String = cmb_Curso.SelectedItem
        rtxtbox_NotasCurso.Clear()
        rtxtbox_NotasCurso.Visible = True
        If cmb_Curso.SelectedItem <> "" Then
            If codCurso.Equals(codCurso) Then
                For Each alumno In coleccionAluNotas
                    If alumno.P_cod_curso.Equals(codCurso) Then
                        encontrado = True
                        rtxtbox_NotasCurso.Text += "CÓDIGO DE ALUMNO: " & alumno.P_cod_alumno & vbNewLine
                        rtxtbox_NotasCurso.Text += "CÓDIGO DE CURSO: " & codCurso & vbNewLine

                        modulos_ciclo(alumno.P_cod_curso)

                        For i = 0 To 3
                            rtxtbox_NotasCurso.Text += "           " & arrayModulos(i) & "                         " & alumno.P_Array_nota(i) & "                       " & alumno.P_Array_recu(i) & vbNewLine
                        Next
                        rtxtbox_NotasCurso.Text += "NOTA MEDIA:            " & calMedia(alumno.P_Array_nota) & "                " & calMedia(alumno.P_Array_recu) & vbNewLine
                    End If

                Next

            Else
                MsgBox("Seleccione en combobox")

            End If

        End If

        If Not encontrado Then
            MsgBox("No existen alumnos del curso " & codCurso)

        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

    End Sub
End Class