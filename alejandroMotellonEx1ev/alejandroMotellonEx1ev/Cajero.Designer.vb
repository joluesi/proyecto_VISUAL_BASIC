<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajero
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPantalla = New System.Windows.Forms.TextBox()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReintegro
        '
        Me.btnReintegro.Location = New System.Drawing.Point(40, 86)
        Me.btnReintegro.Name = "btnReintegro"
        Me.btnReintegro.Size = New System.Drawing.Size(121, 35)
        Me.btnReintegro.TabIndex = 0
        Me.btnReintegro.Text = "REINTEGRO"
        Me.btnReintegro.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(40, 173)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(121, 35)
        Me.btnIngreso.TabIndex = 1
        Me.btnIngreso.Text = "INGRESO"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(40, 257)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(121, 35)
        Me.btnSaldo.TabIndex = 2
        Me.btnSaldo.Text = "SALDO"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CAJERO"
        '
        'txtPantalla
        '
        Me.txtPantalla.Location = New System.Drawing.Point(220, 103)
        Me.txtPantalla.Multiline = True
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.ReadOnly = True
        Me.txtPantalla.Size = New System.Drawing.Size(262, 54)
        Me.txtPantalla.TabIndex = 4
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(254, 194)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(75, 23)
        Me.btn20.TabIndex = 5
        Me.btn20.Text = "20"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Location = New System.Drawing.Point(377, 194)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(75, 23)
        Me.btn50.TabIndex = 6
        Me.btn50.Text = "50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Location = New System.Drawing.Point(254, 235)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(75, 23)
        Me.btn100.TabIndex = 7
        Me.btn100.Text = "100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Location = New System.Drawing.Point(377, 235)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(75, 23)
        Me.btn200.TabIndex = 8
        Me.btn200.Text = "200"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(317, 285)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Cajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 338)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.txtPantalla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaldo)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnReintegro)
        Me.Name = "Cajero"
        Me.Text = "Cajero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReintegro As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnSaldo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPantalla As TextBox
    Friend WithEvents btn20 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btnCancelar As Button
End Class
