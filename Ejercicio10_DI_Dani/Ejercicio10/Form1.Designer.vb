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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AltaDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlquilarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDVDToolStripMenuItem, Me.ConsultaDVDToolStripMenuItem, Me.AltaClienteToolStripMenuItem, Me.ConsultaClienteToolStripMenuItem, Me.AlquilarToolStripMenuItem, Me.DevolverToolStripMenuItem, Me.ListadosConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaDVDToolStripMenuItem
        '
        Me.AltaDVDToolStripMenuItem.Name = "AltaDVDToolStripMenuItem"
        Me.AltaDVDToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.AltaDVDToolStripMenuItem.Text = "Alta DVD"
        '
        'ConsultaDVDToolStripMenuItem
        '
        Me.ConsultaDVDToolStripMenuItem.Name = "ConsultaDVDToolStripMenuItem"
        Me.ConsultaDVDToolStripMenuItem.Size = New System.Drawing.Size(113, 24)
        Me.ConsultaDVDToolStripMenuItem.Text = "Consulta DVD"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        '
        'ConsultaClienteToolStripMenuItem
        '
        Me.ConsultaClienteToolStripMenuItem.Name = "ConsultaClienteToolStripMenuItem"
        Me.ConsultaClienteToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.ConsultaClienteToolStripMenuItem.Text = "Consulta Cliente"
        '
        'AlquilarToolStripMenuItem
        '
        Me.AlquilarToolStripMenuItem.Name = "AlquilarToolStripMenuItem"
        Me.AlquilarToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.AlquilarToolStripMenuItem.Text = "Alquilar"
        '
        'DevolverToolStripMenuItem
        '
        Me.DevolverToolStripMenuItem.Name = "DevolverToolStripMenuItem"
        Me.DevolverToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.DevolverToolStripMenuItem.Text = "Devolver"
        '
        'ListadosConsultasToolStripMenuItem
        '
        Me.ListadosConsultasToolStripMenuItem.Name = "ListadosConsultasToolStripMenuItem"
        Me.ListadosConsultasToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.ListadosConsultasToolStripMenuItem.Text = "Listados/Consultas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(504, 497)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 586)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquilarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
