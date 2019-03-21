<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_dinero = New System.Windows.Forms.TextBox()
        Me.txt_billetes_10 = New System.Windows.Forms.TextBox()
        Me.txt_billetes_20 = New System.Windows.Forms.TextBox()
        Me.txt_billetes_50 = New System.Windows.Forms.TextBox()
        Me.txt_billetes_100 = New System.Windows.Forms.TextBox()
        Me.txt_billetes_200 = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_billetes_500 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_billetes_5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de dinero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Billetes de 20:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Billetes de 10: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Billetes de 50:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Billetes de 100:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Billetes de 200:"
        '
        'txt_dinero
        '
        Me.txt_dinero.Location = New System.Drawing.Point(301, 55)
        Me.txt_dinero.Name = "txt_dinero"
        Me.txt_dinero.Size = New System.Drawing.Size(100, 20)
        Me.txt_dinero.TabIndex = 6
        '
        'txt_billetes_10
        '
        Me.txt_billetes_10.Location = New System.Drawing.Point(301, 139)
        Me.txt_billetes_10.Name = "txt_billetes_10"
        Me.txt_billetes_10.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_10.TabIndex = 7
        '
        'txt_billetes_20
        '
        Me.txt_billetes_20.Location = New System.Drawing.Point(301, 186)
        Me.txt_billetes_20.Name = "txt_billetes_20"
        Me.txt_billetes_20.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_20.TabIndex = 8
        '
        'txt_billetes_50
        '
        Me.txt_billetes_50.Location = New System.Drawing.Point(301, 233)
        Me.txt_billetes_50.Name = "txt_billetes_50"
        Me.txt_billetes_50.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_50.TabIndex = 9
        '
        'txt_billetes_100
        '
        Me.txt_billetes_100.Location = New System.Drawing.Point(301, 279)
        Me.txt_billetes_100.Name = "txt_billetes_100"
        Me.txt_billetes_100.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_100.TabIndex = 10
        '
        'txt_billetes_200
        '
        Me.txt_billetes_200.Location = New System.Drawing.Point(301, 329)
        Me.txt_billetes_200.Name = "txt_billetes_200"
        Me.txt_billetes_200.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_200.TabIndex = 11
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(509, 99)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(152, 36)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Billetes de 500:"
        '
        'txt_billetes_500
        '
        Me.txt_billetes_500.Location = New System.Drawing.Point(301, 378)
        Me.txt_billetes_500.Name = "txt_billetes_500"
        Me.txt_billetes_500.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_500.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Billetes de 5: "
        '
        'txt_billetes_5
        '
        Me.txt_billetes_5.Location = New System.Drawing.Point(301, 99)
        Me.txt_billetes_5.Name = "txt_billetes_5"
        Me.txt_billetes_5.Size = New System.Drawing.Size(100, 20)
        Me.txt_billetes_5.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_billetes_5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_billetes_500)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txt_billetes_200)
        Me.Controls.Add(Me.txt_billetes_100)
        Me.Controls.Add(Me.txt_billetes_50)
        Me.Controls.Add(Me.txt_billetes_20)
        Me.Controls.Add(Me.txt_billetes_10)
        Me.Controls.Add(Me.txt_dinero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_dinero As TextBox
    Friend WithEvents txt_billetes_10 As TextBox
    Friend WithEvents txt_billetes_20 As TextBox
    Friend WithEvents txt_billetes_50 As TextBox
    Friend WithEvents txt_billetes_100 As TextBox
    Friend WithEvents txt_billetes_200 As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_billetes_500 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_billetes_5 As TextBox
End Class
