<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CursarPedido
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
        Me.richtxtb_CursarPedido = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richtxtb_CursarPedido
        '
        Me.richtxtb_CursarPedido.Location = New System.Drawing.Point(35, 34)
        Me.richtxtb_CursarPedido.Name = "richtxtb_CursarPedido"
        Me.richtxtb_CursarPedido.Size = New System.Drawing.Size(730, 487)
        Me.richtxtb_CursarPedido.TabIndex = 0
        Me.richtxtb_CursarPedido.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(56, 558)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(118, 39)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'CursarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 653)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.richtxtb_CursarPedido)
        Me.Name = "CursarPedido"
        Me.Text = "Cursar Pedido"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents richtxtb_CursarPedido As RichTextBox
    Friend WithEvents btnVolver As Button
End Class
