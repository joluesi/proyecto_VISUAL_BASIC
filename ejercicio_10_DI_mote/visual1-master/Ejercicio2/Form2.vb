Public Class Form2

    Private Sub txtOpcion_TextChanged(sender As Object, e As EventArgs) Handles txtOpcion.TextChanged
        If txtOpcion.Text = "" Then
            MsgBox("Introduce un número")
        Else
            If IsNumeric(txtOpcion.Text) Then
                If txtOpcion.Text > 5 Or txtOpcion.Text < 1 Then
                    MsgBox("Opción introducida incorrecta")
                Else
                    Select Case txtOpcion.Text
                        Case 1

                            'Introducir datos
                            Me.Close()

                            Form3.Show()
                            txtOpcion.Clear()
                        Case 2
                            If IsNothing(alumnos) Then
                                MsgBox("ERROR, no hay nada", vbExclamation)
                            Else
                                'Consultar datos
                                Me.Close()
                                Form4.Show()
                                txtOpcion.Clear()
                            End If

                        Case 3

                            If IsNothing(alumnos) Then
                                MsgBox("ERROR, no hay nada", vbExclamation)
                            Else
                                'Método burbuja
                                Dim auxAlumno As Alumno
                                For i = 0 To alumnos.Length - 1
                                    For j = i + 1 To alumnos.Length - 1
                                        If alumnos(i).apelAlumno > alumnos(j).apelAlumno Then
                                            auxAlumno = alumnos(i)
                                            alumnos(i) = alumnos(j)
                                            alumnos(j) = auxAlumno
                                        End If
                                    Next
                                Next
                                'Listado del array ordenado
                                gpLista.Visible = True
                                Dim listaOrdenada As String = ""
                                For Each alu As Alumno In alumnos
                                    listaOrdenada = listaOrdenada & ("-- Código: " & CStr(alu.codAlumno) & " -- Nombre: " & alu.nomAlumno & " -- Apellidos: " & alu.apelAlumno &
                                    " -- Teléfono: " & CStr(alu.telAlumno) & " -- Email: " & alu.emailAlumno & " -- Curso: " & alu.cursoAlumno & vbCrLf & vbCrLf)
                                Next
                                txtLista.Text = listaOrdenada
                            End If
                            txtOpcion.Clear()

                        Case 4
                            'MostrarArray

                            If IsNothing(alumnos) Then
                                MsgBox("ERROR, no hay nada", vbExclamation)

                            Else

                                Dim lista As String = ""
                                For Each alumno As Alumno In alumnos
                                    lista = lista & ("-- Código: " & CStr(alumno.codAlumno) & " -- Nombre: " & alumno.nomAlumno & " -- Apellidos: " & alumno.apelAlumno &
                               " -- Teléfono: " & CStr(alumno.telAlumno) & " -- Email: " & alumno.emailAlumno & " -- Curso: " & alumno.cursoAlumno & vbCrLf & vbCrLf)
                                Next
                                txtLista.Text = lista
                                gpLista.Visible = True
                            End If
                            txtOpcion.Clear()
                        Case 5
                            Me.Close()
                            End
                    End Select
                End If
            Else
                MsgBox("Introduce una número del 1 al 5")
            End If
        End If
    End Sub
End Class