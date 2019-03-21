<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquilar
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
        Me.gbAlquilar = New System.Windows.Forms.GroupBox()
        Me.txtcodigoAlquilar = New System.Windows.Forms.TextBox()
        Me.lblCodigoAlquilar = New System.Windows.Forms.Label()
        Me.txtfechaalquiler = New System.Windows.Forms.TextBox()
        Me.txtcodcliAlquilar = New System.Windows.Forms.TextBox()
        Me.lblFechaAlquiler = New System.Windows.Forms.Label()
        Me.lblcodcliAlquiler = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbAlquilar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAlquilar
        '
        Me.gbAlquilar.Controls.Add(Me.btnVolver)
        Me.gbAlquilar.Controls.Add(Me.btnAceptar)
        Me.gbAlquilar.Controls.Add(Me.txtfechaalquiler)
        Me.gbAlquilar.Controls.Add(Me.txtcodcliAlquilar)
        Me.gbAlquilar.Controls.Add(Me.lblFechaAlquiler)
        Me.gbAlquilar.Controls.Add(Me.lblcodcliAlquiler)
        Me.gbAlquilar.Controls.Add(Me.txtcodigoAlquilar)
        Me.gbAlquilar.Controls.Add(Me.lblCodigoAlquilar)
        Me.gbAlquilar.Location = New System.Drawing.Point(42, 34)
        Me.gbAlquilar.Name = "gbAlquilar"
        Me.gbAlquilar.Size = New System.Drawing.Size(334, 352)
        Me.gbAlquilar.TabIndex = 0
        Me.gbAlquilar.TabStop = False
        Me.gbAlquilar.Text = "Alquilar"
        '
        'txtcodigoAlquilar
        '
        Me.txtcodigoAlquilar.Location = New System.Drawing.Point(150, 45)
        Me.txtcodigoAlquilar.Name = "txtcodigoAlquilar"
        Me.txtcodigoAlquilar.Size = New System.Drawing.Size(120, 20)
        Me.txtcodigoAlquilar.TabIndex = 5
        '
        'lblCodigoAlquilar
        '
        Me.lblCodigoAlquilar.AutoSize = True
        Me.lblCodigoAlquilar.Location = New System.Drawing.Point(36, 48)
        Me.lblCodigoAlquilar.Name = "lblCodigoAlquilar"
        Me.lblCodigoAlquilar.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigoAlquilar.TabIndex = 4
        Me.lblCodigoAlquilar.Text = "Código:"
        '
        'txtfechaalquiler
        '
        Me.txtfechaalquiler.Location = New System.Drawing.Point(150, 141)
        Me.txtfechaalquiler.Name = "txtfechaalquiler"
        Me.txtfechaalquiler.Size = New System.Drawing.Size(120, 20)
        Me.txtfechaalquiler.TabIndex = 16
        '
        'txtcodcliAlquilar
        '
        Me.txtcodcliAlquilar.Location = New System.Drawing.Point(150, 93)
        Me.txtcodcliAlquilar.Name = "txtcodcliAlquilar"
        Me.txtcodcliAlquilar.Size = New System.Drawing.Size(120, 20)
        Me.txtcodcliAlquilar.TabIndex = 15
        '
        'lblFechaAlquiler
        '
        Me.lblFechaAlquiler.AutoSize = True
        Me.lblFechaAlquiler.Location = New System.Drawing.Point(36, 141)
        Me.lblFechaAlquiler.Name = "lblFechaAlquiler"
        Me.lblFechaAlquiler.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaAlquiler.TabIndex = 14
        Me.lblFechaAlquiler.Text = "Fecha de Alquiler:"
        '
        'lblcodcliAlquiler
        '
        Me.lblcodcliAlquiler.AutoSize = True
        Me.lblcodcliAlquiler.Location = New System.Drawing.Point(36, 93)
        Me.lblcodcliAlquiler.Name = "lblcodcliAlquiler"
        Me.lblcodcliAlquiler.Size = New System.Drawing.Size(78, 13)
        Me.lblcodcliAlquiler.TabIndex = 13
        Me.lblcodcliAlquiler.Text = "Código Cliente:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(101, 211)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 33)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(101, 267)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(101, 33)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Alquilar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbAlquilar)
        Me.Name = "Alquilar"
        Me.Text = "Alquilar"
        Me.gbAlquilar.ResumeLayout(False)
        Me.gbAlquilar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAlquilar As GroupBox
    Friend WithEvents txtcodigoAlquilar As TextBox
    Friend WithEvents lblCodigoAlquilar As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtfechaalquiler As TextBox
    Friend WithEvents txtcodcliAlquilar As TextBox
    Friend WithEvents lblFechaAlquiler As Label
    Friend WithEvents lblcodcliAlquiler As Label
End Class
