<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_DVD
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtConsultaAlquilado = New System.Windows.Forms.TextBox()
        Me.txtConsultaDiasAlquiler = New System.Windows.Forms.TextBox()
        Me.txtConsultaTituloDVD = New System.Windows.Forms.TextBox()
        Me.txtConsultaCodigoDVD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(276, 305)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(124, 32)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Volver"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(86, 305)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(124, 32)
        Me.btnConsultar.TabIndex = 28
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtConsultaAlquilado
        '
        Me.txtConsultaAlquilado.Location = New System.Drawing.Point(299, 230)
        Me.txtConsultaAlquilado.Name = "txtConsultaAlquilado"
        Me.txtConsultaAlquilado.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaAlquilado.TabIndex = 27
        '
        'txtConsultaDiasAlquiler
        '
        Me.txtConsultaDiasAlquiler.Location = New System.Drawing.Point(299, 170)
        Me.txtConsultaDiasAlquiler.Name = "txtConsultaDiasAlquiler"
        Me.txtConsultaDiasAlquiler.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaDiasAlquiler.TabIndex = 26
        '
        'txtConsultaTituloDVD
        '
        Me.txtConsultaTituloDVD.Location = New System.Drawing.Point(299, 111)
        Me.txtConsultaTituloDVD.Name = "txtConsultaTituloDVD"
        Me.txtConsultaTituloDVD.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaTituloDVD.TabIndex = 25
        '
        'txtConsultaCodigoDVD
        '
        Me.txtConsultaCodigoDVD.Location = New System.Drawing.Point(299, 50)
        Me.txtConsultaCodigoDVD.Name = "txtConsultaCodigoDVD"
        Me.txtConsultaCodigoDVD.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaCodigoDVD.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Título DVD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Días Alquiler (MAXIMO):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "¿Se encuentra Alquilado?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Código DVD"
        '
        'Consulta_DVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 450)
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
        Me.Name = "Consulta_DVD"
        Me.Text = "Consulta_DVD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtConsultaAlquilado As TextBox
    Friend WithEvents txtConsultaDiasAlquiler As TextBox
    Friend WithEvents txtConsultaTituloDVD As TextBox
    Friend WithEvents txtConsultaCodigoDVD As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
