<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesbloquearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlCajero = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBotonesCajero = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.txtClaveCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlCajero.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotonesCajero.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearArrayToolStripMenuItem, Me.CajeroToolStripMenuItem, Me.DesbloquearToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearArrayToolStripMenuItem
        '
        Me.CrearArrayToolStripMenuItem.Name = "CrearArrayToolStripMenuItem"
        Me.CrearArrayToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CrearArrayToolStripMenuItem.Text = "Crear Array"
        '
        'CajeroToolStripMenuItem
        '
        Me.CajeroToolStripMenuItem.Name = "CajeroToolStripMenuItem"
        Me.CajeroToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CajeroToolStripMenuItem.Text = "Cajero "
        '
        'DesbloquearToolStripMenuItem
        '
        Me.DesbloquearToolStripMenuItem.Name = "DesbloquearToolStripMenuItem"
        Me.DesbloquearToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.DesbloquearToolStripMenuItem.Text = "Desbloquear"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'pnlCajero
        '
        Me.pnlCajero.Controls.Add(Me.PictureBox1)
        Me.pnlCajero.Controls.Add(Me.Label3)
        Me.pnlCajero.Controls.Add(Me.btnAceptar)
        Me.pnlCajero.Controls.Add(Me.txtNombreCliente)
        Me.pnlCajero.Controls.Add(Me.Label1)
        Me.pnlCajero.Location = New System.Drawing.Point(15, 43)
        Me.pnlCajero.Name = "pnlCajero"
        Me.pnlCajero.Size = New System.Drawing.Size(357, 395)
        Me.pnlCajero.TabIndex = 1
        Me.pnlCajero.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Repaso_EXAMEN_1_EVAL_DI.My.Resources.Resources.Dollar
        Me.PictureBox1.Location = New System.Drawing.Point(29, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Banco Malo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(144, 313)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(111, 26)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(144, 272)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(154, 20)
        Me.txtNombreCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Cliente:"
        '
        'pnlBotonesCajero
        '
        Me.pnlBotonesCajero.Controls.Add(Me.btnVolver)
        Me.pnlBotonesCajero.Controls.Add(Me.btnEntrar)
        Me.pnlBotonesCajero.Controls.Add(Me.txtClaveCliente)
        Me.pnlBotonesCajero.Controls.Add(Me.Label2)
        Me.pnlBotonesCajero.Controls.Add(Me.btn0)
        Me.pnlBotonesCajero.Controls.Add(Me.btn9)
        Me.pnlBotonesCajero.Controls.Add(Me.btn8)
        Me.pnlBotonesCajero.Controls.Add(Me.btn7)
        Me.pnlBotonesCajero.Controls.Add(Me.btn6)
        Me.pnlBotonesCajero.Controls.Add(Me.btn5)
        Me.pnlBotonesCajero.Controls.Add(Me.btn4)
        Me.pnlBotonesCajero.Controls.Add(Me.btn3)
        Me.pnlBotonesCajero.Controls.Add(Me.btn2)
        Me.pnlBotonesCajero.Controls.Add(Me.btn1)
        Me.pnlBotonesCajero.Location = New System.Drawing.Point(401, 43)
        Me.pnlBotonesCajero.Name = "pnlBotonesCajero"
        Me.pnlBotonesCajero.Size = New System.Drawing.Size(387, 395)
        Me.pnlBotonesCajero.TabIndex = 2
        Me.pnlBotonesCajero.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(194, 352)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(111, 26)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(194, 310)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(111, 26)
        Me.btnEntrar.TabIndex = 12
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'txtClaveCliente
        '
        Me.txtClaveCliente.Location = New System.Drawing.Point(194, 269)
        Me.txtClaveCliente.Name = "txtClaveCliente"
        Me.txtClaveCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveCliente.ReadOnly = True
        Me.txtClaveCliente.Size = New System.Drawing.Size(111, 20)
        Me.txtClaveCliente.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Clave del Cliente:"
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(158, 200)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(50, 46)
        Me.btn0.TabIndex = 9
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(225, 138)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(50, 46)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(158, 138)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(50, 46)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(92, 138)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(50, 46)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(225, 76)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(50, 46)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(158, 76)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(50, 46)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(92, 76)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(50, 46)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(225, 14)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(50, 46)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(158, 14)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(50, 46)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(92, 14)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(50, 46)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlBotonesCajero)
        Me.Controls.Add(Me.pnlCajero)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlCajero.ResumeLayout(False)
        Me.pnlCajero.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotonesCajero.ResumeLayout(False)
        Me.pnlBotonesCajero.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CrearArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesbloquearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlCajero As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlBotonesCajero As Panel
    Friend WithEvents btnEntrar As Button
    Friend WithEvents txtClaveCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
