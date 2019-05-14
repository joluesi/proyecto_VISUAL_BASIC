<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolverDVD
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
        Me.txtDevDiasTrans = New System.Windows.Forms.TextBox()
        Me.txtDevFechaDevol = New System.Windows.Forms.TextBox()
        Me.txtDevFechaAlquiler = New System.Windows.Forms.TextBox()
        Me.txtDevCodCliente = New System.Windows.Forms.TextBox()
        Me.txtDevCodDVD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(162, 417)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 24
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtDevDiasTrans
        '
        Me.txtDevDiasTrans.Location = New System.Drawing.Point(249, 340)
        Me.txtDevDiasTrans.Name = "txtDevDiasTrans"
        Me.txtDevDiasTrans.Size = New System.Drawing.Size(169, 20)
        Me.txtDevDiasTrans.TabIndex = 23
        '
        'txtDevFechaDevol
        '
        Me.txtDevFechaDevol.Location = New System.Drawing.Point(249, 288)
        Me.txtDevFechaDevol.Name = "txtDevFechaDevol"
        Me.txtDevFechaDevol.Size = New System.Drawing.Size(169, 20)
        Me.txtDevFechaDevol.TabIndex = 22
        '
        'txtDevFechaAlquiler
        '
        Me.txtDevFechaAlquiler.Location = New System.Drawing.Point(249, 233)
        Me.txtDevFechaAlquiler.Name = "txtDevFechaAlquiler"
        Me.txtDevFechaAlquiler.Size = New System.Drawing.Size(169, 20)
        Me.txtDevFechaAlquiler.TabIndex = 21
        '
        'txtDevCodCliente
        '
        Me.txtDevCodCliente.Location = New System.Drawing.Point(249, 176)
        Me.txtDevCodCliente.Name = "txtDevCodCliente"
        Me.txtDevCodCliente.Size = New System.Drawing.Size(169, 20)
        Me.txtDevCodCliente.TabIndex = 20
        '
        'txtDevCodDVD
        '
        Me.txtDevCodDVD.Location = New System.Drawing.Point(249, 114)
        Me.txtDevCodDVD.Name = "txtDevCodDVD"
        Me.txtDevCodDVD.Size = New System.Drawing.Size(169, 20)
        Me.txtDevCodDVD.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Dias transcurridos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fecha Devolución:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Fecha de alquiler:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Código Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Código DVD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Devolver DVD"
        '
        'DevolverDVD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 513)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtDevDiasTrans)
        Me.Controls.Add(Me.txtDevFechaDevol)
        Me.Controls.Add(Me.txtDevFechaAlquiler)
        Me.Controls.Add(Me.txtDevCodCliente)
        Me.Controls.Add(Me.txtDevCodDVD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DevolverDVD"
        Me.Text = "DevolverDVD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents txtDevDiasTrans As TextBox
    Friend WithEvents txtDevFechaDevol As TextBox
    Friend WithEvents txtDevFechaAlquiler As TextBox
    Friend WithEvents txtDevCodCliente As TextBox
    Friend WithEvents txtDevCodDVD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
