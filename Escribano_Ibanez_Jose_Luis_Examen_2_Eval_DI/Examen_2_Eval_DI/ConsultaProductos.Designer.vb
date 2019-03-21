<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaProductos
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtConsultaStockProd = New System.Windows.Forms.TextBox()
        Me.txtConsultaPrecioProd = New System.Windows.Forms.TextBox()
        Me.txtConsultaNombreProd = New System.Windows.Forms.TextBox()
        Me.txtConsultaCodProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(293, 311)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 32)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(103, 311)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(124, 32)
        Me.btnConsultar.TabIndex = 18
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtConsultaStockProd
        '
        Me.txtConsultaStockProd.Location = New System.Drawing.Point(316, 236)
        Me.txtConsultaStockProd.Name = "txtConsultaStockProd"
        Me.txtConsultaStockProd.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaStockProd.TabIndex = 17
        '
        'txtConsultaPrecioProd
        '
        Me.txtConsultaPrecioProd.Location = New System.Drawing.Point(316, 176)
        Me.txtConsultaPrecioProd.Name = "txtConsultaPrecioProd"
        Me.txtConsultaPrecioProd.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaPrecioProd.TabIndex = 16
        '
        'txtConsultaNombreProd
        '
        Me.txtConsultaNombreProd.Location = New System.Drawing.Point(316, 117)
        Me.txtConsultaNombreProd.Name = "txtConsultaNombreProd"
        Me.txtConsultaNombreProd.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaNombreProd.TabIndex = 15
        '
        'txtConsultaCodProd
        '
        Me.txtConsultaCodProd.Location = New System.Drawing.Point(316, 56)
        Me.txtConsultaCodProd.Name = "txtConsultaCodProd"
        Me.txtConsultaCodProd.Size = New System.Drawing.Size(155, 20)
        Me.txtConsultaCodProd.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Precio producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Stock producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código producto:"
        '
        'ConsultaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtConsultaStockProd)
        Me.Controls.Add(Me.txtConsultaPrecioProd)
        Me.Controls.Add(Me.txtConsultaNombreProd)
        Me.Controls.Add(Me.txtConsultaCodProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaProductos"
        Me.Text = "ConsultaProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtConsultaStockProd As TextBox
    Friend WithEvents txtConsultaPrecioProd As TextBox
    Friend WithEvents txtConsultaNombreProd As TextBox
    Friend WithEvents txtConsultaCodProd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
