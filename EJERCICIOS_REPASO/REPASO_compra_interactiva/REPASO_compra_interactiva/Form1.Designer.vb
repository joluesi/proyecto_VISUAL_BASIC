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
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbxEquipoNecesario = New System.Windows.Forms.GroupBox()
        Me.rbtnPortatil = New System.Windows.Forms.RadioButton()
        Me.rbtnMac = New System.Windows.Forms.RadioButton()
        Me.rbtnPC = New System.Windows.Forms.RadioButton()
        Me.gbxOpcionales = New System.Windows.Forms.GroupBox()
        Me.chkFotocopiadora = New System.Windows.Forms.CheckBox()
        Me.chkCalculadora = New System.Windows.Forms.CheckBox()
        Me.chkContestador = New System.Windows.Forms.CheckBox()
        Me.lstPerifericos = New System.Windows.Forms.ListBox()
        Me.lblPerifericos = New System.Windows.Forms.Label()
        Me.cboPago = New System.Windows.Forms.ComboBox()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picFotocopiadora = New System.Windows.Forms.PictureBox()
        Me.picBolsa = New System.Windows.Forms.PictureBox()
        Me.picCheque = New System.Windows.Forms.PictureBox()
        Me.picDolares = New System.Windows.Forms.PictureBox()
        Me.picCalculadora = New System.Windows.Forms.PictureBox()
        Me.picAntena = New System.Windows.Forms.PictureBox()
        Me.picImpresora = New System.Windows.Forms.PictureBox()
        Me.picHDD = New System.Windows.Forms.PictureBox()
        Me.picContestador = New System.Windows.Forms.PictureBox()
        Me.picPortatil = New System.Windows.Forms.PictureBox()
        Me.picMac = New System.Windows.Forms.PictureBox()
        Me.picPC = New System.Windows.Forms.PictureBox()
        Me.gbxEquipoNecesario.SuspendLayout()
        Me.gbxOpcionales.SuspendLayout()
        CType(Me.picFotocopiadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBolsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAntena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImpresora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHDD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContestador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPortatil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.Location = New System.Drawing.Point(23, 29)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(280, 33)
        Me.lblCompra.TabIndex = 0
        Me.lblCompra.Text = "Compra Interactiva"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(29, 83)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(367, 68)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Actualice su oficina comprando los productos que necesite con casillas de verific" &
    "ación, botones de opción y cuadros de lista." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'gbxEquipoNecesario
        '
        Me.gbxEquipoNecesario.Controls.Add(Me.rbtnPortatil)
        Me.gbxEquipoNecesario.Controls.Add(Me.rbtnMac)
        Me.gbxEquipoNecesario.Controls.Add(Me.rbtnPC)
        Me.gbxEquipoNecesario.Location = New System.Drawing.Point(29, 176)
        Me.gbxEquipoNecesario.Name = "gbxEquipoNecesario"
        Me.gbxEquipoNecesario.Size = New System.Drawing.Size(226, 142)
        Me.gbxEquipoNecesario.TabIndex = 2
        Me.gbxEquipoNecesario.TabStop = False
        Me.gbxEquipoNecesario.Text = "Equipo (necesario)"
        '
        'rbtnPortatil
        '
        Me.rbtnPortatil.AutoSize = True
        Me.rbtnPortatil.Location = New System.Drawing.Point(23, 102)
        Me.rbtnPortatil.Name = "rbtnPortatil"
        Me.rbtnPortatil.Size = New System.Drawing.Size(90, 17)
        Me.rbtnPortatil.TabIndex = 2
        Me.rbtnPortatil.Text = "Portátil (500€)"
        Me.rbtnPortatil.UseVisualStyleBackColor = True
        '
        'rbtnMac
        '
        Me.rbtnMac.AutoSize = True
        Me.rbtnMac.Location = New System.Drawing.Point(23, 66)
        Me.rbtnMac.Name = "rbtnMac"
        Me.rbtnMac.Size = New System.Drawing.Size(113, 17)
        Me.rbtnMac.TabIndex = 1
        Me.rbtnMac.Text = "Macintosh (1000€)"
        Me.rbtnMac.UseVisualStyleBackColor = True
        '
        'rbtnPC
        '
        Me.rbtnPC.AutoSize = True
        Me.rbtnPC.Checked = True
        Me.rbtnPC.Location = New System.Drawing.Point(23, 31)
        Me.rbtnPC.Name = "rbtnPC"
        Me.rbtnPC.Size = New System.Drawing.Size(72, 17)
        Me.rbtnPC.TabIndex = 0
        Me.rbtnPC.TabStop = True
        Me.rbtnPC.Text = "PC (700€)"
        Me.rbtnPC.UseVisualStyleBackColor = True
        '
        'gbxOpcionales
        '
        Me.gbxOpcionales.Controls.Add(Me.chkFotocopiadora)
        Me.gbxOpcionales.Controls.Add(Me.chkCalculadora)
        Me.gbxOpcionales.Controls.Add(Me.chkContestador)
        Me.gbxOpcionales.Location = New System.Drawing.Point(29, 369)
        Me.gbxOpcionales.Name = "gbxOpcionales"
        Me.gbxOpcionales.Size = New System.Drawing.Size(226, 172)
        Me.gbxOpcionales.TabIndex = 3
        Me.gbxOpcionales.TabStop = False
        Me.gbxOpcionales.Text = "Equipo de oficina (0-3)"
        '
        'chkFotocopiadora
        '
        Me.chkFotocopiadora.AutoSize = True
        Me.chkFotocopiadora.Location = New System.Drawing.Point(22, 119)
        Me.chkFotocopiadora.Name = "chkFotocopiadora"
        Me.chkFotocopiadora.Size = New System.Drawing.Size(127, 17)
        Me.chkFotocopiadora.TabIndex = 2
        Me.chkFotocopiadora.Text = "Fotocopiadora (100€)"
        Me.chkFotocopiadora.UseVisualStyleBackColor = True
        '
        'chkCalculadora
        '
        Me.chkCalculadora.AutoSize = True
        Me.chkCalculadora.Location = New System.Drawing.Point(23, 77)
        Me.chkCalculadora.Name = "chkCalculadora"
        Me.chkCalculadora.Size = New System.Drawing.Size(109, 17)
        Me.chkCalculadora.TabIndex = 1
        Me.chkCalculadora.Text = "Calculadora (20€)"
        Me.chkCalculadora.UseVisualStyleBackColor = True
        '
        'chkContestador
        '
        Me.chkContestador.AutoSize = True
        Me.chkContestador.Location = New System.Drawing.Point(23, 36)
        Me.chkContestador.Name = "chkContestador"
        Me.chkContestador.Size = New System.Drawing.Size(110, 17)
        Me.chkContestador.TabIndex = 0
        Me.chkContestador.Text = "Contestador (50€)"
        Me.chkContestador.UseVisualStyleBackColor = True
        '
        'lstPerifericos
        '
        Me.lstPerifericos.AccessibleDescription = ""
        Me.lstPerifericos.FormattingEnabled = True
        Me.lstPerifericos.Items.AddRange(New Object() {"Disco duro adicional (75€)", "Impresora (90€)", "Antena (50€)"})
        Me.lstPerifericos.Location = New System.Drawing.Point(313, 207)
        Me.lstPerifericos.Name = "lstPerifericos"
        Me.lstPerifericos.Size = New System.Drawing.Size(229, 108)
        Me.lstPerifericos.TabIndex = 4
        '
        'lblPerifericos
        '
        Me.lblPerifericos.AutoSize = True
        Me.lblPerifericos.Location = New System.Drawing.Point(313, 176)
        Me.lblPerifericos.Name = "lblPerifericos"
        Me.lblPerifericos.Size = New System.Drawing.Size(107, 13)
        Me.lblPerifericos.TabIndex = 5
        Me.lblPerifericos.Text = "Periféricos (Solo uno)"
        '
        'cboPago
        '
        Me.cboPago.FormattingEnabled = True
        Me.cboPago.Items.AddRange(New Object() {"Dólares EEUU", "Cheque", "Bolsa"})
        Me.cboPago.Location = New System.Drawing.Point(313, 405)
        Me.cboPago.Name = "cboPago"
        Me.cboPago.Size = New System.Drawing.Size(121, 21)
        Me.cboPago.TabIndex = 6
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Location = New System.Drawing.Point(313, 369)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(88, 13)
        Me.lblPago.TabIndex = 7
        Me.lblPago.Text = "Método de pago:"
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.Location = New System.Drawing.Point(675, 29)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(276, 33)
        Me.lblProductos.TabIndex = 8
        Me.lblProductos.Text = "Productos Pedidos"
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuesto.Location = New System.Drawing.Point(313, 461)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(121, 35)
        Me.btnPresupuesto.TabIndex = 21
        Me.btnPresupuesto.Text = "Presupuesto"
        Me.btnPresupuesto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(313, 521)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(121, 35)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picFotocopiadora
        '
        Me.picFotocopiadora.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.CopyMach
        Me.picFotocopiadora.Location = New System.Drawing.Point(842, 476)
        Me.picFotocopiadora.Name = "picFotocopiadora"
        Me.picFotocopiadora.Size = New System.Drawing.Size(211, 161)
        Me.picFotocopiadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotocopiadora.TabIndex = 20
        Me.picFotocopiadora.TabStop = False
        Me.picFotocopiadora.Visible = False
        '
        'picBolsa
        '
        Me.picBolsa.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.PoundBag
        Me.picBolsa.Location = New System.Drawing.Point(594, 476)
        Me.picBolsa.Name = "picBolsa"
        Me.picBolsa.Size = New System.Drawing.Size(211, 161)
        Me.picBolsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBolsa.TabIndex = 19
        Me.picBolsa.TabStop = False
        Me.picBolsa.Visible = False
        '
        'picCheque
        '
        Me.picCheque.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Check
        Me.picCheque.Location = New System.Drawing.Point(594, 476)
        Me.picCheque.Name = "picCheque"
        Me.picCheque.Size = New System.Drawing.Size(211, 161)
        Me.picCheque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheque.TabIndex = 18
        Me.picCheque.TabStop = False
        Me.picCheque.Visible = False
        '
        'picDolares
        '
        Me.picDolares.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Dollar
        Me.picDolares.Location = New System.Drawing.Point(594, 476)
        Me.picDolares.Name = "picDolares"
        Me.picDolares.Size = New System.Drawing.Size(211, 161)
        Me.picDolares.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDolares.TabIndex = 17
        Me.picDolares.TabStop = False
        Me.picDolares.Visible = False
        '
        'picCalculadora
        '
        Me.picCalculadora.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Calcultr
        Me.picCalculadora.Location = New System.Drawing.Point(842, 280)
        Me.picCalculadora.Name = "picCalculadora"
        Me.picCalculadora.Size = New System.Drawing.Size(211, 161)
        Me.picCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCalculadora.TabIndex = 16
        Me.picCalculadora.TabStop = False
        Me.picCalculadora.Visible = False
        '
        'picAntena
        '
        Me.picAntena.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.SateDish
        Me.picAntena.Location = New System.Drawing.Point(594, 280)
        Me.picAntena.Name = "picAntena"
        Me.picAntena.Size = New System.Drawing.Size(211, 161)
        Me.picAntena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAntena.TabIndex = 15
        Me.picAntena.TabStop = False
        Me.picAntena.Visible = False
        '
        'picImpresora
        '
        Me.picImpresora.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Printer
        Me.picImpresora.Location = New System.Drawing.Point(594, 280)
        Me.picImpresora.Name = "picImpresora"
        Me.picImpresora.Size = New System.Drawing.Size(211, 161)
        Me.picImpresora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImpresora.TabIndex = 14
        Me.picImpresora.TabStop = False
        Me.picImpresora.Visible = False
        '
        'picHDD
        '
        Me.picHDD.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Harddisk
        Me.picHDD.Location = New System.Drawing.Point(594, 280)
        Me.picHDD.Name = "picHDD"
        Me.picHDD.Size = New System.Drawing.Size(211, 161)
        Me.picHDD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHDD.TabIndex = 13
        Me.picHDD.TabStop = False
        Me.picHDD.Visible = False
        '
        'picContestador
        '
        Me.picContestador.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.AnswMach
        Me.picContestador.Location = New System.Drawing.Point(842, 87)
        Me.picContestador.Name = "picContestador"
        Me.picContestador.Size = New System.Drawing.Size(211, 161)
        Me.picContestador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContestador.TabIndex = 12
        Me.picContestador.TabStop = False
        Me.picContestador.Visible = False
        '
        'picPortatil
        '
        Me.picPortatil.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Laptop1
        Me.picPortatil.Location = New System.Drawing.Point(594, 87)
        Me.picPortatil.Name = "picPortatil"
        Me.picPortatil.Size = New System.Drawing.Size(211, 161)
        Me.picPortatil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPortatil.TabIndex = 11
        Me.picPortatil.TabStop = False
        Me.picPortatil.Visible = False
        '
        'picMac
        '
        Me.picMac.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.Computer
        Me.picMac.Location = New System.Drawing.Point(594, 87)
        Me.picMac.Name = "picMac"
        Me.picMac.Size = New System.Drawing.Size(211, 161)
        Me.picMac.TabIndex = 10
        Me.picMac.TabStop = False
        Me.picMac.Visible = False
        '
        'picPC
        '
        Me.picPC.Image = Global.REPASO_compra_interactiva.My.Resources.Resources.PComputr
        Me.picPC.Location = New System.Drawing.Point(594, 87)
        Me.picPC.Name = "picPC"
        Me.picPC.Size = New System.Drawing.Size(211, 161)
        Me.picPC.TabIndex = 9
        Me.picPC.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 679)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPresupuesto)
        Me.Controls.Add(Me.picFotocopiadora)
        Me.Controls.Add(Me.picBolsa)
        Me.Controls.Add(Me.picCheque)
        Me.Controls.Add(Me.picDolares)
        Me.Controls.Add(Me.picCalculadora)
        Me.Controls.Add(Me.picAntena)
        Me.Controls.Add(Me.picImpresora)
        Me.Controls.Add(Me.picHDD)
        Me.Controls.Add(Me.picContestador)
        Me.Controls.Add(Me.picPortatil)
        Me.Controls.Add(Me.picMac)
        Me.Controls.Add(Me.picPC)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.lblPago)
        Me.Controls.Add(Me.cboPago)
        Me.Controls.Add(Me.lblPerifericos)
        Me.Controls.Add(Me.lstPerifericos)
        Me.Controls.Add(Me.gbxOpcionales)
        Me.Controls.Add(Me.gbxEquipoNecesario)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCompra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxEquipoNecesario.ResumeLayout(False)
        Me.gbxEquipoNecesario.PerformLayout()
        Me.gbxOpcionales.ResumeLayout(False)
        Me.gbxOpcionales.PerformLayout()
        CType(Me.picFotocopiadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBolsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAntena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImpresora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHDD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContestador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPortatil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompra As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gbxEquipoNecesario As GroupBox
    Friend WithEvents rbtnPortatil As RadioButton
    Friend WithEvents rbtnMac As RadioButton
    Friend WithEvents rbtnPC As RadioButton
    Friend WithEvents gbxOpcionales As GroupBox
    Friend WithEvents chkFotocopiadora As CheckBox
    Friend WithEvents chkCalculadora As CheckBox
    Friend WithEvents chkContestador As CheckBox
    Friend WithEvents lstPerifericos As ListBox
    Friend WithEvents lblPerifericos As Label
    Friend WithEvents cboPago As ComboBox
    Friend WithEvents lblPago As Label
    Friend WithEvents lblProductos As Label
    Friend WithEvents picPC As PictureBox
    Friend WithEvents picMac As PictureBox
    Friend WithEvents picPortatil As PictureBox
    Friend WithEvents picContestador As PictureBox
    Friend WithEvents picHDD As PictureBox
    Friend WithEvents picImpresora As PictureBox
    Friend WithEvents picAntena As PictureBox
    Friend WithEvents picCalculadora As PictureBox
    Friend WithEvents picDolares As PictureBox
    Friend WithEvents picCheque As PictureBox
    Friend WithEvents picBolsa As PictureBox
    Friend WithEvents picFotocopiadora As PictureBox
    Friend WithEvents btnPresupuesto As Button
    Friend WithEvents btnSalir As Button
End Class
