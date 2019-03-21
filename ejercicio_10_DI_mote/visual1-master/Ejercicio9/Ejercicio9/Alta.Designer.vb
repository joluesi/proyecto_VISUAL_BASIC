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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbArticuloReba = New System.Windows.Forms.RadioButton()
        Me.rbArticulo = New System.Windows.Forms.RadioButton()
        Me.lblRebaja = New System.Windows.Forms.Label()
        Me.txtRebaja = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Categoría"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Existencias"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(99, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(99, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(99, 183)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(121, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'txtExistencias
        '
        Me.txtExistencias.Location = New System.Drawing.Point(99, 235)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(121, 20)
        Me.txtExistencias.TabIndex = 9
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbArticuloReba)
        Me.gbTipo.Controls.Add(Me.rbArticulo)
        Me.gbTipo.Location = New System.Drawing.Point(244, 70)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(146, 100)
        Me.gbTipo.TabIndex = 10
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo de Artículo"
        '
        'rbArticuloReba
        '
        Me.rbArticuloReba.AutoSize = True
        Me.rbArticuloReba.Location = New System.Drawing.Point(7, 77)
        Me.rbArticuloReba.Name = "rbArticuloReba"
        Me.rbArticuloReba.Size = New System.Drawing.Size(111, 17)
        Me.rbArticuloReba.TabIndex = 1
        Me.rbArticuloReba.TabStop = True
        Me.rbArticuloReba.Text = "Artículo Rebajado"
        Me.rbArticuloReba.UseVisualStyleBackColor = True
        '
        'rbArticulo
        '
        Me.rbArticulo.AutoSize = True
        Me.rbArticulo.Location = New System.Drawing.Point(7, 32)
        Me.rbArticulo.Name = "rbArticulo"
        Me.rbArticulo.Size = New System.Drawing.Size(62, 17)
        Me.rbArticulo.TabIndex = 0
        Me.rbArticulo.TabStop = True
        Me.rbArticulo.Text = "Artículo"
        Me.rbArticulo.UseVisualStyleBackColor = True
        '
        'lblRebaja
        '
        Me.lblRebaja.AutoSize = True
        Me.lblRebaja.Location = New System.Drawing.Point(227, 211)
        Me.lblRebaja.Name = "lblRebaja"
        Me.lblRebaja.Size = New System.Drawing.Size(41, 13)
        Me.lblRebaja.TabIndex = 11
        Me.lblRebaja.Text = "Rebaja"
        Me.lblRebaja.Visible = False
        '
        'txtRebaja
        '
        Me.txtRebaja.Location = New System.Drawing.Point(274, 208)
        Me.txtRebaja.Name = "txtRebaja"
        Me.txtRebaja.Size = New System.Drawing.Size(100, 20)
        Me.txtRebaja.TabIndex = 12
        Me.txtRebaja.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(72, 309)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(224, 309)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Items.AddRange(New Object() {"Informática", "Imagen", "Telefonía", "Sonido"})
        Me.cbCategoria.Location = New System.Drawing.Point(99, 130)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbCategoria.TabIndex = 15
        '
        'Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 375)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtRebaja)
        Me.Controls.Add(Me.lblRebaja)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.txtExistencias)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta"
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents gbTipo As GroupBox
    Friend WithEvents rbArticuloReba As RadioButton
    Friend WithEvents rbArticulo As RadioButton
    Friend WithEvents lblRebaja As Label
    Friend WithEvents txtRebaja As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cbCategoria As ComboBox
End Class
