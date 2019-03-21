<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presupuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rtxbPresupuesto = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtxbPresupuesto
        '
        Me.rtxbPresupuesto.Location = New System.Drawing.Point(12, 49)
        Me.rtxbPresupuesto.Name = "rtxbPresupuesto"
        Me.rtxbPresupuesto.Size = New System.Drawing.Size(759, 402)
        Me.rtxbPresupuesto.TabIndex = 0
        Me.rtxbPresupuesto.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(281, 488)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(147, 34)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.Location = New System.Drawing.Point(12, 9)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(254, 24)
        Me.lblDetalle.TabIndex = 2
        Me.lblDetalle.Text = "Su presupuesto detallado:"
        '
        'Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.rtxbPresupuesto)
        Me.Name = "Presupuesto"
        Me.Text = "Presupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtxbPresupuesto As RichTextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblDetalle As Label
End Class
