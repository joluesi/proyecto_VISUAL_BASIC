<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCursarPedido
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
        Me.richCursar = New System.Windows.Forms.RichTextBox()
        Me.btnVolverCursar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richCursar
        '
        Me.richCursar.Location = New System.Drawing.Point(40, 45)
        Me.richCursar.Name = "richCursar"
        Me.richCursar.Size = New System.Drawing.Size(520, 317)
        Me.richCursar.TabIndex = 0
        Me.richCursar.Text = ""
        '
        'btnVolverCursar
        '
        Me.btnVolverCursar.Location = New System.Drawing.Point(40, 400)
        Me.btnVolverCursar.Name = "btnVolverCursar"
        Me.btnVolverCursar.Size = New System.Drawing.Size(113, 38)
        Me.btnVolverCursar.TabIndex = 1
        Me.btnVolverCursar.Text = "Volver"
        Me.btnVolverCursar.UseVisualStyleBackColor = True
        '
        'formCursarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 475)
        Me.Controls.Add(Me.btnVolverCursar)
        Me.Controls.Add(Me.richCursar)
        Me.Name = "formCursarPedido"
        Me.Text = "formCursarPedido"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents richCursar As RichTextBox
    Friend WithEvents btnVolverCursar As Button
End Class
