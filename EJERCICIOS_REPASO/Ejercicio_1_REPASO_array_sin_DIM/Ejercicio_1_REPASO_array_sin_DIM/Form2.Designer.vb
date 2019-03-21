<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.gbxConsulta = New System.Windows.Forms.GroupBox()
        Me.lblXConsulta = New System.Windows.Forms.Label()
        Me.rbtn_NombreAlum = New System.Windows.Forms.RadioButton()
        Me.rbtn_NºAlum = New System.Windows.Forms.RadioButton()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblUsuLog = New System.Windows.Forms.Label()
        Me.gbxConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(43, 48)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(78, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código Alumno"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(43, 90)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre Alumno"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(43, 130)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(87, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellidos Alumno"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(43, 168)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(87, 13)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Teléfono Alumno"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(43, 208)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(70, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email Alumno"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(43, 246)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(72, 13)
        Me.lblCurso.TabIndex = 5
        Me.lblCurso.Text = "Curso Alumno"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(148, 48)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(187, 20)
        Me.txtCodigo.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 90)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(187, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(148, 130)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(187, 20)
        Me.txtApellido.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(148, 168)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(187, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(148, 208)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(187, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(148, 246)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(187, 20)
        Me.txtCurso.TabIndex = 11
        '
        'gbxConsulta
        '
        Me.gbxConsulta.Controls.Add(Me.lblXConsulta)
        Me.gbxConsulta.Controls.Add(Me.rbtn_NombreAlum)
        Me.gbxConsulta.Controls.Add(Me.rbtn_NºAlum)
        Me.gbxConsulta.Controls.Add(Me.btnConsultar)
        Me.gbxConsulta.Controls.Add(Me.txtAlumno)
        Me.gbxConsulta.Location = New System.Drawing.Point(407, 90)
        Me.gbxConsulta.Name = "gbxConsulta"
        Me.gbxConsulta.Size = New System.Drawing.Size(336, 176)
        Me.gbxConsulta.TabIndex = 12
        Me.gbxConsulta.TabStop = False
        Me.gbxConsulta.Text = "Consulta Alumnos:"
        Me.gbxConsulta.Visible = False
        '
        'lblXConsulta
        '
        Me.lblXConsulta.AutoSize = True
        Me.lblXConsulta.Location = New System.Drawing.Point(35, 71)
        Me.lblXConsulta.Name = "lblXConsulta"
        Me.lblXConsulta.Size = New System.Drawing.Size(60, 13)
        Me.lblXConsulta.TabIndex = 5
        Me.lblXConsulta.Text = "Nº Alumno:"
        '
        'rbtn_NombreAlum
        '
        Me.rbtn_NombreAlum.AutoSize = True
        Me.rbtn_NombreAlum.Location = New System.Drawing.Point(146, 36)
        Me.rbtn_NombreAlum.Name = "rbtn_NombreAlum"
        Me.rbtn_NombreAlum.Size = New System.Drawing.Size(100, 17)
        Me.rbtn_NombreAlum.TabIndex = 4
        Me.rbtn_NombreAlum.TabStop = True
        Me.rbtn_NombreAlum.Text = "Nombre Alumno"
        Me.rbtn_NombreAlum.UseVisualStyleBackColor = True
        '
        'rbtn_NºAlum
        '
        Me.rbtn_NºAlum.AutoSize = True
        Me.rbtn_NºAlum.Location = New System.Drawing.Point(38, 36)
        Me.rbtn_NºAlum.Name = "rbtn_NºAlum"
        Me.rbtn_NºAlum.Size = New System.Drawing.Size(75, 17)
        Me.rbtn_NºAlum.TabIndex = 3
        Me.rbtn_NºAlum.TabStop = True
        Me.rbtn_NºAlum.Text = "Nº Alumno"
        Me.rbtn_NºAlum.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(120, 118)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(106, 31)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(158, 71)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(106, 20)
        Me.txtAlumno.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(46, 299)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(106, 31)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(172, 299)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(106, 31)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(303, 299)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(106, 31)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblUsuLog
        '
        Me.lblUsuLog.AutoSize = True
        Me.lblUsuLog.Location = New System.Drawing.Point(491, 26)
        Me.lblUsuLog.Name = "lblUsuLog"
        Me.lblUsuLog.Size = New System.Drawing.Size(0, 13)
        Me.lblUsuLog.TabIndex = 16
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblUsuLog)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbxConsulta)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gbxConsulta.ResumeLayout(False)
        Me.gbxConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCurso As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents gbxConsulta As GroupBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtAlumno As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblUsuLog As Label
    Friend WithEvents lblXConsulta As Label
    Friend WithEvents rbtn_NombreAlum As RadioButton
    Friend WithEvents rbtn_NºAlum As RadioButton
End Class
