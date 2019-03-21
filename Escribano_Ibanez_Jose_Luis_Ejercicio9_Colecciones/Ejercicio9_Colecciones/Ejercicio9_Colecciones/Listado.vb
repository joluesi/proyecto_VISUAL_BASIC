Imports System.ComponentModel

Public Class Listado
    Public cambios As Boolean = False

    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Listado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If cambios = True Then
            Dim result As DialogResult = MessageBox.Show("¿Desea guardar los cambios?", Me.Text,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If result = DialogResult.Cancel Then
                e.Cancel = True
            End If

            If result = DialogResult.Yes Then
                Form1.guardar()
            End If

            If result = DialogResult.No Then
                cambios = False
            End If
        End If
    End Sub

    Private Sub rich1_TextChanged(sender As Object, e As EventArgs) Handles rtboxListado.TextChanged

        cambios = True

    End Sub
End Class