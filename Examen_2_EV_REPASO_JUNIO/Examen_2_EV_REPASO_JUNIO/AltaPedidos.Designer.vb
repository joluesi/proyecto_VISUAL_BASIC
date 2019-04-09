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
        Me.btnVolverAltaPedido = New System.Windows.Forms.Button()
        Me.btnAceptarAltaPedido = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccionPedido = New System.Windows.Forms.TextBox()
        Me.txtFechaPedido = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtCodPedido = New System.Windows.Forms.TextBox()
        Me.grbDetalles = New System.Windows.Forms.GroupBox()
        Me.btnVolverDetalle = New System.Windows.Forms.Button()
        Me.btnGuardarDetalles = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescuentoDetalles = New System.Windows.Forms.TextBox()
        Me.txtCantidadProDetalles = New System.Windows.Forms.TextBox()
        Me.cmbCodProducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodDetalle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbDetalles.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverAltaPedido
        '
        Me.btnVolverAltaPedido.Location = New System.Drawing.Point(58, 346)
        Me.btnVolverAltaPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverAltaPedido.Name = "btnVolverAltaPedido"
        Me.btnVolverAltaPedido.Size = New System.Drawing.Size(175, 40)
        Me.btnVolverAltaPedido.TabIndex = 21
        Me.btnVolverAltaPedido.Text = "Volver"
        Me.btnVolverAltaPedido.UseVisualStyleBackColor = True
        '
        'btnAceptarAltaPedido
        '
        Me.btnAceptarAltaPedido.Location = New System.Drawing.Point(55, 284)
        Me.btnAceptarAltaPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarAltaPedido.Name = "btnAceptarAltaPedido"
        Me.btnAceptarAltaPedido.Size = New System.Drawing.Size(175, 40)
        Me.btnAceptarAltaPedido.TabIndex = 20
        Me.btnAceptarAltaPedido.Text = "Aceptar"
        Me.btnAceptarAltaPedido.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Fecha pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Codigo Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo pedido"
        '
        'txtDireccionPedido
        '
        Me.txtDireccionPedido.Enabled = False
        Me.txtDireccionPedido.Location = New System.Drawing.Point(55, 231)
        Me.txtDireccionPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionPedido.Name = "txtDireccionPedido"
        Me.txtDireccionPedido.ReadOnly = True
        Me.txtDireccionPedido.Size = New System.Drawing.Size(176, 20)
        Me.txtDireccionPedido.TabIndex = 15
        '
        'txtFechaPedido
        '
        Me.txtFechaPedido.Enabled = False
        Me.txtFechaPedido.Location = New System.Drawing.Point(55, 186)
        Me.txtFechaPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaPedido.Name = "txtFechaPedido"
        Me.txtFechaPedido.ReadOnly = True
        Me.txtFechaPedido.Size = New System.Drawing.Size(176, 20)
        Me.txtFechaPedido.TabIndex = 14
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(55, 138)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(176, 20)
        Me.txtCodCliente.TabIndex = 13
        '
        'txtCodPedido
        '
        Me.txtCodPedido.Enabled = False
        Me.txtCodPedido.Location = New System.Drawing.Point(55, 86)
        Me.txtCodPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodPedido.Name = "txtCodPedido"
        Me.txtCodPedido.ReadOnly = True
        Me.txtCodPedido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodPedido.Size = New System.Drawing.Size(176, 20)
        Me.txtCodPedido.TabIndex = 12
        '
        'grbDetalles
        '
        Me.grbDetalles.Controls.Add(Me.btnVolverDetalle)
        Me.grbDetalles.Controls.Add(Me.btnGuardarDetalles)
        Me.grbDetalles.Controls.Add(Me.Label8)
        Me.grbDetalles.Controls.Add(Me.Label7)
        Me.grbDetalles.Controls.Add(Me.txtDescuentoDetalles)
        Me.grbDetalles.Controls.Add(Me.txtCantidadProDetalles)
        Me.grbDetalles.Controls.Add(Me.cmbCodProducto)
        Me.grbDetalles.Controls.Add(Me.Label6)
        Me.grbDetalles.Controls.Add(Me.Label5)
        Me.grbDetalles.Controls.Add(Me.txtCodDetalle)
        Me.grbDetalles.Location = New System.Drawing.Point(322, 86)
        Me.grbDetalles.Margin = New System.Windows.Forms.Padding(2)
        Me.grbDetalles.Name = "grbDetalles"
        Me.grbDetalles.Padding = New System.Windows.Forms.Padding(2)
        Me.grbDetalles.Size = New System.Drawing.Size(229, 371)
        Me.grbDetalles.TabIndex = 11
        Me.grbDetalles.TabStop = False
        Me.grbDetalles.Text = "GroupBox1"
        Me.grbDetalles.Visible = False
        '
        'btnVolverDetalle
        '
        Me.btnVolverDetalle.Location = New System.Drawing.Point(20, 309)
        Me.btnVolverDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverDetalle.Name = "btnVolverDetalle"
        Me.btnVolverDetalle.Size = New System.Drawing.Size(175, 28)
        Me.btnVolverDetalle.TabIndex = 15
        Me.btnVolverDetalle.Text = "Volver "
        Me.btnVolverDetalle.UseVisualStyleBackColor = True
        '
        'btnGuardarDetalles
        '
        Me.btnGuardarDetalles.Location = New System.Drawing.Point(19, 251)
        Me.btnGuardarDetalles.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarDetalles.Name = "btnGuardarDetalles"
        Me.btnGuardarDetalles.Size = New System.Drawing.Size(175, 28)
        Me.btnGuardarDetalles.TabIndex = 14
        Me.btnGuardarDetalles.Text = "Guardar"
        Me.btnGuardarDetalles.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 135)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad productos"
        '
        'txtDescuentoDetalles
        '
        Me.txtDescuentoDetalles.Location = New System.Drawing.Point(19, 206)
        Me.txtDescuentoDetalles.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescuentoDetalles.Name = "txtDescuentoDetalles"
        Me.txtDescuentoDetalles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescuentoDetalles.Size = New System.Drawing.Size(176, 20)
        Me.txtDescuentoDetalles.TabIndex = 11
        '
        'txtCantidadProDetalles
        '
        Me.txtCantidadProDetalles.Location = New System.Drawing.Point(19, 151)
        Me.txtCantidadProDetalles.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadProDetalles.Name = "txtCantidadProDetalles"
        Me.txtCantidadProDetalles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCantidadProDetalles.Size = New System.Drawing.Size(176, 20)
        Me.txtCantidadProDetalles.TabIndex = 10
        '
        'cmbCodProducto
        '
        Me.cmbCodProducto.FormattingEnabled = True
        Me.cmbCodProducto.Location = New System.Drawing.Point(19, 100)
        Me.cmbCodProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCodProducto.Name = "cmbCodProducto"
        Me.cmbCodProducto.Size = New System.Drawing.Size(176, 21)
        Me.cmbCodProducto.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Codigo producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Codigo pedido"
        '
        'txtCodDetalle
        '
        Me.txtCodDetalle.Enabled = False
        Me.txtCodDetalle.Location = New System.Drawing.Point(19, 52)
        Me.txtCodDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodDetalle.Name = "txtCodDetalle"
        Me.txtCodDetalle.ReadOnly = True
        Me.txtCodDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodDetalle.Size = New System.Drawing.Size(176, 20)
        Me.txtCodDetalle.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ALTA DE PEDIDOS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(329, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 18)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "DETALLE DE PEDIDOS:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AltaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 557)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnVolverAltaPedido)
        Me.Controls.Add(Me.btnAceptarAltaPedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDireccionPedido)
        Me.Controls.Add(Me.txtFechaPedido)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.txtCodPedido)
        Me.Controls.Add(Me.grbDetalles)
        Me.Name = "AltaPedidos"
        Me.Text = "AltaPedidos"
        Me.grbDetalles.ResumeLayout(False)
        Me.grbDetalles.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolverAltaPedido As Button
    Friend WithEvents btnAceptarAltaPedido As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDireccionPedido As TextBox
    Friend WithEvents txtFechaPedido As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtCodPedido As TextBox
    Friend WithEvents grbDetalles As GroupBox
    Friend WithEvents btnGuardarDetalles As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescuentoDetalles As TextBox
    Friend WithEvents txtCantidadProDetalles As TextBox
    Friend WithEvents cmbCodProducto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodDetalle As TextBox
    Friend WithEvents btnVolverDetalle As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
