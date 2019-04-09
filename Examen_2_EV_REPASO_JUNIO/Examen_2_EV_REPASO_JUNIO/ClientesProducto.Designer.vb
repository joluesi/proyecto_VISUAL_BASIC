<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesProducto
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
        Me.richtxt_clientesProduc = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richtxt_clientesProduc
        '
        Me.richtxt_clientesProduc.Location = New System.Drawing.Point(0, 0)
        Me.richtxt_clientesProduc.Name = "richtxt_clientesProduc"
        Me.richtxt_clientesProduc.ReadOnly = True
        Me.richtxt_clientesProduc.Size = New System.Drawing.Size(845, 770)
        Me.richtxt_clientesProduc.TabIndex = 0
        Me.richtxt_clientesProduc.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(508, 672)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(132, 38)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(183, 672)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 38)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar Listado"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'ClientesProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 770)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.richtxt_clientesProduc)
        Me.Name = "ClientesProducto"
        Me.Text = "Clientes de Producto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents richtxt_clientesProduc As RichTextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnGuardar As Button
End Class
