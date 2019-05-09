<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaDVD
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDiasAlquilerDVD = New System.Windows.Forms.TextBox()
        Me.txtTituloDVD = New System.Windows.Forms.TextBox()
        Me.txtCodigoDVD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(251, 253)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 29)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(81, 253)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 29)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDiasAlquilerDVD
        '
        Me.txtDiasAlquilerDVD.Location = New System.Drawing.Point(251, 200)
        Me.txtDiasAlquilerDVD.Name = "txtDiasAlquilerDVD"
        Me.txtDiasAlquilerDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasAlquilerDVD.TabIndex = 16
        '
        'txtTituloDVD
        '
        Me.txtTituloDVD.Location = New System.Drawing.Point(251, 154)
        Me.txtTituloDVD.Name = "txtTituloDVD"
        Me.txtTituloDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtTituloDVD.TabIndex = 15
        '
        'txtCodigoDVD
        '
        Me.txtCodigoDVD.Location = New System.Drawing.Point(251, 102)
        Me.txtCodigoDVD.Name = "txtCodigoDVD"
        Me.txtCodigoDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoDVD.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Título de DVD: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Días alquiler de DVD: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Código de DVD: "
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.Location = New System.Drawing.Point(55, 37)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(124, 20)
        Me.lbl_1.TabIndex = 10
        Me.lbl_1.Text = "Alta de DVD´s"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AltaDVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDiasAlquilerDVD)
        Me.Controls.Add(Me.txtTituloDVD)
        Me.Controls.Add(Me.txtCodigoDVD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_1)
        Me.Name = "AltaDVD"
        Me.Text = "AltaDVD"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDiasAlquilerDVD As TextBox
    Friend WithEvents txtTituloDVD As TextBox
    Friend WithEvents txtCodigoDVD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
