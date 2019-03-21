<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.txtRebajaConsulta = New System.Windows.Forms.TextBox()
        Me.lblRebaja = New System.Windows.Forms.Label()
        Me.cmbCategoriaConsulta = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtPrecioConsulta = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtExistenciasConsulta = New System.Windows.Forms.TextBox()
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.txtNombreConsulta = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigoConsulta = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRebajaConsulta
        '
        Me.txtRebajaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRebajaConsulta.Location = New System.Drawing.Point(193, 387)
        Me.txtRebajaConsulta.Name = "txtRebajaConsulta"
        Me.txtRebajaConsulta.ReadOnly = True
        Me.txtRebajaConsulta.Size = New System.Drawing.Size(148, 22)
        Me.txtRebajaConsulta.TabIndex = 23
        '
        'lblRebaja
        '
        Me.lblRebaja.AutoSize = True
        Me.lblRebaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRebaja.Location = New System.Drawing.Point(58, 390)
        Me.lblRebaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRebaja.Name = "lblRebaja"
        Me.lblRebaja.Size = New System.Drawing.Size(63, 16)
        Me.lblRebaja.TabIndex = 22
        Me.lblRebaja.Text = "Rebaja:"
        '
        'cmbCategoriaConsulta
        '
        Me.cmbCategoriaConsulta.Enabled = False
        Me.cmbCategoriaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaConsulta.FormattingEnabled = True
        Me.cmbCategoriaConsulta.Items.AddRange(New Object() {"Informática", "Imagen", "Telefonía", "Sonido"})
        Me.cmbCategoriaConsulta.Location = New System.Drawing.Point(193, 325)
        Me.cmbCategoriaConsulta.Name = "cmbCategoriaConsulta"
        Me.cmbCategoriaConsulta.Size = New System.Drawing.Size(148, 24)
        Me.cmbCategoriaConsulta.TabIndex = 21
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(58, 325)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(80, 16)
        Me.lblCategoria.TabIndex = 20
        Me.lblCategoria.Text = "Categoría:"
        '
        'txtPrecioConsulta
        '
        Me.txtPrecioConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioConsulta.Location = New System.Drawing.Point(193, 257)
        Me.txtPrecioConsulta.Name = "txtPrecioConsulta"
        Me.txtPrecioConsulta.ReadOnly = True
        Me.txtPrecioConsulta.Size = New System.Drawing.Size(148, 22)
        Me.txtPrecioConsulta.TabIndex = 19
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(58, 257)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 16)
        Me.lblPrecio.TabIndex = 18
        Me.lblPrecio.Text = "Precio:"
        '
        'txtExistenciasConsulta
        '
        Me.txtExistenciasConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistenciasConsulta.Location = New System.Drawing.Point(193, 192)
        Me.txtExistenciasConsulta.Name = "txtExistenciasConsulta"
        Me.txtExistenciasConsulta.ReadOnly = True
        Me.txtExistenciasConsulta.Size = New System.Drawing.Size(148, 22)
        Me.txtExistenciasConsulta.TabIndex = 17
        '
        'lblExistencias
        '
        Me.lblExistencias.AutoSize = True
        Me.lblExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencias.Location = New System.Drawing.Point(58, 192)
        Me.lblExistencias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Size = New System.Drawing.Size(91, 16)
        Me.lblExistencias.TabIndex = 16
        Me.lblExistencias.Text = "Existencias:"
        '
        'txtNombreConsulta
        '
        Me.txtNombreConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreConsulta.Location = New System.Drawing.Point(193, 126)
        Me.txtNombreConsulta.Name = "txtNombreConsulta"
        Me.txtNombreConsulta.ReadOnly = True
        Me.txtNombreConsulta.Size = New System.Drawing.Size(148, 22)
        Me.txtNombreConsulta.TabIndex = 15
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(58, 126)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 16)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre:"
        '
        'txtCodigoConsulta
        '
        Me.txtCodigoConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoConsulta.Location = New System.Drawing.Point(193, 63)
        Me.txtCodigoConsulta.Name = "txtCodigoConsulta"
        Me.txtCodigoConsulta.ReadOnly = True
        Me.txtCodigoConsulta.Size = New System.Drawing.Size(148, 22)
        Me.txtCodigoConsulta.TabIndex = 13
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(58, 63)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(62, 16)
        Me.lblCodigo.TabIndex = 12
        Me.lblCodigo.Text = "Código:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(61, 477)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(122, 40)
        Me.btnVolver.TabIndex = 24
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(219, 477)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 40)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 595)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtRebajaConsulta)
        Me.Controls.Add(Me.lblRebaja)
        Me.Controls.Add(Me.cmbCategoriaConsulta)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.txtPrecioConsulta)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtExistenciasConsulta)
        Me.Controls.Add(Me.lblExistencias)
        Me.Controls.Add(Me.txtNombreConsulta)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCodigoConsulta)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Consulta"
        Me.Text = "Consultas / Bajas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRebajaConsulta As TextBox
    Friend WithEvents lblRebaja As Label
    Friend WithEvents cmbCategoriaConsulta As ComboBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtPrecioConsulta As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtExistenciasConsulta As TextBox
    Friend WithEvents lblExistencias As Label
    Friend WithEvents txtNombreConsulta As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigoConsulta As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnEliminar As Button
End Class
