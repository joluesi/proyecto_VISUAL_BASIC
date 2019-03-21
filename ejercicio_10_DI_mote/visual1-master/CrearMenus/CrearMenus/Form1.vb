Public Class Form1
    Friend WithEvents menuColorAzulFondo, menuColorAzulTexto As ToolStripMenuItem
    Friend WithEvents menuColorVerdeFondo, menuColorVerdeTexto As ToolStripMenuItem
    Friend WithEvents menuColorRojoFondo, menuColorRojoTexto As ToolStripMenuItem

    Friend WithEvents MenuItemPegar As MenuItem
    Friend WithEvents MenuItemCopiar As MenuItem

    Private Sub chkVerde_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerde.CheckedChanged
        If chkVerde.Checked Then
            menuColorVerdeFondo = New ToolStripMenuItem
            menuColorVerdeTexto = New ToolStripMenuItem
            menuColorVerdeFondo.Text = "Verde"
            menuColorVerdeTexto.Text = "Verde"

            tsMenuFondo.DropDownItems.Add(menuColorVerdeFondo)
            tsMenuTexto.DropDownItems.Add(menuColorVerdeTexto)
            AddHandler(menuColorVerdeFondo.Click), AddressOf menuColorVerdeFondo_Click
            AddHandler(menuColorVerdeTexto.Click), AddressOf menuColorVerdeTexto_Click


        Else
            tsMenuFondo.DropDownItems.Remove(menuColorVerdeFondo)
            tsMenuTexto.DropDownItems.Remove(menuColorVerdeTexto)

        End If
    End Sub

    Private Sub chkRojo_CheckedChanged(sender As Object, e As EventArgs) Handles chkRojo.CheckedChanged
        If chkRojo.Checked Then
            menuColorRojoFondo = New ToolStripMenuItem
            menuColorRojoTexto = New ToolStripMenuItem
            menuColorRojoFondo.Text = "Rojo"
            menuColorRojoTexto.Text = "Rojo"

            tsMenuFondo.DropDownItems.Add(menuColorRojoFondo)
            tsMenuTexto.DropDownItems.Add(menuColorRojoTexto)
            AddHandler(menuColorRojoFondo.Click), AddressOf menuColorRojoFondo_Click
            AddHandler(menuColorRojoTexto.Click), AddressOf menuColorRojoTexto_Click

        Else
            tsMenuFondo.DropDownItems.Remove(menuColorRojoFondo)
            tsMenuTexto.DropDownItems.Remove(menuColorRojoTexto)

        End If
    End Sub

    Private Sub chkAzul_CheckedChanged(sender As Object, e As EventArgs) Handles chkAzul.CheckedChanged
        If chkAzul.Checked Then
            menuColorAzulFondo = New ToolStripMenuItem
            menuColorAzulTexto = New ToolStripMenuItem
            menuColorAzulFondo.Text = "Azul"
            menuColorAzulTexto.Text = "Azul"

            tsMenuFondo.DropDownItems.Add(menuColorAzulFondo)
            tsMenuTexto.DropDownItems.Add(menuColorAzulTexto)
            AddHandler(menuColorAzulFondo.Click), AddressOf menuColorAzulFondo_Click
            AddHandler(menuColorAzulTexto.Click), AddressOf menuColorAzulTexto_Click

        Else
            tsMenuFondo.DropDownItems.Remove(menuColorAzulFondo)
            tsMenuTexto.DropDownItems.Remove(menuColorAzulTexto)

        End If
    End Sub

    Sub menuColorVerdeFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuColorVerdeFondo.Click
        Me.BackColor = Color.Green
    End Sub
    Sub menuColorVerdeTexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuColorVerdeTexto.Click
        txtBox.ForeColor = Color.Green
    End Sub
    Sub menuColorAzulFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuColorAzulFondo.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

    End Sub

    Sub menuColorAzulTexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuColorAzulTexto.Click
        txtBox.ForeColor = Color.Blue
    End Sub
    Sub menuColorRojoFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuColorRojoFondo.Click
        Me.BackColor = Color.Red
    End Sub
    Sub menuColorRojoTexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuColorRojoTexto.Click
        txtBox.ForeColor = Color.Red
    End Sub

End Class
