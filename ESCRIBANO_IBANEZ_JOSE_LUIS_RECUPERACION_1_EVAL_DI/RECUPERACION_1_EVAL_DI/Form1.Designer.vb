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
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlquilerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbDvd = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblcodcli = New System.Windows.Forms.Label()
        Me.lblalquila = New System.Windows.Forms.Label()
        Me.lblDevuelve = New System.Windows.Forms.Label()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.txtfechaalquiler = New System.Windows.Forms.TextBox()
        Me.txtfechadevuelve = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbConsulta = New System.Windows.Forms.GroupBox()
        Me.lbltitulodvd = New System.Windows.Forms.Label()
        Me.txtTituloConsulta = New System.Windows.Forms.TextBox()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbDvd.SuspendLayout()
        Me.gbConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.AlquilerToolStripMenuItem, Me.DevolverToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1025, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AltaToolStripMenuItem.Text = "Alta "
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'AlquilerToolStripMenuItem
        '
        Me.AlquilerToolStripMenuItem.Name = "AlquilerToolStripMenuItem"
        Me.AlquilerToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AlquilerToolStripMenuItem.Text = "Alquiler"
        '
        'DevolverToolStripMenuItem
        '
        Me.DevolverToolStripMenuItem.Name = "DevolverToolStripMenuItem"
        Me.DevolverToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.DevolverToolStripMenuItem.Text = "Devolver"
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
        'gbDvd
        '
        Me.gbDvd.Controls.Add(Me.btnLimpiar)
        Me.gbDvd.Controls.Add(Me.txtfechadevuelve)
        Me.gbDvd.Controls.Add(Me.txtfechaalquiler)
        Me.gbDvd.Controls.Add(Me.txtcodcli)
        Me.gbDvd.Controls.Add(Me.lblDevuelve)
        Me.gbDvd.Controls.Add(Me.lblalquila)
        Me.gbDvd.Controls.Add(Me.lblcodcli)
        Me.gbDvd.Controls.Add(Me.btnGuardar)
        Me.gbDvd.Controls.Add(Me.btnSalir)
        Me.gbDvd.Controls.Add(Me.txtDias)
        Me.gbDvd.Controls.Add(Me.txtTitulo)
        Me.gbDvd.Controls.Add(Me.txtcodigo)
        Me.gbDvd.Controls.Add(Me.lblDias)
        Me.gbDvd.Controls.Add(Me.lblTitulo)
        Me.gbDvd.Controls.Add(Me.lblCodigo)
        Me.gbDvd.Location = New System.Drawing.Point(63, 54)
        Me.gbDvd.Name = "gbDvd"
        Me.gbDvd.Size = New System.Drawing.Size(406, 384)
        Me.gbDvd.TabIndex = 1
        Me.gbDvd.TabStop = False
        Me.gbDvd.Text = "Alta"
        Me.gbDvd.Visible = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(47, 30)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(47, 75)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Título:"
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(47, 121)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(70, 13)
        Me.lblDias.TabIndex = 2
        Me.lblDias.Text = "Días Alquiler:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(161, 27)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtcodigo.TabIndex = 3
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(161, 68)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(120, 20)
        Me.txtTitulo.TabIndex = 4
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(161, 118)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(120, 20)
        Me.txtDias.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(64, 313)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(182, 313)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblcodcli
        '
        Me.lblcodcli.AutoSize = True
        Me.lblcodcli.Location = New System.Drawing.Point(47, 171)
        Me.lblcodcli.Name = "lblcodcli"
        Me.lblcodcli.Size = New System.Drawing.Size(78, 13)
        Me.lblcodcli.TabIndex = 8
        Me.lblcodcli.Text = "Código Cliente:"
        Me.lblcodcli.Visible = False
        '
        'lblalquila
        '
        Me.lblalquila.AutoSize = True
        Me.lblalquila.Location = New System.Drawing.Point(47, 213)
        Me.lblalquila.Name = "lblalquila"
        Me.lblalquila.Size = New System.Drawing.Size(92, 13)
        Me.lblalquila.TabIndex = 9
        Me.lblalquila.Text = "Fecha de Alquiler:"
        Me.lblalquila.Visible = False
        '
        'lblDevuelve
        '
        Me.lblDevuelve.AutoSize = True
        Me.lblDevuelve.Location = New System.Drawing.Point(47, 254)
        Me.lblDevuelve.Name = "lblDevuelve"
        Me.lblDevuelve.Size = New System.Drawing.Size(87, 13)
        Me.lblDevuelve.TabIndex = 10
        Me.lblDevuelve.Text = "Fecha devuelve:"
        Me.lblDevuelve.Visible = False
        '
        'txtcodcli
        '
        Me.txtcodcli.Location = New System.Drawing.Point(161, 171)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.Size = New System.Drawing.Size(120, 20)
        Me.txtcodcli.TabIndex = 11
        Me.txtcodcli.Visible = False
        '
        'txtfechaalquiler
        '
        Me.txtfechaalquiler.Location = New System.Drawing.Point(161, 213)
        Me.txtfechaalquiler.Name = "txtfechaalquiler"
        Me.txtfechaalquiler.Size = New System.Drawing.Size(120, 20)
        Me.txtfechaalquiler.TabIndex = 12
        Me.txtfechaalquiler.Visible = False
        '
        'txtfechadevuelve
        '
        Me.txtfechadevuelve.Location = New System.Drawing.Point(161, 251)
        Me.txtfechadevuelve.Name = "txtfechadevuelve"
        Me.txtfechadevuelve.Size = New System.Drawing.Size(120, 20)
        Me.txtfechadevuelve.TabIndex = 13
        Me.txtfechadevuelve.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(302, 313)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'gbConsulta
        '
        Me.gbConsulta.Controls.Add(Me.btnVolver)
        Me.gbConsulta.Controls.Add(Me.btnConsulta)
        Me.gbConsulta.Controls.Add(Me.txtTituloConsulta)
        Me.gbConsulta.Controls.Add(Me.lbltitulodvd)
        Me.gbConsulta.Location = New System.Drawing.Point(537, 64)
        Me.gbConsulta.Name = "gbConsulta"
        Me.gbConsulta.Size = New System.Drawing.Size(367, 301)
        Me.gbConsulta.TabIndex = 2
        Me.gbConsulta.TabStop = False
        Me.gbConsulta.Text = "Consultar"
        Me.gbConsulta.Visible = False
        '
        'lbltitulodvd
        '
        Me.lbltitulodvd.AutoSize = True
        Me.lbltitulodvd.Location = New System.Drawing.Point(39, 58)
        Me.lbltitulodvd.Name = "lbltitulodvd"
        Me.lbltitulodvd.Size = New System.Drawing.Size(64, 13)
        Me.lbltitulodvd.TabIndex = 1
        Me.lbltitulodvd.Text = "Título DVD:"
        '
        'txtTituloConsulta
        '
        Me.txtTituloConsulta.Location = New System.Drawing.Point(135, 55)
        Me.txtTituloConsulta.Name = "txtTituloConsulta"
        Me.txtTituloConsulta.Size = New System.Drawing.Size(120, 20)
        Me.txtTituloConsulta.TabIndex = 5
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(154, 123)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(89, 23)
        Me.btnConsulta.TabIndex = 8
        Me.btnConsulta.Text = "CONSULTAR"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(154, 180)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 23)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 450)
        Me.Controls.Add(Me.gbConsulta)
        Me.Controls.Add(Me.gbDvd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbDvd.ResumeLayout(False)
        Me.gbDvd.PerformLayout()
        Me.gbConsulta.ResumeLayout(False)
        Me.gbConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbDvd As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtDias As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblDias As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtfechadevuelve As TextBox
    Friend WithEvents txtfechaalquiler As TextBox
    Friend WithEvents txtcodcli As TextBox
    Friend WithEvents lblDevuelve As Label
    Friend WithEvents lblalquila As Label
    Friend WithEvents lblcodcli As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents gbConsulta As GroupBox
    Friend WithEvents txtTituloConsulta As TextBox
    Friend WithEvents lbltitulodvd As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnConsulta As Button
End Class
