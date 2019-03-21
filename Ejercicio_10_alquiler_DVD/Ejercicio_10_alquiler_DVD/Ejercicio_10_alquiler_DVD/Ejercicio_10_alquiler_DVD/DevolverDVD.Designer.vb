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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDevCodDVD = New System.Windows.Forms.TextBox()
        Me.txtDevCodCliente = New System.Windows.Forms.TextBox()
        Me.txtDevFechaAlquiler = New System.Windows.Forms.TextBox()
        Me.txtDevFechaDevol = New System.Windows.Forms.TextBox()
        Me.txtDevDiasTrans = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Devolver DVD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código DVD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de alquiler:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Devolución:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dias transcurridos:"
        '
        'txtDevCodDVD
        '
        Me.txtDevCodDVD.Location = New System.Drawing.Point(272, 140)
        Me.txtDevCodDVD.Name = "txtDevCodDVD"
        Me.txtDevCodDVD.Size = New System.Drawing.Size(169, 20)
        Me.txtDevCodDVD.TabIndex = 6
        '
        'txtDevCodCliente
        '
        Me.txtDevCodCliente.Location = New System.Drawing.Point(272, 202)
        Me.txtDevCodCliente.Name = "txtDevCodCliente"
        Me.txtDevCodCliente.Size = New System.Drawing.Size(169, 20)
        Me.txtDevCodCliente.TabIndex = 7
        '
        'txtDevFechaAlquiler
        '
        Me.txtDevFechaAlquiler.Location = New System.Drawing.Point(272, 259)
        Me.txtDevFechaAlquiler.Name = "txtDevFechaAlquiler"
        Me.txtDevFechaAlquiler.Size = New System.Drawing.Size(169, 20)
        Me.txtDevFechaAlquiler.TabIndex = 8
        '
        'txtDevFechaDevol
        '
        Me.txtDevFechaDevol.Location = New System.Drawing.Point(272, 314)
        Me.txtDevFechaDevol.Name = "txtDevFechaDevol"
        Me.txtDevFechaDevol.Size = New System.Drawing.Size(169, 20)
        Me.txtDevFechaDevol.TabIndex = 9
        '
        'txtDevDiasTrans
        '
        Me.txtDevDiasTrans.Location = New System.Drawing.Point(272, 366)
        Me.txtDevDiasTrans.Name = "txtDevDiasTrans"
        Me.txtDevDiasTrans.Size = New System.Drawing.Size(169, 20)
        Me.txtDevDiasTrans.TabIndex = 10
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(185, 443)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 616)
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
        Me.Name = "Devolver"
        Me.Text = "Devolver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDevCodDVD As TextBox
    Friend WithEvents txtDevCodCliente As TextBox
    Friend WithEvents txtDevFechaAlquiler As TextBox
    Friend WithEvents txtDevFechaDevol As TextBox
    Friend WithEvents txtDevDiasTrans As TextBox
    Friend WithEvents btnVolver As Button
End Class
