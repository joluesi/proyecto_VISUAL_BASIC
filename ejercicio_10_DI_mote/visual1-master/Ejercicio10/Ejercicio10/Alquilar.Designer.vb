<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alquilar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnBuscarAlquilar = New System.Windows.Forms.Button()
        Me.gbAlquiler = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbAlquiler.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce código DVD"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(145, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'btnBuscarAlquilar
        '
        Me.btnBuscarAlquilar.Location = New System.Drawing.Point(155, 64)
        Me.btnBuscarAlquilar.Name = "btnBuscarAlquilar"
        Me.btnBuscarAlquilar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAlquilar.TabIndex = 2
        Me.btnBuscarAlquilar.Text = "Buscar"
        Me.btnBuscarAlquilar.UseVisualStyleBackColor = True
        '
        'gbAlquiler
        '
        Me.gbAlquiler.Controls.Add(Me.btnCancelar)
        Me.gbAlquiler.Controls.Add(Me.btnAceptar)
        Me.gbAlquiler.Controls.Add(Me.txtFecha)
        Me.gbAlquiler.Controls.Add(Me.Label3)
        Me.gbAlquiler.Controls.Add(Me.txtCliente)
        Me.gbAlquiler.Controls.Add(Me.Label2)
        Me.gbAlquiler.Location = New System.Drawing.Point(29, 110)
        Me.gbAlquiler.Name = "gbAlquiler"
        Me.gbAlquiler.Size = New System.Drawing.Size(230, 262)
        Me.gbAlquiler.TabIndex = 3
        Me.gbAlquiler.TabStop = False
        Me.gbAlquiler.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(68, 189)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(68, 136)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Alquilar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(68, 77)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(68, 31)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Alquilar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 396)
        Me.Controls.Add(Me.gbAlquiler)
        Me.Controls.Add(Me.btnBuscarAlquilar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alquilar"
        Me.Text = "Alquilar"
        Me.gbAlquiler.ResumeLayout(False)
        Me.gbAlquiler.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnBuscarAlquilar As Button
    Friend WithEvents gbAlquiler As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label2 As Label
End Class
