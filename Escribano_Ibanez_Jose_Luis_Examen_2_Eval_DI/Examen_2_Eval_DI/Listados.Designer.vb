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
        Me.btnListadoTodosPEDIDOS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProductosXCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(160, 219)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnListadoTodosPEDIDOS
        '
        Me.btnListadoTodosPEDIDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoTodosPEDIDOS.Location = New System.Drawing.Point(53, 138)
        Me.btnListadoTodosPEDIDOS.Name = "btnListadoTodosPEDIDOS"
        Me.btnListadoTodosPEDIDOS.Size = New System.Drawing.Size(355, 31)
        Me.btnListadoTodosPEDIDOS.TabIndex = 16
        Me.btnListadoTodosPEDIDOS.Text = "Todos los pedidos cursados"
        Me.btnListadoTodosPEDIDOS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Listados:"
        '
        'btnProductosXCliente
        '
        Me.btnProductosXCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductosXCliente.Location = New System.Drawing.Point(53, 78)
        Me.btnProductosXCliente.Name = "btnProductosXCliente"
        Me.btnProductosXCliente.Size = New System.Drawing.Size(355, 31)
        Me.btnProductosXCliente.TabIndex = 14
        Me.btnProductosXCliente.Text = "Pedidos cursados por COD. cliente"
        Me.btnProductosXCliente.UseVisualStyleBackColor = True
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 302)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnListadoTodosPEDIDOS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProductosXCliente)
        Me.Name = "Listados"
        Me.Text = "Listados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnListadoTodosPEDIDOS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProductosXCliente As Button
End Class
