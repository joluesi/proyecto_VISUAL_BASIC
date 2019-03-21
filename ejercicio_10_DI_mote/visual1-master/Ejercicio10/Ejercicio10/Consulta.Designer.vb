<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.rbTitulo = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtDiasAlquiler = New System.Windows.Forms.TextBox()
        Me.txtAlquilado = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(112, 25)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(100, 20)
        Me.txtConsulta.TabIndex = 0
        '
        'rbTitulo
        '
        Me.rbTitulo.AutoSize = True
        Me.rbTitulo.Checked = True
        Me.rbTitulo.Location = New System.Drawing.Point(221, 12)
        Me.rbTitulo.Name = "rbTitulo"
        Me.rbTitulo.Size = New System.Drawing.Size(53, 17)
        Me.rbTitulo.TabIndex = 1
        Me.rbTitulo.TabStop = True
        Me.rbTitulo.Text = "Título"
        Me.rbTitulo.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(221, 47)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rbCodigo.TabIndex = 2
        Me.rbCodigo.Text = "Código"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consulta:"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbDatos.Controls.Add(Me.txtDiasAlquiler)
        Me.gbDatos.Controls.Add(Me.txtAlquilado)
        Me.gbDatos.Controls.Add(Me.txtTitulo)
        Me.gbDatos.Controls.Add(Me.txtCodigo)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Location = New System.Drawing.Point(12, 93)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(535, 254)
        Me.gbDatos.TabIndex = 4
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos:"
        Me.gbDatos.Visible = False
        '
        'txtDiasAlquiler
        '
        Me.txtDiasAlquiler.Location = New System.Drawing.Point(314, 145)
        Me.txtDiasAlquiler.Name = "txtDiasAlquiler"
        Me.txtDiasAlquiler.ReadOnly = True
        Me.txtDiasAlquiler.Size = New System.Drawing.Size(114, 20)
        Me.txtDiasAlquiler.TabIndex = 7
        '
        'txtAlquilado
        '
        Me.txtAlquilado.Location = New System.Drawing.Point(314, 59)
        Me.txtAlquilado.Name = "txtAlquilado"
        Me.txtAlquilado.ReadOnly = True
        Me.txtAlquilado.Size = New System.Drawing.Size(114, 20)
        Me.txtAlquilado.TabIndex = 6
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(86, 145)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(114, 20)
        Me.txtTitulo.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(86, 59)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(114, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Alquilado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Días Alquiler:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Título"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnConsulta.Location = New System.Drawing.Point(326, 18)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(91, 32)
        Me.btnConsulta.TabIndex = 5
        Me.btnConsulta.Text = "BUSCAR"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancelar.Location = New System.Drawing.Point(436, 18)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 32)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(550, 359)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbCodigo)
        Me.Controls.Add(Me.rbTitulo)
        Me.Controls.Add(Me.txtConsulta)
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConsulta As TextBox
    Friend WithEvents rbTitulo As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiasAlquiler As TextBox
    Friend WithEvents txtAlquilado As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConsulta As Button
    Friend WithEvents btnCancelar As Button
End Class
