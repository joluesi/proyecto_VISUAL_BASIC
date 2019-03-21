<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desbloquear
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodDesblo = New System.Windows.Forms.TextBox()
        Me.txtClaveDesblo = New System.Windows.Forms.TextBox()
        Me.btnDesbloquear = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave Cliente:"
        '
        'txtCodDesblo
        '
        Me.txtCodDesblo.Location = New System.Drawing.Point(165, 96)
        Me.txtCodDesblo.Name = "txtCodDesblo"
        Me.txtCodDesblo.Size = New System.Drawing.Size(134, 20)
        Me.txtCodDesblo.TabIndex = 2
        '
        'txtClaveDesblo
        '
        Me.txtClaveDesblo.Location = New System.Drawing.Point(165, 150)
        Me.txtClaveDesblo.Name = "txtClaveDesblo"
        Me.txtClaveDesblo.Size = New System.Drawing.Size(134, 20)
        Me.txtClaveDesblo.TabIndex = 3
        '
        'btnDesbloquear
        '
        Me.btnDesbloquear.Location = New System.Drawing.Point(165, 210)
        Me.btnDesbloquear.Name = "btnDesbloquear"
        Me.btnDesbloquear.Size = New System.Drawing.Size(117, 32)
        Me.btnDesbloquear.TabIndex = 4
        Me.btnDesbloquear.Text = "DESBLOQUEAR"
        Me.btnDesbloquear.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(165, 273)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(117, 32)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Desbloquear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 379)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnDesbloquear)
        Me.Controls.Add(Me.txtClaveDesblo)
        Me.Controls.Add(Me.txtCodDesblo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Desbloquear"
        Me.Text = "Desbloquear"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodDesblo As TextBox
    Friend WithEvents txtClaveDesblo As TextBox
    Friend WithEvents btnDesbloquear As Button
    Friend WithEvents btnVolver As Button
End Class
