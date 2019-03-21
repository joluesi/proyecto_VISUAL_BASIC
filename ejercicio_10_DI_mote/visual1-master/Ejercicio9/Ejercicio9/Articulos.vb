Imports System.IO

Public Class Articulos
    Dim cadenaGrabar As StreamWriter
    Dim cadenaMostrar As StreamReader
    Public lista As New Collection
    Public cont = 1

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim formAlta As New Alta
        formAlta.Name = "Alta " & Str(lista.Count + 1)
        formAlta.MdiParent = Me
        formAlta.Show()

    End Sub

    Private Sub ConsultaBajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaBajaToolStripMenuItem.Click

        Dim formConsulta As New Consulta
        formConsulta.MdiParent = Me
        formConsulta.Show()
    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click

        Dim formLista As New Listado
        formLista.MdiParent = Me
        Dim listado As String = "CÓDIGO" & vbTab & vbTab & "NOMBRE" & vbTab & vbTab & "CATEGORÍA" & vbTab &
        "PRECIO" & vbTab & vbTab & "EXISTENCIAS" & vbTab & vbTab & "REBAJA" & vbCrLf

        For i = 1 To lista.Count
            listado = listado & lista(i).imprimirArticulo() & vbCrLf

        Next
        formLista.rtbTexto.Text = listado
        formLista.Show()
    End Sub


    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim art1 As New Articulo("1", "Pantalla", "Informática", 89, 3)
        Dim art2 As New Articulo("2", "Altavoz", "Sonido", 50, 5)
        Dim art3 As New Articulo("3", "Foto", "Imagen", 40, 4)
        lista.Add(art1, "1")
        lista.Add(art2, "2")
        lista.Add(art3, "3")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If Me.MdiChildren.Length > 0 Then
            Dim formHijos = Me.MdiChildren
            For Each hijo In formHijos
                hijo.Close()
            Next
        End If
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantidad.Text = ""
        txtCodigo.Text = ""
        gbPedido.Visible = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtCodigo.Text Is Nothing Or txtCantidad.Text Is Nothing Then
            MessageBox.Show("Introduce todos los datos")
        Else
            If lista.Contains(txtCodigo.Text) Then
                MessageBox.Show("Bien")

                Dim artBuscar As New Articulo
                Dim articulo As New Articulo
                Dim articuloRebajado As New ArticuloRebajado

                artBuscar = lista(txtCodigo.Text)

                If artBuscar.existencias > CInt(txtCantidad.Text) Then
                    actualizarExistencias(txtCodigo.Text, txtCantidad.Text)
                    Dim precio As Double
                    Dim existencias As Integer
                    If lista(txtCodigo.Text).GetType() = articuloRebajado.GetType() Then
                        articuloRebajado = lista(txtCodigo.Text)
                        precio = CInt(txtCantidad.Text) * (articuloRebajado.precio - articuloRebajado.rebajaArticulo)
                        existencias = articuloRebajado.existencias
                    Else
                        articulo = lista(txtCodigo.Text)
                        precio = CInt(txtCantidad.Text) * articulo.precio
                        existencias = articulo.existencias
                    End If

                    MessageBox.Show("PEDIDO REALIZADO" & vbCrLf & "Producto:" & articulo.nombre & vbCrLf & "Cantidad:" & txtCantidad.Text & vbCrLf & "Precio: " & precio)
                    txtCodigo.Text = ""
                    txtCantidad.Text = ""
                    gbPedido.Visible = False
                Else
                    MessageBox.Show("No hay existencias suficientes." & vbCrLf & "Disponibles: " & articulo.existencias)
                    txtCantidad.Text = ""
                End If

            Else
                MessageBox.Show("No se encuentra un Artículo con ese código")
                txtCodigo.Text = ""
                txtCantidad.Text = ""
            End If
        End If

    End Sub

    Private Function actualizarExistencias(ByVal clave As String, ByVal cantidad As String)
        Dim articulo As Articulo = lista(clave)
        articulo.existencias -= CInt(cantidad)
    End Function

    Private Sub PedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click
        gbPedido.Show()

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            Dim formHijo As Listado = Me.ActiveMdiChild
            If formHijo Is Nothing Then Return
            Dim dlgO As New SaveFileDialog()
            dlgO.InitialDirectory = "Escritorio"
            dlgO.Title = "Guardar fichero..."
            dlgO.FileName = formHijo.Text
            dlgO.DefaultExt = "txt,rtf"
            dlgO.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

            If dlgO.ShowDialog() = DialogResult.OK Then
                Dim ruta As String = dlgO.FileName.ToString
                formHijo.Tag = ruta
                Dim formato As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
                Dim cadenaGrabar As New StreamWriter(ruta)
                cadenaGrabar.WriteLine(formHijo.rtbTexto.Text)
                cadenaGrabar.Flush()
                cadenaGrabar.Close()
                formHijo.rtbTexto.SaveFile(formHijo.Tag, formato)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim dlgAbrir As New OpenFileDialog()
        dlgAbrir.InitialDirectory = "C:\"
        dlgAbrir.Title = "Seleccione un fichero..."
        dlgAbrir.FileName = "Document"
        dlgAbrir.DefaultExt = ".txt"
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"


        Dim result As DialogResult = dlgAbrir.ShowDialog()
        If result = DialogResult.OK Then
            'Nombre del fichero con la ruta
            Dim pathfilename As String = dlgAbrir.FileName.ToString
            cadenaMostrar = New StreamReader(pathfilename)
            'Nombre del fichero, sin la ruta
            Dim filename As String = dlgAbrir.SafeFileName.ToString

            Dim formHijo As New Listado
            formHijo.Tag = pathfilename
            formHijo.Name = filename
            formHijo.rtbTexto.Text = cadenaMostrar.ReadToEnd
            formHijo.MdiParent = Me
            cadenaMostrar.Close()
            formHijo.rtbTexto.Visible = True
            formHijo.Show()
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MessageBox.Show("Alejandro Motellón Martínez. Ejercicio 9. 25-01-2019")
    End Sub
End Class
