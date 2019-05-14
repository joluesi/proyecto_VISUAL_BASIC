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
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlquilarDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.AlquilarDVDToolStripMenuItem, Me.DevolverDVDToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeDVDToolStripMenuItem, Me.AltaDeCLIENTEToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'AltaDeDVDToolStripMenuItem
        '
        Me.AltaDeDVDToolStripMenuItem.Name = "AltaDeDVDToolStripMenuItem"
        Me.AltaDeDVDToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AltaDeDVDToolStripMenuItem.Text = "Alta de DVD"
        '
        'AltaDeCLIENTEToolStripMenuItem
        '
        Me.AltaDeCLIENTEToolStripMenuItem.Name = "AltaDeCLIENTEToolStripMenuItem"
        Me.AltaDeCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AltaDeCLIENTEToolStripMenuItem.Text = "Alta de CLIENTE"
        '
        'AlquilarDVDToolStripMenuItem
        '
        Me.AlquilarDVDToolStripMenuItem.Name = "AlquilarDVDToolStripMenuItem"
        Me.AlquilarDVDToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.AlquilarDVDToolStripMenuItem.Text = "Alquilar DVD"
        '
        'DevolverDVDToolStripMenuItem
        '
        Me.DevolverDVDToolStripMenuItem.Name = "DevolverDVDToolStripMenuItem"
        Me.DevolverDVDToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.DevolverDVDToolStripMenuItem.Text = "Devolver DVD"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeDVDToolStripMenuItem, Me.ConsultaDeCLIENTEToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultaDeDVDToolStripMenuItem
        '
        Me.ConsultaDeDVDToolStripMenuItem.Name = "ConsultaDeDVDToolStripMenuItem"
        Me.ConsultaDeDVDToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ConsultaDeDVDToolStripMenuItem.Text = "Consulta de DVD"
        '
        'ConsultaDeCLIENTEToolStripMenuItem
        '
        Me.ConsultaDeCLIENTEToolStripMenuItem.Name = "ConsultaDeCLIENTEToolStripMenuItem"
        Me.ConsultaDeCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ConsultaDeCLIENTEToolStripMenuItem.Text = "Consulta de CLIENTE"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
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
        Me.Text = "Programa DVD"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeCLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquilarDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeCLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
