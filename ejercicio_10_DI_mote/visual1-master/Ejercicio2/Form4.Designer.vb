<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Consulta = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtConsCurso = New System.Windows.Forms.TextBox()
        Me.txtConsEmail = New System.Windows.Forms.TextBox()
        Me.txtConsTelef = New System.Windows.Forms.TextBox()
        Me.txtConsApel = New System.Windows.Forms.TextBox()
        Me.txtConsNombre = New System.Windows.Forms.TextBox()
        Me.txtConsCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.txtNuAlum = New System.Windows.Forms.TextBox()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.Consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Consulta
        '
        Me.Consulta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Consulta.Controls.Add(Me.btnSalir)
        Me.Consulta.Controls.Add(Me.btnModificar)
        Me.Consulta.Controls.Add(Me.txtConsCurso)
        Me.Consulta.Controls.Add(Me.txtConsEmail)
        Me.Consulta.Controls.Add(Me.txtConsTelef)
        Me.Consulta.Controls.Add(Me.txtConsApel)
        Me.Consulta.Controls.Add(Me.txtConsNombre)
        Me.Consulta.Controls.Add(Me.txtConsCodigo)
        Me.Consulta.Controls.Add(Me.Label6)
        Me.Consulta.Controls.Add(Me.Label5)
        Me.Consulta.Controls.Add(Me.Label4)
        Me.Consulta.Controls.Add(Me.Label3)
        Me.Consulta.Controls.Add(Me.Label2)
        Me.Consulta.Controls.Add(Me.Label1)
        Me.Consulta.Controls.Add(Me.btnMenu)
        Me.Consulta.Controls.Add(Me.btnConsulta)
        Me.Consulta.Controls.Add(Me.txtNuAlum)
        Me.Consulta.Controls.Add(Me.lblConsulta)
        Me.Consulta.Location = New System.Drawing.Point(0, 1)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(799, 449)
        Me.Consulta.TabIndex = 17
        Me.Consulta.TabStop = False
        Me.Consulta.Text = "Consultar"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnSalir.Location = New System.Drawing.Point(425, 380)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(139, 34)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir de la app"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(632, 200)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(139, 34)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtConsCurso
        '
        Me.txtConsCurso.Location = New System.Drawing.Point(464, 289)
        Me.txtConsCurso.Name = "txtConsCurso"
        Me.txtConsCurso.Size = New System.Drawing.Size(100, 20)
        Me.txtConsCurso.TabIndex = 17
        '
        'txtConsEmail
        '
        Me.txtConsEmail.Location = New System.Drawing.Point(464, 208)
        Me.txtConsEmail.Name = "txtConsEmail"
        Me.txtConsEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtConsEmail.TabIndex = 16
        '
        'txtConsTelef
        '
        Me.txtConsTelef.Location = New System.Drawing.Point(464, 130)
        Me.txtConsTelef.Name = "txtConsTelef"
        Me.txtConsTelef.Size = New System.Drawing.Size(100, 20)
        Me.txtConsTelef.TabIndex = 15
        '
        'txtConsApel
        '
        Me.txtConsApel.Location = New System.Drawing.Point(226, 289)
        Me.txtConsApel.Name = "txtConsApel"
        Me.txtConsApel.Size = New System.Drawing.Size(100, 20)
        Me.txtConsApel.TabIndex = 14
        '
        'txtConsNombre
        '
        Me.txtConsNombre.Location = New System.Drawing.Point(226, 208)
        Me.txtConsNombre.Name = "txtConsNombre"
        Me.txtConsNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtConsNombre.TabIndex = 13
        '
        'txtConsCodigo
        '
        Me.txtConsCodigo.Location = New System.Drawing.Point(226, 130)
        Me.txtConsCodigo.Name = "txtConsCodigo"
        Me.txtConsCodigo.ReadOnly = True
        Me.txtConsCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtConsCodigo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Curso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(407, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMenu.Location = New System.Drawing.Point(226, 380)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(139, 34)
        Me.btnMenu.TabIndex = 5
        Me.btnMenu.Text = "Volver a Menú"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnConsulta.Location = New System.Drawing.Point(506, 36)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(85, 31)
        Me.btnConsulta.TabIndex = 2
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'txtNuAlum
        '
        Me.txtNuAlum.Location = New System.Drawing.Point(320, 42)
        Me.txtNuAlum.Name = "txtNuAlum"
        Me.txtNuAlum.Size = New System.Drawing.Size(100, 20)
        Me.txtNuAlum.TabIndex = 1
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Location = New System.Drawing.Point(223, 45)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(82, 13)
        Me.lblConsulta.TabIndex = 0
        Me.lblConsulta.Text = "Nombre Alumno"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Consulta)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Consulta.ResumeLayout(False)
        Me.Consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Consulta As GroupBox
    Friend WithEvents btnConsulta As Button
    Friend WithEvents txtNuAlum As TextBox
    Friend WithEvents lblConsulta As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtConsCurso As TextBox
    Friend WithEvents txtConsEmail As TextBox
    Friend WithEvents txtConsTelef As TextBox
    Friend WithEvents txtConsApel As TextBox
    Friend WithEvents txtConsNombre As TextBox
    Friend WithEvents txtConsCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
End Class
