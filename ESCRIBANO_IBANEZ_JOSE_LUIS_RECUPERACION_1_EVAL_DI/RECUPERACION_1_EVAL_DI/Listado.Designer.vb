<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado
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
        Me.gbListado = New System.Windows.Forms.GroupBox()
        Me.txtListado = New System.Windows.Forms.TextBox()
        Me.gbListado.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbListado
        '
        Me.gbListado.Controls.Add(Me.txtListado)
        Me.gbListado.Location = New System.Drawing.Point(23, 25)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(765, 402)
        Me.gbListado.TabIndex = 0
        Me.gbListado.TabStop = False
        Me.gbListado.Text = "Listado"
        '
        'txtListado
        '
        Me.txtListado.Location = New System.Drawing.Point(7, 20)
        Me.txtListado.Multiline = True
        Me.txtListado.Name = "txtListado"
        Me.txtListado.Size = New System.Drawing.Size(752, 376)
        Me.txtListado.TabIndex = 0
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbListado)
        Me.Name = "Listado"
        Me.Text = "Listado"
        Me.gbListado.ResumeLayout(False)
        Me.gbListado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbListado As GroupBox
    Friend WithEvents txtListado As TextBox
End Class
