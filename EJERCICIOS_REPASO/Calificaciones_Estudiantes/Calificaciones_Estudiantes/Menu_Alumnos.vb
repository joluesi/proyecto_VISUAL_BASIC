Public Class Menu_Alumnos
    Private Sub txt_Intro_Opcion_TextChanged(sender As Object, e As EventArgs) Handles txt_Intro_Opcion.TextChanged

        Dim opcion As Integer
        opcion = CInt(txt_Intro_Opcion.Text)
        Select Case opcion

            Case 1
                Me.Hide()
                Form1.Show()

            Case 2

                If IsNothing(varAlumno) Then
                    MsgBox("No se han introducido alumnos")
                Else
                    Me.Hide()
                    Form1.Show()
                End If

            Case 3

                If IsNothing(varAlumno) Then
                    MsgBox("No se han introducido alumnos")

                Else
                    For i = 0 To (varAlumno.Length - 1)
                        For j = i + 1 To (varAlumno.Length - 1)

                            If varAlumno(i).promAlumno < varAlumno(j).promAlumno Then   'Ordeno array por nota promedio más alta
                                auxAlumno = varAlumno(i)
                                varAlumno(i) = varAlumno(j)

                                varAlumno(j) = auxAlumno

                            End If

                        Next

                    Next
                    MsgBox("Array de Alumnos ordenado")

                End If

            Case 4

                If IsNothing(varAlumno) Then
                    MsgBox("No se han introducido alumnos")

                Else
                    Dim listado As String = ""

                    For Each alumno As ALUMNO In varAlumno
                        listado = listado & ("---------------------------------------------" & vbCrLf &
                                         "Nombre: " & alumno.nombreAlumno &
                                         ", Nota 1: " & alumno.nota1Alumno &
                                         ", Nota 2: " & alumno.nota2Alumno &
                                         ", Nota 3: " & alumno.nota3Alumno &
                                         ", Nota 4: " & alumno.nota4Alumno &
                                         ", Promedio: " & alumno.promAlumno &
                                         ", Puntuación: " & alumno.puntAlumno & vbCrLf &
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