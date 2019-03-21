<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnReintegro = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReintegro
        '
        Me.btnReintegro.Location = New System.Drawing.Point(64, 287)
        Me.btnReintegro.Name = "btnReintegro"
        Me.btnReintegro.Size = New System.Drawing.Size(75, 23)
        Me.btnReintegro.TabIndex = 0
        Me.btnReintegro.Text = "Reintegro"
        Me.btnReintegro.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(166, 287)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(75, 23)
        Me.btnIngreso.TabIndex = 0
        Me.btnIngreso.Text = "Ingreso"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(266, 287)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(75, 23)
        Me.btnSaldo.TabIndex = 0
        Me.btnSaldo.Text = "Saldo"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.HideSelection = False
        Me.txtSaldo.Location = New System.Drawing.Point(157, 105)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 1
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(123, 150)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(75, 23)
        Me.btn20.TabIndex = 2
        Me.btn20.Text = "20€"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(210, 150)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(75, 23)
        Me.btn50.TabIndex = 2
        Me.btn50.Text = "50€"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(123, 179)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(75, 23)
        Me.btn100.TabIndex = 2
        Me.btn100.Text = "100€"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Location = New System.Drawing.Point(210, 179)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(75, 23)
        Me.btn200.TabIndex = 2
        Me.btn200.Text = "200€"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(314, 333)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 381)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.btnSaldo)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnReintegro)
        Me.KeyPreview = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReintegro As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnSaldo As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents btn20 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btnCancelar As Button
End Class
