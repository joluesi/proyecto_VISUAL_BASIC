<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formListadoProductos
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
        Me.richListado = New System.Windows.Forms.RichTextBox()
        Me.btnVolverListado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richListado
        '
        Me.richListado.Location = New System.Drawing.Point(48, 48)
        Me.richListado.Name = "richListado"
        Me.richListado.Size = New System.Drawing.Size(550, 373)
        Me.richListado.TabIndex = 0
        Me.richListado.Text = ""
        '
        'btnVolverListado
        '
        Me.btnVolverListado.Location = New System.Drawing.Point(48, 450)
        Me.btnVolverListado.Name = "btnVolverListado"
        Me.btnVolverListado.Size = New System.Drawing.Size(544, 40)
        Me.btnVolverListado.TabIndex = 1
        Me.btnVolverListado.Text = "Volver"
        Me.btnVolverListado.UseVisualStyleBackColor = True
        '
        'formListadoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 516)
        Me.Controls.Add(Me.btnVolverListado)
        Me.Controls.Add(Me.richListado)
        Me.Name = "formListadoProductos"
        Me.Text = "formListadoProductos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents richListado As RichTextBox
    Friend WithEvents btnVolverListado As Button
End Class
