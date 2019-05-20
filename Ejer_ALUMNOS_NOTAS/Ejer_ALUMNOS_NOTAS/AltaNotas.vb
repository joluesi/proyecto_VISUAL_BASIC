Public Class AltaNotas
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtCodAlumno.Text <> "" Then
            If coleccionALUMNOS.Contains(txtCodAlumno.Text) Then
                gbx_codCurso.Visible = True
                If coleccionALUMNOS(txtCodAlumno.Text).P_cod_ciclo = "DAM" Then
                    If txtCodCurso.Text = "1DAM" Then
                        txtCodCurso.ReadOnly = True
                        modulos_ciclo(txtCodCurso.Text)
                        Label1_mod.Text = arrayModulos.ElementAt(0)
                        Label2_mod.Text = arrayModulos.ElementAt(1)
                        Label3_mod.Text = arrayModulos.ElementAt(2)
                        Label4_mod.Text = arrayModulos.ElementAt(3)
                        gbx_modulos.Visible = True
                        btnAlta.Visible = True
                        btnGuardar.Visible = False

                    ElseIf txtCodCurso.Text = "2DAM" Then
                        txtCodCurso.ReadOnly = True
                        modulos_ciclo(txtCodCurso.Text)
                        Label1_mod.Text = arrayModulos.ElementAt(0)
                        Label2_mod.Text = arrayModulos.ElementAt(1)
                        Label3_mod.Text = arrayModulos.ElementAt(2)
                        Label4_mod.Text = arrayModulos.ElementAt(3)
                        gbx_modulos.Visible = True
                        btnAlta.Visible = True
                        btnGuardar.Visible = False

                    Else
                        MsgBox("Info. El Alumno es del ciclo DAM. Introduzca 1DAM o 2DAM")
                    End If

                ElseIf coleccionALUMNOS(txtCodAlumno.Text).P_cod_ciclo = "DAW" Then
                    If txtCodCurso.Text = "1DAW" Then
                        txtCodCurso.ReadOnly = True
                        modulos_ciclo(txtCodCurso.Text)
                        Label1_mod.Text = arrayModulos.ElementAt(0)
                        Label2_mod.Text = arrayModulos.ElementAt(1)
                        Label3_mod.Text = arrayModulos.ElementAt(2)
                        Label4_mod.Text = arrayModulos.ElementAt(3)
                        gbx_modulos.Visible = True
                        btnAlta.Visible = True
                        btnGuardar.Visible = False

                    ElseIf txtCodCurso.Text = "2DAW" Then
                        txtCodCurso.ReadOnly = True
                        modulos_ciclo(txtCodCurso.Text)
                        Label1_mod.Text = arrayModulos.ElementAt(0)
                        Label2_mod.Text = arrayModulos.ElementAt(1)
                        Label3_mod.Text = arrayModulos.ElementAt(2)
                        Label4_mod.Text = arrayModulos.ElementAt(3)
                        gbx_modulos.Visible = True
                        btnAlta.Visible = True
                        btnGuardar.Visible = False

                    Else
                        MsgBox("Info. El Alumno es del ciclo DAW. Introduzca 1DAW o 2DAW")
                    End If

                End If

            Else
                MsgBox("No existe ese Alumno")
            End If

        Else
            MsgBox("Antes introduzca código de alumno")

        End If

    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

        If gbx_modulos.Visible = True Then
            If coleccionALUMNOS.Contains(txtCodAlumno.Text) Then
                Try
                    If txtNotaMod1.Text <> "" And txtNotaMod2.Text <> "" And txtNotaMod3.Text <> "" And txtNotaMod4.Text <> "" Then
                        coleccionAluNotas.Add(New Class_NOTAS(txtCodAlumno.Text, txtCodCurso.Text,
                                          array_nota:={CInt(txtNotaMod1.Text), CInt(txtNotaMod2.Text), CInt(txtNotaMod3.Text), CInt(txtNotaMod4.Text)},
                                          array_recu:={0, 0, 0, 0}), txtCodAlumno.Text)
                        MsgBox("Añadidas notas a la colección")
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()

    End Sub


End Class