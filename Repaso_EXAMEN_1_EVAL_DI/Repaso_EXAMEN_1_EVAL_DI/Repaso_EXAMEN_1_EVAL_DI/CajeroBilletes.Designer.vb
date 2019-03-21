<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CajeroBilletes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReintegro = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn50 = New System.Windows.Forms.Button()
        Me.btn200 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido. Seleccione su opción: "
        '
        'btnReintegro
        '
        Me.btnReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReintegro.Location = New System.Drawing.Point(50, 216)
        Me.btnReintegro.Name = "btnReintegro"
        Me.btnReintegro.Size = New System.Drawing.Size(111, 27)
        Me.btnReintegro.TabIndex = 1
        Me.btnReintegro.Text = "REINTEGRO"
        Me.btnReintegro.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.Location = New System.Drawing.Point(207, 216)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(111, 27)
        Me.btnIngreso.TabIndex = 2
        Me.btnIngreso.Text = "INGRESO"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnSaldo
        '
        Me.btnSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldo.Location = New System.Drawing.Point(365, 216)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(135, 27)
        Me.btnSaldo.TabIndex = 3
        Me.btnSaldo.Text = "Mostrar SALDO"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(50, 85)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(450, 96)
        Me.txtDisplay.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(568, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Seleccione billetes (€):"
        '
        'btn20
        '
        Me.btn20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn20.Location = New System.Drawing.Point(613, 85)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(74, 53)
        Me.btn20.TabIndex = 6
        Me.btn20.Text = "20"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.Location = New System.Drawing.Point(613, 231)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(74, 53)
        Me.btn100.TabIndex = 7
        Me.btn100.Text = "100"
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btn50
        '
        Me.btn50.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn50.Location = New System.Drawing.Point(613, 159)
        Me.btn50.Name = "btn50"
        Me.btn50.Size = New System.Drawing.Size(74, 54)
        Me.btn50.TabIndex = 8
        Me.btn50.Text = "50"
        Me.btn50.UseVisualStyleBackColor = True
        '
        'btn200
        '
        Me.btn200.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.Location = New System.Drawing.Point(613, 302)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(74, 54)
        Me.btn200.TabIndex = 9
        Me.btn200.Text = "200"
        Me.btn200.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(154, 302)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(220, 27)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'CajeroBilletes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn50)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnSaldo)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnReintegro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CajeroBilletes"
        Me.Text = "CajeroBilletes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnReintegro As Button
    Friend WithEvents btnIngreso As Button
    Friend WithEvents btnSaldo As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn20 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn50 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btnVolver As Button
End Class
