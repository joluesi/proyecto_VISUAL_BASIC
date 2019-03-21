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
        Me.btnAzar = New System.Windows.Forms.Button()
        Me.txtNumeroAzar = New System.Windows.Forms.TextBox()
        Me.btnAzarRangos = New System.Windows.Forms.Button()
        Me.lbl_N_Inf = New System.Windows.Forms.Label()
        Me.lbl_N_Sup = New System.Windows.Forms.Label()
        Me.txtInferior = New System.Windows.Forms.TextBox()
        Me.txtSuperior = New System.Windows.Forms.TextBox()
        Me.txtAzarRangos = New System.Windows.Forms.TextBox()
        Me.txtEjecutarRaiz = New System.Windows.Forms.TextBox()
        Me.txtNumeroRaiz = New System.Windows.Forms.TextBox()
        Me.txtRaiz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Raiz = New System.Windows.Forms.Label()
        Me.btnEjecutarRaiz = New System.Windows.Forms.Button()
        Me.txtEjecutarDecimales = New System.Windows.Forms.TextBox()
        Me.txtDecimales = New System.Windows.Forms.TextBox()
        Me.txtNumeroDecimal = New System.Windows.Forms.TextBox()
        Me.lbl_Decimales = New System.Windows.Forms.Label()
        Me.lbl_Num_Decimal = New System.Windows.Forms.Label()
        Me.btnEjecutarDecimal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAzar
        '
        Me.btnAzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAzar.Location = New System.Drawing.Point(94, 70)
        Me.btnAzar.Name = "btnAzar"
        Me.btnAzar.Size = New System.Drawing.Size(411, 50)
        Me.btnAzar.TabIndex = 0
        Me.btnAzar.Text = "Número al azar entre 1 y 10"
        Me.btnAzar.UseVisualStyleBackColor = True
        '
        'txtNumeroAzar
        '
        Me.txtNumeroAzar.Location = New System.Drawing.Point(564, 70)
        Me.txtNumeroAzar.Multiline = True
        Me.txtNumeroAzar.Name = "txtNumeroAzar"
        Me.txtNumeroAzar.Size = New System.Drawing.Size(108, 50)
        Me.txtNumeroAzar.TabIndex = 1
        '
        'btnAzarRangos
        '
        Me.btnAzarRangos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAzarRangos.Location = New System.Drawing.Point(94, 174)
        Me.btnAzarRangos.Name = "btnAzarRangos"
        Me.btnAzarRangos.Size = New System.Drawing.Size(195, 92)
        Me.btnAzarRangos.TabIndex = 2
        Me.btnAzarRangos.Text = "Número al azar entre rangos"
        Me.btnAzarRangos.UseVisualStyleBackColor = True
        '
        'lbl_N_Inf
        '
        Me.lbl_N_Inf.AutoSize = True
        Me.lbl_N_Inf.Location = New System.Drawing.Point(311, 174)
        Me.lbl_N_Inf.Name = "lbl_N_Inf"
        Me.lbl_N_Inf.Size = New System.Drawing.Size(57, 13)
        Me.lbl_N_Inf.TabIndex = 3
        Me.lbl_N_Inf.Text = "Nº Inferior:"
        '
        'lbl_N_Sup
        '
        Me.lbl_N_Sup.AutoSize = True
        Me.lbl_N_Sup.Location = New System.Drawing.Point(311, 234)
        Me.lbl_N_Sup.Name = "lbl_N_Sup"
        Me.lbl_N_Sup.Size = New System.Drawing.Size(64, 13)
        Me.lbl_N_Sup.TabIndex = 4
        Me.lbl_N_Sup.Text = "Nº Superior:"
        '
        'txtInferior
        '
        Me.txtInferior.Location = New System.Drawing.Point(409, 174)
        Me.txtInferior.Multiline = True
        Me.txtInferior.Name = "txtInferior"
        Me.txtInferior.Size = New System.Drawing.Size(96, 32)
        Me.txtInferior.TabIndex = 5
        '
        'txtSuperior
        '
        Me.txtSuperior.Location = New System.Drawing.Point(409, 234)
        Me.txtSuperior.Multiline = True
        Me.txtSuperior.Name = "txtSuperior"
        Me.txtSuperior.Size = New System.Drawing.Size(96, 32)
        Me.txtSuperior.TabIndex = 6
        '
        'txtAzarRangos
        '
        Me.txtAzarRangos.Location = New System.Drawing.Point(564, 197)
        Me.txtAzarRangos.Multiline = True
        Me.txtAzarRangos.Name = "txtAzarRangos"
        Me.txtAzarRangos.Size = New System.Drawing.Size(108, 50)
        Me.txtAzarRangos.TabIndex = 7
        '
        'txtEjecutarRaiz
        '
        Me.txtEjecutarRaiz.Location = New System.Drawing.Point(564, 344)
        Me.txtEjecutarRaiz.Multiline = True
        Me.txtEjecutarRaiz.Name = "txtEjecutarRaiz"
        Me.txtEjecutarRaiz.Size = New System.Drawing.Size(108, 50)
        Me.txtEjecutarRaiz.TabIndex = 13
        '
        'txtNumeroRaiz
        '
        Me.txtNumeroRaiz.Location = New System.Drawing.Point(409, 381)
        Me.txtNumeroRaiz.Multiline = True
        Me.txtNumeroRaiz.Name = "txtNumeroRaiz"
        Me.txtNumeroRaiz.Size = New System.Drawing.Size(96, 32)
        Me.txtNumeroRaiz.TabIndex = 12
        '
        'txtRaiz
        '
        Me.txtRaiz.Location = New System.Drawing.Point(409, 321)
        Me.txtRaiz.Multiline = True
        Me.txtRaiz.Name = "txtRaiz"
        Me.txtRaiz.Size = New System.Drawing.Size(96, 32)
        Me.txtRaiz.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Número:"
        '
        'lbl_Raiz
        '
        Me.lbl_Raiz.AutoSize = True
        Me.lbl_Raiz.Location = New System.Drawing.Point(311, 321)
        Me.lbl_Raiz.Name = "lbl_Raiz"
        Me.lbl_Raiz.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Raiz.TabIndex = 9
        Me.lbl_Raiz.Text = "Raíz:"
        '
        'btnEjecutarRaiz
        '
        Me.btnEjecutarRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutarRaiz.Location = New System.Drawing.Point(94, 321)
        Me.btnEjecutarRaiz.Name = "btnEjecutarRaiz"
        Me.btnEjecutarRaiz.Size = New System.Drawing.Size(195, 92)
        Me.btnEjecutarRaiz.TabIndex = 8
        Me.btnEjecutarRaiz.Text = "Ejecutar:"
        Me.btnEjecutarRaiz.UseVisualStyleBackColor = True
        '
        'txtEjecutarDecimales
        '
        Me.txtEjecutarDecimales.Location = New System.Drawing.Point(564, 492)
        Me.txtEjecutarDecimales.Multiline = True
        Me.txtEjecutarDecimales.Name = "txtEjecutarDecimales"
        Me.txtEjecutarDecimales.Size = New System.Drawing.Size(108, 50)
        Me.txtEjecutarDecimales.TabIndex = 19
        '
        'txtDecimales
        '
        Me.txtDecimales.Location = New System.Drawing.Point(409, 529)
        Me.txtDecimales.Multiline = True
        Me.txtDecimales.Name = "txtDecimales"
        Me.txtDecimales.Size = New System.Drawing.Size(96, 32)
        Me.txtDecimales.TabIndex = 18
        '
        'txtNumeroDecimal
        '
        Me.txtNumeroDecimal.Location = New System.Drawing.Point(409, 469)
        Me.txtNumeroDecimal.Multiline = True
        Me.txtNumeroDecimal.Name = "txtNumeroDecimal"
        Me.txtNumeroDecimal.Size = New System.Drawing.Size(96, 32)
        Me.txtNumeroDecimal.TabIndex = 17
        '
        'lbl_Decimales
        '
        Me.lbl_Decimales.AutoSize = True
        Me.lbl_Decimales.Location = New System.Drawing.Point(311, 529)
        Me.lbl_Decimales.Name = "lbl_Decimales"
        Me.lbl_Decimales.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Decimales.TabIndex = 16
        Me.lbl_Decimales.Text = "Decimales"
        '
        'lbl_Num_Decimal
        '
        Me.lbl_Num_Decimal.AutoSize = True
        Me.lbl_Num_Decimal.Location = New System.Drawing.Point(311, 469)
        Me.lbl_Num_Decimal.Name = "lbl_Num_Decimal"
        Me.lbl_Num_Decimal.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Num_Decimal.TabIndex = 15
        Me.lbl_Num_Decimal.Text = "Número:"
        '
        'btnEjecutarDecimal
        '
        Me.btnEjecutarDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutarDecimal.Location = New System.Drawing.Point(94, 469)
        Me.btnEjecutarDecimal.Name = "btnEjecutarDecimal"
        Me.btnEjecutarDecimal.Size = New System.Drawing.Size(195, 92)
        Me.btnEjecutarDecimal.TabIndex = 14
        Me.btnEjecutarDecimal.Text = "Ejecutar:"
        Me.btnEjecutarDecimal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 790)
        Me.Controls.Add(Me.txtEjecutarDecimales)
        Me.Controls.Add(Me.txtDecimales)
        Me.Controls.Add(Me.txtNumeroDecimal)
        Me.Controls.Add(Me.lbl_Decimales)
        Me.Controls.Add(Me.lbl_Num_Decimal)
        Me.Controls.Add(Me.btnEjecutarDecimal)
        Me.Controls.Add(Me.txtEjecutarRaiz)
        Me.Controls.Add(Me.txtNumeroRaiz)
        Me.Controls.Add(Me.txtRaiz)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Raiz)
        Me.Controls.Add(Me.btnEjecutarRaiz)
        Me.Controls.Add(Me.txtAzarRangos)
        Me.Controls.Add(Me.txtSuperior)
        Me.Controls.Add(Me.txtInferior)
        Me.Controls.Add(Me.lbl_N_Sup)
        Me.Controls.Add(Me.lbl_N_Inf)
        Me.Controls.Add(Me.btnAzarRangos)
        Me.Controls.Add(Me.txtNumeroAzar)
        Me.Controls.Add(Me.btnAzar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAzar As Button
    Friend WithEvents txtNumeroAzar As TextBox
    Friend WithEvents btnAzarRangos As Button
    Friend WithEvents lbl_N_Inf As Label
    Friend WithEvents lbl_N_Sup As Label
    Friend WithEvents txtInferior As TextBox
    Friend WithEvents txtSuperior As TextBox
    Friend WithEvents txtAzarRangos As TextBox
    Friend WithEvents txtEjecutarRaiz As TextBox
    Friend WithEvents txtNumeroRaiz As TextBox
    Friend WithEvents txtRaiz As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Raiz As Label
    Friend WithEvents btnEjecutarRaiz As Button
    Friend WithEvents txtEjecutarDecimales As TextBox
    Friend WithEvents txtDecimales As TextBox
    Friend WithEvents txtNumeroDecimal As TextBox
    Friend WithEvents lbl_Decimales As Label
    Friend WithEvents lbl_Num_Decimal As Label
    Friend WithEvents btnEjecutarDecimal As Button
End Class
