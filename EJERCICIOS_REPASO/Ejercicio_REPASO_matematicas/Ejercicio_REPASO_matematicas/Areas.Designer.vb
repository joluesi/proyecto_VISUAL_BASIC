<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Areas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Areas))
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.gbxFiguras = New System.Windows.Forms.GroupBox()
        Me.rbtnTriangulo = New System.Windows.Forms.RadioButton()
        Me.rbtnCuadrado = New System.Windows.Forms.RadioButton()
        Me.rbtnRectangulo = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbxFiguras.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(104, 125)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(31, 13)
        Me.lblBase.TabIndex = 0
        Me.lblBase.Text = "Base"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(104, 179)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(34, 13)
        Me.lblAltura.TabIndex = 1
        Me.lblAltura.Text = "Altura"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(161, 125)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(100, 20)
        Me.txtBase.TabIndex = 2
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(161, 179)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 3
        '
        'gbxFiguras
        '
        Me.gbxFiguras.Controls.Add(Me.rbtnRectangulo)
        Me.gbxFiguras.Controls.Add(Me.rbtnCuadrado)
        Me.gbxFiguras.Controls.Add(Me.rbtnTriangulo)
        Me.gbxFiguras.Location = New System.Drawing.Point(302, 70)
        Me.gbxFiguras.Name = "gbxFiguras"
        Me.gbxFiguras.Size = New System.Drawing.Size(367, 48)
        Me.gbxFiguras.TabIndex = 4
        Me.gbxFiguras.TabStop = False
        Me.gbxFiguras.Text = "Figuras Geométricas"
        '
        'rbtnTriangulo
        '
        Me.rbtnTriangulo.AutoSize = True
        Me.rbtnTriangulo.Location = New System.Drawing.Point(25, 19)
        Me.rbtnTriangulo.Name = "rbtnTriangulo"
        Me.rbtnTriangulo.Size = New System.Drawing.Size(69, 17)
        Me.rbtnTriangulo.TabIndex = 0
        Me.rbtnTriangulo.TabStop = True
        Me.rbtnTriangulo.Text = "Triángulo"
        Me.rbtnTriangulo.UseVisualStyleBackColor = True
        '
        'rbtnCuadrado
        '
        Me.rbtnCuadrado.AutoSize = True
        Me.rbtnCuadrado.Location = New System.Drawing.Point(126, 19)
        Me.rbtnCuadrado.Name = "rbtnCuadrado"
        Me.rbtnCuadrado.Size = New System.Drawing.Size(71, 17)
        Me.rbtnCuadrado.TabIndex = 1
        Me.rbtnCuadrado.TabStop = True
        Me.rbtnCuadrado.Text = "Cuadrado"
        Me.rbtnCuadrado.UseVisualStyleBackColor = True
        '
        'rbtnRectangulo
        '
        Me.rbtnRectangulo.AutoSize = True
        Me.rbtnRectangulo.Location = New System.Drawing.Point(242, 19)
        Me.rbtnRectangulo.Name = "rbtnRectangulo"
        Me.rbtnRectangulo.Size = New System.Drawing.Size(80, 17)
        Me.rbtnRectangulo.TabIndex = 2
        Me.rbtnRectangulo.TabStop = True
        Me.rbtnRectangulo.Text = "Rectángulo"
        Me.rbtnRectangulo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Ejercicio_REPASO_matematicas.My.Resources.Resources.images_geometrics2
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(302, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 108)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(302, 270)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(58, 13)
        Me.lblArea.TabIndex = 6
        Me.lblArea.Text = "El Area es:"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(377, 270)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(122, 20)
        Me.txtArea.TabIndex = 7
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(532, 270)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(111, 32)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Areas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxFiguras)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.lblBase)
        Me.Name = "Areas"
        Me.Text = "Areas"
        Me.gbxFiguras.ResumeLayout(False)
        Me.gbxFiguras.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBase As Label
    Friend WithEvents lblAltura As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents gbxFiguras As GroupBox
    Friend WithEvents rbtnTriangulo As RadioButton
    Friend WithEvents rbtnRectangulo As RadioButton
    Friend WithEvents rbtnCuadrado As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblArea As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btnVolver As Button
End Class
