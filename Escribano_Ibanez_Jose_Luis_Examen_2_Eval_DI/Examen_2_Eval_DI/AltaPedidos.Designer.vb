<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPedidos
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodPedido = New System.Windows.Forms.TextBox()
        Me.txtClientePedido = New System.Windows.Forms.TextBox()
        Me.txtFechaPedido = New System.Windows.Forms.TextBox()
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDirecPedido = New System.Windows.Forms.TextBox()
        Me.gbdetallePedido = New System.Windows.Forms.GroupBox()
        Me.btnVolver_detal = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtcodprod_detal = New System.Windows.Forms.TextBox()
        Me.txtcodped_detal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbdetallePedido.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Pedido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Pedido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente Pedido:"
        '
        'txtCodPedido
        '
        Me.txtCodPedido.Location = New System.Drawing.Point(225, 46)
        Me.txtCodPedido.Name = "txtCodPedido"
        Me.txtCodPedido.Size = New System.Drawing.Size(135, 20)
        Me.txtCodPedido.TabIndex = 3
        '
        'txtClientePedido
        '
        Me.txtClientePedido.Location = New System.Drawing.Point(225, 106)
        Me.txtClientePedido.Name = "txtClientePedido"
        Me.txtClientePedido.Size = New System.Drawing.Size(135, 20)
        Me.txtClientePedido.TabIndex = 4
        '
        'txtFechaPedido
        '
        Me.txtFechaPedido.Location = New System.Drawing.Point(225, 162)
        Me.txtFechaPedido.Name = "txtFechaPedido"
        Me.txtFechaPedido.Size = New System.Drawing.Size(135, 20)
        Me.txtFechaPedido.TabIndex = 5
        '
        'btnPedido
        '
        Me.btnPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedido.Location = New System.Drawing.Point(52, 286)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(129, 33)
        Me.btnPedido.TabIndex = 6
        Me.btnPedido.Text = "Alta Pedido"
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(225, 286)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(129, 33)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dirección de Pedido:"
        '
        'txtDirecPedido
        '
        Me.txtDirecPedido.Location = New System.Drawing.Point(225, 219)
        Me.txtDirecPedido.Name = "txtDirecPedido"
        Me.txtDirecPedido.Size = New System.Drawing.Size(135, 20)
        Me.txtDirecPedido.TabIndex = 9
        '
        'gbdetallePedido
        '
        Me.gbdetallePedido.Controls.Add(Me.btnVolver_detal)
        Me.gbdetallePedido.Controls.Add(Me.btnGuardar)
        Me.gbdetallePedido.Controls.Add(Me.txtDescuento)
        Me.gbdetallePedido.Controls.Add(Me.txtUnidades)
        Me.gbdetallePedido.Controls.Add(Me.txtcodprod_detal)
        Me.gbdetallePedido.Controls.Add(Me.txtcodped_detal)
        Me.gbdetallePedido.Controls.Add(Me.Label8)
        Me.gbdetallePedido.Controls.Add(Me.Label7)
        Me.gbdetallePedido.Controls.Add(Me.Label6)
        Me.gbdetallePedido.Controls.Add(Me.Label5)
        Me.gbdetallePedido.Location = New System.Drawing.Point(436, 34)
        Me.gbdetallePedido.Name = "gbdetallePedido"
        Me.gbdetallePedido.Size = New System.Drawing.Size(455, 326)
        Me.gbdetallePedido.TabIndex = 10
        Me.gbdetallePedido.TabStop = False
        Me.gbdetallePedido.Text = "GroupBox1"
        Me.gbdetallePedido.Visible = False
        '
        'btnVolver_detal
        '
        Me.btnVolver_detal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver_detal.Location = New System.Drawing.Point(238, 234)
        Me.btnVolver_detal.Name = "btnVolver_detal"
        Me.btnVolver_detal.Size = New System.Drawing.Size(129, 33)
        Me.btnVolver_detal.TabIndex = 10
        Me.btnVolver_detal.Text = "Volver"
        Me.btnVolver_detal.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(43, 234)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 33)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(238, 167)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(135, 20)
        Me.txtDescuento.TabIndex = 8
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(238, 122)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(135, 20)
        Me.txtUnidades.TabIndex = 7
        '
        'txtcodprod_detal
        '
        Me.txtcodprod_detal.Location = New System.Drawing.Point(238, 79)
        Me.txtcodprod_detal.Name = "txtcodprod_detal"
        Me.txtcodprod_detal.Size = New System.Drawing.Size(135, 20)
        Me.txtcodprod_detal.TabIndex = 6
        '
        'txtcodped_detal
        '
        Me.txtcodped_detal.Location = New System.Drawing.Point(238, 34)
        Me.txtcodped_detal.Name = "txtcodped_detal"
        Me.txtcodped_detal.Size = New System.Drawing.Size(135, 20)
        Me.txtcodped_detal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Descuento: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Unidades: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Código de producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Código de Pedido:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AltaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 398)
        Me.Controls.Add(Me.gbdetallePedido)
        Me.Controls.Add(Me.txtDirecPedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnPedido)
        Me.Controls.Add(Me.txtFechaPedido)
        Me.Controls.Add(Me.txtClientePedido)
        Me.Controls.Add(Me.txtCodPedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaPedidos"
        Me.Text = "AltaPedidos"
        Me.gbdetallePedido.ResumeLayout(False)
        Me.gbdetallePedido.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodPedido As TextBox
    Friend WithEvents txtClientePedido As TextBox
    Friend WithEvents txtFechaPedido As TextBox
    Friend WithEvents btnPedido As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDirecPedido As TextBox
    Friend WithEvents gbdetallePedido As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVolver_detal As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents txtcodprod_detal As TextBox
    Friend WithEvents txtcodped_detal As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
