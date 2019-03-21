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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCrearArray = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtBloqueo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.lblBloqueo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.gbxIdent = New System.Windows.Forms.GroupBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
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
        Me.gbxConsultar = New System.Windows.Forms.GroupBox()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.gbxBanco = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxIdent.SuspendLayout()
        Me.gbxConsultar.SuspendLayout()
        Me.gbxBanco.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(363, 190)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(110, 31)
        Me.btnVolver.TabIndex = 31
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(363, 128)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(110, 31)
        Me.btnLimpiar.TabIndex = 30
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCrearArray
        '
        Me.btnCrearArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearArray.Location = New System.Drawing.Point(363, 64)
        Me.btnCrearArray.Name = "btnCrearArray"
        Me.btnCrearArray.Size = New System.Drawing.Size(110, 31)
        Me.btnCrearArray.TabIndex = 29
        Me.btnCrearArray.Text = "Crear Array"
        Me.btnCrearArray.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(177, 232)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(153, 20)
        Me.txtSaldo.TabIndex = 27
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(177, 188)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(153, 20)
        Me.txtClave.TabIndex = 26
        '
        'txtBloqueo
        '
        Me.txtBloqueo.Location = New System.Drawing.Point(177, 147)
        Me.txtBloqueo.Name = "txtBloqueo"
        Me.txtBloqueo.Size = New System.Drawing.Size(153, 20)
        Me.txtBloqueo.TabIndex = 25
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(177, 106)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 24
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(177, 64)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(153, 20)
        Me.txtCodigo.TabIndex = 23
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(52, 232)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(69, 13)
        Me.lblSaldo.TabIndex = 21
        Me.lblSaldo.Text = "Saldo Cliente"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(49, 188)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(69, 13)
        Me.lblClave.TabIndex = 20
        Me.lblClave.Text = "Clave Cliente"
        '
        'lblBloqueo
        '
        Me.lblBloqueo.AutoSize = True
        Me.lblBloqueo.Location = New System.Drawing.Point(49, 147)
        Me.lblBloqueo.Name = "lblBloqueo"
        Me.lblBloqueo.Size = New System.Drawing.Size(81, 13)
        Me.lblBloqueo.TabIndex = 19
        Me.lblBloqueo.Text = "Bloqueo Cliente"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(49, 106)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(79, 13)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre Cliente"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(49, 64)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Código Cliente"
        '
        'gbxIdent
        '
        Me.gbxIdent.Controls.Add(Me.txtIdentificacion)
        Me.gbxIdent.Controls.Add(Me.btn0)
        Me.gbxIdent.Controls.Add(Me.btn9)
        Me.gbxIdent.Controls.Add(Me.btn8)
        Me.gbxIdent.Controls.Add(Me.btn7)
        Me.gbxIdent.Controls.Add(Me.btn6)
        Me.gbxIdent.Controls.Add(Me.btn5)
        Me.gbxIdent.Controls.Add(Me.btn4)
        Me.gbxIdent.Controls.Add(Me.btn3)
        Me.gbxIdent.Controls.Add(Me.btn2)
        Me.gbxIdent.Controls.Add(Me.btn1)
        Me.gbxIdent.Location = New System.Drawing.Point(122, 86)
        Me.gbxIdent.Name = "gbxIdent"
        Me.gbxIdent.Size = New System.Drawing.Size(296, 173)
        Me.gbxIdent.TabIndex = 37
        Me.gbxIdent.TabStop = False
        Me.gbxIdent.Text = "Identificación:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(92, 133)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(138, 20)
        Me.txtIdentificacion.TabIndex = 10
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(236, 74)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(48, 44)
        Me.btn0.TabIndex = 9
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(182, 74)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(48, 44)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(128, 74)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(48, 44)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(74, 74)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(48, 44)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(20, 76)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(48, 44)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(236, 19)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(48, 44)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(182, 20)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(48, 44)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(128, 20)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(48, 44)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(74, 20)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(48, 44)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(20, 20)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(48, 44)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'gbxConsultar
        '
        Me.gbxConsultar.Controls.Add(Me.btn_Volver)
        Me.gbxConsultar.Controls.Add(Me.btnConsultar)
        Me.gbxConsultar.Controls.Add(Me.txtNombreCliente)
        Me.gbxConsultar.Controls.Add(Me.lblNombreCliente)
        Me.gbxConsultar.Location = New System.Drawing.Point(98, 305)
        Me.gbxConsultar.Name = "gbxConsultar"
        Me.gbxConsultar.Size = New System.Drawing.Size(296, 184)
        Me.gbxConsultar.TabIndex = 36
        Me.gbxConsultar.TabStop = False
        Me.gbxConsultar.Text = "Consultar Clientes"
        Me.gbxConsultar.Visible = False
        '
        'btn_Volver
        '
        Me.btn_Volver.Location = New System.Drawing.Point(115, 144)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(138, 23)
        Me.btn_Volver.TabIndex = 3
        Me.btn_Volver.Text = "VOLVER"
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(115, 85)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(138, 23)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(115, 28)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(138, 20)
        Me.txtNombreCliente.TabIndex = 1
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(26, 31)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(82, 13)
        Me.lblNombreCliente.TabIndex = 0
        Me.lblNombreCliente.Text = "Nombre Cliente:"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(20, 28)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(467, 55)
        Me.lblLogo.TabIndex = 38
        Me.lblLogo.Text = "BANCO HONRADO"
        '
        'gbxBanco
        '
        Me.gbxBanco.Controls.Add(Me.lblLogo)
        Me.gbxBanco.Controls.Add(Me.gbxIdent)
        Me.gbxBanco.Location = New System.Drawing.Point(503, 12)
        Me.gbxBanco.Name = "gbxBanco"
        Me.gbxBanco.Size = New System.Drawing.Size(515, 274)
        Me.gbxBanco.TabIndex = 39
        Me.gbxBanco.TabStop = False
        Me.gbxBanco.Text = "Interfaz Banco"
        Me.gbxBanco.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1164, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.ToolStripMenuItem1.Text = "Crear"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 551)
        Me.Controls.Add(Me.gbxBanco)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gbxConsultar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCrearArray)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtBloqueo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblBloqueo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxIdent.ResumeLayout(False)
        Me.gbxIdent.PerformLayout()
        Me.gbxConsultar.ResumeLayout(False)
        Me.gbxConsultar.PerformLayout()
        Me.gbxBanco.ResumeLayout(False)
        Me.gbxBanco.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCrearArray As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents txtBloqueo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblClave As Label
    Friend WithEvents lblBloqueo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents gbxIdent As GroupBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents btn0 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents gbxConsultar As GroupBox
    Friend WithEvents btn_Volver As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents gbxBanco As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
