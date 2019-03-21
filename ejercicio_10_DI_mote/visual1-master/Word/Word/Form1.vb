Imports System.IO

Public Class Form1

    Dim cadenaGrabar As StreamWriter
    Dim cadenaMostrar As StreamReader

    Private Sub AbrirToolStripButton_Click(sender As Object, e As EventArgs) Handles AbrirToolStripButton.Click, AbrirToolStripMenuItem.Click
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

            Dim formHijo As New Form2
            formHijo.Tag = pathfilename
            formHijo.Name = filename
            formHijo.RichText.Text = cadenaMostrar.ReadToEnd
            formHijo.MdiParent = Me
            cadenaMostrar.Close()
            formHijo.Show()
        End If
    End Sub


    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click, NuevoToolStripMenuItem.Click
        Dim formHijo As New Form2
        formHijo.MdiParent = Me
        formHijo.Show()

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click, GuardarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichText.Modified And formHijo.Tag = "" Then 'Si no existe..
            GuardarComoToolStripMenuItem.PerformClick()
            Exit Sub
        ElseIf formHijo.RichText.Modified And formHijo.Tag <> "" Then
            Dim ruta As String = formHijo.Tag
            Dim formato As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
            formHijo.RichText.SaveFile(ruta, formato)
        End If
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
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
            cadenaGrabar.WriteLine(formHijo.RichText.Text)
            cadenaGrabar.Flush()
            cadenaGrabar.Close()
            formHijo.RichText.SaveFile(formHijo.Tag, formato)
        End If
    End Sub

    Private Sub CopiarToolStripButton_Click(sender As Object, e As EventArgs) Handles CopiarToolStripButton.Click, CopiarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        My.Computer.Clipboard.SetText(formHijo.RichText.SelectedText)
    End Sub

    Private Sub PegarToolStripButton_Click(sender As Object, e As EventArgs) Handles PegarToolStripButton.Click, PegarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        formHijo.RichText.SelectedText = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub CortarToolStripButton_Click(sender As Object, e As EventArgs) Handles CortarToolStripButton.Click, CortarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        My.Computer.Clipboard.SetText(formHijo.RichText.SelectedText)
        formHijo.RichText.SelectedText = ""
    End Sub

    Private Sub ColorTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorTextoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgColor As New ColorDialog()
        dlgColor.ShowDialog()
        formHijo.RichText.SelectionColor = dlgColor.Color
    End Sub

    Private Sub FormatoTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatoTextoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgFuente As New FontDialog()
        dlgFuente.ShowDialog()
        formHijo.RichText.SelectionFont = dlgFuente.Font
    End Sub

    Private Sub ColorFondoTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorFondoTextoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgFondo As New ColorDialog()
        dlgFondo.ShowDialog()
        formHijo.RichText.SelectionBackColor = dlgFondo.Color
    End Sub

    Private Sub ColorFondoFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorFondoFormularioToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgFondoForm As New ColorDialog()
        dlgFondoForm.ShowDialog()
        formHijo.BackColor = dlgFondoForm.Color
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub ListaDeDocumentosAbiertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeDocumentosAbiertosToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons)
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        formHijo.RichText.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        formHijo.RichText.Redo()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        formHijo.RichText.SelectAll()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        While Me.MdiChildren.Length > 0
            Dim formHijo As Form2 = Me.ActiveMdiChild

            If formHijo.RichText.Modified Then
                Dim result As DialogResult = MessageBox.Show("¿Desea guardar los cambios?", "Cambios sin guardar",
                                                             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                If result = DialogResult.Yes Then
                    GuardarToolStripButton.PerformClick()
                    formHijo.Close()
                ElseIf result = DialogResult.No Then
                    formHijo.Close()
                Else
                    Return
                End If
            End If
        End While
        Me.Close()
    End Sub

End Class
