<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.lbl4Salir = New System.Windows.Forms.Label()
        Me.lbl3FactFibo = New System.Windows.Forms.Label()
        Me.lbl2Areas = New System.Windows.Forms.Label()
        Me.lbl1Calculadora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(406, 317)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(100, 20)
        Me.txtOpcion.TabIndex = 11
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Location = New System.Drawing.Point(296, 317)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(89, 13)
        Me.lblOpcion.TabIndex = 10
        Me.lblOpcion.Text = "Introducir opción:"
        '
        'lbl4Salir
        '
        Me.lbl4Salir.AutoSize = True
        Me.lbl4Salir.Location = New System.Drawing.Point(295, 261)
        Me.lbl4Salir.Name = "lbl4Salir"
        Me.lbl4Salir.Size = New System.Drawing.Size(39, 13)
        Me.lbl4Salir.TabIndex = 9
        Me.lbl4Salir.Text = "4. Salir"
        '
        'lbl3FactFibo
        '
        Me.lbl3FactFibo.AutoSize = True
        Me.lbl3FactFibo.Location = New System.Drawing.Point(295, 210)
        Me.lbl3FactFibo.Name = "lbl3FactFibo"
        Me.lbl3FactFibo.Size = New System.Drawing.Size(154, 13)
        Me.lbl3FactFibo.TabIndex = 8
        Me.lbl3FactFibo.Text = "3. Cálculo Factorial y Fibonacci"
        '
        'lbl2Areas
        '
        Me.lbl2Areas.AutoSize = True
        Me.lbl2Areas.Location = New System.Drawing.Point(295, 162)
        Me.lbl2Areas.Name = "lbl2Areas"
        Me.lbl2Areas.Size = New System.Drawing.Size(98, 13)
        Me.lbl2Areas.TabIndex = 7
        Me.lbl2Areas.Text = "2. Cálculo de áreas"
        '
        'lbl1Calculadora
        '
        Me.lbl1Calculadora.AutoSize = True
        Me.lbl1Calculadora.Location = New System.Drawing.Point(295, 113)
        Me.lbl1Calculadora.Name = "lbl1Calculadora"
        Me.lbl1Calculadora.Size = New System.Drawing.Size(97, 13)
        Me.lbl1Calculadora.TabIndex = 6
        Me.lbl1Calculadora.Text = "1. Mini Calculadora"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.lbl4Salir)
        Me.Controls.Add(Me.lbl3FactFibo)
        Me.Controls.Add(Me.lbl2Areas)
        Me.Controls.Add(Me.lbl1Calculadora)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOpcion As TextBox
    Friend WithEvents lblOpcion As Label
    Friend WithEvents lbl4Salir As Label
    Friend WithEvents lbl3FactFibo As Label
    Friend WithEvents lbl2Areas As Label
    Friend WithEvents lbl1Calculadora As Label
End Class
