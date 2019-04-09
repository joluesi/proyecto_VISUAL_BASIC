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
        Me.ProductosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosDeClienteMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.CursarPedidoToolStripMenuItem, Me.ConsultasListadosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosClientesToolStripMenuItem, Me.PedidosToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ProductosClientesToolStripMenuItem
        '
        Me.ProductosClientesToolStripMenuItem.Name = "ProductosClientesToolStripMenuItem"
        Me.ProductosClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ProductosClientesToolStripMenuItem.Text = "Productos / Clientes"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'CursarPedidoToolStripMenuItem
        '
        Me.CursarPedidoToolStripMenuItem.Name = "CursarPedidoToolStripMenuItem"
        Me.CursarPedidoToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.CursarPedidoToolStripMenuItem.Text = "Cursar Pedido"
        '
        'ConsultasListadosToolStripMenuItem
        '
        Me.ConsultasListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosDeClienteMesToolStripMenuItem, Me.ClientesDeProductoToolStripMenuItem, Me.AbrirListadoToolStripMenuItem})
        Me.ConsultasListadosToolStripMenuItem.Name = "ConsultasListadosToolStripMenuItem"
        Me.ConsultasListadosToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ConsultasListadosToolStripMenuItem.Text = "Consultas / Listados"
        '
        'ProductosDeClienteMesToolStripMenuItem
        '
        Me.ProductosDeClienteMesToolStripMenuItem.Name = "ProductosDeClienteMesToolStripMenuItem"
        Me.ProductosDeClienteMesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ProductosDeClienteMesToolStripMenuItem.Text = "Productos de Cliente mes"
        '
        'ClientesDeProductoToolStripMenuItem
        '
        Me.ClientesDeProductoToolStripMenuItem.Name = "ClientesDeProductoToolStripMenuItem"
        Me.ClientesDeProductoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ClientesDeProductoToolStripMenuItem.Text = "Clientes de Producto"
        '
        'AbrirListadoToolStripMenuItem
        '
        Me.AbrirListadoToolStripMenuItem.Name = "AbrirListadoToolStripMenuItem"
        Me.AbrirListadoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AbrirListadoToolStripMenuItem.Text = "Abrir listado"
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
        Me.Text = "Aplicacion Pedidos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursarPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosDeClienteMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesDeProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
