Imports System.IO

Public Class Form1

    Dim cadenaGrabar As StreamWriter
    Dim cadenaMostrar As StreamReader

    Private Sub AbrirToolStripButton_Click(sender As Object, e As EventArgs) Handles AbrirToolStripButton.Click

        Dim dlg0 As New OpenFileDialog()
        dlg0.InitialDirectory = "C:\Users\LINUX INSIDE\source\repos"
        dlg0.Title = "Seleccione un fichero..."
        dlg0.FileName = "" '"Document" 'nombre de fichero por defecto
        dlg0.DefaultExt = ".txt" 'extensión por defecto
        dlg0.Filter = "Text documents (.txt) | *.txt | Todos los archivos (*.*) | *.* " 'Filtro por extensión

        'muestra open file dialog box
        Dim result As DialogResult = dlg0.ShowDialog()
        'procesos con resultado de open file dialog box
        If result = DialogResult.OK Then
            'captura solo el nombre del fichero, con la ruta completa
            Dim pathfilename As String = dlg0.FileName.ToString
            'capturo solo el nombre de fichero, sin la ruta
            Dim filename As String = dlg0.SafeFileName.ToString

            cadenaMostrar = New StreamReader(pathfilename)

            Dim f As New Form2
            f.Tag = pathfilename
            f.Name = filename
            f.RichTextBox.Text = cadenaMostrar.ReadToEnd
            f.MdiParent = Me
            f.Show()
            cadenaMostrar.Close()

        End If

    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        Dim f As New Form2
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click, GuardarToolStripMenuItem.Click

        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichTextBox.Modified And formHijo.Tag = "" Then
            Dim result As DialogResult = MessageBox.Show("Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                GuardarComoToolStripMenuItem.PerformClick()
                Exit Sub
            End If
        ElseIf formHijo.RichTextBox.Modified And formHijo.Tag <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim ruta As String = formHijo.Tag
                Dim formato As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
                formHijo.RichTextBox.SaveFile(ruta, formato)
            End If
        End If


    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlg0 As New SaveFileDialog()
        dlg0.InitialDirectory = "Escritorio"
        dlg0.Title = "Guardar Fichero"
        dlg0.FileName = formHijo.Text
        dlg0.DefaultExt = ".txt, .rtf"
        dlg0.Filter = "Text documents (.txt) | *.txt | Todos los archivos (*.*) | *.* " 'Filtro por extensión

        If dlg0.ShowDialog() = DialogResult.OK Then
            Dim ruta As String = dlg0.FileName.ToString
            formHijo.Tag = ruta
            Dim formato As RichTextBoxStreamType = RichTextBoxStreamType.PlainText
            Dim cadenaGrabar As New StreamWriter(ruta)
            cadenaGrabar.WriteLine(formHijo.RichTextBox.Text)
            cadenaGrabar.Flush()
            cadenaGrabar.Close()
            formHijo.RichTextBox.SaveFile(formHijo.Tag, formato)
        End If

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichTextBox.SelectedText <> "" Then
            formHijo.RichTextBox.Copy()

        End If
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichTextBox.SelectedText <> "" Then
            formHijo.RichTextBox.Cut()

        End If
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichTextBox.SelectedText <> "" Then
            formHijo.RichTextBox.Paste()

        End If
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichTextBox.CanUndo Then
            formHijo.RichTextBox.Undo()

        End If
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        If formHijo.RichTextBox.CanRedo Then
            formHijo.RichTextBox.Redo()

        End If
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        formHijo.RichTextBox.SelectAll()

    End Sub

    Private Sub ColorTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorTextoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgC As New ColorDialog()
        If dlgC.ShowDialog = DialogResult.OK Then
            formHijo.RichTextBox.SelectionColor = dlgC.Color
        End If

    End Sub

    Private Sub ColorFondoFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorFondoFormularioToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgC As New ColorDialog()
        If dlgC.ShowDialog = DialogResult.OK Then
            formHijo.RichTextBox.SelectionBackColor = dlgC.Color

        End If
    End Sub

    Private Sub FormatoTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatoTextoToolStripMenuItem.Click
        Dim formHijo As Form2 = Me.ActiveMdiChild
        If formHijo Is Nothing Then Return
        Dim dlgF As New FontDialog()
        If dlgF.ShowDialog = DialogResult.OK Then
            formHijo.RichTextBox.Font = dlgF.Font()

        End If
    End Sub
End Class
