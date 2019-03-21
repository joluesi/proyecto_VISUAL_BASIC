<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolver
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
        Me.gbDevolver = New System.Windows.Forms.GroupBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtcodigoDevolver = New System.Windows.Forms.TextBox()
        Me.lblCodigoDevolver = New System.Windows.Forms.Label()
        Me.txtDiasTrans = New System.Windows.Forms.TextBox()
        Me.lblDiasTrans = New System.Windows.Forms.Label()
        Me.gbDevolver.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDevolver
        '
        Me.gbDevolver.Controls.Add(Me.txtDiasTrans)
        Me.gbDevolver.Controls.Add(Me.lblDiasTrans)
        Me.gbDevolver.Controls.Add(Me.btnVolver)
        Me.gbDevolver.Controls.Add(Me.btnAceptar)
        Me.gbDevolver.Controls.Add(Me.txtcodigoDevolver)
        Me.gbDevolver.Controls.Add(Me.lblCodigoDevolver)
        Me.gbDevolver.Location = New System.Drawing.Point(57, 37)
        Me.gbDevolver.Name = "gbDevolver"
        Me.gbDevolver.Size = New System.Drawing.Size(362, 343)
        Me.gbDevolver.TabIndex = 1
        Me.gbDevolver.TabStop = False
        Me.gbDevolver.Text = "Devolver"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(150, 143)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(101, 33)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(150, 91)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 33)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtcodigoDevolver
        '
        Me.txtcodigoDevolver.Location = New System.Drawing.Point(150, 45)
        Me.txtcodigoDevolver.Name = "txtcodigoDevolver"
        Me.txtcodigoDevolver.Size = New System.Drawing.Size(120, 20)
        Me.txtcodigoDevolver.TabIndex = 5
        '
        'lblCodigoDevolver
        '
        Me.lblCodigoDevolver.AutoSize = True
        Me.lblCodigoDevolver.Location = New System.Drawing.Point(36, 48)
        Me.lblCodigoDevolver.Name = "lblCodigoDevolver"
        Me.lblCodigoDevolver.Size = New System.Drawing.Size(69, 13)
        Me.lblCodigoDevolver.TabIndex = 4
        Me.lblCodigoDevolver.Text = "Código DVD:"
        '
        'txtDiasTrans
        '
        Me.txtDiasTrans.Location = New System.Drawing.Point(150, 245)
        Me.txtDiasTrans.Name = "txtDiasTrans"
        Me.txtDiasTrans.Size = New System.Drawing.Size(120, 20)
        Me.txtDiasTrans.TabIndex = 22
        '
        'lblDiasTrans
        '
        Me.lblDiasTrans.AutoSize = True
        Me.lblDiasTrans.Location = New System.Drawing.Point(36, 248)
        Me.lblDiasTrans.Name = "lblDiasTrans"
        Me.lblDiasTrans.Size = New System.Drawing.Size(96, 13)
        Me.lblDiasTrans.TabIndex = 21
        Me.lblDiasTrans.Text = "Días transcurridos:"
        '
        'Devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbDevolver)
        Me.Name = "Devolver"
        Me.Text = "Devolver"
        Me.gbDevolver.ResumeLayout(False)
        Me.gbDevolver.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDevolver As GroupBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtcodigoDevolver As TextBox
    Friend WithEvents lblCodigoDevolver As Label
    Friend WithEvents txtDiasTrans As TextBox
    Friend WithEvents lblDiasTrans As Label
End Class
