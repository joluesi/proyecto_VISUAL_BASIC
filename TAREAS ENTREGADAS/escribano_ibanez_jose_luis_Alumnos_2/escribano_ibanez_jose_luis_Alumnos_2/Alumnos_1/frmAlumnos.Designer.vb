<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Intro_Opcion = New System.Windows.Forms.TextBox()
        Me.gbListado = New System.Windows.Forms.GroupBox()
        Me.txtListado = New System.Windows.Forms.TextBox()
        Me.gbListado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1 - Introducir Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2 - Consultar Alumno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3 - Ordenar Array"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4 - Listar Array"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5 - Fin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Introducir Opción:"
        '
        'txt_Intro_Opcion
        '
        Me.txt_Intro_Opcion.Location = New System.Drawing.Point(273, 275)
        Me.txt_Intro_Opcion.Name = "txt_Intro_Opcion"
        Me.txt_Intro_Opcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Intro_Opcion.TabIndex = 6
        '
        'gbListado
        '
        Me.gbListado.Controls.Add(Me.txtListado)
        Me.gbListado.Location = New System.Drawing.Point(464, 55)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(614, 281)
        Me.gbListado.TabIndex = 7
        Me.gbListado.TabStop = False
        Me.gbListado.Text = "Listado de Alumnos"
        Me.gbListado.Visible = False
        '
        'txtListado
        '
        Me.txtListado.Location = New System.Drawing.Point(51, 19)
        Me.txtListado.Multiline = True
        Me.txtListado.Name = "txtListado"
        Me.txtListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtListado.Size = New System.Drawing.Size(522, 238)
        Me.txtListado.TabIndex = 0
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 348)
        Me.Controls.Add(Me.gbListado)
        Me.Controls.Add(Me.txt_Intro_Opcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAlumnos"
        Me.Text = "Alumnos"
        Me.gbListado.ResumeLayout(False)
        Me.gbListado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Intro_Opcion As TextBox
    Friend WithEvents gbListado As GroupBox
    Friend WithEvents txtListado As TextBox
End Class
