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
        Me.txtCodigoDVD = New System.Windows.Forms.TextBox()
        Me.txtTituloDVD = New System.Windows.Forms.TextBox()
        Me.txtDiasMaxDVD = New System.Windows.Forms.TextBox()
        Me.btnAltaDVD = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAltaCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoDVD
        '
        Me.txtCodigoDVD.Location = New System.Drawing.Point(37, 33)
        Me.txtCodigoDVD.Name = "txtCodigoDVD"
        Me.txtCodigoDVD.Size = New System.Drawing.Size(199, 22)
        Me.txtCodigoDVD.TabIndex = 0
        '
        'txtTituloDVD
        '
        Me.txtTituloDVD.Location = New System.Drawing.Point(37, 90)
        Me.txtTituloDVD.Name = "txtTituloDVD"
        Me.txtTituloDVD.Size = New System.Drawing.Size(199, 22)
        Me.txtTituloDVD.TabIndex = 1
        '
        'txtDiasMaxDVD
        '
        Me.txtDiasMaxDVD.Location = New System.Drawing.Point(37, 152)
        Me.txtDiasMaxDVD.Name = "txtDiasMaxDVD"
        Me.txtDiasMaxDVD.Size = New System.Drawing.Size(199, 22)
        Me.txtDiasMaxDVD.TabIndex = 2
        '
        'btnAltaDVD
        '
        Me.btnAltaDVD.Location = New System.Drawing.Point(37, 209)
        Me.btnAltaDVD.Name = "btnAltaDVD"
        Me.btnAltaDVD.Size = New System.Drawing.Size(85, 56)
        Me.btnAltaDVD.TabIndex = 3
        Me.btnAltaDVD.Text = "Alta DVD"
        Me.btnAltaDVD.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codigo DVD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Titulo DVD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dias maximos de alquiler"
        '
        'btnAltaCancelar
        '
        Me.btnAltaCancelar.Location = New System.Drawing.Point(151, 209)
        Me.btnAltaCancelar.Name = "btnAltaCancelar"
        Me.btnAltaCancelar.Size = New System.Drawing.Size(85, 56)
        Me.btnAltaCancelar.TabIndex = 7
        Me.btnAltaCancelar.Text = "Cancelar"
        Me.btnAltaCancelar.UseVisualStyleBackColor = True
        '
        'AltaDVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 291)
        Me.Controls.Add(Me.btnAltaCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAltaDVD)
        Me.Controls.Add(Me.txtDiasMaxDVD)
        Me.Controls.Add(Me.txtTituloDVD)
        Me.Controls.Add(Me.txtCodigoDVD)
        Me.Name = "AltaDVD"
        Me.Text = "AltaDVD"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigoDVD As TextBox
    Friend WithEvents txtTituloDVD As TextBox
    Friend WithEvents txtDiasMaxDVD As TextBox
    Friend WithEvents btnAltaDVD As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAltaCancelar As Button
End Class
