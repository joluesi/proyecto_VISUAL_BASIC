<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btnCancelar4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReintegro
        '
        Me.btnReintegro.Location = New System.Drawing.Point(12, 46)
        Me.btnReintegro.Name = "btnReintegro"
        Me.btnReintegro.Size = New System.Drawing.Size(133, 65)
        Me.btnReintegro.TabIndex = 0
        Me.btnReintegro.Text = "Reintegro"
        Me.btnReintegro.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(180, 46)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(133, 65)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "Ingreso"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(348, 46)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(133, 65)
        Me.btnSaldo.TabIndex = 2
        Me.btnSaldo.Text = "Saldo"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(13, 144)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(468, 54)
        Me.txtCantidad.TabIndex = 3
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(13, 218)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(74, 76)
        Me.btn20.TabIndex = 4
        Me.btn20.Text = "20€"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(93, 218)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(74, 76)
        Me.btn50.TabIndex = 5
        Me.btn50.Text = "50€"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(173, 218)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(74, 76)
        Me.btn100.TabIndex = 6
        Me.btn100.Text = "100€"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Location = New System.Drawing.Point(253, 218)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(74, 76)
        Me.btn200.TabIndex = 7
        Me.btn200.Text = "200€"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btnCancelar4
        '
        Me.btnCancelar4.Location = New System.Drawing.Point(334, 218)
        Me.btnCancelar4.Name = "btnCancelar4"
        Me.btnCancelar4.Size = New System.Drawing.Size(147, 76)
        Me.btnCancelar4.TabIndex = 8
        Me.btnCancelar4.Text = "CANCELAR"
        Me.btnCancelar4.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 306)
        Me.Controls.Add(Me.btnCancelar4)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnSaldo)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnReintegro)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReintegro As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSaldo As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btn20 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btnCancelar4 As Button
End Class
