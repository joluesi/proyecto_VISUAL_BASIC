Public Class frmAlumnos
    Private Sub txt_Intro_Opcion_TextChanged(sender As Object, e As EventArgs) Handles txt_Intro_Opcion.TextChanged

        Dim opcion As Integer
        opcion = CInt(txt_Intro_Opcion.Text)
        Select Case opcion

            Case 1
                Me.Hide()
                Form3.Show()

            Case 2
                Me.Hide()
                Form3.Show()

            Case 3

                If IsNothing(alumnos) Then
                    MsgBox("No se han introducido alumnos")

                Else
                    For i = 0 To (alumnos.Length - 1)
                        For j = i + 1 To (alumnos.Length - 1)

                            If alumnos(i).apellAlumno > alumnos(j).apellAlumno Then
                                auxAlumno = alumnos(i)
                                alumnos(i) = alumnos(j)

                                alumnos(j) = auxAlumno

                            End If

                        Next

                    Next

                    Dim listadoOrd As String = ""

                    For Each alumno As ALUMNO In alumnos
                        listadoOrd = listadoOrd & ("---------------------------------------------" & vbCrLf &
                                             "Código: " & alumno.codAlumno &
                                             ", Nombre: " & alumno.nomAlumno &
                                             ", Apellidos: " & alumno.apellAlumno &
                                             ", Teléfono: " & alumno.telfAlumno &
                                             ", Email: " & alumno.emailAlumno &
                                             ", Curso: " & alumno.cursoAlumno & vbCrLf &
                                             "---------------------------------------------")
                    Next
                    txtListado.Text = listadoOrd
                    MsgBox("Array de alumnos ordenado !!!")

                End If

            Case 4

                If IsNothing(alumnos) Then
                    MsgBox("No se han introducido alumnos")

                Else
                    Dim listado As String = ""

                    For Each alumno As ALUMNO In alumnos
                        listado = listado & ("---------------------------------------------" & vbCrLf &
                                         "Código: " & alumno.codAlumno &
                                         ", Nombre: " & alumno.nomAlumno &
                                         ", Apellidos: " & alumno.apellAlumno &
                                         ", Teléfono: " & alumno.telfAlumno &
                                         ", Email: " & alumno.emailAlumno &
                                         ", Curso: " & alumno.cursoAlumno & vbCrLf &
                                         "---------------------------------------------")
                    Next

                    txtListado.Text = listado
                    gbListado.Visible = True

                End If

            Case 5
                MsgBox("¡¡¡Que tengas un buen día!!!")
                Me.Close()
                End

        End Select


    End Sub

    Private Sub frmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class