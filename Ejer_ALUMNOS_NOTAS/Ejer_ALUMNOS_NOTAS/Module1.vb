Module Module1

    'colecciones de las clases
    Public coleccionALUMNOS As New Collection
    'Public coleccionNOTAS As New Collection
    Public coleccionAluNotas As New Collection

    'array de módulos(4 módulos x curso, máximo 5)
    Public arrayModulos(3) As String

    Public cont As Integer = 0

    'función para cargar array de módulos
    Public Function modulos_ciclo(texto As String) As String
        If texto = "1DAM" Or texto = "1DAW" Then
            arrayModulos = {"java", "bbdd", "entornos", "sistemas"}
        ElseIf texto = "2DAM" Then
            arrayModulos = {"python", "visualbasic", "xml", "procesos"}
        ElseIf texto = "2DAW" Then
            arrayModulos = {"prog.servidor", "prog.cliente", "javascript", "php"}
        Else
            MsgBox("Error.Introduzca 1DAM/1DAW/2DAM/2DAW")

        End If

        Return arrayModulos(3)

    End Function

    'función para pedir si añado o no añado más ALUMNOS
    Public Sub AnadirALUMNOS()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro ALUMNO?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            borrarTextAlta()
            AltaAlumnos.txtCodCiclo.Focus()
        Else
            borrarTextAlta()
            AltaAlumnos.Hide()
            Form1.Show()
        End If
    End Sub

    'función borrar casilleros alta de Alumnos
    Public Sub borrarTextAlta()
        AltaAlumnos.txtCodCiclo.Clear()
        AltaAlumnos.txtCodAlumno.Clear()
        AltaAlumnos.txtNombreAlumno.Clear()
        AltaAlumnos.txtDirecAlumno.Clear()
        AltaAlumnos.txtTelfnoAlumno.Clear()
        AltaAlumnos.txtEmailAlumno.Clear()

    End Sub

    'función borrar casilleros alta de Notas
    Public Sub borrarAltaNotas()
        AltaNotas.txtCodAlumno.Clear()
        AltaNotas.txtCodCurso.Clear()
        AltaNotas.txtNotaMod1.Clear()
        AltaNotas.txtNotaMod2.Clear()
        AltaNotas.txtNotaMod3.Clear()
        AltaNotas.txtNotaMod4.Clear()
        AltaNotas.gbx_codCurso.Visible = False
        AltaNotas.gbx_modulos.Visible = False
        AltaNotas.btnAlta.Visible = False
        AltaNotas.btnGuardar.Visible = True


    End Sub

    'función borrar casilleros alta de Notas
    Public Sub borrarConsultaNotas()
        ConsultaNotas.txtCodAlumno.Clear()
        ConsultaNotas.txtCodCurso.Clear()
        ConsultaNotas.txtNotaMod1.Clear()
        ConsultaNotas.txtNotaMod2.Clear()
        ConsultaNotas.txtNotaMod3.Clear()
        ConsultaNotas.txtNotaMod4.Clear()
        ConsultaNotas.txtNotaMod5.Clear()
        ConsultaNotas.txtNotaMod6.Clear()
        ConsultaNotas.txtNotaMod7.Clear()
        ConsultaNotas.txtNotaMod8.Clear()
        ConsultaNotas.gbx_Consulta.Visible = False

    End Sub


    'función mostrar notas
    Public Function mostrarNotas(codigoAlumno As Integer) As String
        If coleccionALUMNOS.Contains(codigoAlumno) Then
            modulos_ciclo(coleccionAluNotas(codigoAlumno).P_cod_curso)
            For i = 0 To 3
                NotasAlumno.rtxtbox_NotasAlumno.Text += arrayModulos(i) & "             " & coleccionAluNotas(codigoAlumno).P_Array_nota(i) & "             " & coleccionAluNotas(codigoAlumno).P_Array_recu(i) & vbNewLine
            Next
        Else
            MsgBox("No existe ese Alumno")
        End If

        Return NotasAlumno.rtxtbox_NotasAlumno.Text

    End Function

    'función calcular nota media
    Public Function calMedia(notas As Array) As Double
        Dim sumaNotas As Double = 0.0
        For i = 0 To notas.Length - 1
            sumaNotas += notas(i)
        Next

        Return sumaNotas / notas.Length

    End Function

End Module
