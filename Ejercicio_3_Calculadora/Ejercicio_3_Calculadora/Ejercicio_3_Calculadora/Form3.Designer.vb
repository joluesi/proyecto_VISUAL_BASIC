<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtFactorial = New System.Windows.Forms.TextBox()
        Me.txtFibonacci = New System.Windows.Forms.TextBox()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnFibonacci = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(85, 63)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(194, 13)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Introduce un número entero menor de 8"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(305, 63)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 1
        '
        'txtFactorial
        '
        Me.txtFactorial.Location = New System.Drawing.Point(305, 109)
        Me.txtFactorial.Name = "txtFactorial"
        Me.txtFactorial.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorial.TabIndex = 3
        '
        'txtFibonacci
        '
        Me.txtFibonacci.Location = New System.Drawing.Point(305, 152)
        Me.txtFibonacci.Name = "txtFibonacci"
        Me.txtFibonacci.Size = New System.Drawing.Size(100, 20)
        Me.txtFibonacci.TabIndex = 5
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(204, 109)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(75, 23)
        Me.btnFactorial.TabIndex = 6
        Me.btnFactorial.Text = "FACTORIAL"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnFibonacci
        '
        Me.btnFibonacci.Location = New System.Drawing.Point(204, 152)
        Me.btnFibonacci.Name = "btnFibonacci"
        Me.btnFibonacci.Size = New System.Drawing.Size(75, 23)
        Me.btnFibonacci.TabIndex = 7
        Me.btnFibonacci.Text = "FIBONACCI"
        Me.btnFibonacci.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(317, 204)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 314)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnFibonacci)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.txtFibonacci)
        Me.Controls.Add(Me.txtFactorial)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtFactorial As TextBox
    Friend WithEvents txtFibonacci As TextBox
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnFibonacci As Button
    Friend WithEvents btnVolver As Button
End Class
