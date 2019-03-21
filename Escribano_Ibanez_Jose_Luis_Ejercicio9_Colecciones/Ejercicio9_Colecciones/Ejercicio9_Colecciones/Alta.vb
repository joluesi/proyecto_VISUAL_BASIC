Public Class Alta
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If coleccionArticulo.Count = 0 Then

                If rbtnArticulo.Checked Then
                    coleccionArticulo.Add(New Articulo(txtCodigo.Text, txtNombre.Text, cmbCategoria.Text, CDbl(txtPrecio.Text), CInt(txtExistencias.Text)), txtCodigo.Text)
                    MsgBox("Artículo " & txtNombre.Text & " dado de alta con éxito")
                    DarOtraAlta()
                Else
                    coleccionArticulo.Add(New ArticuloRebajado(txtCodigo.Text, txtNombre.Text, cmbCategoria.Text, CDbl(txtPrecio.Text), CInt(txtExistencias.Text), CShort(txtRebaja.Text)), txtCodigo.Text)
                    MsgBox("Artículo " & txtNombre.Text & " dado de alta con éxito")
                    DarOtraAlta()
                End If

            Else

                If coleccionArticulo.Contains(txtCodigo.Text) Then
                    MsgBox("El articulo con codigo " & txtCodigo.Text & " ya existe.")
                    txtCodigo.Clear()
                    txtCodigo.Focus()

                Else

                    If rbtnArticulo.Checked Then
                        coleccionArticulo.Add(New Articulo(txtCodigo.Text, txtNombre.Text, cmbCategoria.Text, CDbl(txtPrecio.Text), CInt(txtExistencias.Text)), txtCodigo.Text)
                        MsgBox("Artículo " & txtNombre.Text & " dado de alta con éxito")
                        DarOtraAlta()

                    Else
                        coleccionArticulo.Add(New ArticuloRebajado(txtCodigo.Text, txtNombre.Text, cmbCategoria.Text, CDbl(txtPrecio.Text), CInt(txtExistencias.Text), CShort(txtRebaja.Text)), txtCodigo.Text)
                        MsgBox("Artículo " & txtNombre.Text & " dado de alta con éxito")
                        DarOtraAlta()

                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Introduzca todos los casilleros. Precio, existencias y rebaja numéricos")
        End Try

    End Sub

    Private Sub rbtnArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnArticulo.CheckedChanged

        If rbtnArticulo.Checked Then
            lblRebaja.Visible = False
            txtRebaja.Visible = False

        Else
            lblRebaja.Visible = True
            txtRebaja.Visible = True
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()
        Form1.Show()

    End Sub

    Public Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtExistencias.Text = ""
        txtPrecio.Text = ""
        txtRebaja.Text = ""
        cmbCategoria.SelectedItem = Nothing

    End Sub

    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRebaja.Visible = False
        txtRebaja.Visible = False
        rbtnArticulo.Checked = True
    End Sub

End Class