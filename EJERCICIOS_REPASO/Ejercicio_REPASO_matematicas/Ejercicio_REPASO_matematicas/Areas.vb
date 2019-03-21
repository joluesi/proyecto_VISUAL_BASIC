Public Class Areas

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged
        If Not (IsNumeric(txtBase.Text)) Then
            MsgBox("Por favor, introduzca valor numérico")
        End If
    End Sub

    Private Sub txtAltura_TextChanged(sender As Object, e As EventArgs) Handles txtAltura.TextChanged
        If Not (IsNumeric(txtAltura.Text)) Then
            MsgBox("Por favor, introduzca valor numérico")
        End If
    End Sub

    Public Function AreaTriangulo(base As Single, altura As Single) As Single
        AreaTriangulo = (base * altura) / 2

    End Function

    Public Function AreaCuadrado(base As Single) As Single
        AreaCuadrado = (base * base)

    End Function

    Public Function AreaRectangulo(base As Single, altura As Single) As Single
        AreaRectangulo = base * altura

    End Function

    Private Sub rbtnTriangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTriangulo.CheckedChanged

        If rbtnTriangulo.Checked Then
            txtAltura.Visible = True
            If (txtBase.Text = "" Or txtAltura.Text = "") Then
                MsgBox("Por favor, introduzca base y altura")
            Else
                txtArea.Text = AreaTriangulo(base:=txtBase.Text, altura:=txtAltura.Text)
            End If
        End If

    End Sub

    Private Sub rbtnCuadrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCuadrado.CheckedChanged

        If rbtnCuadrado.Checked Then
            txtAltura.Visible = False
            If (txtBase.Text = "") Then
                MsgBox("Por favor, introduzca base")
            Else
                txtArea.Text = AreaCuadrado(base:=txtBase.Text)
            End If

        End If

    End Sub

    Private Sub rbtnRectangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRectangulo.CheckedChanged

        If rbtnRectangulo.Checked Then
            txtAltura.Visible = True
            If (txtBase.Text = "" Or txtAltura.Text = "") Then
                MsgBox("Por favor, introduzca base y altura")
            Else
                txtArea.Text = AreaRectangulo(base:=txtBase.Text, altura:=txtAltura.Text)
            End If
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Menu_Opciones.Show()

    End Sub
End Class