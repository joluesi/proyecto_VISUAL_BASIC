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
        Me.ALTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTACLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTAPEDIDOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CURSARPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTACLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAPEDIDOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASLISTADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALTAToolStripMenuItem, Me.ALTACLIENTESToolStripMenuItem, Me.ALTAPEDIDOSToolStripMenuItem, Me.CURSARPEDIDOToolStripMenuItem, Me.CONSULTACLIENTESToolStripMenuItem, Me.CONSULTAPEDIDOSToolStripMenuItem, Me.CONSULTASLISTADOSToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1206, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ALTAToolStripMenuItem
        '
        Me.ALTAToolStripMenuItem.Name = "ALTAToolStripMenuItem"
        Me.ALTAToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.ALTAToolStripMenuItem.Text = "ALTA PRODUCTOS "
        '
        'ALTACLIENTESToolStripMenuItem
        '
        Me.ALTACLIENTESToolStripMenuItem.Name = "ALTACLIENTESToolStripMenuItem"
        Me.ALTACLIENTESToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ALTACLIENTESToolStripMenuItem.Text = "ALTA CLIENTES"
        '
        'ALTAPEDIDOSToolStripMenuItem
        '
        Me.ALTAPEDIDOSToolStripMenuItem.Name = "ALTAPEDIDOSToolStripMenuItem"
        Me.ALTAPEDIDOSToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ALTAPEDIDOSToolStripMenuItem.Text = "ALTA PEDIDOS"
        '
        'CURSARPEDIDOToolStripMenuItem
        '
        Me.CURSARPEDIDOToolStripMenuItem.Name = "CURSARPEDIDOToolStripMenuItem"
        Me.CURSARPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.CURSARPEDIDOToolStripMenuItem.Text = "CURSAR PEDIDO"
        '
        'CONSULTACLIENTESToolStripMenuItem
        '
        Me.CONSULTACLIENTESToolStripMenuItem.Name = "CONSULTACLIENTESToolStripMenuItem"
        Me.CONSULTACLIENTESToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.CONSULTACLIENTESToolStripMenuItem.Text = "CONSULTA CLIENTES"
        '
        'CONSULTAPEDIDOSToolStripMenuItem
        '
        Me.CONSULTAPEDIDOSToolStripMenuItem.Name = "CONSULTAPEDIDOSToolStripMenuItem"
        Me.CONSULTAPEDIDOSToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.CONSULTAPEDIDOSToolStripMenuItem.Text = "CONSULTA PEDIDOS"
        '
        'CONSULTASLISTADOSToolStripMenuItem
        '
        Me.CONSULTASLISTADOSToolStripMenuItem.Name = "CONSULTASLISTADOSToolStripMenuItem"
        Me.CONSULTASLISTADOSToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CONSULTASLISTADOSToolStripMenuItem.Text = "LISTADOS"
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
        Me.ClientSize = New System.Drawing.Size(1206, 450)
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
    Friend WithEvents ALTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALTACLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALTAPEDIDOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CURSARPEDIDOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTACLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAPEDIDOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTASLISTADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
End Class
