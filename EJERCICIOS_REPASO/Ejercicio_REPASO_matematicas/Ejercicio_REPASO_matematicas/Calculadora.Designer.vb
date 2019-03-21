<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.lbl_num1 = New System.Windows.Forms.Label()
        Me.lbl_num2 = New System.Windows.Forms.Label()
        Me.lbl_solucion = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtSolucion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_num1
        '
        Me.lbl_num1.AutoSize = True
        Me.lbl_num1.Location = New System.Drawing.Point(112, 82)
        Me.lbl_num1.Name = "lbl_num1"
        Me.lbl_num1.Size = New System.Drawing.Size(53, 13)
        Me.lbl_num1.TabIndex = 0
        Me.lbl_num1.Text = "Nümero 1"
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(202, 82)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(53, 13)
        Me.lbl_num2.TabIndex = 1
        Me.lbl_num2.Text = "Nümero 2"
        '
        'lbl_solucion
        '
        Me.lbl_solucion.AutoSize = True
        Me.lbl_solucion.Location = New System.Drawing.Point(454, 151)
        Me.lbl_solucion.Name = "lbl_solucion"
        Me.lbl_solucion.Size = New System.Drawing.Size(48, 13)
        Me.lbl_solucion.TabIndex = 2
        Me.lbl_solucion.Text = "Solución"
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(314, 82)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(60, 50)
        Me.btnSuma.TabIndex = 3
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(142, 203)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(87, 33)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(314, 151)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(60, 50)
        Me.btnResta.TabIndex = 5
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.Location = New System.Drawing.Point(314, 218)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(60, 50)
        Me.btnMulti.TabIndex = 6
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(314, 286)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(60, 50)
        Me.btnDividir.TabIndex = 7
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(115, 112)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(65, 20)
        Me.txtNum1.TabIndex = 8
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(205, 112)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(65, 20)
        Me.txtNum2.TabIndex = 9
        '
        'txtSolucion
        '
        Me.txtSolucion.Location = New System.Drawing.Point(457, 181)
        Me.txtSolucion.Name = "txtSolucion"
        Me.txtSolucion.Size = New System.Drawing.Size(106, 20)
        Me.txtSolucion.TabIndex = 10
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSolucion)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.lbl_solucion)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.lbl_num1)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_num1 As Label
    Friend WithEvents lbl_num2 As Label
    Friend WithEvents lbl_solucion As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtSolucion As TextBox
End Class
