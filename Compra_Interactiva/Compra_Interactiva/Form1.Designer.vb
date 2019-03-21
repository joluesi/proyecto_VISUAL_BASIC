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
        Me.gbEquipos = New System.Windows.Forms.GroupBox()
        Me.rbtnPortatil = New System.Windows.Forms.RadioButton()
        Me.rbtnMac = New System.Windows.Forms.RadioButton()
        Me.rbtnPC = New System.Windows.Forms.RadioButton()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.chbFotocopia = New System.Windows.Forms.CheckBox()
        Me.chbCalculadora = New System.Windows.Forms.CheckBox()
        Me.chbContestador = New System.Windows.Forms.CheckBox()
        Me.lsbPerifericos = New System.Windows.Forms.ListBox()
        Me.lblPerifericos = New System.Windows.Forms.Label()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.picContestador = New System.Windows.Forms.PictureBox()
        Me.picImpresora = New System.Windows.Forms.PictureBox()
        Me.picCalculadora = New System.Windows.Forms.PictureBox()
        Me.picDolar = New System.Windows.Forms.PictureBox()
        Me.picFotocopia = New System.Windows.Forms.PictureBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.picMac = New System.Windows.Forms.PictureBox()
        Me.picLaptop = New System.Windows.Forms.PictureBox()
        Me.picEfectivo = New System.Windows.Forms.PictureBox()
        Me.picCheque = New System.Windows.Forms.PictureBox()
        Me.picDiscoDuro = New System.Windows.Forms.PictureBox()
        Me.picAntena = New System.Windows.Forms.PictureBox()
        Me.gbEquipos.SuspendLayout()
        Me.gb2.SuspendLayout()
        CType(Me.picContestador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImpresora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotocopia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiscoDuro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAntena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEquipos
        '
        Me.gbEquipos.Controls.Add(Me.rbtnPortatil)
        Me.gbEquipos.Controls.Add(Me.rbtnMac)
        Me.gbEquipos.Controls.Add(Me.rbtnPC)
        Me.gbEquipos.Location = New System.Drawing.Point(50, 36)
        Me.gbEquipos.Name = "gbEquipos"
        Me.gbEquipos.Size = New System.Drawing.Size(153, 163)
        Me.gbEquipos.TabIndex = 0
        Me.gbEquipos.TabStop = False
        Me.gbEquipos.Text = "Equipo (necesario)"
        '
        'rbtnPortatil
        '
        Me.rbtnPortatil.AutoSize = True
        Me.rbtnPortatil.Location = New System.Drawing.Point(25, 118)
        Me.rbtnPortatil.Name = "rbtnPortatil"
        Me.rbtnPortatil.Size = New System.Drawing.Size(57, 17)
        Me.rbtnPortatil.TabIndex = 2
        Me.rbtnPortatil.Text = "Portatil"
        Me.rbtnPortatil.UseVisualStyleBackColor = True
        '
        'rbtnMac
        '
        Me.rbtnMac.AutoSize = True
        Me.rbtnMac.Location = New System.Drawing.Point(25, 75)
        Me.rbtnMac.Name = "rbtnMac"
        Me.rbtnMac.Size = New System.Drawing.Size(74, 17)
        Me.rbtnMac.TabIndex = 1
        Me.rbtnMac.Text = "Macintosh"
        Me.rbtnMac.UseVisualStyleBackColor = True
        '
        'rbtnPC
        '
        Me.rbtnPC.AutoSize = True
        Me.rbtnPC.Checked = True
        Me.rbtnPC.Location = New System.Drawing.Point(25, 34)
        Me.rbtnPC.Name = "rbtnPC"
        Me.rbtnPC.Size = New System.Drawing.Size(39, 17)
        Me.rbtnPC.TabIndex = 0
        Me.rbtnPC.TabStop = True
        Me.rbtnPC.Text = "PC"
        Me.rbtnPC.UseVisualStyleBackColor = True
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.chbFotocopia)
        Me.gb2.Controls.Add(Me.chbCalculadora)
        Me.gb2.Controls.Add(Me.chbContestador)
        Me.gb2.Location = New System.Drawing.Point(50, 239)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(153, 159)
        Me.gb2.TabIndex = 1
        Me.gb2.TabStop = False
        Me.gb2.Text = "Equipo de oficina (0-3)"
        '
        'chbFotocopia
        '
        Me.chbFotocopia.AutoSize = True
        Me.chbFotocopia.Location = New System.Drawing.Point(25, 118)
        Me.chbFotocopia.Name = "chbFotocopia"
        Me.chbFotocopia.Size = New System.Drawing.Size(94, 17)
        Me.chbFotocopia.TabIndex = 2
        Me.chbFotocopia.Text = "Fotocopiadora"
        Me.chbFotocopia.UseVisualStyleBackColor = True
        '
        'chbCalculadora
        '
        Me.chbCalculadora.AutoSize = True
        Me.chbCalculadora.Location = New System.Drawing.Point(25, 78)
        Me.chbCalculadora.Name = "chbCalculadora"
        Me.chbCalculadora.Size = New System.Drawing.Size(82, 17)
        Me.chbCalculadora.TabIndex = 1
        Me.chbCalculadora.Text = "Calculadora"
        Me.chbCalculadora.UseVisualStyleBackColor = True
        '
        'chbContestador
        '
        Me.chbContestador.AutoSize = True
        Me.chbContestador.Location = New System.Drawing.Point(25, 36)
        Me.chbContestador.Name = "chbContestador"
        Me.chbContestador.Size = New System.Drawing.Size(83, 17)
        Me.chbContestador.TabIndex = 0
        Me.chbContestador.Text = "Contestador"
        Me.chbContestador.UseVisualStyleBackColor = True
        '
        'lsbPerifericos
        '
        Me.lsbPerifericos.FormattingEnabled = True
        Me.lsbPerifericos.Items.AddRange(New Object() {"Disco duro adicional", "Impresora", "Antena"})
        Me.lsbPerifericos.Location = New System.Drawing.Point(245, 70)
        Me.lsbPerifericos.Name = "lsbPerifericos"
        Me.lsbPerifericos.Size = New System.Drawing.Size(151, 82)
        Me.lsbPerifericos.TabIndex = 2
        '
        'lblPerifericos
        '
        Me.lblPerifericos.AutoSize = True
        Me.lblPerifericos.Location = New System.Drawing.Point(245, 51)
        Me.lblPerifericos.Name = "lblPerifericos"
        Me.lblPerifericos.Size = New System.Drawing.Size(108, 13)
        Me.lblPerifericos.TabIndex = 3
        Me.lblPerifericos.Text = "Periféricos (sólo uno):"
        '
        'cmbPago
        '
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Items.AddRange(New Object() {"Dolares - EEUU", "Pago en efectivo", "Cheque"})
        Me.cmbPago.Location = New System.Drawing.Point(245, 251)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(151, 21)
        Me.cmbPago.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(273, 317)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 32)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(471, 51)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(98, 13)
        Me.lblProductos.TabIndex = 6
        Me.lblProductos.Text = "Productos pedidos:"
        '
        'picContestador
        '
        Me.picContestador.Image = Global.Compra_Interactiva.My.Resources.Resources.AnswMach
        Me.picContestador.Location = New System.Drawing.Point(644, 70)
        Me.picContestador.Name = "picContestador"
        Me.picContestador.Size = New System.Drawing.Size(135, 84)
        Me.picContestador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picContestador.TabIndex = 8
        Me.picContestador.TabStop = False
        Me.picContestador.Visible = False
        '
        'picImpresora
        '
        Me.picImpresora.Image = Global.Compra_Interactiva.My.Resources.Resources.Printer
        Me.picImpresora.Location = New System.Drawing.Point(474, 188)
        Me.picImpresora.Name = "picImpresora"
        Me.picImpresora.Size = New System.Drawing.Size(135, 84)
        Me.picImpresora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImpresora.TabIndex = 9
        Me.picImpresora.TabStop = False
        Me.picImpresora.Visible = False
        '
        'picCalculadora
        '
        Me.picCalculadora.Image = Global.Compra_Interactiva.My.Resources.Resources.Calcultr
        Me.picCalculadora.Location = New System.Drawing.Point(644, 188)
        Me.picCalculadora.Name = "picCalculadora"
        Me.picCalculadora.Size = New System.Drawing.Size(135, 84)
        Me.picCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCalculadora.TabIndex = 10
        Me.picCalculadora.TabStop = False
        Me.picCalculadora.Visible = False
        '
        'picDolar
        '
        Me.picDolar.Image = Global.Compra_Interactiva.My.Resources.Resources.Dollar
        Me.picDolar.Location = New System.Drawing.Point(474, 302)
        Me.picDolar.Name = "picDolar"
        Me.picDolar.Size = New System.Drawing.Size(135, 84)
        Me.picDolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDolar.TabIndex = 11
        Me.picDolar.TabStop = False
        Me.picDolar.Visible = False
        '
        'picFotocopia
        '
        Me.picFotocopia.ErrorImage = Global.Compra_Interactiva.My.Resources.Resources.SateDish
        Me.picFotocopia.Image = Global.Compra_Interactiva.My.Resources.Resources.CopyMach
        Me.picFotocopia.Location = New System.Drawing.Point(644, 302)
        Me.picFotocopia.Name = "picFotocopia"
        Me.picFotocopia.Size = New System.Drawing.Size(135, 84)
        Me.picFotocopia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFotocopia.TabIndex = 12
        Me.picFotocopia.TabStop = False
        Me.picFotocopia.Visible = False
        '
        'picComputer
        '
        Me.picComputer.Image = Global.Compra_Interactiva.My.Resources.Resources.PComputr
        Me.picComputer.Location = New System.Drawing.Point(474, 70)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(135, 84)
        Me.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComputer.TabIndex = 7
        Me.picComputer.TabStop = False
        '
        'picMac
        '
        Me.picMac.Image = Global.Compra_Interactiva.My.Resources.Resources.Computer
        Me.picMac.Location = New System.Drawing.Point(474, 70)
        Me.picMac.Name = "picMac"
        Me.picMac.Size = New System.Drawing.Size(135, 84)
        Me.picMac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMac.TabIndex = 13
        Me.picMac.TabStop = False
        '
        'picLaptop
        '
        Me.picLaptop.Image = Global.Compra_Interactiva.My.Resources.Resources.Laptop1
        Me.picLaptop.Location = New System.Drawing.Point(474, 70)
        Me.picLaptop.Name = "picLaptop"
        Me.picLaptop.Size = New System.Drawing.Size(135, 84)
        Me.picLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaptop.TabIndex = 14
        Me.picLaptop.TabStop = False
        '
        'picEfectivo
        '
        Me.picEfectivo.Image = Global.Compra_Interactiva.My.Resources.Resources.PoundBag
        Me.picEfectivo.Location = New System.Drawing.Point(474, 302)
        Me.picEfectivo.Name = "picEfectivo"
        Me.picEfectivo.Size = New System.Drawing.Size(135, 84)
        Me.picEfectivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEfectivo.TabIndex = 15
        Me.picEfectivo.TabStop = False
        Me.picEfectivo.Visible = False
        '
        'picCheque
        '
        Me.picCheque.Image = Global.Compra_Interactiva.My.Resources.Resources.Check
        Me.picCheque.Location = New System.Drawing.Point(474, 302)
        Me.picCheque.Name = "picCheque"
        Me.picCheque.Size = New System.Drawing.Size(135, 84)
        Me.picCheque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheque.TabIndex = 16
        Me.picCheque.TabStop = False
        Me.picCheque.Visible = False
        '
        'picDiscoDuro
        '
        Me.picDiscoDuro.Image = Global.Compra_Interactiva.My.Resources.Resources.Harddisk
        Me.picDiscoDuro.Location = New System.Drawing.Point(474, 188)
        Me.picDiscoDuro.Name = "picDiscoDuro"
        Me.picDiscoDuro.Size = New System.Drawing.Size(135, 84)
        Me.picDiscoDuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiscoDuro.TabIndex = 17
        Me.picDiscoDuro.TabStop = False
        Me.picDiscoDuro.Visible = False
        '
        'picAntena
        '
        Me.picAntena.Image = Global.Compra_Interactiva.My.Resources.Resources.SateDish
        Me.picAntena.Location = New System.Drawing.Point(474, 188)
        Me.picAntena.Name = "picAntena"
        Me.picAntena.Size = New System.Drawing.Size(135, 84)
        Me.picAntena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAntena.TabIndex = 18
        Me.picAntena.TabStop = False
        Me.picAntena.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picAntena)
        Me.Controls.Add(Me.picDiscoDuro)
        Me.Controls.Add(Me.picCheque)
        Me.Controls.Add(Me.picEfectivo)
        Me.Controls.Add(Me.picLaptop)
        Me.Controls.Add(Me.picMac)
        Me.Controls.Add(Me.picFotocopia)
        Me.Controls.Add(Me.picDolar)
        Me.Controls.Add(Me.picCalculadora)
        Me.Controls.Add(Me.picImpresora)
        Me.Controls.Add(Me.picContestador)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbPago)
        Me.Controls.Add(Me.lblPerifericos)
        Me.Controls.Add(Me.lsbPerifericos)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.gbEquipos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbEquipos.ResumeLayout(False)
        Me.gbEquipos.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        CType(Me.picContestador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImpresora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotocopia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLaptop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiscoDuro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAntena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEquipos As GroupBox
    Friend WithEvents rbtnPortatil As RadioButton
    Friend WithEvents rbtnMac As RadioButton
    Friend WithEvents rbtnPC As RadioButton
    Friend WithEvents gb2 As GroupBox
    Friend WithEvents chbFotocopia As CheckBox
    Friend WithEvents chbCalculadora As CheckBox
    Friend WithEvents chbContestador As CheckBox
    Friend WithEvents lsbPerifericos As ListBox
    Friend WithEvents lblPerifericos As Label
    Friend WithEvents cmbPago As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblProductos As Label
    Friend WithEvents picContestador As PictureBox
    Friend WithEvents picImpresora As PictureBox
    Friend WithEvents picCalculadora As PictureBox
    Friend WithEvents picDolar As PictureBox
    Friend WithEvents picFotocopia As PictureBox
    Friend WithEvents picComputer As PictureBox
    Friend WithEvents picMac As PictureBox
    Friend WithEvents picLaptop As PictureBox
    Friend WithEvents picEfectivo As PictureBox
    Friend WithEvents picCheque As PictureBox
    Friend WithEvents picDiscoDuro As PictureBox
    Friend WithEvents picAntena As PictureBox
End Class
