Public Class NotasCurso

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Dim encontrado As Boolean = False

        Dim codCurso As String = cmb_Curso.SelectedItem

        If cmb_Curso.SelectedItem <> "" Then
            If cmb_Curso.SelectedItem.Equals("1DAM") Then
                For Each alumno In coleccionAluNotas
                    If alumno.P_cod_curso.Equals(codCurso) Then
                        encontrado = True
                    End If
                Next

                If encontrado Then
                    Me.Visible = True
                    rtxtbox_NotasCurso.Clear()

                    For Each alum In coleccionAluNotas
                        rtxtbox_NotasCurso.Text = "CÓDIGO DE ALUMNO: " & alum.P_cod_alumno & vbNewLine
                        rtxtbox_NotasCurso.Text += "CÓDIGO DE CURSO: " & codCurso & vbNewLine

                        modulos_ciclo(alum.P_cod_curso)

                        For i = 0 To 3
                            rtxtbox_NotasCurso.Text += "           " & arrayModulos(i) & "                         " & alum.P_Array_nota(i) & "                       " & alum.P_Array_recu(i) & vbNewLine
                        Next
                        rtxtbox_NotasCurso.Text += "NOTA MEDIA:            " & calMedia(alum.P_Array_nota) & "                " & calMedia(alum.P_Array_recu) & vbNewLine

                    Next

                Else
                    MsgBox("Antes seleccione código de curso en combobox")

                End If

            End If

        End If

    End Sub

End Class