<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtRebaja = New System.Windows.Forms.TextBox()
        Me.lblRebaja = New System.Windows.Forms.Label()
        Me.gbxTipoArt = New System.Windows.Forms.GroupBox()
        Me.rbtnArtRebaja = New System.Windows.Forms.RadioButton()
        Me.rbtnArticulo = New System.Windows.Forms.RadioButton()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbxTipoArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(84, 58)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(62, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(219, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(219, 121)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(148, 22)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(84, 121)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 16)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtExistencias
        '
        Me.txtExistencias.Location = New System.Drawing.Point(219, 187)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(148, 22)
        Me.txtExistencias.TabIndex = 5
        '
        'lblExistencias
        '
        Me.lblExistencias.AutoSize = True
        Me.lblExistencias.Location = New System.Drawing.Point(84, 187)
        Me.lblExistencias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Size = New System.Drawing.Size(91, 16)
        Me.lblExistencias.TabIndex = 4
        Me.lblExistencias.Text = "Existencias:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(219, 252)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(148, 22)
        Me.txtPrecio.TabIndex = 7
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(84, 252)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 16)
        Me.lblPrecio.TabIndex = 6
        Me.lblPrecio.Text = "Precio:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(84, 320)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(80, 16)
        Me.lblCategoria.TabIndex = 8
        Me.lblCategoria.Text = "Categoría:"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"Informática", "Imagen", "Telefonía", "Sonido"})
        Me.cmbCategoria.Location = New System.Drawing.Point(219, 320)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(181, 24)
        Me.cmbCategoria.TabIndex = 9
        '
        'txtRebaja
        '
        Me.txtRebaja.Location = New System.Drawing.Point(525, 249)
        Me.txtRebaja.Name = "txtRebaja"
        Me.txtRebaja.Size = New System.Drawing.Size(148, 22)
        Me.txtRebaja.TabIndex = 11
        '
        'lblRebaja
        '
        Me.lblRebaja.AutoSize = True
        Me.lblRebaja.Location = New System.Drawing.Point(417, 252)
        Me.lblRebaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRebaja.Name = "lblRebaja"
        Me.lblRebaja.Size = New System.Drawing.Size(63, 16)
        Me.lblRebaja.TabIndex = 10
        Me.lblRebaja.Text = "Rebaja:"
        '
        'gbxTipoArt
        '
        Me.gbxTipoArt.Controls.Add(Me.rbtnArtRebaja)
        Me.gbxTipoArt.Controls.Add(Me.rbtnArticulo)
        Me.gbxTipoArt.Location = New System.Drawing.Point(87, 393)
        Me.gbxTipoArt.Name = "gbxTipoArt"
        Me.gbxTipoArt.Size = New System.Drawing.Size(439, 78)
        Me.gbxTipoArt.TabIndex = 12
        Me.gbxTipoArt.TabStop = False
        Me.gbxTipoArt.Text = "Tipo de Artículo:"
        '
        'rbtnArtRebaja
        '
        Me.rbtnArtRebaja.AutoSize = True
        Me.rbtnArtRebaja.Location = New System.Drawing.Point(202, 34)
        Me.rbtnArtRebaja.Name = "rbtnArtRebaja"
        Me.rbtnArtRebaja.Size = New System.Drawing.Size(151, 20)
        Me.rbtnArtRebaja.TabIndex = 1
        Me.rbtnArtRebaja.TabStop = True
        Me.rbtnArtRebaja.Text = "Artículo Rebajado"
        Me.rbtnArtRebaja.UseVisualStyleBackColor = True
        '
        'rbtnArticulo
        '
        Me.rbtnArticulo.AutoSize = True
        Me.rbtnArticulo.Checked = True
        Me.rbtnArticulo.Location = New System.Drawing.Point(45, 34)
        Me.rbtnArticulo.Name = "rbtnArticulo"
        Me.rbtnArticulo.Size = New System.Drawing.Size(78, 20)
        Me.rbtnArticulo.TabIndex = 0
        Me.rbtnArticulo.TabStop = True
        Me.rbtnArticulo.Text = "Artículo"
        Me.rbtnArticulo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(336, 515)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(144, 38)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(529, 515)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(144, 38)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(145, 515)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(144, 38)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 615)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxTipoArt)
        Me.Controls.Add(Me.txtRebaja)
        Me.Controls.Add(Me.lblRebaja)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtExistencias)
        Me.Controls.Add(Me.lblExistencias)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Alta"
        Me.Text = "Alta"
        Me.gbxTipoArt.ResumeLayout(False)
        Me.gbxTipoArt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents lblExistencias As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents txtRebaja As TextBox
    Friend WithEvents lblRebaja As Label
    Friend WithEvents gbxTipoArt As GroupBox
    Friend WithEvents rbtnArtRebaja As RadioButton
    Friend WithEvents rbtnArticulo As RadioButton
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiar As Button
End Class
