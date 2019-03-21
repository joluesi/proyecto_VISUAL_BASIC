<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTADVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTACLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTACLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALQUILARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEVOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOSCONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALToolStripMenuItem, Me.CONSULTADVDToolStripMenuItem, Me.ALTACLIENTESToolStripMenuItem, Me.CONSULTACLIENTESToolStripMenuItem, Me.ALQUILARToolStripMenuItem, Me.DEVOLVERToolStripMenuItem, Me.LISTADOSCONSULTASToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ALToolStripMenuItem
        '
        Me.ALToolStripMenuItem.Name = "ALToolStripMenuItem"
        Me.ALToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ALToolStripMenuItem.Text = "ALTA DVD"
        '
        'CONSULTADVDToolStripMenuItem
        '
        Me.CONSULTADVDToolStripMenuItem.Name = "CONSULTADVDToolStripMenuItem"
        Me.CONSULTADVDToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.CONSULTADVDToolStripMenuItem.Text = "CONSULTA DVD"
        '
        'ALTACLIENTESToolStripMenuItem
        '
        Me.ALTACLIENTESToolStripMenuItem.Name = "ALTACLIENTESToolStripMenuItem"
        Me.ALTACLIENTESToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ALTACLIENTESToolStripMenuItem.Text = "ALTA CLIENTES"
        '
        'CONSULTACLIENTESToolStripMenuItem
        '
        Me.CONSULTACLIENTESToolStripMenuItem.Name = "CONSULTACLIENTESToolStripMenuItem"
        Me.CONSULTACLIENTESToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.CONSULTACLIENTESToolStripMenuItem.Text = "CONSULTA CLIENTES"
        '
        'ALQUILARToolStripMenuItem
        '
        Me.ALQUILARToolStripMenuItem.Name = "ALQUILARToolStripMenuItem"
        Me.ALQUILARToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ALQUILARToolStripMenuItem.Text = "ALQUILAR"
        '
        'DEVOLVERToolStripMenuItem
        '
        Me.DEVOLVERToolStripMenuItem.Name = "DEVOLVERToolStripMenuItem"
        Me.DEVOLVERToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.DEVOLVERToolStripMenuItem.Text = "DEVOLVER"
        '
        'LISTADOSCONSULTASToolStripMenuItem
        '
        Me.LISTADOSCONSULTASToolStripMenuItem.Name = "LISTADOSCONSULTASToolStripMenuItem"
        Me.LISTADOSCONSULTASToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.LISTADOSCONSULTASToolStripMenuItem.Text = "LISTADOS / CONSULTAS "
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 450)
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
    Friend WithEvents ALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTADVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALTACLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTACLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALQUILARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DEVOLVERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOSCONSULTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
End Class
