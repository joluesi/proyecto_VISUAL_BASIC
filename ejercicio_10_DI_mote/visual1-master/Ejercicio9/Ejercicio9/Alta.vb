Public Class Alta

    Private Sub rbArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbArticulo.CheckedChanged, rbArticuloReba.CheckedChanged
        If rbArticulo.Checked Then
            txtRebaja.Visible = False
            lblRebaja.Visible = False
        Else
            txtRebaja.Visible = True
            lblRebaja.Visible = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCodigo.Text = ""
        txtNombre.Text = ""
        cbCategoria.SelectedItem = Nothing
        txtPrecio.Text = ""
        txtExistencias.Text = ""
        txtRebaja.Text = ""
        txtRebaja.Visible = False
        lblRebaja.Visible = False
        rbArticulo.Checked = False
        rbArticuloReba.Checked = False

        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtCodigo.Text Is Nothing Or txtNombre.Text Is Nothing Or
            cbCategoria.Text Is Nothing Or txtPrecio.Text Is Nothing Or txtExistencias.Text Is Nothing Or
            txtExistencias.Text Is Nothing Then

            MessageBox.Show("Introduce todos los datos")
        Else
            If rbArticulo.Checked Then
                If Articulos.lista.Contains(txtCodigo.Text) Then
                    MessageBox.Show("Ya existe un Artículo con ese código")
                Else

                    Try
                        Dim art As New Articulo
                        art.codigo = txtCodigo.Text
                        art.nombre = txtNombre.Text
                        art.categoria = cbCategoria.Text
                        art.precio = CDbl(txtPrecio.Text)
                        art.existencias = CInt(txtExistencias.Text)

                        Articulos.lista.Add(art, txtCodigo.Text) 'Se añade clave

                        Dim result As DialogResult = MessageBox.Show("¿Desea añadir otro artículo?", "Otro articulo",
                                                        MessageBoxButtons.YesNo)

                        If result = DialogResult.Yes Then
                            txtCodigo.Text = ""
                            txtNombre.Text = ""
                            cbCategoria.Text = ""
                            txtPrecio.Text = ""
                            txtExistencias.Text = ""
                            txtRebaja.Text = ""
                        Else
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Datos inválidos")
                    End Try
                End If

            ElseIf rbArticuloReba.Checked Then
                    Try
                        Dim artReb As New ArticuloRebajado
                        artReb.codigo = txtCodigo.Text
                        artReb.nombre = txtNombre.Text
                        artReb.categoria = cbCategoria.Text
                        artReb.precio = CDbl(txtPrecio.Text)
                        artReb.existencias = txtExistencias.Text
                        artReb.rebajaArticulo = CShort(txtRebaja.Text)

                    Articulos.lista.Add(artReb, "1") 'Se añade clave


                    Dim result As DialogResult = MessageBox.Show("¿Desea añadir otro artículo?", "Otro articulo",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

                        If result = DialogResult.Yes Then
                            txtCodigo.Text = ""
                            txtNombre.Text = ""
                            cbCategoria.Text = ""
                            txtPrecio.Text = ""
                            txtExistencias.Text = ""
                            txtRebaja.Text = ""
                        Else
                            Me.Close()
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Datos inválidos")
                    End Try
                Else
                    MessageBox.Show("Elige un tipo de artículo")
            End If
        End If

    End Sub


End Class