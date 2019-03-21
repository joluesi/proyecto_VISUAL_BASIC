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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.gbxOrden = New System.Windows.Forms.GroupBox()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.rbtnDescend = New System.Windows.Forms.RadioButton()
        Me.rbtnAscend = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNumeros = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbxOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca un nuevo número:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(85, 93)
        Me.txtNumero.Multiline = True
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(117, 28)
        Me.txtNumero.TabIndex = 1
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadir.Location = New System.Drawing.Point(257, 93)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(116, 28)
        Me.btnAnadir.TabIndex = 2
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'gbxOrden
        '
        Me.gbxOrden.Controls.Add(Me.btnOrdenar)
        Me.gbxOrden.Controls.Add(Me.rbtnDescend)
        Me.gbxOrden.Controls.Add(Me.rbtnAscend)
        Me.gbxOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOrden.Location = New System.Drawing.Point(85, 166)
        Me.gbxOrden.Name = "gbxOrden"
        Me.gbxOrden.Size = New System.Drawing.Size(313, 123)
        Me.gbxOrden.TabIndex = 3
        Me.gbxOrden.TabStop = False
        Me.gbxOrden.Text = "Orden:"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenar.Location = New System.Drawing.Point(172, 48)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(116, 28)
        Me.btnOrdenar.TabIndex = 3
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'rbtnDescend
        '
        Me.rbtnDescend.AutoSize = True
        Me.rbtnDescend.Location = New System.Drawing.Point(20, 76)
        Me.rbtnDescend.Name = "rbtnDescend"
        Me.rbtnDescend.Size = New System.Drawing.Size(134, 24)
        Me.rbtnDescend.TabIndex = 1
        Me.rbtnDescend.Text = "Descendente"
        Me.rbtnDescend.UseVisualStyleBackColor = True
        '
        'rbtnAscend
        '
        Me.rbtnAscend.AutoSize = True
        Me.rbtnAscend.Checked = True
        Me.rbtnAscend.Location = New System.Drawing.Point(20, 36)
        Me.rbtnAscend.Name = "rbtnAscend"
        Me.rbtnAscend.Size = New System.Drawing.Size(123, 24)
        Me.rbtnAscend.TabIndex = 0
        Me.rbtnAscend.TabStop = True
        Me.rbtnAscend.Text = "Ascendente"
        Me.rbtnAscend.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(664, 93)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 28)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(454, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lista de Números:"
        '
        'lstNumeros
        '
        Me.lstNumeros.FormattingEnabled = True
        Me.lstNumeros.Location = New System.Drawing.Point(458, 93)
        Me.lstNumeros.Name = "lstNumeros"
        Me.lstNumeros.Size = New System.Drawing.Size(190, 199)
        Me.lstNumeros.TabIndex = 10
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(664, 153)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(116, 28)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 350)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lstNumeros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxOrden)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxOrden.ResumeLayout(False)
        Me.gbxOrden.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents gbxOrden As GroupBox
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents rbtnDescend As RadioButton
    Friend WithEvents rbtnAscend As RadioButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstNumeros As ListBox
    Friend WithEvents btnLimpiar As Button
End Class
