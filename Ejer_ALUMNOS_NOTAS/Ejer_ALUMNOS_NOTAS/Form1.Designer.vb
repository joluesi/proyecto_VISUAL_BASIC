<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntroducirNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEditarNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.NotasToolStripMenuItem, Me.ImprimirNotasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeAlumnosToolStripMenuItem})
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'AltaDeAlumnosToolStripMenuItem
        '
        Me.AltaDeAlumnosToolStripMenuItem.Name = "AltaDeAlumnosToolStripMenuItem"
        Me.AltaDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AltaDeAlumnosToolStripMenuItem.Text = "Alta de Alumnos"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntroducirNotasToolStripMenuItem, Me.ConsultarEditarNotasToolStripMenuItem})
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.NotasToolStripMenuItem.Text = "Notas"
        '
        'IntroducirNotasToolStripMenuItem
        '
        Me.IntroducirNotasToolStripMenuItem.Name = "IntroducirNotasToolStripMenuItem"
        Me.IntroducirNotasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.IntroducirNotasToolStripMenuItem.Text = "Introducir Notas"
        '
        'ConsultarEditarNotasToolStripMenuItem
        '
        Me.ConsultarEditarNotasToolStripMenuItem.Name = "ConsultarEditarNotasToolStripMenuItem"
        Me.ConsultarEditarNotasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ConsultarEditarNotasToolStripMenuItem.Text = "Consultar / Editar Notas"
        '
        'ImprimirNotasToolStripMenuItem
        '
        Me.ImprimirNotasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnoToolStripMenuItem, Me.CursoNotasToolStripMenuItem})
        Me.ImprimirNotasToolStripMenuItem.Name = "ImprimirNotasToolStripMenuItem"
        Me.ImprimirNotasToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ImprimirNotasToolStripMenuItem.Text = "Imprimir Notas"
        '
        'AlumnoToolStripMenuItem
        '
        Me.AlumnoToolStripMenuItem.Name = "AlumnoToolStripMenuItem"
        Me.AlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlumnoToolStripMenuItem.Text = "Alumno Notas"
        '
        'CursoNotasToolStripMenuItem
        '
        Me.CursoNotasToolStripMenuItem.Name = "CursoNotasToolStripMenuItem"
        Me.CursoNotasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CursoNotasToolStripMenuItem.Text = "Curso Notas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntroducirNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEditarNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursoNotasToolStripMenuItem As ToolStripMenuItem
End Class
