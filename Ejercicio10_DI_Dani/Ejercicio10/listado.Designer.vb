<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado
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
        Me.btnComprobarCodigo = New System.Windows.Forms.Button()
        Me.btnTodosAlquilados = New System.Windows.Forms.Button()
        Me.btnTodosNoAlquilados = New System.Windows.Forms.Button()
        Me.btnVolverListado = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnComprobarCodigo
        '
        Me.btnComprobarCodigo.Location = New System.Drawing.Point(12, 41)
        Me.btnComprobarCodigo.Name = "btnComprobarCodigo"
        Me.btnComprobarCodigo.Size = New System.Drawing.Size(110, 64)
        Me.btnComprobarCodigo.TabIndex = 0
        Me.btnComprobarCodigo.Text = "Comprobar por codigo de cliente"
        Me.btnComprobarCodigo.UseVisualStyleBackColor = True
        '
        'btnTodosAlquilados
        '
        Me.btnTodosAlquilados.Location = New System.Drawing.Point(140, 41)
        Me.btnTodosAlquilados.Name = "btnTodosAlquilados"
        Me.btnTodosAlquilados.Size = New System.Drawing.Size(110, 64)
        Me.btnTodosAlquilados.TabIndex = 1
        Me.btnTodosAlquilados.Text = "Todos los DVD alquilados"
        Me.btnTodosAlquilados.UseVisualStyleBackColor = True
        '
        'btnTodosNoAlquilados
        '
        Me.btnTodosNoAlquilados.Location = New System.Drawing.Point(271, 41)
        Me.btnTodosNoAlquilados.Name = "btnTodosNoAlquilados"
        Me.btnTodosNoAlquilados.Size = New System.Drawing.Size(110, 64)
        Me.btnTodosNoAlquilados.TabIndex = 2
        Me.btnTodosNoAlquilados.Text = "Todos los DVD No alquilados"
        Me.btnTodosNoAlquilados.UseVisualStyleBackColor = True
        '
        'btnVolverListado
        '
        Me.btnVolverListado.Location = New System.Drawing.Point(12, 141)
        Me.btnVolverListado.Name = "btnVolverListado"
        Me.btnVolverListado.Size = New System.Drawing.Size(498, 37)
        Me.btnVolverListado.TabIndex = 3
        Me.btnVolverListado.Text = "Volver"
        Me.btnVolverListado.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 64)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Que cliente tiene el DVD?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 190)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVolverListado)
        Me.Controls.Add(Me.btnTodosNoAlquilados)
        Me.Controls.Add(Me.btnTodosAlquilados)
        Me.Controls.Add(Me.btnComprobarCodigo)
        Me.Name = "listado"
        Me.Text = "listado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnComprobarCodigo As Button
    Friend WithEvents btnTodosAlquilados As Button
    Friend WithEvents btnTodosNoAlquilados As Button
    Friend WithEvents btnVolverListado As Button
    Friend WithEvents Button1 As Button
End Class
