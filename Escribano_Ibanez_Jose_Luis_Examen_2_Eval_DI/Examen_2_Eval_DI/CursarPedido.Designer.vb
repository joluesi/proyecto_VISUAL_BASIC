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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnCursarPedido = New System.Windows.Forms.Button()
        Me.txtcodPedCursar = New System.Windows.Forms.TextBox()
        Me.txtCliPedCursar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Código de pedido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente del pedido:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(278, 219)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnCursarPedido
        '
        Me.btnCursarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCursarPedido.Location = New System.Drawing.Point(48, 219)
        Me.btnCursarPedido.Name = "btnCursarPedido"
        Me.btnCursarPedido.Size = New System.Drawing.Size(179, 32)
        Me.btnCursarPedido.TabIndex = 12
        Me.btnCursarPedido.Text = "Cursar Pedido"
        Me.btnCursarPedido.UseVisualStyleBackColor = True
        '
        'txtcodPedCursar
        '
        Me.txtcodPedCursar.Location = New System.Drawing.Point(273, 80)
        Me.txtcodPedCursar.Name = "txtcodPedCursar"
        Me.txtcodPedCursar.Size = New System.Drawing.Size(129, 20)
        Me.txtcodPedCursar.TabIndex = 14
        '
        'txtCliPedCursar
        '
        Me.txtCliPedCursar.Location = New System.Drawing.Point(273, 142)
        Me.txtCliPedCursar.Name = "txtCliPedCursar"
        Me.txtCliPedCursar.Size = New System.Drawing.Size(129, 20)
        Me.txtCliPedCursar.TabIndex = 15
        '
        'CursarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 450)
        Me.Controls.Add(Me.txtCliPedCursar)
        Me.Controls.Add(Me.txtcodPedCursar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCursarPedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "CursarPedido"
        Me.Text = "CursarPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnCursarPedido As Button
    Friend WithEvents txtcodPedCursar As TextBox
    Friend WithEvents txtCliPedCursar As TextBox
End Class
