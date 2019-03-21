Public Class Form1
    Private Sub ltbIzquierda_MouseMove(sender As Object, e As MouseEventArgs) Handles ltbIzquierda.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ltbIzquierda.DoDragDrop(ltbIzquierda.SelectedItem, DragDropEffects.All)
        End If
    End Sub

    Private Sub ltbDerecha_MouseMove(sender As Object, e As MouseEventArgs) Handles ltbDerecha.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ltbDerecha.DoDragDrop(ltbDerecha.SelectedItem, DragDropEffects.All)
        End If
    End Sub

    Private Sub ltbIzquierda_DragEnter(sender As Object, e As DragEventArgs) Handles ltbIzquierda.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ltbDerecha_DragEnter(sender As Object, e As DragEventArgs) Handles ltbDerecha.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ltbIzquierda_DragDrop(sender As Object, e As DragEventArgs) Handles ltbIzquierda.DragDrop
        ltbIzquierda.Items.Add(ltbDerecha.SelectedItem)
        ltbDerecha.Items.Remove(ltbDerecha.SelectedItem)
    End Sub

    Private Sub ltbDerecha_DragDrop(sender As Object, e As DragEventArgs) Handles ltbDerecha.DragDrop
        ltbDerecha.Items.Add(ltbIzquierda.SelectedItem)
        ltbIzquierda.Items.Remove(ltbIzquierda.SelectedItem)
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        ltbDerecha.Items.Add(ltbIzquierda.SelectedItem)
        ltbIzquierda.Items.Remove(ltbIzquierda.SelectedItem)
    End Sub

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        ltbIzquierda.Items.Add(ltbDerecha.SelectedItem)
        ltbDerecha.Items.Remove(ltbDerecha.SelectedItem)
    End Sub

    Private Sub btnDerechaTodo_Click(sender As Object, e As EventArgs) Handles btnDerechaTodo.Click
        ltbDerecha.Items.Add(ltbIzquierda.Items)
        ltbIzquierda.Items.Remove(ltbIzquierda.Items)
    End Sub

    Private Sub btnIzquierdaTodo_Click(sender As Object, e As EventArgs) Handles btnIzquierdaTodo.Click

    End Sub


End Class
