Public Class Consulta
    Dim codigo As String
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCodigConsulta.Text Is Nothing Then
            MsgBox("Introduce código del artículo")
        Else
            Dim artRebMostrado As New ArticuloRebajado
            Dim artMostrado As New Articulo

            Try
                codigo = txtCodigConsulta.Text
                Dim encontrado = False

                If Articulos.lista.Contains(codigo) Then

                    Try
                        Dim artBuscar As New ArticuloRebajado
                        artBuscar = Articulos.lista(codigo)
                        artRebMostrado = artBuscar
                    Catch
                        Dim artBuscar As New Articulo
                        artBuscar = Articulos.lista(codigo)
                        artMostrado = artBuscar
                    Finally
                        rtbConsulta.Text = "CÓDIGO" & vbTab & vbTab & "NOMBRE" & vbTab & vbTab & "CATEGORÍA" & vbTab &
                        "PRECIO" & vbTab & vbTab & "EXISTENCIAS" & vbTab & vbTab & "REBAJA" & vbCrLf

                        If artMostrado Is Nothing Then
                            rtbConsulta.Text += artRebMostrado.imprimirArticulo
                        Else
                            rtbConsulta.Text += artMostrado.imprimirArticulo
                        End If
                        rtbConsulta.Visible = True
                        btnEliminar.Visible = True
                    End Try
                End If

            Catch ex As FormatException
                MsgBox("Introduce un número")
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult = MessageBox.Show("¿Seguro que quieres eliminar el artículo de la colección?", "Eliminando Artículo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Articulos.lista.Remove(codigo)
            rtbConsulta.Text = ""
            txtCodigConsulta.Text = ""
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        txtCodigConsulta.Text = ""
        Me.Close()

    End Sub
End Class