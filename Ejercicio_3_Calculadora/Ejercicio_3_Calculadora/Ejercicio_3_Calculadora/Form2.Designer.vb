<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.rbtnRectangulo = New System.Windows.Forms.RadioButton()
        Me.rbtnTriangulo = New System.Windows.Forms.RadioButton()
        Me.rbtnCuadrado = New System.Windows.Forms.RadioButton()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblArea = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(130, 93)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(31, 13)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "Base"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(130, 139)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(34, 13)
        Me.lblNum2.TabIndex = 1
        Me.lblNum2.Text = "Altura"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(183, 93)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(74, 20)
        Me.txtBase.TabIndex = 2
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(183, 136)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(74, 20)
        Me.txtAltura.TabIndex = 3
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(558, 230)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'rbtnRectangulo
        '
        Me.rbtnRectangulo.AutoSize = True
        Me.rbtnRectangulo.Location = New System.Drawing.Point(544, 70)
        Me.rbtnRectangulo.Name = "rbtnRectangulo"
        Me.rbtnRectangulo.Size = New System.Drawing.Size(80, 17)
        Me.rbtnRectangulo.TabIndex = 6
        Me.rbtnRectangulo.TabStop = True
        Me.rbtnRectangulo.Text = "Rectángulo"
        Me.rbtnRectangulo.UseVisualStyleBackColor = True
        '
        'rbtnTriangulo
        '
        Me.rbtnTriangulo.AutoSize = True
        Me.rbtnTriangulo.Location = New System.Drawing.Point(316, 70)
        Me.rbtnTriangulo.Name = "rbtnTriangulo"
        Me.rbtnTriangulo.Size = New System.Drawing.Size(69, 17)
        Me.rbtnTriangulo.TabIndex = 7
        Me.rbtnTriangulo.TabStop = True
        Me.rbtnTriangulo.Text = "Triángulo"
        Me.rbtnTriangulo.UseVisualStyleBackColor = True
        '
        'rbtnCuadrado
        '
        Me.rbtnCuadrado.AutoSize = True
        Me.rbtnCuadrado.Location = New System.Drawing.Point(425, 70)
        Me.rbtnCuadrado.Name = "rbtnCuadrado"
        Me.rbtnCuadrado.Size = New System.Drawing.Size(71, 17)
        Me.rbtnCuadrado.TabIndex = 8
        Me.rbtnCuadrado.TabStop = True
        Me.rbtnCuadrado.Text = "Cuadrado"
        Me.rbtnCuadrado.UseVisualStyleBackColor = True
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(393, 230)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(122, 20)
        Me.txtArea.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ejercicio_3_Calculadora.My.Resources.Resources.images_geometrics2
        Me.PictureBox1.Location = New System.Drawing.Point(298, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 110)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(298, 230)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(58, 13)
        Me.lblArea.TabIndex = 12
        Me.lblArea.Text = "El Área es:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 323)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.rbtnCuadrado)
        Me.Controls.Add(Me.rbtnTriangulo)
        Me.Controls.Add(Me.rbtnRectangulo)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents rbtnRectangulo As RadioButton
    Friend WithEvents rbtnTriangulo As RadioButton
    Friend WithEvents rbtnCuadrado As RadioButton
    Friend WithEvents txtArea As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblArea As Label
End Class
