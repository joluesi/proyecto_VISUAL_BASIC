<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Devolucion
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
        Me.txtCodDvdDev = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodCliDev = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaAlquiler = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaDevolucion = New System.Windows.Forms.TextBox()
        Me.btnVolverD = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTranscurridos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCodDvdDev
        '
        Me.txtCodDvdDev.Location = New System.Drawing.Point(44, 104)
        Me.txtCodDvdDev.Name = "txtCodDvdDev"
        Me.txtCodDvdDev.Size = New System.Drawing.Size(232, 22)
        Me.txtCodDvdDev.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEVOLUCION DVD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo del DVD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo del cliente"
        '
        'txtCodCliDev
        '
        Me.txtCodCliDev.Location = New System.Drawing.Point(44, 156)
        Me.txtCodCliDev.Name = "txtCodCliDev"
        Me.txtCodCliDev.Size = New System.Drawing.Size(232, 22)
        Me.txtCodCliDev.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha del alquiler"
        '
        'txtFechaAlquiler
        '
        Me.txtFechaAlquiler.Location = New System.Drawing.Point(44, 216)
        Me.txtFechaAlquiler.Name = "txtFechaAlquiler"
        Me.txtFechaAlquiler.Size = New System.Drawing.Size(232, 22)
        Me.txtFechaAlquiler.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de devolucion"
        '
        'txtFechaDevolucion
        '
        Me.txtFechaDevolucion.Location = New System.Drawing.Point(44, 279)
        Me.txtFechaDevolucion.Name = "txtFechaDevolucion"
        Me.txtFechaDevolucion.Size = New System.Drawing.Size(232, 22)
        Me.txtFechaDevolucion.TabIndex = 7
        '
        'btnVolverD
        '
        Me.btnVolverD.Location = New System.Drawing.Point(49, 398)
        Me.btnVolverD.Name = "btnVolverD"
        Me.btnVolverD.Size = New System.Drawing.Size(227, 55)
        Me.btnVolverD.TabIndex = 10
        Me.btnVolverD.Text = "Volver"
        Me.btnVolverD.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dias transcurridos"
        '
        'txtTranscurridos
        '
        Me.txtTranscurridos.Location = New System.Drawing.Point(47, 345)
        Me.txtTranscurridos.Name = "txtTranscurridos"
        Me.txtTranscurridos.Size = New System.Drawing.Size(229, 22)
        Me.txtTranscurridos.TabIndex = 12
        '
        'Devolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 486)
        Me.Controls.Add(Me.txtTranscurridos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnVolverD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFechaDevolucion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFechaAlquiler)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodCliDev)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodDvdDev)
        Me.Name = "Devolucion"
        Me.Text = "Devolucion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodDvdDev As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodCliDev As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaAlquiler As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaDevolucion As TextBox
    Friend WithEvents btnVolverD As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTranscurridos As TextBox
End Class
