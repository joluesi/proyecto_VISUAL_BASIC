Public Class AltaAlumnos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If Me.ValidateChildren And txtCodCiclo.Text <> "" And txtCodAlumno.Text <> "" And txtNombreAlumno.Text <> "" And txtDirecAlumno.Text <> "" And txtTelfnoAlumno.Text <> "" And txtEmailAlumno.Text <> "" Then
                If txtCodCiclo.Text = "DAM" Or txtCodCiclo.Text = "DAW" Then
                    If coleccionALUMNOS.Contains(txtCodAlumno.Text) Then
                        MsgBox("Ya existe ese Alumno")
                    Else
                        coleccionALUMNOS.Add(New Class_ALUMNO(txtCodAlumno.Text, txtCodCiclo.Text, txtNombreAlumno.Text, txtDirecAlumno.Text, txtTelfnoAlumno.Text, txtEmailAlumno.Text), txtCodAlumno.Text)
                        MsgBox("Alumno dado de alta.")
                        AnadirALUMNOS()
                    End If
                Else
                    MsgBox("En código de ciclo introduzca DAM o DAW")
                End If
            Else
                MsgBox("Antes debe rellenar todos los casilleros de forma correcta")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AltaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ToolTipCodCiclo = New ToolTip
        Dim ToolTipCodAlum = New ToolTip
        Dim ToolTipNombre = New ToolTip
        Dim ToolTipDir = New ToolTip
        Dim ToolTipTel = New ToolTip
        Dim ToolTipEmail = New ToolTip

        ToolTipCodCiclo.SetToolTip(Me.txtCodCiclo, "tipo String")
        ToolTipCodAlum.SetToolTip(Me.txtCodAlumno, "tipo String")
        ToolTipNombre.SetToolTip(Me.txtNombreAlumno, "tipo String")
        ToolTipDir.SetToolTip(Me.txtDirecAlumno, "tipo String")
        ToolTipTel.SetToolTip(Me.txtTelfnoAlumno, "tipo Single")
        ToolTipEmail.SetToolTip(Me.txtEmailAlumno, "tipo String")

    End Sub

    Private Sub txtCodCiclo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodCiclo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub txtCodAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub txtNombreAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub txtDirecAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDirecAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub txtTelfnoAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTelfnoAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo Single")
        End If
    End Sub

    Private Sub txtEmailAlumno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmailAlumno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class
