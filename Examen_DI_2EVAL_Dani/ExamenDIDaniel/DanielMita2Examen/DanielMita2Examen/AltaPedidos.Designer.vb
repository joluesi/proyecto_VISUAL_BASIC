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
        Me.grbDetalles = New System.Windows.Forms.GroupBox()
        Me.btnGuardarDetalles = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescuentoDetalles = New System.Windows.Forms.TextBox()
        Me.txtCantidadProDetalles = New System.Windows.Forms.TextBox()
        Me.comboCodProductoDetalle = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodDetalle = New System.Windows.Forms.TextBox()
        Me.txtCodPedido = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtFechaPedido = New System.Windows.Forms.TextBox()
        Me.txtDireccionPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptarAltaPedido = New System.Windows.Forms.Button()
        Me.btnVolverAltaPedido = New System.Windows.Forms.Button()
        Me.grbDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDetalles
        '
        Me.grbDetalles.Controls.Add(Me.btnGuardarDetalles)
        Me.grbDetalles.Controls.Add(Me.Label8)
        Me.grbDetalles.Controls.Add(Me.Label7)
        Me.grbDetalles.Controls.Add(Me.txtDescuentoDetalles)
        Me.grbDetalles.Controls.Add(Me.txtCantidadProDetalles)
        Me.grbDetalles.Controls.Add(Me.comboCodProductoDetalle)
        Me.grbDetalles.Controls.Add(Me.Label6)
        Me.grbDetalles.Controls.Add(Me.Label5)
        Me.grbDetalles.Controls.Add(Me.txtCodDetalle)
        Me.grbDetalles.Location = New System.Drawing.Point(401, 70)
        Me.grbDetalles.Name = "grbDetalles"
        Me.grbDetalles.Size = New System.Drawing.Size(305, 487)
        Me.grbDetalles.TabIndex = 0
        Me.grbDetalles.TabStop = False
        Me.grbDetalles.Text = "GroupBox1"
        '
        'btnGuardarDetalles
        '
        Me.btnGuardarDetalles.Location = New System.Drawing.Point(25, 309)
        Me.btnGuardarDetalles.Name = "btnGuardarDetalles"
        Me.btnGuardarDetalles.Size = New System.Drawing.Size(233, 35)
        Me.btnGuardarDetalles.TabIndex = 14
        Me.btnGuardarDetalles.Text = "Guardar"
        Me.btnGuardarDetalles.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Descuento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cantidad productos"
        '
        'txtDescuentoDetalles
        '
        Me.txtDescuentoDetalles.Location = New System.Drawing.Point(25, 254)
        Me.txtDescuentoDetalles.Name = "txtDescuentoDetalles"
        Me.txtDescuentoDetalles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescuentoDetalles.Size = New System.Drawing.Size(233, 22)
        Me.txtDescuentoDetalles.TabIndex = 11
        '
        'txtCantidadProDetalles
        '
        Me.txtCantidadProDetalles.Location = New System.Drawing.Point(25, 186)
        Me.txtCantidadProDetalles.Name = "txtCantidadProDetalles"
        Me.txtCantidadProDetalles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCantidadProDetalles.Size = New System.Drawing.Size(233, 22)
        Me.txtCantidadProDetalles.TabIndex = 10
        '
        'comboCodProductoDetalle
        '
        Me.comboCodProductoDetalle.FormattingEnabled = True
        Me.comboCodProductoDetalle.Location = New System.Drawing.Point(25, 123)
        Me.comboCodProductoDetalle.Name = "comboCodProductoDetalle"
        Me.comboCodProductoDetalle.Size = New System.Drawing.Size(233, 24)
        Me.comboCodProductoDetalle.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Codigo producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Codigo pedido"
        '
        'txtCodDetalle
        '
        Me.txtCodDetalle.Enabled = False
        Me.txtCodDetalle.Location = New System.Drawing.Point(25, 64)
        Me.txtCodDetalle.Name = "txtCodDetalle"
        Me.txtCodDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodDetalle.Size = New System.Drawing.Size(233, 22)
        Me.txtCodDetalle.TabIndex = 2
        '
        'txtCodPedido
        '
        Me.txtCodPedido.Enabled = False
        Me.txtCodPedido.Location = New System.Drawing.Point(46, 70)
        Me.txtCodPedido.Name = "txtCodPedido"
        Me.txtCodPedido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodPedido.Size = New System.Drawing.Size(233, 22)
        Me.txtCodPedido.TabIndex = 1
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(46, 134)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(233, 22)
        Me.txtCodCliente.TabIndex = 2
        '
        'txtFechaPedido
        '
        Me.txtFechaPedido.Enabled = False
        Me.txtFechaPedido.Location = New System.Drawing.Point(46, 193)
        Me.txtFechaPedido.Name = "txtFechaPedido"
        Me.txtFechaPedido.Size = New System.Drawing.Size(233, 22)
        Me.txtFechaPedido.TabIndex = 3
        '
        'txtDireccionPedido
        '
        Me.txtDireccionPedido.Enabled = False
        Me.txtDireccionPedido.Location = New System.Drawing.Point(46, 248)
        Me.txtDireccionPedido.Name = "txtDireccionPedido"
        Me.txtDireccionPedido.Size = New System.Drawing.Size(233, 22)
        Me.txtDireccionPedido.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Codigo Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Direccion"
        '
        'btnAceptarAltaPedido
        '
        Me.btnAceptarAltaPedido.Location = New System.Drawing.Point(46, 314)
        Me.btnAceptarAltaPedido.Name = "btnAceptarAltaPedido"
        Me.btnAceptarAltaPedido.Size = New System.Drawing.Size(233, 49)
        Me.btnAceptarAltaPedido.TabIndex = 9
        Me.btnAceptarAltaPedido.Text = "Aceptar"
        Me.btnAceptarAltaPedido.UseVisualStyleBackColor = True
        '
        'btnVolverAltaPedido
        '
        Me.btnVolverAltaPedido.Location = New System.Drawing.Point(49, 390)
        Me.btnVolverAltaPedido.Name = "btnVolverAltaPedido"
        Me.btnVolverAltaPedido.Size = New System.Drawing.Size(233, 49)
        Me.btnVolverAltaPedido.TabIndex = 10
        Me.btnVolverAltaPedido.Text = "Volver"
        Me.btnVolverAltaPedido.UseVisualStyleBackColor = True
        '
        'AltaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 672)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbDetalles As GroupBox
    Friend WithEvents txtCodPedido As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtFechaPedido As TextBox
    Friend WithEvents txtDireccionPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptarAltaPedido As Button
    Friend WithEvents btnVolverAltaPedido As Button
    Friend WithEvents txtCodDetalle As TextBox
    Friend WithEvents comboCodProductoDetalle As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescuentoDetalles As TextBox
    Friend WithEvents txtCantidadProDetalles As TextBox
    Friend WithEvents btnGuardarDetalles As Button
End Class
