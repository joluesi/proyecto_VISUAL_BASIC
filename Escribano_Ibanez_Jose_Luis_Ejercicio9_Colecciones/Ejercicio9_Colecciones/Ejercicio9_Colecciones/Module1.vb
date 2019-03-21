Module Module1

    Public coleccionArticulo As New Collection

    Public Sub DarOtraAlta()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea dar de alta otro artículo?", "Atencion", MessageBoxButtons.YesNo)

        If opcion = DialogResult.Yes Then
            Alta.btnLimpiar.PerformClick()
            Alta.txtCodigo.Focus()
        Else
            Alta.btnLimpiar.PerformClick()
            Alta.Hide()
            Form1.Show()
        End If

    End Sub

    Public Sub consultarArticulo(codigo As String)

        If coleccionArticulo(codigo).GetType.ToString = "Ejercicio9_Colecciones.Articulo" Then

            Consulta.txtCodigoConsulta.Text = coleccionArticulo(codigo).GetSet_codigo
            Consulta.txtNombreConsulta.Text = coleccionArticulo(codigo).GetSet_nombre
            Consulta.txtExistenciasConsulta.Text = coleccionArticulo(codigo).GetSet_existencias
            Consulta.txtPrecioConsulta.Text = coleccionArticulo(codigo).GetSet_precio
            Consulta.cmbCategoriaConsulta.Text = coleccionArticulo(codigo).GetSet_categoria

        Else
            Consulta.txtCodigoConsulta.Text = coleccionArticulo(codigo).GetSet_codigo
            Consulta.txtNombreConsulta.Text = coleccionArticulo(codigo).GetSet_nombre
            Consulta.txtExistenciasConsulta.Text = coleccionArticulo(codigo).GetSet_existencias
            Consulta.txtPrecioConsulta.Text = coleccionArticulo(codigo).GetSet_precio
            Consulta.cmbCategoriaConsulta.Text = coleccionArticulo(codigo).GetSet_categoria
            Consulta.txtRebajaConsulta.Text = coleccionArticulo(codigo).GetSet_rebaja

        End If

    End Sub


End Module
