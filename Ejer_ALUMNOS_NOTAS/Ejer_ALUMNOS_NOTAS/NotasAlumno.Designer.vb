<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasAlumno
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
        Me.rtxtbox_NotasAlumno = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxtbox_NotasAlumno
        '
        Me.rtxtbox_NotasAlumno.Location = New System.Drawing.Point(38, 34)
        Me.rtxtbox_NotasAlumno.Name = "rtxtbox_NotasAlumno"
        Me.rtxtbox_NotasAlumno.Size = New System.Drawing.Size(996, 632)
        Me.rtxtbox_NotasAlumno.TabIndex = 0
        Me.rtxtbox_NotasAlumno.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(77, 707)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(149, 34)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'NotasAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 795)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.rtxtbox_NotasAlumno)
        Me.Name = "NotasAlumno"
        Me.Text = "NotasAlumno"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtxtbox_NotasAlumno As RichTextBox
    Friend WithEvents btnVolver As Button
End Class
