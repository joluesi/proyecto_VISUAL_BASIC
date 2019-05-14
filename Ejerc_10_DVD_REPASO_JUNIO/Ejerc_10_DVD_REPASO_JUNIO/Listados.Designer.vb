<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listados
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnListadoDVD_NO_ALQUI = New System.Windows.Forms.Button()
        Me.btnListadoClienteDVD = New System.Windows.Forms.Button()
        Me.btnListadoTodosDVD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnListadoXCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(183, 348)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnListadoDVD_NO_ALQUI
        '
        Me.btnListadoDVD_NO_ALQUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoDVD_NO_ALQUI.Location = New System.Drawing.Point(68, 205)
        Me.btnListadoDVD_NO_ALQUI.Name = "btnListadoDVD_NO_ALQUI"
        Me.btnListadoDVD_NO_ALQUI.Size = New System.Drawing.Size(355, 31)
        Me.btnListadoDVD_NO_ALQUI.TabIndex = 18
        Me.btnListadoDVD_NO_ALQUI.Text = "Todos los DVD´s NO alquilados"
        Me.btnListadoDVD_NO_ALQUI.UseVisualStyleBackColor = True
        '
        'btnListadoClienteDVD
        '
        Me.btnListadoClienteDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoClienteDVD.Location = New System.Drawing.Point(68, 266)
        Me.btnListadoClienteDVD.Name = "btnListadoClienteDVD"
        Me.btnListadoClienteDVD.Size = New System.Drawing.Size(355, 31)
        Me.btnListadoClienteDVD.TabIndex = 17
        Me.btnListadoClienteDVD.Text = "Qué Cliente tiene un DVD en concreto"
        Me.btnListadoClienteDVD.UseVisualStyleBackColor = True
        '
        'btnListadoTodosDVD
        '
        Me.btnListadoTodosDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoTodosDVD.Location = New System.Drawing.Point(68, 143)
        Me.btnListadoTodosDVD.Name = "btnListadoTodosDVD"
        Me.btnListadoTodosDVD.Size = New System.Drawing.Size(355, 31)
        Me.btnListadoTodosDVD.TabIndex = 16
        Me.btnListadoTodosDVD.Text = "Todos los DVD´s alquilados"
        Me.btnListadoTodosDVD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Listados / Consultas"
        '
        'btnListadoXCliente
        '
        Me.btnListadoXCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoXCliente.Location = New System.Drawing.Point(68, 83)
        Me.btnListadoXCliente.Name = "btnListadoXCliente"
        Me.btnListadoXCliente.Size = New System.Drawing.Size(355, 31)
        Me.btnListadoXCliente.TabIndex = 14
        Me.btnListadoXCliente.Text = "DVD´s alquilados por COD. cliente"
        Me.btnListadoXCliente.UseVisualStyleBackColor = True
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnListadoDVD_NO_ALQUI)
        Me.Controls.Add(Me.btnListadoClienteDVD)
        Me.Controls.Add(Me.btnListadoTodosDVD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnListadoXCliente)
        Me.Name = "Listados"
        Me.Text = "Listados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnListadoDVD_NO_ALQUI As Button
    Friend WithEvents btnListadoClienteDVD As Button
    Friend WithEvents btnListadoTodosDVD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnListadoXCliente As Button
End Class
