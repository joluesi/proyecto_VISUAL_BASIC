Imports System.ComponentModel

Public Class AltaDVD
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If Me.ValidateChildren And txtCodigoDVD.Text <> String.Empty And txtTituloDVD.Text <> String.Empty And txtDiasAlquilerDVD.Text <> String.Empty Then

                If coleccionDVD.Contains(txtCodigoDVD.Text) Then
                    MsgBox("Ya existe ese DVD")
                Else
                    coleccionDVD.Add(New Class_DVD(txtCodigoDVD.Text, txtTituloDVD.Text, txtDiasAlquilerDVD.Text), txtCodigoDVD.Text)
                    MsgBox("DVD dado de alta")
                    AnadirDVD()
                End If

            Else
                MsgBox("Introduzca datos correctos")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AltaDVD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ToolTipCodigo = New ToolTip
        Dim ToolTipTitulo = New ToolTip
        Dim ToolTipDias = New ToolTip

        ToolTipCodigo.SetToolTip(Me.txtCodigoDVD, "tipo String")
        ToolTipTitulo.SetToolTip(Me.txtTituloDVD, "tipo String")
        ToolTipTitulo.SetToolTip(Me.txtDiasAlquilerDVD, "tipo Short")
    End Sub

    Private Sub txtCodigoDVD_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoDVD.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub txtTituloDVD_Validating(sender As Object, e As CancelEventArgs) Handles txtTituloDVD.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If
    End Sub

    Private Sub txtDiasAlquilerDVD_Validating(sender As Object, e As CancelEventArgs) Handles txtDiasAlquilerDVD.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo Short")
        End If
    End Sub
End Class