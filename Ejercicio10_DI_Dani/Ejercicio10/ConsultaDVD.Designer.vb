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
        Me.txtConsultaCodigoDVD = New System.Windows.Forms.TextBox()
        Me.txtConsultaTituloDVD = New System.Windows.Forms.TextBox()
        Me.txtConsultaDiasDVD = New System.Windows.Forms.TextBox()
        Me.txtConsultaSiAlquiladoDVD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConsultaCancelar = New System.Windows.Forms.Button()
        Me.btnVolverConsultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtConsultaCodigoDVD
        '
        Me.txtConsultaCodigoDVD.Location = New System.Drawing.Point(45, 55)
        Me.txtConsultaCodigoDVD.Name = "txtConsultaCodigoDVD"
        Me.txtConsultaCodigoDVD.Size = New System.Drawing.Size(189, 22)
        Me.txtConsultaCodigoDVD.TabIndex = 0
        '
        'txtConsultaTituloDVD
        '
        Me.txtConsultaTituloDVD.Location = New System.Drawing.Point(45, 104)
        Me.txtConsultaTituloDVD.Name = "txtConsultaTituloDVD"
        Me.txtConsultaTituloDVD.Size = New System.Drawing.Size(189, 22)
        Me.txtConsultaTituloDVD.TabIndex = 1
        '
        'txtConsultaDiasDVD
        '
        Me.txtConsultaDiasDVD.Location = New System.Drawing.Point(45, 152)
        Me.txtConsultaDiasDVD.Name = "txtConsultaDiasDVD"
        Me.txtConsultaDiasDVD.Size = New System.Drawing.Size(189, 22)
        Me.txtConsultaDiasDVD.TabIndex = 2
        '
        'txtConsultaSiAlquiladoDVD
        '
        Me.txtConsultaSiAlquiladoDVD.Location = New System.Drawing.Point(45, 203)
        Me.txtConsultaSiAlquiladoDVD.Name = "txtConsultaSiAlquiladoDVD"
        Me.txtConsultaSiAlquiladoDVD.Size = New System.Drawing.Size(189, 22)
        Me.txtConsultaSiAlquiladoDVD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codigo DVD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Titulo DVD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dias maximos de alguiler"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alquilado actualmente?"
        '
        'btnConsultaCancelar
        '
        Me.btnConsultaCancelar.Location = New System.Drawing.Point(149, 259)
        Me.btnConsultaCancelar.Name = "btnConsultaCancelar"
        Me.btnConsultaCancelar.Size = New System.Drawing.Size(85, 51)
        Me.btnConsultaCancelar.TabIndex = 8
        Me.btnConsultaCancelar.Text = "Terminar consulta"
        Me.btnConsultaCancelar.UseVisualStyleBackColor = True
        '
        'btnVolverConsultar
        '
        Me.btnVolverConsultar.Location = New System.Drawing.Point(45, 259)
        Me.btnVolverConsultar.Name = "btnVolverConsultar"
        Me.btnVolverConsultar.Size = New System.Drawing.Size(85, 51)
        Me.btnVolverConsultar.TabIndex = 9
        Me.btnVolverConsultar.Text = "Volver a consultar"
        Me.btnVolverConsultar.UseVisualStyleBackColor = True
        '
        'ConsultaDVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 345)
        Me.Controls.Add(Me.btnVolverConsultar)
        Me.Controls.Add(Me.btnConsultaCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConsultaSiAlquiladoDVD)
        Me.Controls.Add(Me.txtConsultaDiasDVD)
        Me.Controls.Add(Me.txtConsultaTituloDVD)
        Me.Controls.Add(Me.txtConsultaCodigoDVD)
        Me.Name = "ConsultaDVD"
        Me.Text = "ConsultaDVD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConsultaCodigoDVD As TextBox
    Friend WithEvents txtConsultaTituloDVD As TextBox
    Friend WithEvents txtConsultaDiasDVD As TextBox
    Friend WithEvents txtConsultaSiAlquiladoDVD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConsultaCancelar As Button
    Friend WithEvents btnVolverConsultar As Button
End Class
