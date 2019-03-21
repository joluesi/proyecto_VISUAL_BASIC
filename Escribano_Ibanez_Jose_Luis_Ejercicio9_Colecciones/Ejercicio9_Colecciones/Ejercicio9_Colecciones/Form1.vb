Imports System.IO

Public Class Form1

    Public activo As Listado
    Public cadenaReader As StreamReader
    Public cadenaWriter As StreamWriter


    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Me.Hide()
        Alta.Show()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("José Luis Escribano Ibáñez - Ejercicio 9 - Colecciones")

    End Sub

    Private Sub ConsultaBajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaBajaToolStripMenuItem.Click
        Try
            Dim opcion As String = InputBox("Introduzca código del artículo")

            If opcion <> "" Then
                If coleccionArticulo.Contains(opcion) Then
                    consultarArticulo(opcion)
                    Me.Hide()
                    Consulta.Show()
                Else
                    MsgBox("No existe el código de artículo")

                End If
            End If

        Catch ex As Exception
            MsgBox("Introduzca código")
        End Try
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click

        If coleccionArticulo.Count = 0 Then
            MsgBox("No existen artículos registrados")
        Else
            Dim codigo As String = InputBox("Introduzca el codigo del articulo")

            If coleccionArticulo.Contains(codigo) Then
                Dim valorPedido As Double = coleccionArticulo(codigo).actualizacionExistencias()
                MsgBox("Pedido realizado con exito." & vbNewLine & "Valor del pedido = " & valorPedido & "€" & vbNewLine &
                   "Stock disponible = " & coleccionArticulo(codigo).GetSet_existencias)
            Else
                MsgBox("El codigo de artículo introducido no existe")
            End If
        End If
    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click

        Dim hijo As Listado = New Listado()
        Dim cadenaCategorias As String
        hijo.cambios = True
        hijo.MdiParent = Me

        cadenaCategorias = "Codigo" & vbTab & "Nombre" & vbTab & "   Categoria" & vbTab & "  " & "Precio" & vbTab & " Existencias" & vbTab & "Rebaja" & vbNewLine & vbNewLine

        hijo.rtboxListado.Text += cadenaCategorias

        For i As Integer = 1 To coleccionArticulo.Count Step 1
            hijo.rtboxListado.Text += coleccionArticulo(i).imprimirArticulo() & vbNewLine
        Next

        hijo.Show()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        guardar()

    End Sub

    Public Function guardarComo()

        activo = Me.ActiveMdiChild

        If activo IsNot Nothing Then

            Dim dlgG As New SaveFileDialog()
            dlgG.Title = “Guardar como… “
            dlgG.Filter = "Text documents (*.txt)|*.txt"
            Dim result As DialogResult = dlgG.ShowDialog()

            If result = DialogResult.OK Then
                Dim pathfilename As String = dlgG.FileName.ToString
                cadenaWriter = New StreamWriter(pathfilename)
                cadenaWriter.Write(activo.rtboxListado.Text)
                cadenaWriter.Close()
            End If
            activo.cambios = False
        End If

    End Function

    Public Function guardar()

        activo = Me.ActiveMdiChild

        If activo IsNot Nothing Then

            If activo.Tag IsNot Nothing Then
                cadenaWriter = New StreamWriter(activo.Tag.ToString)
                cadenaWriter.Write(activo.rtboxListado.Text)
                cadenaWriter.Close()
            Else
                guardarComo()
            End If

            activo.cambios = False

        End If

    End Function

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click

        Dim hijo As Listado = New Listado
        Dim cajadi As New OpenFileDialog()
        cajadi.InitialDirectory = "%USERPROFILE%\Desktop"
        cajadi.Title = “Seleccione un Fichero… “
        cajadi.FileName = ""
        cajadi.Filter = "Text documents (.txt)|*.txt"
        Dim result As DialogResult = cajadi.ShowDialog()


        If result = DialogResult.OK Then
            Dim pathfilename As String = cajadi.FileName.ToString
            Dim filename As String = cajadi.SafeFileName.ToString

            hijo.MdiParent = Me
            hijo.Text = filename
            hijo.Tag = pathfilename
            Dim cadenaReader As StreamReader = New StreamReader(pathfilename)
            hijo.rtboxListado.Text = cadenaReader.ReadToEnd
            cadenaReader.Close()
            hijo.Show()

        End If
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click

    End Sub
End Class
