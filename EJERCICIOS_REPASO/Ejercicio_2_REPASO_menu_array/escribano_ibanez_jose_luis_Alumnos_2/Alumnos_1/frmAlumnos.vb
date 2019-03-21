Public Class frmAlumnos
    Private Sub txt_Intro_Opcion_TextChanged(sender As Object, e As EventArgs) Handles txt_Intro_Opcion.TextChanged

        Dim opcion As Integer
        opcion = CInt(txt_Intro_Opcion.Text)
        Select Case opcion

            Case 1
                Me.Hide()
                Form3.Show()

            Case 2

                If IsNothing(varAlumnos) Then
                    MsgBox("No se han introducido alumnos")
                Else
                    Me.Hide()
                    Form3.Show()
                End If

            Case 3

                If IsNothing(varAlumnos) Then
                    MsgBox("No se han introducido alumnos")

                Else
                    For i = 0 To (varAlumnos.Length - 1)
                        For j = i + 1 To (varAlumnos.Length - 1)

                            If varAlumnos(i).apellAlumno > varAlumnos(j).apellAlumno Then
                                auxAlumno = varAlumnos(i)
                                varAlumnos(i) = varAlumnos(j)

                                varAlumnos(j) = auxAlumno

                            End If

                        Next

                    Next

                    'Dim listadoOrd As String = ""

                    'For Each alumno As ALUMNO In varAlumnos
                    '    listadoOrd = listadoOrd & ("---------------------------------------------" & vbCrLf &
                    '                         "Código: " & alumno.codAlumno &
                    '                         ", Nombre: " & alumno.nomAlumno &
                    '                         ", Apellidos: " & alumno.apellAlumno &
                    '                         ", Teléfono: " & alumno.telfAlumno &
                    '                         ", Email: " & alumno.emailAlumno &
                    '                         ", Curso: " & alumno.cursoAlumno & vbCrLf &
                    '                         "---------------------------------------------")
                    'Next
                    'txtListado.Text = listadoOrd
                    MsgBox("Array de alumnos ordenado !!!")

                End If

            Case 4

                If IsNothing(varAlumnos) Then
                    MsgBox("No se han introducido alumnos")

                Else
                    Dim listado As String = ""

                    For Each alumno As ALUMNO In varAlumnos
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
End Class