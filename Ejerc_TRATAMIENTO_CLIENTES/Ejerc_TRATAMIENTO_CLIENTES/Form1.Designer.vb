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
        Me.TratamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbx_AltaClientes = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoCli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_ConsultaClientes = New System.Windows.Forms.GroupBox()
        Me.btnSalirConsulta = New System.Windows.Forms.Button()
        Me.txtConsulNombreCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConsulTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConsulCodigoCli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbx_cons_Trat = New System.Windows.Forms.GroupBox()
        Me.btnSalirTratCons = New System.Windows.Forms.Button()
        Me.txtConsTratNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConsTratPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConsTratCodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbx_Factura = New System.Windows.Forms.GroupBox()
        Me.btnSalirFactura = New System.Windows.Forms.Button()
        Me.rtxtb_factura = New System.Windows.Forms.RichTextBox()
        Me.cmbTratamientos = New System.Windows.Forms.ComboBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rtxtb_listado = New System.Windows.Forms.RichTextBox()
        Me.btnSalirListado = New System.Windows.Forms.Button()
        Me.gbx_ListadoCli = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbx_AltaClientes.SuspendLayout()
        Me.gbx_ConsultaClientes.SuspendLayout()
        Me.gbx_cons_Trat.SuspendLayout()
        Me.gbx_Factura.SuspendLayout()
        Me.gbx_ListadoCli.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1118, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.TratamientosToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'TratamientosToolStripMenuItem
        '
        Me.TratamientosToolStripMenuItem.Name = "TratamientosToolStripMenuItem"
        Me.TratamientosToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TratamientosToolStripMenuItem.Text = "Tratamientos"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.TratamientosToolStripMenuItem1})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ClienteToolStripMenuItem.Text = "Consulta Clientes"
        '
        'TratamientosToolStripMenuItem1
        '
        Me.TratamientosToolStripMenuItem1.Name = "TratamientosToolStripMenuItem1"
        Me.TratamientosToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.TratamientosToolStripMenuItem1.Text = "Consulta Tratamientos"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'gbx_AltaClientes
        '
        Me.gbx_AltaClientes.Controls.Add(Me.btnSalir)
        Me.gbx_AltaClientes.Controls.Add(Me.btnGuardar)
        Me.gbx_AltaClientes.Controls.Add(Me.txtNombreCli)
        Me.gbx_AltaClientes.Controls.Add(Me.Label3)
        Me.gbx_AltaClientes.Controls.Add(Me.txtTelefono)
        Me.gbx_AltaClientes.Controls.Add(Me.Label2)
        Me.gbx_AltaClientes.Controls.Add(Me.txtCodigoCli)
        Me.gbx_AltaClientes.Controls.Add(Me.Label1)
        Me.gbx_AltaClientes.Location = New System.Drawing.Point(26, 45)
        Me.gbx_AltaClientes.Name = "gbx_AltaClientes"
        Me.gbx_AltaClientes.Size = New System.Drawing.Size(275, 236)
        Me.gbx_AltaClientes.TabIndex = 1
        Me.gbx_AltaClientes.TabStop = False
        Me.gbx_AltaClientes.Text = "Alta Clientes"
        Me.gbx_AltaClientes.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(149, 185)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(40, 185)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNombreCli
        '
        Me.txtNombreCli.Location = New System.Drawing.Point(104, 95)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.Size = New System.Drawing.Size(136, 20)
        Me.txtNombreCli.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(104, 138)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(136, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Teléfono:"
        '
        'txtCodigoCli
        '
        Me.txtCodigoCli.Location = New System.Drawing.Point(104, 52)
        Me.txtCodigoCli.Name = "txtCodigoCli"
        Me.txtCodigoCli.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigoCli.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código: "
        '
        'gbx_ConsultaClientes
        '
        Me.gbx_ConsultaClientes.Controls.Add(Me.btnSalirConsulta)
        Me.gbx_ConsultaClientes.Controls.Add(Me.txtConsulNombreCli)
        Me.gbx_ConsultaClientes.Controls.Add(Me.Label4)
        Me.gbx_ConsultaClientes.Controls.Add(Me.txtConsulTelefono)
        Me.gbx_ConsultaClientes.Controls.Add(Me.Label5)
        Me.gbx_ConsultaClientes.Controls.Add(Me.txtConsulCodigoCli)
        Me.gbx_ConsultaClientes.Controls.Add(Me.Label6)
        Me.gbx_ConsultaClientes.Location = New System.Drawing.Point(386, 45)
        Me.gbx_ConsultaClientes.Name = "gbx_ConsultaClientes"
        Me.gbx_ConsultaClientes.Size = New System.Drawing.Size(275, 236)
        Me.gbx_ConsultaClientes.TabIndex = 2
        Me.gbx_ConsultaClientes.TabStop = False
        Me.gbx_ConsultaClientes.Text = "Consulta Clientes"
        Me.gbx_ConsultaClientes.Visible = False
        '
        'btnSalirConsulta
        '
        Me.btnSalirConsulta.Location = New System.Drawing.Point(104, 185)
        Me.btnSalirConsulta.Name = "btnSalirConsulta"
        Me.btnSalirConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirConsulta.TabIndex = 8
        Me.btnSalirConsulta.Text = "Salir"
        Me.btnSalirConsulta.UseVisualStyleBackColor = True
        '
        'txtConsulNombreCli
        '
        Me.txtConsulNombreCli.Location = New System.Drawing.Point(104, 95)
        Me.txtConsulNombreCli.Name = "txtConsulNombreCli"
        Me.txtConsulNombreCli.Size = New System.Drawing.Size(136, 20)
        Me.txtConsulNombreCli.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre:"
        '
        'txtConsulTelefono
        '
        Me.txtConsulTelefono.Location = New System.Drawing.Point(104, 138)
        Me.txtConsulTelefono.Name = "txtConsulTelefono"
        Me.txtConsulTelefono.Size = New System.Drawing.Size(136, 20)
        Me.txtConsulTelefono.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Teléfono:"
        '
        'txtConsulCodigoCli
        '
        Me.txtConsulCodigoCli.Location = New System.Drawing.Point(104, 52)
        Me.txtConsulCodigoCli.Name = "txtConsulCodigoCli"
        Me.txtConsulCodigoCli.Size = New System.Drawing.Size(136, 20)
        Me.txtConsulCodigoCli.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código: "
        '
        'gbx_cons_Trat
        '
        Me.gbx_cons_Trat.Controls.Add(Me.btnSalirTratCons)
        Me.gbx_cons_Trat.Controls.Add(Me.txtConsTratNombre)
        Me.gbx_cons_Trat.Controls.Add(Me.Label7)
        Me.gbx_cons_Trat.Controls.Add(Me.txtConsTratPrecio)
        Me.gbx_cons_Trat.Controls.Add(Me.Label8)
        Me.gbx_cons_Trat.Controls.Add(Me.txtConsTratCodigo)
        Me.gbx_cons_Trat.Controls.Add(Me.Label9)
        Me.gbx_cons_Trat.Location = New System.Drawing.Point(787, 45)
        Me.gbx_cons_Trat.Name = "gbx_cons_Trat"
        Me.gbx_cons_Trat.Size = New System.Drawing.Size(275, 236)
        Me.gbx_cons_Trat.TabIndex = 3
        Me.gbx_cons_Trat.TabStop = False
        Me.gbx_cons_Trat.Text = "Consulta Tratamientos"
        Me.gbx_cons_Trat.Visible = False
        '
        'btnSalirTratCons
        '
        Me.btnSalirTratCons.Location = New System.Drawing.Point(104, 185)
        Me.btnSalirTratCons.Name = "btnSalirTratCons"
        Me.btnSalirTratCons.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirTratCons.TabIndex = 8
        Me.btnSalirTratCons.Text = "Salir"
        Me.btnSalirTratCons.UseVisualStyleBackColor = True
        '
        'txtConsTratNombre
        '
        Me.txtConsTratNombre.Location = New System.Drawing.Point(104, 95)
        Me.txtConsTratNombre.Name = "txtConsTratNombre"
        Me.txtConsTratNombre.Size = New System.Drawing.Size(136, 20)
        Me.txtConsTratNombre.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nombre:"
        '
        'txtConsTratPrecio
        '
        Me.txtConsTratPrecio.Location = New System.Drawing.Point(104, 138)
        Me.txtConsTratPrecio.Name = "txtConsTratPrecio"
        Me.txtConsTratPrecio.Size = New System.Drawing.Size(136, 20)
        Me.txtConsTratPrecio.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Precio:"
        '
        'txtConsTratCodigo
        '
        Me.txtConsTratCodigo.Location = New System.Drawing.Point(104, 52)
        Me.txtConsTratCodigo.Name = "txtConsTratCodigo"
        Me.txtConsTratCodigo.Size = New System.Drawing.Size(136, 20)
        Me.txtConsTratCodigo.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Código: "
        '
        'gbx_Factura
        '
        Me.gbx_Factura.Controls.Add(Me.btnSalirFactura)
        Me.gbx_Factura.Controls.Add(Me.rtxtb_factura)
        Me.gbx_Factura.Controls.Add(Me.cmbTratamientos)
        Me.gbx_Factura.Controls.Add(Me.btnAnadir)
        Me.gbx_Factura.Controls.Add(Me.Label12)
        Me.gbx_Factura.Location = New System.Drawing.Point(26, 302)
        Me.gbx_Factura.Name = "gbx_Factura"
        Me.gbx_Factura.Size = New System.Drawing.Size(477, 422)
        Me.gbx_Factura.TabIndex = 4
        Me.gbx_Factura.TabStop = False
        Me.gbx_Factura.Text = "Facturas x Tratamientos:"
        Me.gbx_Factura.Visible = False
        '
        'btnSalirFactura
        '
        Me.btnSalirFactura.Location = New System.Drawing.Point(200, 365)
        Me.btnSalirFactura.Name = "btnSalirFactura"
        Me.btnSalirFactura.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirFactura.TabIndex = 10
        Me.btnSalirFactura.Text = "Salir"
        Me.btnSalirFactura.UseVisualStyleBackColor = True
        '
        'rtxtb_factura
        '
        Me.rtxtb_factura.Location = New System.Drawing.Point(26, 79)
        Me.rtxtb_factura.Name = "rtxtb_factura"
        Me.rtxtb_factura.Size = New System.Drawing.Size(424, 262)
        Me.rtxtb_factura.TabIndex = 9
        Me.rtxtb_factura.Text = ""
        Me.rtxtb_factura.Visible = False
        '
        'cmbTratamientos
        '
        Me.cmbTratamientos.FormattingEnabled = True
        Me.cmbTratamientos.Location = New System.Drawing.Point(163, 35)
        Me.cmbTratamientos.Name = "cmbTratamientos"
        Me.cmbTratamientos.Size = New System.Drawing.Size(121, 21)
        Me.cmbTratamientos.TabIndex = 8
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(320, 35)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir.TabIndex = 7
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nombre Tratamiento:"
        '
        'rtxtb_listado
        '
        Me.rtxtb_listado.Location = New System.Drawing.Point(18, 79)
        Me.rtxtb_listado.Name = "rtxtb_listado"
        Me.rtxtb_listado.Size = New System.Drawing.Size(424, 262)
        Me.rtxtb_listado.TabIndex = 9
        Me.rtxtb_listado.Text = ""
        Me.rtxtb_listado.Visible = False
        '
        'btnSalirListado
        '
        Me.btnSalirListado.Location = New System.Drawing.Point(200, 365)
        Me.btnSalirListado.Name = "btnSalirListado"
        Me.btnSalirListado.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirListado.TabIndex = 10
        Me.btnSalirListado.Text = "Salir"
        Me.btnSalirListado.UseVisualStyleBackColor = True
        '
        'gbx_ListadoCli
        '
        Me.gbx_ListadoCli.Controls.Add(Me.btnSalirListado)
        Me.gbx_ListadoCli.Controls.Add(Me.rtxtb_listado)
        Me.gbx_ListadoCli.Location = New System.Drawing.Point(585, 302)
        Me.gbx_ListadoCli.Name = "gbx_ListadoCli"
        Me.gbx_ListadoCli.Size = New System.Drawing.Size(477, 422)
        Me.gbx_ListadoCli.TabIndex = 5
        Me.gbx_ListadoCli.TabStop = False
        Me.gbx_ListadoCli.Text = "Listado de Clientes con Tratamiento:"
        Me.gbx_ListadoCli.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 750)
        Me.Controls.Add(Me.gbx_ListadoCli)
        Me.Controls.Add(Me.gbx_Factura)
        Me.Controls.Add(Me.gbx_cons_Trat)
        Me.Controls.Add(Me.gbx_ConsultaClientes)
        Me.Controls.Add(Me.gbx_AltaClientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbx_AltaClientes.ResumeLayout(False)
        Me.gbx_AltaClientes.PerformLayout()
        Me.gbx_ConsultaClientes.ResumeLayout(False)
        Me.gbx_ConsultaClientes.PerformLayout()
        Me.gbx_cons_Trat.ResumeLayout(False)
        Me.gbx_cons_Trat.PerformLayout()
        Me.gbx_Factura.ResumeLayout(False)
        Me.gbx_Factura.PerformLayout()
        Me.gbx_ListadoCli.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TratamientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbx_AltaClientes As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombreCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoCli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TratamientosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents gbx_ConsultaClientes As GroupBox
    Friend WithEvents txtConsulNombreCli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConsulTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConsulCodigoCli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalirConsulta As Button
    Friend WithEvents gbx_cons_Trat As GroupBox
    Friend WithEvents btnSalirTratCons As Button
    Friend WithEvents txtConsTratNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConsTratPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConsTratCodigo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gbx_Factura As GroupBox
    Friend WithEvents cmbTratamientos As ComboBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents rtxtb_factura As RichTextBox
    Friend WithEvents btnSalirFactura As Button
    Friend WithEvents rtxtb_listado As RichTextBox
    Friend WithEvents btnSalirListado As Button
    Friend WithEvents gbx_ListadoCli As GroupBox
End Class
