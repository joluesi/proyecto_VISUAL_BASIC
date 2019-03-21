<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolver
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
        Me.btnBuscarAlquilar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAlquiler = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDevolver = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiasAlquiler = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbAlquiler.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscarAlquilar
        '
        Me.btnBuscarAlquilar.Location = New System.Drawing.Point(158, 74)
        Me.btnBuscarAlquilar.Name = "btnBuscarAlquilar"
        Me.btnBuscarAlquilar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAlquilar.TabIndex = 5
        Me.btnBuscarAlquilar.Text = "Buscar"
        Me.btnBuscarAlquilar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(148, 46)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Introduce código DVD"
        '
        'gbAlquiler
        '
        Me.gbAlquiler.Controls.Add(Me.txtDiasAlquiler)
        Me.gbAlquiler.Controls.Add(Me.Label4)
        Me.gbAlquiler.Controls.Add(Me.btnCancelar)
        Me.gbAlquiler.Controls.Add(Me.btnDevolver)
        Me.gbAlquiler.Controls.Add(Me.txtFecha)
        Me.gbAlquiler.Controls.Add(Me.Label3)
        Me.gbAlquiler.Controls.Add(Me.txtCliente)
        Me.gbAlquiler.Controls.Add(Me.Label2)
        Me.gbAlquiler.Location = New System.Drawing.Point(18, 118)
        Me.gbAlquiler.Name = "gbAlquiler"
        Me.gbAlquiler.Size = New System.Drawing.Size(230, 320)
        Me.gbAlquiler.TabIndex = 6
        Me.gbAlquiler.TabStop = False
        Me.gbAlquiler.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(63, 239)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnDevolver
        '
        Me.btnDevolver.Location = New System.Drawing.Point(63, 186)
        Me.btnDevolver.Name = "btnDevolver"
        Me.btnDevolver.Size = New System.Drawing.Size(75, 23)
        Me.btnDevolver.TabIndex = 5
        Me.btnDevolver.Text = "Devolver"
        Me.btnDevolver.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(96, 77)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(96, 31)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'txtDiasAlquiler
        '
        Me.txtDiasAlquiler.Location = New System.Drawing.Point(96, 124)
        Me.txtDiasAlquiler.Name = "txtDiasAlquiler"
        Me.txtDiasAlquiler.ReadOnly = True
        Me.txtDiasAlquiler.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasAlquiler.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Días Alquiler"
        '
        'Devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 450)
        Me.Controls.Add(Me.gbAlquiler)
        Me.Controls.Add(Me.btnBuscarAlquilar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Devolver"
        Me.Text = "Devolver"
        Me.gbAlquiler.ResumeLayout(False)
        Me.gbAlquiler.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarAlquilar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbAlquiler As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiasAlquiler As TextBox
    Friend WithEvents Label4 As Label
End Class
