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
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaArrayComprasMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComisiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.butSalirC = New System.Windows.Forms.Button()
        Me.cmbCodVendedor = New System.Windows.Forms.ComboBox()
        Me.butGuardarC = New System.Windows.Forms.Button()
        Me.txtComprasMes = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.butSalirV = New System.Windows.Forms.Button()
        Me.butGuardarV = New System.Windows.Forms.Button()
        Me.CobZona = New System.Windows.Forms.ComboBox()
        Me.txtComision = New System.Windows.Forms.TextBox()
        Me.txtCodVendedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grbComision = New System.Windows.Forms.GroupBox()
        Me.butSalirComi = New System.Windows.Forms.Button()
        Me.butCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbVend = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grbComision.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.AltaToolStripMenuItem.Text = "Compras Cliente"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Alta"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaArrayComprasMesToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.TratamientoToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ConsultaToolStripMenuItem.Text = "Compras Mes"
        '
        'AltaArrayComprasMesToolStripMenuItem
        '
        Me.AltaArrayComprasMesToolStripMenuItem.Name = "AltaArrayComprasMesToolStripMenuItem"
        Me.AltaArrayComprasMesToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AltaArrayComprasMesToolStripMenuItem.Text = "Alta array ComprasMes"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ClienteToolStripMenuItem.Text = "Inicializar compras_mes"
        '
        'TratamientoToolStripMenuItem
        '
        Me.TratamientoToolStripMenuItem.Name = "TratamientoToolStripMenuItem"
        Me.TratamientoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.TratamientoToolStripMenuItem.Text = "Actualizar compras_mes"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.ComisiónToolStripMenuItem, Me.VentaTotalToolStripMenuItem})
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.FacturaToolStripMenuItem.Text = "Vendedor"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'ComisiónToolStripMenuItem
        '
        Me.ComisiónToolStripMenuItem.Name = "ComisiónToolStripMenuItem"
        Me.ComisiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComisiónToolStripMenuItem.Text = "Comisión"
        '
        'VentaTotalToolStripMenuItem
        '
        Me.VentaTotalToolStripMenuItem.Name = "VentaTotalToolStripMenuItem"
        Me.VentaTotalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VentaTotalToolStripMenuItem.Text = "Ventas totales"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.butSalirC)
        Me.GroupBox1.Controls.Add(Me.cmbCodVendedor)
        Me.GroupBox1.Controls.Add(Me.butGuardarC)
        Me.GroupBox1.Controls.Add(Me.txtComprasMes)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 154)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta Cliente"
        Me.GroupBox1.Visible = False
        '
        'butSalirC
        '
        Me.butSalirC.Location = New System.Drawing.Point(153, 115)
        Me.butSalirC.Name = "butSalirC"
        Me.butSalirC.Size = New System.Drawing.Size(46, 24)
        Me.butSalirC.TabIndex = 11
        Me.butSalirC.Text = "Salir"
        Me.butSalirC.UseVisualStyleBackColor = True
        '
        'cmbCodVendedor
        '
        Me.cmbCodVendedor.FormattingEnabled = True
        Me.cmbCodVendedor.Location = New System.Drawing.Point(99, 45)
        Me.cmbCodVendedor.Name = "cmbCodVendedor"
        Me.cmbCodVendedor.Size = New System.Drawing.Size(100, 21)
        Me.cmbCodVendedor.TabIndex = 10
        '
        'butGuardarC
        '
        Me.butGuardarC.Location = New System.Drawing.Point(14, 116)
        Me.butGuardarC.Name = "butGuardarC"
        Me.butGuardarC.Size = New System.Drawing.Size(56, 23)
        Me.butGuardarC.TabIndex = 8
        Me.butGuardarC.Text = "Guardar"
        Me.butGuardarC.UseVisualStyleBackColor = True
        '
        'txtComprasMes
        '
        Me.txtComprasMes.Location = New System.Drawing.Point(99, 72)
        Me.txtComprasMes.Name = "txtComprasMes"
        Me.txtComprasMes.ReadOnly = True
        Me.txtComprasMes.Size = New System.Drawing.Size(100, 20)
        Me.txtComprasMes.TabIndex = 7
        Me.txtComprasMes.Text = "0"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(99, 23)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 4
        Me.txtCodCliente.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Compras_mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod_Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod_Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.butSalirV)
        Me.GroupBox2.Controls.Add(Me.butGuardarV)
        Me.GroupBox2.Controls.Add(Me.CobZona)
        Me.GroupBox2.Controls.Add(Me.txtComision)
        Me.GroupBox2.Controls.Add(Me.txtCodVendedor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(239, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 151)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alta Vendedor"
        Me.GroupBox2.Visible = False
        '
        'butSalirV
        '
        Me.butSalirV.Location = New System.Drawing.Point(161, 113)
        Me.butSalirV.Name = "butSalirV"
        Me.butSalirV.Size = New System.Drawing.Size(45, 23)
        Me.butSalirV.TabIndex = 8
        Me.butSalirV.Text = "Salir"
        Me.butSalirV.UseVisualStyleBackColor = True
        '
        'butGuardarV
        '
        Me.butGuardarV.Location = New System.Drawing.Point(20, 113)
        Me.butGuardarV.Name = "butGuardarV"
        Me.butGuardarV.Size = New System.Drawing.Size(53, 23)
        Me.butGuardarV.TabIndex = 7
        Me.butGuardarV.Text = "Guardar"
        Me.butGuardarV.UseVisualStyleBackColor = True
        '
        'CobZona
        '
        Me.CobZona.FormattingEnabled = True
        Me.CobZona.Items.AddRange(New Object() {"Norte", "Sur", "Este", "Oeste"})
        Me.CobZona.Location = New System.Drawing.Point(106, 48)
        Me.CobZona.Name = "CobZona"
        Me.CobZona.Size = New System.Drawing.Size(100, 21)
        Me.CobZona.TabIndex = 6
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(106, 76)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(100, 20)
        Me.txtComision.TabIndex = 5
        Me.txtComision.Text = "5"
        '
        'txtCodVendedor
        '
        Me.txtCodVendedor.Location = New System.Drawing.Point(106, 22)
        Me.txtCodVendedor.Name = "txtCodVendedor"
        Me.txtCodVendedor.Size = New System.Drawing.Size(100, 20)
        Me.txtCodVendedor.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Comisión"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Zona"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cod_vendedor"
        '
        'grbComision
        '
        Me.grbComision.Controls.Add(Me.butSalirComi)
        Me.grbComision.Controls.Add(Me.butCalcular)
        Me.grbComision.Controls.Add(Me.Label3)
        Me.grbComision.Controls.Add(Me.cmbVend)
        Me.grbComision.Location = New System.Drawing.Point(12, 27)
        Me.grbComision.Name = "grbComision"
        Me.grbComision.Size = New System.Drawing.Size(469, 60)
        Me.grbComision.TabIndex = 7
        Me.grbComision.TabStop = False
        Me.grbComision.Text = "Comisión"
        Me.grbComision.Visible = False
        '
        'butSalirComi
        '
        Me.butSalirComi.Location = New System.Drawing.Point(227, 19)
        Me.butSalirComi.Name = "butSalirComi"
        Me.butSalirComi.Size = New System.Drawing.Size(49, 23)
        Me.butSalirComi.TabIndex = 3
        Me.butSalirComi.Text = "Salir"
        Me.butSalirComi.UseVisualStyleBackColor = True
        '
        'butCalcular
        '
        Me.butCalcular.Location = New System.Drawing.Point(160, 19)
        Me.butCalcular.Name = "butCalcular"
        Me.butCalcular.Size = New System.Drawing.Size(53, 23)
        Me.butCalcular.TabIndex = 2
        Me.butCalcular.Text = "Calcular"
        Me.butCalcular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Código vendedor"
        '
        'cmbVend
        '
        Me.cmbVend.FormattingEnabled = True
        Me.cmbVend.Location = New System.Drawing.Point(105, 19)
        Me.cmbVend.Name = "cmbVend"
        Me.cmbVend.Size = New System.Drawing.Size(49, 21)
        Me.cmbVend.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 270)
        Me.Controls.Add(Me.grbComision)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Examen recuperación Marzo 2019"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grbComision.ResumeLayout(False)
        Me.grbComision.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TratamientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents butGuardarC As System.Windows.Forms.Button
    Friend WithEvents txtComprasMes As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AltaArrayComprasMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComisiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbCodVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComision As System.Windows.Forms.TextBox
    Friend WithEvents txtCodVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CobZona As System.Windows.Forms.ComboBox
    Friend WithEvents butSalirC As System.Windows.Forms.Button
    Friend WithEvents butSalirV As System.Windows.Forms.Button
    Friend WithEvents butGuardarV As System.Windows.Forms.Button
    Friend WithEvents grbComision As System.Windows.Forms.GroupBox
    Friend WithEvents butCalcular As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbVend As System.Windows.Forms.ComboBox
    Friend WithEvents butSalirComi As System.Windows.Forms.Button

End Class
