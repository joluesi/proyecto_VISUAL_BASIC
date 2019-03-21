Public Class AltaDVD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAltaDVD.Click

        If coleccionDVD.Count = 0 Then 'coleccion vacia, no hay que comprobar nada
            MsgBox("DVD dado de alta satisfactoriamente")
            coleccionDVD.Add(New DVD(txtCodigoDVD.Text, txtTituloDVD.Text, CInt(txtDiasMaxDVD.Text)), txtCodigoDVD.Text)
            Si_o_No()


        Else ' tiene datos, hay que comprobar

            If coleccionDVD.Contains(txtCodigoDVD.Text) Then
                MsgBox("El articulo con codigo " + txtCodigoDVD.Text + " ya existe")
                borrarAlta()
            Else
                MsgBox("DVD dado de alta satisfactoriamente")
                coleccionDVD.Add(New DVD(txtCodigoDVD.Text, txtTituloDVD.Text, CInt(txtDiasMaxDVD.Text)), txtCodigoDVD.Text)
                Si_o_No()
            End If

        End If


    End Sub




    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoDVD.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTituloDVD.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiasMaxDVD.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTituloDVD.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtDiasMaxDVD.TextChanged

    End Sub

    Private Sub btnAltaCancelar_Click(sender As Object, e As EventArgs) Handles btnAltaCancelar.Click

        Me.Hide()
        Form1.Show()
        borrarAlta()
    End Sub

    'Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    '    If Not IsNumeric(txtCodigo.Text) Then
    '        ErrorProvider1.SetError(txtCodigo, "Es obligatorio")
    '    Else
    '        ErrorProvider1.SetError(txtCodigo, Nothing)
    '    End If
    'End Sub


End Class