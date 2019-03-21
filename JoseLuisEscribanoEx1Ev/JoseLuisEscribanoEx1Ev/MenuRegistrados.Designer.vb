<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuRegistrados
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
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.lblOpcion = New System.Windows.Forms.Label()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.lblDesbloquear = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.lblReintegro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(441, 278)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(100, 20)
        Me.txtOpcion.TabIndex = 13
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpcion.Location = New System.Drawing.Point(265, 279)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(158, 20)
        Me.lblOpcion.TabIndex = 12
        Me.lblOpcion.Text = "Introduzca opción:"
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.Location = New System.Drawing.Point(242, 229)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(153, 20)
        Me.lblSalir.TabIndex = 11
        Me.lblSalir.Text = "4. - Volver a Inicio"
        '
        'lblDesbloquear
        '
        Me.lblDesbloquear.AutoSize = True
        Me.lblDesbloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesbloquear.Location = New System.Drawing.Point(242, 190)
        Me.lblDesbloquear.Name = "lblDesbloquear"
        Me.lblDesbloquear.Size = New System.Drawing.Size(86, 20)
        Me.lblDesbloquear.TabIndex = 9
        Me.lblDesbloquear.Text = "3. - Saldo"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(242, 154)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(101, 20)
        Me.lblCajero.TabIndex = 8
        Me.lblCajero.Text = "2. - Ingreso"
        '
        'lblReintegro
        '
        Me.lblReintegro.AutoSize = True
        Me.lblReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReintegro.Location = New System.Drawing.Point(242, 113)
        Me.lblReintegro.Name = "lblReintegro"
        Me.lblReintegro.Size = New System.Drawing.Size(114, 20)
        Me.lblReintegro.TabIndex = 7
        Me.lblReintegro.Text = "1.- Reintegro"
        '
        'MenuRegistrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.lblSalir)
        Me.Controls.Add(Me.lblDesbloquear)
        Me.Controls.Add(Me.lblCajero)
        Me.Controls.Add(Me.lblReintegro)
        Me.Name = "MenuRegistrados"
        Me.Text = "MenuRegistrados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOpcion As TextBox
    Friend WithEvents lblOpcion As Label
    Friend WithEvents lblSalir As Label
    Friend WithEvents lblDesbloquear As Label
    Friend WithEvents lblCajero As Label
    Friend WithEvents lblReintegro As Label
End Class
