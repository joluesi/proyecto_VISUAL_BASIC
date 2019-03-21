<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ltbIzquierda = New System.Windows.Forms.ListBox()
        Me.ltbDerecha = New System.Windows.Forms.ListBox()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnDerechaTodo = New System.Windows.Forms.Button()
        Me.btnIzquierdaTodo = New System.Windows.Forms.Button()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltbIzquierda
        '
        Me.ltbIzquierda.AllowDrop = True
        Me.ltbIzquierda.FormattingEnabled = True
        Me.ltbIzquierda.Items.AddRange(New Object() {"aa", "bb", "cc", "dd", "ee", "ff"})
        Me.ltbIzquierda.Location = New System.Drawing.Point(127, 98)
        Me.ltbIzquierda.Name = "ltbIzquierda"
        Me.ltbIzquierda.Size = New System.Drawing.Size(120, 160)
        Me.ltbIzquierda.TabIndex = 0
        '
        'ltbDerecha
        '
        Me.ltbDerecha.AllowDrop = True
        Me.ltbDerecha.FormattingEnabled = True
        Me.ltbDerecha.Items.AddRange(New Object() {"11", "22", "33", "44", "55", "66"})
        Me.ltbDerecha.Location = New System.Drawing.Point(382, 98)
        Me.ltbDerecha.Name = "ltbDerecha"
        Me.ltbDerecha.Size = New System.Drawing.Size(120, 160)
        Me.ltbDerecha.TabIndex = 1
        '
        'btnDerecha
        '
        Me.btnDerecha.Location = New System.Drawing.Point(277, 98)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(75, 23)
        Me.btnDerecha.TabIndex = 2
        Me.btnDerecha.Text = ">"
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnDerechaTodo
        '
        Me.btnDerechaTodo.Location = New System.Drawing.Point(277, 143)
        Me.btnDerechaTodo.Name = "btnDerechaTodo"
        Me.btnDerechaTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnDerechaTodo.TabIndex = 3
        Me.btnDerechaTodo.Text = ">>"
        Me.btnDerechaTodo.UseVisualStyleBackColor = True
        '
        'btnIzquierdaTodo
        '
        Me.btnIzquierdaTodo.Location = New System.Drawing.Point(277, 190)
        Me.btnIzquierdaTodo.Name = "btnIzquierdaTodo"
        Me.btnIzquierdaTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnIzquierdaTodo.TabIndex = 4
        Me.btnIzquierdaTodo.Text = "<<"
        Me.btnIzquierdaTodo.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Location = New System.Drawing.Point(277, 235)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(75, 23)
        Me.btnIzquierda.TabIndex = 5
        Me.btnIzquierda.Text = "<"
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 450)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.btnIzquierdaTodo)
        Me.Controls.Add(Me.btnDerechaTodo)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.ltbDerecha)
        Me.Controls.Add(Me.ltbIzquierda)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ltbIzquierda As ListBox
    Friend WithEvents ltbDerecha As ListBox
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnDerechaTodo As Button
    Friend WithEvents btnIzquierdaTodo As Button
    Friend WithEvents btnIzquierda As Button
End Class
