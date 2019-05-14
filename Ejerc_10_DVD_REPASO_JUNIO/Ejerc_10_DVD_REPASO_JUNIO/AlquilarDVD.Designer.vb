<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlquilarDVD
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAlquilar = New System.Windows.Forms.Button()
        Me.txtCodAlquilarCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoAlquilarDVD = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(251, 286)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAlquilar
        '
        Me.btnAlquilar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquilar.Location = New System.Drawing.Point(61, 286)
        Me.btnAlquilar.Name = "btnAlquilar"
        Me.btnAlquilar.Size = New System.Drawing.Size(124, 32)
        Me.btnAlquilar.TabIndex = 18
        Me.btnAlquilar.Text = "Alquilar"
        Me.btnAlquilar.UseVisualStyleBackColor = True
        '
        'txtCodAlquilarCliente
        '
        Me.txtCodAlquilarCliente.Location = New System.Drawing.Point(255, 201)
        Me.txtCodAlquilarCliente.Name = "txtCodAlquilarCliente"
        Me.txtCodAlquilarCliente.Size = New System.Drawing.Size(120, 20)
        Me.txtCodAlquilarCliente.TabIndex = 17
        '
        'txtCodigoAlquilarDVD
        '
        Me.txtCodigoAlquilarDVD.Location = New System.Drawing.Point(255, 136)
        Me.txtCodigoAlquilarDVD.Name = "txtCodigoAlquilarDVD"
        Me.txtCodigoAlquilarDVD.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoAlquilarDVD.TabIndex = 16
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(321, 62)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 20)
        Me.lblFecha.TabIndex = 15
        Me.lblFecha.Text = "fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Código DVD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Código Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Alquilar DVD"
        '
        'AlquilarDVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAlquilar)
        Me.Controls.Add(Me.txtCodAlquilarCliente)
        Me.Controls.Add(Me.txtCodigoAlquilarDVD)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AlquilarDVD"
        Me.Text = "AlquilarDVD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAlquilar As Button
    Friend WithEvents txtCodAlquilarCliente As TextBox
    Friend WithEvents txtCodigoAlquilarDVD As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
