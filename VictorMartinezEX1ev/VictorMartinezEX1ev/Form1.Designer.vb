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
        Me.CrearArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesbloquearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblIntroduce = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pcbBanco = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.DaniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FadsfaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pcbBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearArrayToolStripMenuItem, Me.CajeroToolStripMenuItem, Me.DesbloquearToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(574, 24)
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
        Me.CajeroToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.CajeroToolStripMenuItem.Text = "Cajero"
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
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(242, 212)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCliente.TabIndex = 2
        Me.txtCliente.Visible = False
        '
        'lblIntroduce
        '
        Me.lblIntroduce.AutoSize = True
        Me.lblIntroduce.Location = New System.Drawing.Point(239, 180)
        Me.lblIntroduce.Name = "lblIntroduce"
        Me.lblIntroduce.Size = New System.Drawing.Size(101, 13)
        Me.lblIntroduce.TabIndex = 3
        Me.lblIntroduce.Text = "Introduce un cliente"
        Me.lblIntroduce.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(252, 257)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'pcbBanco
        '
        Me.pcbBanco.Image = Global.VictorMartinezEX1ev.My.Resources.Resources.PoundBag
        Me.pcbBanco.InitialImage = Global.VictorMartinezEX1ev.My.Resources.Resources.PoundBag
        Me.pcbBanco.Location = New System.Drawing.Point(42, 56)
        Me.pcbBanco.Name = "pcbBanco"
        Me.pcbBanco.Size = New System.Drawing.Size(122, 105)
        Me.pcbBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBanco.TabIndex = 1
        Me.pcbBanco.TabStop = False
        Me.pcbBanco.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaniToolStripMenuItem, Me.FadsfaToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(574, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'DaniToolStripMenuItem
        '
        Me.DaniToolStripMenuItem.Name = "DaniToolStripMenuItem"
        Me.DaniToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.DaniToolStripMenuItem.Text = "dani"
        '
        'FadsfaToolStripMenuItem
        '
        Me.FadsfaToolStripMenuItem.Name = "FadsfaToolStripMenuItem"
        Me.FadsfaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.FadsfaToolStripMenuItem.Text = "fadsfa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 420)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblIntroduce)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.pcbBanco)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pcbBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CrearArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesbloquearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pcbBanco As PictureBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblIntroduce As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents DaniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FadsfaToolStripMenuItem As ToolStripMenuItem
End Class
