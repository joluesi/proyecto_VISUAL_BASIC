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
        Me.ALTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDvdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDVDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlquilarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.devolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaAlquiladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALTAToolStripMenuItem, Me.CONSULTAToolStripMenuItem, Me.AlquilarToolStripMenuItem, Me.devolverToolStripMenuItem, Me.LISTADOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ALTAToolStripMenuItem
        '
        Me.ALTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDvdToolStripMenuItem, Me.AltaClienteToolStripMenuItem})
        Me.ALTAToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ALTAToolStripMenuItem.Name = "ALTAToolStripMenuItem"
        Me.ALTAToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ALTAToolStripMenuItem.Text = "ALTA"
        '
        'AltaDvdToolStripMenuItem
        '
        Me.AltaDvdToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AltaDvdToolStripMenuItem.Name = "AltaDvdToolStripMenuItem"
        Me.AltaDvdToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltaDvdToolStripMenuItem.Text = "DVD"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltaClienteToolStripMenuItem.Text = "Cliente"
        '
        'CONSULTAToolStripMenuItem
        '
        Me.CONSULTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDVDToolStripMenuItem1, Me.ConsultaClienteToolStripMenuItem1})
        Me.CONSULTAToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CONSULTAToolStripMenuItem.Name = "CONSULTAToolStripMenuItem"
        Me.CONSULTAToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.CONSULTAToolStripMenuItem.Text = "CONSULTA"
        '
        'ConsultaDVDToolStripMenuItem1
        '
        Me.ConsultaDVDToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ConsultaDVDToolStripMenuItem1.Name = "ConsultaDVDToolStripMenuItem1"
        Me.ConsultaDVDToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ConsultaDVDToolStripMenuItem1.Text = "DVD"
        '
        'ConsultaClienteToolStripMenuItem1
        '
        Me.ConsultaClienteToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ConsultaClienteToolStripMenuItem1.Name = "ConsultaClienteToolStripMenuItem1"
        Me.ConsultaClienteToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ConsultaClienteToolStripMenuItem1.Text = "Cliente"
        '
        'AlquilarToolStripMenuItem
        '
        Me.AlquilarToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AlquilarToolStripMenuItem.Name = "AlquilarToolStripMenuItem"
        Me.AlquilarToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.AlquilarToolStripMenuItem.Text = "ALQUILAR"
        '
        'devolverToolStripMenuItem
        '
        Me.devolverToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem"
        Me.devolverToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.devolverToolStripMenuItem.Text = "DEVOLVER"
        '
        'LISTADOToolStripMenuItem
        '
        Me.LISTADOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaClienteToolStripMenuItem2, Me.ListaAlquiladosToolStripMenuItem, Me.ListaDisponiblesToolStripMenuItem, Me.ListaDVDToolStripMenuItem})
        Me.LISTADOToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LISTADOToolStripMenuItem.Name = "LISTADOToolStripMenuItem"
        Me.LISTADOToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.LISTADOToolStripMenuItem.Text = "LISTADO"
        '
        'ListaClienteToolStripMenuItem2
        '
        Me.ListaClienteToolStripMenuItem2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListaClienteToolStripMenuItem2.Name = "ListaClienteToolStripMenuItem2"
        Me.ListaClienteToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ListaClienteToolStripMenuItem2.Text = "Cliente"
        '
        'ListaAlquiladosToolStripMenuItem
        '
        Me.ListaAlquiladosToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListaAlquiladosToolStripMenuItem.Name = "ListaAlquiladosToolStripMenuItem"
        Me.ListaAlquiladosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListaAlquiladosToolStripMenuItem.Text = "DVDs Alquilados"
        '
        'ListaDisponiblesToolStripMenuItem
        '
        Me.ListaDisponiblesToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListaDisponiblesToolStripMenuItem.Name = "ListaDisponiblesToolStripMenuItem"
        Me.ListaDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListaDisponiblesToolStripMenuItem.Text = "DVDs Disponibles"
        '
        'ListaDVDToolStripMenuItem
        '
        Me.ListaDVDToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListaDVDToolStripMenuItem.Name = "ListaDVDToolStripMenuItem"
        Me.ListaDVDToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListaDVDToolStripMenuItem.Text = "DVD "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1028, 623)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "VIDEOCLUB"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ALTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDvdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDVDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultaClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlquilarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTADOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListaAlquiladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents devolverToolStripMenuItem As ToolStripMenuItem
End Class
