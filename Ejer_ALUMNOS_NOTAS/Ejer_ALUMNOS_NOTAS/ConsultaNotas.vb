Public Class ConsultaNotas
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If txtCodAlumno.Text <> "" Then
            If coleccionALUMNOS.Contains(txtCodAlumno.Text) Then
                txtCodAlumno.ReadOnly = True
                gbx_Consulta.Visible = True
                txtCodCurso.Text = coleccionAluNotas(txtCodAlumno.Text).P_cod_curso
                modulos_ciclo(txtCodCurso.Text)
                Label1_mod.Text = arrayModulos.ElementAt(0)
                Label2_mod.Text = arrayModulos.ElementAt(1)
                Label3_mod.Text = arrayModulos.ElementAt(2)
                Label4_mod.Text = arrayModulos.ElementAt(3)
                txtNotaMod1.Text = coleccionAluNotas(txtCodAlumno.Text).P_Array_nota(0)
                txtNotaMod2.Text = coleccionAluNotas(txtCodAlumno.Text).P_Array_nota(1)
                txtNotaMod3.Text = coleccionAluNotas(txtCodAlumno.Text).P_Array_nota(2)
                txtNotaMod4.Text = coleccionAluNotas(txtCodAlumno.Text).P_Array_nota(3)
                btnConsultar.Visible = False
                btnEditar.Visible = True

            Else
                MsgBox("No existe ese Alumno")

            End If

        Else
            MsgBox("Antes introduzca código del Alumno")

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If gbx_Consulta.Visible = True Then
            If coleccionALUMNOS.Contains(txtCodAlumno.Text) Then
                txtNotaMod5.Visible = True
                txtNotaMod6.Visible = True
                txtNotaMod7.Visible = True
                txtNotaMod8.Visible = True
                Try
                    If txtNotaMod5.Text <> "" And txtNotaMod6.Text <> "" And txtNotaMod7.Text <> "" And txtNotaMod8.Text <> "" Then

                        For i = 0 To coleccionAluNotas(txtCodAlumno.Text).P_Array_recu(3)
                            coleccionAluNotas(txtCodAlumno.Text).P_Array_recu(0) = txtNotaMod5.Text
                            coleccionAluNotas(txtCodAlumno.Text).P_Array_recu(1) = txtNotaMod6.Text
                            coleccionAluNotas(txtCodAlumno.Text).P_Array_recu(2) = txtNotaMod7.Text
                            coleccionAluNotas(txtCodAlumno.Text).P_Array_recu(3) = txtNotaMod8.Text
                        Next

                        coleccionAluNotas.Add(New Class_NOTAS(txtCodAlumno.Text, txtCodCurso.Text,
                                          array_nota:={CInt(txtNotaMod1.Text), CInt(txtNotaMod2.Text), CInt(txtNotaMod3.Text), CInt(txtNotaMod4.Text)},
                                          array_recu:={CInt(txtNotaMod5.Text), CInt(txtNotaMod6.Text), CInt(txtNotaMod7.Text), CInt(txtNotaMod8.Text)}))
                        MsgBox("Añadidas notas de recuperación")
                        Me.Hide()
                    Else
                        MsgBox("Introduzca valores numéricos en módulos")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Me.Hide()
                End Try
            Else
                MsgBox("No existe ese Alumno en la colección. (No cambie código de Alumno)")
            End If
        Else
            MsgBox("Antes introduzca código de alumno y de curso")
        End If

    End Sub
End Class