<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConsultaProductosCliente
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
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.richMes = New System.Windows.Forms.RichTextBox()
        Me.btnConsultarMes = New System.Windows.Forms.Button()
        Me.btnVolverConsulta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(49, 62)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(256, 24)
        Me.cmbMes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduce fecha"
        '
        'richMes
        '
        Me.richMes.Location = New System.Drawing.Point(49, 123)
        Me.richMes.Name = "richMes"
        Me.richMes.Size = New System.Drawing.Size(256, 189)
        Me.richMes.TabIndex = 2
        Me.richMes.Text = ""
        '
        'btnConsultarMes
        '
        Me.btnConsultarMes.Location = New System.Drawing.Point(49, 329)
        Me.btnConsultarMes.Name = "btnConsultarMes"
        Me.btnConsultarMes.Size = New System.Drawing.Size(256, 40)
        Me.btnConsultarMes.TabIndex = 3
        Me.btnConsultarMes.Text = "Consultar"
        Me.btnConsultarMes.UseVisualStyleBackColor = True
        '
        'btnVolverConsulta
        '
        Me.btnVolverConsulta.Location = New System.Drawing.Point(49, 390)
        Me.btnVolverConsulta.Name = "btnVolverConsulta"
        Me.btnVolverConsulta.Size = New System.Drawing.Size(256, 40)
        Me.btnVolverConsulta.TabIndex = 4
        Me.btnVolverConsulta.Text = "Volver"
        Me.btnVolverConsulta.UseVisualStyleBackColor = True
        '
        'formConsultaProductosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 452)
        Me.Controls.Add(Me.btnVolverConsulta)
        Me.Controls.Add(Me.btnConsultarMes)
        Me.Controls.Add(Me.richMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMes)
        Me.Name = "formConsultaProductosCliente"
        Me.Text = "formConsultaProductosCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents richMes As RichTextBox
    Friend WithEvents btnConsultarMes As Button
    Friend WithEvents btnVolverConsulta As Button
End Class
