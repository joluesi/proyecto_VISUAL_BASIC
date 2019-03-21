Imports System.ComponentModel

Public Class AltaDvd

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

        Try
            If Me.ValidateChildren And txtCodigoDVD.Text <> String.Empty And txtTituloDVD.Text <> String.Empty And txtDiasAlquilerDVD.Text <> String.Empty And isNumeric(txtDiasAlquilerDVD.Text) Then

                If coleccionDVD.Count = 0 Then
                    MsgBox("Dvd dado de alta.")
                    coleccionDVD.Add(New DVD(txtCodigoDVD.Text, txtTituloDVD.Text, txtDiasAlquilerDVD.Text), txtCodigoDVD.Text)
                    Si_o_No()

                Else
                    If coleccionDVD.Contains(txtCodigoDVD.Text) Then
                        MsgBox("Ya existe ese DVD")
                        borrarTextAlta()
                    Else
                        MsgBox("Dvd dado de alta.")
                        coleccionDVD.Add(New DVD(txtCodigoDVD.Text, txtTituloDVD.Text, txtDiasAlquilerDVD.Text), txtCodigoDVD.Text)
                        Si_o_No()

                    End If

                End If

            Else
            MessageBox.Show("Ingrese datos correctos", "Registro de Altas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Hide()
        Form1.Show()
        borrarTextAlta()
    End Sub

    Private Sub AltaDvd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ToolTipCodigo = New ToolTip
        Dim ToolTipTitulo = New ToolTip
        Dim ToolTipDias = New ToolTip

        ToolTipCodigo.SetToolTip(Me.txtCodigoDVD, "tipo String")
        ToolTipTitulo.SetToolTip(Me.txtTituloDVD, "tipo String")
        ToolTipTitulo.SetToolTip(Me.txtDiasAlquilerDVD, "tipo Short")


    End Sub

    Private Sub txtCodigoDVD_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodigoDVD.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If

    End Sub

    Private Sub txtTituloDVD_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTituloDVD.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo String")
        End If

    End Sub

    Private Sub txtDiasAlquilerDVD_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDiasAlquilerDVD.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "casillero obligatorio, tipo Short")
        End If
    End Sub


End Class