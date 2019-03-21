<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaDVD
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
        Me.txtConsultaCodigoDVD = New System.Windows.Forms.TextBox()
        Me.txtConsultaTituloDVD = New System.Windows.Forms.TextBox()
        Me.txtConsultaDiasAlquiler = New System.Windows.Forms.TextBox()
        Me.txtConsultaAlquilado = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código DVD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¿Se encuentra Alquilado?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Días Alquiler (MAXIMO):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Título DVD"
        '
        'txtConsultaCodigoDVD
        '
        Me.txtConsultaCodigoDVD.Location = New System.Drawing.Point(274, 43)
        Me.txtConsultaCodigoDVD.Name = "txtConsultaCodigoDVD"
        Me.txtConsultaCodigoDVD.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaCodigoDVD.TabIndex = 4
        '
        'txtConsultaTituloDVD
        '
        Me.txtConsultaTituloDVD.Location = New System.Drawing.Point(274, 104)
        Me.txtConsultaTituloDVD.Name = "txtConsultaTituloDVD"
        Me.txtConsultaTituloDVD.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaTituloDVD.TabIndex = 5
        '
        'txtConsultaDiasAlquiler
        '
        Me.txtConsultaDiasAlquiler.Location = New System.Drawing.Point(274, 163)
        Me.txtConsultaDiasAlquiler.Name = "txtConsultaDiasAlquiler"
        Me.txtConsultaDiasAlquiler.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaDiasAlquiler.TabIndex = 6
        '
        'txtConsultaAlquilado
        '
        Me.txtConsultaAlquilado.Location = New System.Drawing.Point(274, 223)
        Me.txtConsultaAlquilado.Name = "txtConsultaAlquilado"
        Me.txtConsultaAlquilado.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaAlquilado.TabIndex = 7
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(61, 298)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(124, 32)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(251, 298)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(124, 32)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ConsultaDVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtConsultaAlquilado)
        Me.Controls.Add(Me.txtConsultaDiasAlquiler)
        Me.Controls.Add(Me.txtConsultaTituloDVD)
        Me.Controls.Add(Me.txtConsultaCodigoDVD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaDVD"
        Me.Text = "ConsultaDVD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConsultaCodigoDVD As TextBox
    Friend WithEvents txtConsultaTituloDVD As TextBox
    Friend WithEvents txtConsultaDiasAlquiler As TextBox
    Friend WithEvents txtConsultaAlquilado As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnCancelar As Button
End Class
