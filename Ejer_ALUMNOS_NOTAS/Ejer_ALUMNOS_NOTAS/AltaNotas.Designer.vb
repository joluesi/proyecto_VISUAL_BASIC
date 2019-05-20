<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaNotas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNotaMod1 = New System.Windows.Forms.TextBox()
        Me.Label1_mod = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCodCurso = New System.Windows.Forms.TextBox()
        Me.txtCodAlumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.txtNotaMod2 = New System.Windows.Forms.TextBox()
        Me.Label2_mod = New System.Windows.Forms.Label()
        Me.txtNotaMod3 = New System.Windows.Forms.TextBox()
        Me.Label3_mod = New System.Windows.Forms.Label()
        Me.txtNotaMod4 = New System.Windows.Forms.TextBox()
        Me.Label4_mod = New System.Windows.Forms.Label()
        Me.gbx_modulos = New System.Windows.Forms.GroupBox()
        Me.gbx_codCurso = New System.Windows.Forms.GroupBox()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.gbx_modulos.SuspendLayout()
        Me.gbx_codCurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNotaMod1
        '
        Me.txtNotaMod1.Location = New System.Drawing.Point(220, 28)
        Me.txtNotaMod1.Name = "txtNotaMod1"
        Me.txtNotaMod1.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaMod1.TabIndex = 46
        '
        'Label1_mod
        '
        Me.Label1_mod.AutoSize = True
        Me.Label1_mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_mod.Location = New System.Drawing.Point(37, 26)
        Me.Label1_mod.Name = "Label1_mod"
        Me.Label1_mod.Size = New System.Drawing.Size(87, 20)
        Me.Label1_mod.TabIndex = 43
        Me.Label1_mod.Text = "Módulo 1:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(229, 508)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 29)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(62, 508)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 29)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCodCurso
        '
        Me.txtCodCurso.Location = New System.Drawing.Point(219, 28)
        Me.txtCodCurso.Name = "txtCodCurso"
        Me.txtCodCurso.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCurso.TabIndex = 40
        '
        'txtCodAlumno
        '
        Me.txtCodAlumno.Location = New System.Drawing.Point(241, 107)
        Me.txtCodAlumno.Name = "txtCodAlumno"
        Me.txtCodAlumno.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAlumno.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Código de Alumno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Código curso:"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.Location = New System.Drawing.Point(38, 41)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(123, 20)
        Me.lbl_1.TabIndex = 34
        Me.lbl_1.Text = "Alta de Notas:"
        '
        'txtNotaMod2
        '
        Me.txtNotaMod2.Location = New System.Drawing.Point(220, 81)
        Me.txtNotaMod2.Name = "txtNotaMod2"
        Me.txtNotaMod2.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaMod2.TabIndex = 48
        '
        'Label2_mod
        '
        Me.Label2_mod.AutoSize = True
        Me.Label2_mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_mod.Location = New System.Drawing.Point(37, 81)
        Me.Label2_mod.Name = "Label2_mod"
        Me.Label2_mod.Size = New System.Drawing.Size(87, 20)
        Me.Label2_mod.TabIndex = 47
        Me.Label2_mod.Text = "Módulo 2:"
        '
        'txtNotaMod3
        '
        Me.txtNotaMod3.Location = New System.Drawing.Point(220, 133)
        Me.txtNotaMod3.Name = "txtNotaMod3"
        Me.txtNotaMod3.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaMod3.TabIndex = 50
        '
        'Label3_mod
        '
        Me.Label3_mod.AutoSize = True
        Me.Label3_mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3_mod.Location = New System.Drawing.Point(37, 133)
        Me.Label3_mod.Name = "Label3_mod"
        Me.Label3_mod.Size = New System.Drawing.Size(87, 20)
        Me.Label3_mod.TabIndex = 49
        Me.Label3_mod.Text = "Módulo 3:"
        '
        'txtNotaMod4
        '
        Me.txtNotaMod4.Location = New System.Drawing.Point(220, 190)
        Me.txtNotaMod4.Name = "txtNotaMod4"
        Me.txtNotaMod4.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaMod4.TabIndex = 52
        '
        'Label4_mod
        '
        Me.Label4_mod.AutoSize = True
        Me.Label4_mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4_mod.Location = New System.Drawing.Point(37, 190)
        Me.Label4_mod.Name = "Label4_mod"
        Me.Label4_mod.Size = New System.Drawing.Size(87, 20)
        Me.Label4_mod.TabIndex = 51
        Me.Label4_mod.Text = "Módulo 4:"
        '
        'gbx_modulos
        '
        Me.gbx_modulos.Controls.Add(Me.Label1_mod)
        Me.gbx_modulos.Controls.Add(Me.txtNotaMod1)
        Me.gbx_modulos.Controls.Add(Me.txtNotaMod4)
        Me.gbx_modulos.Controls.Add(Me.Label4_mod)
        Me.gbx_modulos.Controls.Add(Me.Label2_mod)
        Me.gbx_modulos.Controls.Add(Me.txtNotaMod3)
        Me.gbx_modulos.Controls.Add(Me.txtNotaMod2)
        Me.gbx_modulos.Controls.Add(Me.Label3_mod)
        Me.gbx_modulos.Location = New System.Drawing.Point(21, 232)
        Me.gbx_modulos.Name = "gbx_modulos"
        Me.gbx_modulos.Size = New System.Drawing.Size(367, 239)
        Me.gbx_modulos.TabIndex = 53
        Me.gbx_modulos.TabStop = False
        Me.gbx_modulos.Text = "Módulos"
        Me.gbx_modulos.Visible = False
        '
        'gbx_codCurso
        '
        Me.gbx_codCurso.Controls.Add(Me.Label3)
        Me.gbx_codCurso.Controls.Add(Me.txtCodCurso)
        Me.gbx_codCurso.Location = New System.Drawing.Point(21, 146)
        Me.gbx_codCurso.Name = "gbx_codCurso"
        Me.gbx_codCurso.Size = New System.Drawing.Size(367, 69)
        Me.gbx_codCurso.TabIndex = 54
        Me.gbx_codCurso.TabStop = False
        Me.gbx_codCurso.Text = "Curso:"
        Me.gbx_codCurso.Visible = False
        '
        'btnAlta
        '
        Me.btnAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlta.Location = New System.Drawing.Point(62, 508)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(132, 29)
        Me.btnAlta.TabIndex = 55
        Me.btnAlta.Text = "Dar de Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        Me.btnAlta.Visible = False
        '
        'AltaNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 594)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.gbx_codCurso)
        Me.Controls.Add(Me.gbx_modulos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCodAlumno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_1)
        Me.Name = "AltaNotas"
        Me.Text = "AltaNotas"
        Me.gbx_modulos.ResumeLayout(False)
        Me.gbx_modulos.PerformLayout()
        Me.gbx_codCurso.ResumeLayout(False)
        Me.gbx_codCurso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNotaMod1 As TextBox
    Friend WithEvents Label1_mod As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtCodCurso As TextBox
    Friend WithEvents txtCodAlumno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents txtNotaMod2 As TextBox
    Friend WithEvents Label2_mod As Label
    Friend WithEvents txtNotaMod3 As TextBox
    Friend WithEvents Label3_mod As Label
    Friend WithEvents txtNotaMod4 As TextBox
    Friend WithEvents Label4_mod As Label
    Friend WithEvents gbx_modulos As GroupBox
    Friend WithEvents gbx_codCurso As GroupBox
    Friend WithEvents btnAlta As Button
End Class
