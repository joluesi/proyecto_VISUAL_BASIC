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
        Me.menuToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.mItemCrearArray = New System.Windows.Forms.ToolStripMenuItem()
        Me.mItemCajero = New System.Windows.Forms.ToolStripMenuItem()
        Me.mItemDesbloquear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mItemAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBancoCierva = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grbBotones = New System.Windows.Forms.GroupBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.gpbCliente = New System.Windows.Forms.GroupBox()
        Me.gpbDesbloqueo = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnDesbloqueo = New System.Windows.Forms.Button()
        Me.txtClav = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grbBotones.SuspendLayout()
        Me.gpbCliente.SuspendLayout()
        Me.gpbDesbloqueo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuToolStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(894, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuToolStrip
        '
        Me.menuToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mItemCrearArray, Me.mItemCajero, Me.mItemDesbloquear, Me.mItemAcercaDe, Me.mItemSalir})
        Me.menuToolStrip.Name = "menuToolStrip"
        Me.menuToolStrip.Size = New System.Drawing.Size(50, 20)
        Me.menuToolStrip.Text = "Menú"
        '
        'mItemCrearArray
        '
        Me.mItemCrearArray.Name = "mItemCrearArray"
        Me.mItemCrearArray.Size = New System.Drawing.Size(180, 22)
        Me.mItemCrearArray.Text = "Crear Array"
        '
        'mItemCajero
        '
        Me.mItemCajero.Name = "mItemCajero"
        Me.mItemCajero.Size = New System.Drawing.Size(180, 22)
        Me.mItemCajero.Text = "Cajero"
        '
        'mItemDesbloquear
        '
        Me.mItemDesbloquear.Name = "mItemDesbloquear"
        Me.mItemDesbloquear.Size = New System.Drawing.Size(180, 22)
        Me.mItemDesbloquear.Text = "Desbloquear"
        '
        'mItemAcercaDe
        '
        Me.mItemAcercaDe.Name = "mItemAcercaDe"
        Me.mItemAcercaDe.Size = New System.Drawing.Size(180, 22)
        Me.mItemAcercaDe.Text = "Acerca de"
        '
        'mItemSalir
        '
        Me.mItemSalir.Name = "mItemSalir"
        Me.mItemSalir.Size = New System.Drawing.Size(180, 22)
        Me.mItemSalir.Text = "Salir"
        '
        'lblBancoCierva
        '
        Me.lblBancoCierva.AutoSize = True
        Me.lblBancoCierva.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblBancoCierva.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBancoCierva.Location = New System.Drawing.Point(247, 24)
        Me.lblBancoCierva.Name = "lblBancoCierva"
        Me.lblBancoCierva.Size = New System.Drawing.Size(323, 46)
        Me.lblBancoCierva.TabIndex = 5
        Me.lblBancoCierva.Text = "BANCO CIERVA"
        Me.lblBancoCierva.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(47, 80)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(100, 29)
        Me.txtCliente.TabIndex = 6
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(59, 135)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'grbBotones
        '
        Me.grbBotones.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grbBotones.Controls.Add(Me.btnEntrar)
        Me.grbBotones.Controls.Add(Me.btn0)
        Me.grbBotones.Controls.Add(Me.txtClave)
        Me.grbBotones.Controls.Add(Me.btn9)
        Me.grbBotones.Controls.Add(Me.btn8)
        Me.grbBotones.Controls.Add(Me.btn7)
        Me.grbBotones.Controls.Add(Me.btn6)
        Me.grbBotones.Controls.Add(Me.btn5)
        Me.grbBotones.Controls.Add(Me.btn4)
        Me.grbBotones.Controls.Add(Me.btn3)
        Me.grbBotones.Controls.Add(Me.btn2)
        Me.grbBotones.Controls.Add(Me.btn1)
        Me.grbBotones.Location = New System.Drawing.Point(255, 87)
        Me.grbBotones.Name = "grbBotones"
        Me.grbBotones.Size = New System.Drawing.Size(200, 266)
        Me.grbBotones.TabIndex = 9
        Me.grbBotones.TabStop = False
        Me.grbBotones.Text = "Introduce Clave"
        Me.grbBotones.Visible = False
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(82, 211)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(100, 42)
        Me.btnEntrar.TabIndex = 12
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(25, 211)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(40, 42)
        Me.btn0.TabIndex = 11
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(21, 20)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(161, 26)
        Me.txtClave.TabIndex = 10
        Me.txtClave.UseSystemPasswordChar = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(142, 163)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(40, 42)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(86, 163)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(40, 42)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(25, 163)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(40, 42)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(142, 115)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(40, 42)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(86, 115)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(40, 42)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(25, 115)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 42)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(142, 67)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 42)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(86, 67)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 42)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(25, 67)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 42)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'gpbCliente
        '
        Me.gpbCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gpbCliente.Controls.Add(Me.txtCliente)
        Me.gpbCliente.Controls.Add(Me.btnAceptar)
        Me.gpbCliente.Location = New System.Drawing.Point(40, 87)
        Me.gpbCliente.Name = "gpbCliente"
        Me.gpbCliente.Size = New System.Drawing.Size(200, 266)
        Me.gpbCliente.TabIndex = 10
        Me.gpbCliente.TabStop = False
        Me.gpbCliente.Text = "Introduce nombre"
        Me.gpbCliente.Visible = False
        '
        'gpbDesbloqueo
        '
        Me.gpbDesbloqueo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gpbDesbloqueo.Controls.Add(Me.Label2)
        Me.gpbDesbloqueo.Controls.Add(Me.Label1)
        Me.gpbDesbloqueo.Controls.Add(Me.txtClav)
        Me.gpbDesbloqueo.Controls.Add(Me.txtCodigo)
        Me.gpbDesbloqueo.Controls.Add(Me.btnDesbloqueo)
        Me.gpbDesbloqueo.Location = New System.Drawing.Point(476, 87)
        Me.gpbDesbloqueo.Name = "gpbDesbloqueo"
        Me.gpbDesbloqueo.Size = New System.Drawing.Size(200, 266)
        Me.gpbDesbloqueo.TabIndex = 11
        Me.gpbDesbloqueo.TabStop = False
        Me.gpbDesbloqueo.Text = "Introduce nombre"
        Me.gpbDesbloqueo.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(50, 67)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 29)
        Me.txtCodigo.TabIndex = 6
        '
        'btnDesbloqueo
        '
        Me.btnDesbloqueo.Location = New System.Drawing.Point(57, 182)
        Me.btnDesbloqueo.Name = "btnDesbloqueo"
        Me.btnDesbloqueo.Size = New System.Drawing.Size(75, 23)
        Me.btnDesbloqueo.TabIndex = 7
        Me.btnDesbloqueo.Text = "Desbloquear"
        Me.btnDesbloqueo.UseVisualStyleBackColor = True
        '
        'txtClav
        '
        Me.txtClav.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClav.Location = New System.Drawing.Point(50, 119)
        Me.txtClav.Name = "txtClav"
        Me.txtClav.Size = New System.Drawing.Size(100, 29)
        Me.txtClav.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Clave Cliente"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(717, 126)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(143, 143)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gpbDesbloqueo)
        Me.Controls.Add(Me.gpbCliente)
        Me.Controls.Add(Me.grbBotones)
        Me.Controls.Add(Me.lblBancoCierva)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "e"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbBotones.ResumeLayout(False)
        Me.grbBotones.PerformLayout()
        Me.gpbCliente.ResumeLayout(False)
        Me.gpbCliente.PerformLayout()
        Me.gpbDesbloqueo.ResumeLayout(False)
        Me.gpbDesbloqueo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuToolStrip As ToolStripMenuItem
    Friend WithEvents mItemCrearArray As ToolStripMenuItem
    Friend WithEvents mItemCajero As ToolStripMenuItem
    Friend WithEvents mItemDesbloquear As ToolStripMenuItem
    Friend WithEvents mItemAcercaDe As ToolStripMenuItem
    Friend WithEvents mItemSalir As ToolStripMenuItem
    Friend WithEvents lblBancoCierva As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents grbBotones As GroupBox
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents gpbCliente As GroupBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents gpbDesbloqueo As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClav As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnDesbloqueo As Button
    Friend WithEvents btnSalir As Button
End Class
