<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuClientes
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
        Me.lblArray = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.lblDesbloquear = New System.Windows.Forms.Label()
        Me.lblAcercade = New System.Windows.Forms.Label()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.lblOpcion = New System.Windows.Forms.Label()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblArray
        '
        Me.lblArray.AutoSize = True
        Me.lblArray.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArray.Location = New System.Drawing.Point(83, 96)
        Me.lblArray.Name = "lblArray"
        Me.lblArray.Size = New System.Drawing.Size(131, 20)
        Me.lblArray.TabIndex = 0
        Me.lblArray.Text = "1. - Crear Array"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(83, 137)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(92, 20)
        Me.lblCajero.TabIndex = 1
        Me.lblCajero.Text = "2. - Cajero"
        '
        'lblDesbloquear
        '
        Me.lblDesbloquear.AutoSize = True
        Me.lblDesbloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesbloquear.Location = New System.Drawing.Point(83, 173)
        Me.lblDesbloquear.Name = "lblDesbloquear"
        Me.lblDesbloquear.Size = New System.Drawing.Size(142, 20)
        Me.lblDesbloquear.TabIndex = 2
        Me.lblDesbloquear.Text = "3. - Desbloquear"
        '
        'lblAcercade
        '
        Me.lblAcercade.AutoSize = True
        Me.lblAcercade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcercade.Location = New System.Drawing.Point(83, 212)
        Me.lblAcercade.Name = "lblAcercade"
        Me.lblAcercade.Size = New System.Drawing.Size(124, 20)
        Me.lblAcercade.TabIndex = 3
        Me.lblAcercade.Text = "4. - Acerca De"
        '
        'lblSalir
        '
        Me.lblSalir.AutoSize = True
        Me.lblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalir.Location = New System.Drawing.Point(83, 253)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(76, 20)
        Me.lblSalir.TabIndex = 4
        Me.lblSalir.Text = "5. - Salir"
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpcion.Location = New System.Drawing.Point(124, 301)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(158, 20)
        Me.lblOpcion.TabIndex = 5
        Me.lblOpcion.Text = "Introduzca opción:"
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(300, 300)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(100, 20)
        Me.txtOpcion.TabIndex = 6
        '
        'MenuClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.lblSalir)
        Me.Controls.Add(Me.lblAcercade)
        Me.Controls.Add(Me.lblDesbloquear)
        Me.Controls.Add(Me.lblCajero)
        Me.Controls.Add(Me.lblArray)
        Me.Name = "MenuClientes"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArray As Label
    Friend WithEvents lblCajero As Label
    Friend WithEvents lblDesbloquear As Label
    Friend WithEvents lblAcercade As Label
    Friend WithEvents lblSalir As Label
    Friend WithEvents lblOpcion As Label
    Friend WithEvents txtOpcion As TextBox
End Class
