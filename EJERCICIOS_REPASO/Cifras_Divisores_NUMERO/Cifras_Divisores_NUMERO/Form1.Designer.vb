<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCifras = New System.Windows.Forms.TextBox()
        Me.txtSumaCifrasImpares = New System.Windows.Forms.TextBox()
        Me.txtSumaCifrasPares = New System.Windows.Forms.TextBox()
        Me.txtTotalCifras = New System.Windows.Forms.TextBox()
        Me.txtCifraMayor = New System.Windows.Forms.TextBox()
        Me.txtCifraMenor = New System.Windows.Forms.TextBox()
        Me.txtDivisores = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca un número:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad de cifras:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Suma de cifras impares:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Suma de cifras pares:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Suma total de cifras:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cifra mayor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(70, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cifra menor:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(301, 57)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 7
        '
        'txtCifras
        '
        Me.txtCifras.Location = New System.Drawing.Point(301, 155)
        Me.txtCifras.Name = "txtCifras"
        Me.txtCifras.Size = New System.Drawing.Size(100, 20)
        Me.txtCifras.TabIndex = 8
        '
        'txtSumaCifrasImpares
        '
        Me.txtSumaCifrasImpares.Location = New System.Drawing.Point(301, 206)
        Me.txtSumaCifrasImpares.Name = "txtSumaCifrasImpares"
        Me.txtSumaCifrasImpares.Size = New System.Drawing.Size(100, 20)
        Me.txtSumaCifrasImpares.TabIndex = 9
        '
        'txtSumaCifrasPares
        '
        Me.txtSumaCifrasPares.Location = New System.Drawing.Point(301, 257)
        Me.txtSumaCifrasPares.Name = "txtSumaCifrasPares"
        Me.txtSumaCifrasPares.Size = New System.Drawing.Size(100, 20)
        Me.txtSumaCifrasPares.TabIndex = 10
        '
        'txtTotalCifras
        '
        Me.txtTotalCifras.Location = New System.Drawing.Point(301, 303)
        Me.txtTotalCifras.Name = "txtTotalCifras"
        Me.txtTotalCifras.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCifras.TabIndex = 11
        '
        'txtCifraMayor
        '
        Me.txtCifraMayor.Location = New System.Drawing.Point(301, 350)
        Me.txtCifraMayor.Name = "txtCifraMayor"
        Me.txtCifraMayor.Size = New System.Drawing.Size(100, 20)
        Me.txtCifraMayor.TabIndex = 12
        '
        'txtCifraMenor
        '
        Me.txtCifraMenor.Location = New System.Drawing.Point(301, 398)
        Me.txtCifraMenor.Name = "txtCifraMenor"
        Me.txtCifraMenor.Size = New System.Drawing.Size(100, 20)
        Me.txtCifraMenor.TabIndex = 13
        '
        'txtDivisores
        '
        Me.txtDivisores.Location = New System.Drawing.Point(480, 179)
        Me.txtDivisores.Multiline = True
        Me.txtDivisores.Name = "txtDivisores"
        Me.txtDivisores.Size = New System.Drawing.Size(261, 239)
        Me.txtDivisores.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Divisores:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(553, 89)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 41)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(480, 23)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(114, 41)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(627, 23)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(114, 41)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 472)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDivisores)
        Me.Controls.Add(Me.txtCifraMenor)
        Me.Controls.Add(Me.txtCifraMayor)
        Me.Controls.Add(Me.txtTotalCifras)
        Me.Controls.Add(Me.txtSumaCifrasPares)
        Me.Controls.Add(Me.txtSumaCifrasImpares)
        Me.Controls.Add(Me.txtCifras)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCifras As TextBox
    Friend WithEvents txtSumaCifrasImpares As TextBox
    Friend WithEvents txtSumaCifrasPares As TextBox
    Friend WithEvents txtTotalCifras As TextBox
    Friend WithEvents txtCifraMayor As TextBox
    Friend WithEvents txtCifraMenor As TextBox
    Friend WithEvents txtDivisores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
End Class
