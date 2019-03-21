<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Opciones
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
        Me.lbl_Calculadora = New System.Windows.Forms.Label()
        Me.lbl_Areas = New System.Windows.Forms.Label()
        Me.lbl_FactFibo = New System.Windows.Forms.Label()
        Me.lbl_Salir = New System.Windows.Forms.Label()
        Me.lbl_Opcion = New System.Windows.Forms.Label()
        Me.txt_Opcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Calculadora
        '
        Me.lbl_Calculadora.AutoSize = True
        Me.lbl_Calculadora.Location = New System.Drawing.Point(140, 65)
        Me.lbl_Calculadora.Name = "lbl_Calculadora"
        Me.lbl_Calculadora.Size = New System.Drawing.Size(97, 13)
        Me.lbl_Calculadora.TabIndex = 0
        Me.lbl_Calculadora.Text = "1. Mini Calculadora"
        '
        'lbl_Areas
        '
        Me.lbl_Areas.AutoSize = True
        Me.lbl_Areas.Location = New System.Drawing.Point(140, 109)
        Me.lbl_Areas.Name = "lbl_Areas"
        Me.lbl_Areas.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Areas.TabIndex = 1
        Me.lbl_Areas.Text = "2. Cálculo de áreas"
        '
        'lbl_FactFibo
        '
        Me.lbl_FactFibo.AutoSize = True
        Me.lbl_FactFibo.Location = New System.Drawing.Point(140, 152)
        Me.lbl_FactFibo.Name = "lbl_FactFibo"
        Me.lbl_FactFibo.Size = New System.Drawing.Size(169, 13)
        Me.lbl_FactFibo.TabIndex = 2
        Me.lbl_FactFibo.Text = "3. Cálculo de Factorial y Fibonacci"
        '
        'lbl_Salir
        '
        Me.lbl_Salir.AutoSize = True
        Me.lbl_Salir.Location = New System.Drawing.Point(140, 196)
        Me.lbl_Salir.Name = "lbl_Salir"
        Me.lbl_Salir.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Salir.TabIndex = 3
        Me.lbl_Salir.Text = "4. SALIR"
        '
        'lbl_Opcion
        '
        Me.lbl_Opcion.AutoSize = True
        Me.lbl_Opcion.Location = New System.Drawing.Point(141, 246)
        Me.lbl_Opcion.Name = "lbl_Opcion"
        Me.lbl_Opcion.Size = New System.Drawing.Size(119, 13)
        Me.lbl_Opcion.TabIndex = 4
        Me.lbl_Opcion.Text = "Introduzca una opción: "
        '
        'txt_Opcion
        '
        Me.txt_Opcion.Location = New System.Drawing.Point(277, 246)
        Me.txt_Opcion.Name = "txt_Opcion"
        Me.txt_Opcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Opcion.TabIndex = 5
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Opcion)
        Me.Controls.Add(Me.lbl_Opcion)
        Me.Controls.Add(Me.lbl_Salir)
        Me.Controls.Add(Me.lbl_FactFibo)
        Me.Controls.Add(Me.lbl_Areas)
        Me.Controls.Add(Me.lbl_Calculadora)
        Me.Name = "Menu"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Calculadora As Label
    Friend WithEvents lbl_Areas As Label
    Friend WithEvents lbl_FactFibo As Label
    Friend WithEvents lbl_Salir As Label
    Friend WithEvents lbl_Opcion As Label
    Friend WithEvents txt_Opcion As TextBox
End Class
