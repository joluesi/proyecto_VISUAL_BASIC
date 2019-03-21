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
        Me.gbxEntrada = New System.Windows.Forms.GroupBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_HorasTrab = New System.Windows.Forms.Label()
        Me.lbl_PagoHora = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_HorasTrab = New System.Windows.Forms.TextBox()
        Me.txt_PagoHora = New System.Windows.Forms.TextBox()
        Me.gbx_Salida = New System.Windows.Forms.GroupBox()
        Me.txt_SalarioNeto = New System.Windows.Forms.TextBox()
        Me.txt_Descuento = New System.Windows.Forms.TextBox()
        Me.txt_SalarioBruto = New System.Windows.Forms.TextBox()
        Me.lbl_SalarioNeto = New System.Windows.Forms.Label()
        Me.lbl_Descuento = New System.Windows.Forms.Label()
        Me.lbl_SalarioBruto = New System.Windows.Forms.Label()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbxEntrada.SuspendLayout()
        Me.gbx_Salida.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxEntrada
        '
        Me.gbxEntrada.Controls.Add(Me.txt_PagoHora)
        Me.gbxEntrada.Controls.Add(Me.txt_HorasTrab)
        Me.gbxEntrada.Controls.Add(Me.txt_Nombre)
        Me.gbxEntrada.Controls.Add(Me.lbl_PagoHora)
        Me.gbxEntrada.Controls.Add(Me.lbl_HorasTrab)
        Me.gbxEntrada.Controls.Add(Me.lbl_Nombre)
        Me.gbxEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEntrada.Location = New System.Drawing.Point(71, 43)
        Me.gbxEntrada.Name = "gbxEntrada"
        Me.gbxEntrada.Size = New System.Drawing.Size(637, 198)
        Me.gbxEntrada.TabIndex = 0
        Me.gbxEntrada.TabStop = False
        Me.gbxEntrada.Text = "Entrada de datos:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(24, 37)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(154, 16)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Apellidos y nombres:"
        '
        'lbl_HorasTrab
        '
        Me.lbl_HorasTrab.AutoSize = True
        Me.lbl_HorasTrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HorasTrab.Location = New System.Drawing.Point(24, 90)
        Me.lbl_HorasTrab.Name = "lbl_HorasTrab"
        Me.lbl_HorasTrab.Size = New System.Drawing.Size(133, 16)
        Me.lbl_HorasTrab.TabIndex = 1
        Me.lbl_HorasTrab.Text = "Horas trabajadas:"
        '
        'lbl_PagoHora
        '
        Me.lbl_PagoHora.AutoSize = True
        Me.lbl_PagoHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PagoHora.Location = New System.Drawing.Point(24, 143)
        Me.lbl_PagoHora.Name = "lbl_PagoHora"
        Me.lbl_PagoHora.Size = New System.Drawing.Size(111, 16)
        Me.lbl_PagoHora.TabIndex = 2
        Me.lbl_PagoHora.Text = "Pago por hora:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(211, 37)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(383, 26)
        Me.txt_Nombre.TabIndex = 3
        '
        'txt_HorasTrab
        '
        Me.txt_HorasTrab.Location = New System.Drawing.Point(211, 90)
        Me.txt_HorasTrab.Name = "txt_HorasTrab"
        Me.txt_HorasTrab.Size = New System.Drawing.Size(140, 26)
        Me.txt_HorasTrab.TabIndex = 4
        '
        'txt_PagoHora
        '
        Me.txt_PagoHora.Location = New System.Drawing.Point(211, 142)
        Me.txt_PagoHora.Name = "txt_PagoHora"
        Me.txt_PagoHora.Size = New System.Drawing.Size(140, 26)
        Me.txt_PagoHora.TabIndex = 5
        '
        'gbx_Salida
        '
        Me.gbx_Salida.Controls.Add(Me.txt_SalarioNeto)
        Me.gbx_Salida.Controls.Add(Me.txt_Descuento)
        Me.gbx_Salida.Controls.Add(Me.txt_SalarioBruto)
        Me.gbx_Salida.Controls.Add(Me.lbl_SalarioNeto)
        Me.gbx_Salida.Controls.Add(Me.lbl_Descuento)
        Me.gbx_Salida.Controls.Add(Me.lbl_SalarioBruto)
        Me.gbx_Salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Salida.Location = New System.Drawing.Point(71, 290)
        Me.gbx_Salida.Name = "gbx_Salida"
        Me.gbx_Salida.Size = New System.Drawing.Size(420, 198)
        Me.gbx_Salida.TabIndex = 1
        Me.gbx_Salida.TabStop = False
        Me.gbx_Salida.Text = "Salida de datos:"
        '
        'txt_SalarioNeto
        '
        Me.txt_SalarioNeto.Location = New System.Drawing.Point(211, 142)
        Me.txt_SalarioNeto.Name = "txt_SalarioNeto"
        Me.txt_SalarioNeto.Size = New System.Drawing.Size(140, 26)
        Me.txt_SalarioNeto.TabIndex = 5
        '
        'txt_Descuento
        '
        Me.txt_Descuento.Location = New System.Drawing.Point(211, 90)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.Size = New System.Drawing.Size(140, 26)
        Me.txt_Descuento.TabIndex = 4
        '
        'txt_SalarioBruto
        '
        Me.txt_SalarioBruto.Location = New System.Drawing.Point(211, 37)
        Me.txt_SalarioBruto.Name = "txt_SalarioBruto"
        Me.txt_SalarioBruto.Size = New System.Drawing.Size(140, 26)
        Me.txt_SalarioBruto.TabIndex = 3
        '
        'lbl_SalarioNeto
        '
        Me.lbl_SalarioNeto.AutoSize = True
        Me.lbl_SalarioNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SalarioNeto.Location = New System.Drawing.Point(24, 143)
        Me.lbl_SalarioNeto.Name = "lbl_SalarioNeto"
        Me.lbl_SalarioNeto.Size = New System.Drawing.Size(99, 16)
        Me.lbl_SalarioNeto.TabIndex = 2
        Me.lbl_SalarioNeto.Text = "Salario Neto:"
        '
        'lbl_Descuento
        '
        Me.lbl_Descuento.AutoSize = True
        Me.lbl_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descuento.Location = New System.Drawing.Point(24, 90)
        Me.lbl_Descuento.Name = "lbl_Descuento"
        Me.lbl_Descuento.Size = New System.Drawing.Size(86, 16)
        Me.lbl_Descuento.TabIndex = 1
        Me.lbl_Descuento.Text = "Descuento:"
        '
        'lbl_SalarioBruto
        '
        Me.lbl_SalarioBruto.AutoSize = True
        Me.lbl_SalarioBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SalarioBruto.Location = New System.Drawing.Point(24, 37)
        Me.lbl_SalarioBruto.Name = "lbl_SalarioBruto"
        Me.lbl_SalarioBruto.Size = New System.Drawing.Size(102, 16)
        Me.lbl_SalarioBruto.TabIndex = 0
        Me.lbl_SalarioBruto.Text = "Salario Bruto:"
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Location = New System.Drawing.Point(555, 290)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(153, 44)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(555, 432)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(153, 44)
        Me.btn_Salir.TabIndex = 3
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(555, 362)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(153, 44)
        Me.btn_Limpiar.TabIndex = 4
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 626)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.gbx_Salida)
        Me.Controls.Add(Me.gbxEntrada)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxEntrada.ResumeLayout(False)
        Me.gbxEntrada.PerformLayout()
        Me.gbx_Salida.ResumeLayout(False)
        Me.gbx_Salida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxEntrada As GroupBox
    Friend WithEvents txt_PagoHora As TextBox
    Friend WithEvents txt_HorasTrab As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_PagoHora As Label
    Friend WithEvents lbl_HorasTrab As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents gbx_Salida As GroupBox
    Friend WithEvents txt_SalarioNeto As TextBox
    Friend WithEvents txt_Descuento As TextBox
    Friend WithEvents txt_SalarioBruto As TextBox
    Friend WithEvents lbl_SalarioNeto As Label
    Friend WithEvents lbl_Descuento As Label
    Friend WithEvents lbl_SalarioBruto As Label
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
