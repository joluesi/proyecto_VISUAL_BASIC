<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsMenuFondo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBox = New System.Windows.Forms.RichTextBox()
        Me.chkAzul = New System.Windows.Forms.CheckBox()
        Me.chkVerde = New System.Windows.Forms.CheckBox()
        Me.chkRojo = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMenuFondo, Me.tsMenuTexto})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(291, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsMenuFondo
        '
        Me.tsMenuFondo.Name = "tsMenuFondo"
        Me.tsMenuFondo.Size = New System.Drawing.Size(53, 20)
        Me.tsMenuFondo.Text = "Fondo"
        '
        'tsMenuTexto
        '
        Me.tsMenuTexto.Name = "tsMenuTexto"
        Me.tsMenuTexto.Size = New System.Drawing.Size(55, 20)
        Me.tsMenuTexto.Text = "Fuente"
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(12, 70)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(244, 134)
        Me.txtBox.TabIndex = 1
        Me.txtBox.Text = ""
        '
        'chkAzul
        '
        Me.chkAzul.AutoSize = True
        Me.chkAzul.Location = New System.Drawing.Point(12, 38)
        Me.chkAzul.Name = "chkAzul"
        Me.chkAzul.Size = New System.Drawing.Size(46, 17)
        Me.chkAzul.TabIndex = 2
        Me.chkAzul.Text = "Azúl"
        Me.chkAzul.UseVisualStyleBackColor = True
        '
        'chkVerde
        '
        Me.chkVerde.AutoSize = True
        Me.chkVerde.Location = New System.Drawing.Point(99, 38)
        Me.chkVerde.Name = "chkVerde"
        Me.chkVerde.Size = New System.Drawing.Size(54, 17)
        Me.chkVerde.TabIndex = 3
        Me.chkVerde.Text = "Verde"
        Me.chkVerde.UseVisualStyleBackColor = True
        '
        'chkRojo
        '
        Me.chkRojo.AutoSize = True
        Me.chkRojo.Location = New System.Drawing.Point(186, 38)
        Me.chkRojo.Name = "chkRojo"
        Me.chkRojo.Size = New System.Drawing.Size(48, 17)
        Me.chkRojo.TabIndex = 4
        Me.chkRojo.Text = "Rojo"
        Me.chkRojo.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 114)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 450)
        Me.Controls.Add(Me.chkRojo)
        Me.Controls.Add(Me.chkVerde)
        Me.Controls.Add(Me.chkAzul)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsMenuFondo As ToolStripMenuItem
    Friend WithEvents tsMenuTexto As ToolStripMenuItem
    Friend WithEvents txtBox As RichTextBox
    Friend WithEvents chkAzul As CheckBox
    Friend WithEvents chkVerde As CheckBox
    Friend WithEvents chkRojo As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
