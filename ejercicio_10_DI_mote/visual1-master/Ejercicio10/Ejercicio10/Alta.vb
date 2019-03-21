Imports System.ComponentModel

Public Class Alta
    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTipCodigo = New ToolTip()
        Dim toolTipTitulo = New ToolTip()
        Dim toolTipDias = New ToolTip()

        toolTipCodigo.SetToolTip(Me.txtCodigo, "String")
        toolTipTitulo.SetToolTip(Me.txtTitulo, "cadena de texto")
        toolTipDias.SetToolTip(Me.txtDiasAlquiler, "Short")

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigo.Text = ""
        txtTitulo.Text = ""
        txtDiasAlquiler.Text = ""
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim codigo = txtCodigo.Text
        Dim titulo = txtTitulo.Text
        Dim diasAlquiler = txtDiasAlquiler.Text
        Dim correcto = True

        If datosAltaDvdCorrectos(codigo, titulo, diasAlquiler) = False Then
            MessageBox.Show("Los datos del DVD no son válidos ")
        Else
            Dim dvd As DVD = New DVD(codigo, titulo, diasAlquiler, False)

            If coleccionDvds.Contains(dvd.codigo) Then
                MessageBox.Show("Ya existe un DVD con ese código")
            Else
                coleccionDvds.Add(dvd, dvd.codigo)
                MessageBox.Show("DVD almacenado ")
                Dim result = MessageBox.Show("¿Quieres realizar otra ALTA?", "ALTA", MessageBoxButtons.YesNo)
                txtCodigo.Text = ""
                txtTitulo.Text = ""
                txtDiasAlquiler.Text = ""
                If result = DialogResult.No Then
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub



    Private Function BorrarMensajeError()
        ErrorProvider1.SetError(txtCodigo, "")
        ErrorProvider1.SetError(txtTitulo, "")
        ErrorProvider1.SetError(txtDiasAlquiler, "")
    End Function


    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating

    End Sub
End Class