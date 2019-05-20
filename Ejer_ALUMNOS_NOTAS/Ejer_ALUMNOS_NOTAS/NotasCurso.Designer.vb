<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasCurso
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.cmb_Curso = New System.Windows.Forms.ComboBox()
        Me.rtxtbox_NotasCurso = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Código curso:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(380, 586)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(132, 29)
        Me.btnImprimir.TabIndex = 70
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(594, 586)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 29)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(160, 586)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(132, 29)
        Me.btnSiguiente.TabIndex = 68
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.Location = New System.Drawing.Point(47, 24)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(160, 20)
        Me.lbl_1.TabIndex = 65
        Me.lbl_1.Text = "Notas de Alumnos:"
        '
        'cmb_Curso
        '
        Me.cmb_Curso.FormattingEnabled = True
        Me.cmb_Curso.Items.AddRange(New Object() {"1DAM", "2DAM", "1DAW", "2DAW"})
        Me.cmb_Curso.Location = New System.Drawing.Point(208, 78)
        Me.cmb_Curso.Name = "cmb_Curso"
        Me.cmb_Curso.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Curso.TabIndex = 72
        '
        'rtxtbox_NotasCurso
        '
        Me.rtxtbox_NotasCurso.Location = New System.Drawing.Point(51, 116)
        Me.rtxtbox_NotasCurso.Name = "rtxtbox_NotasCurso"
        Me.rtxtbox_NotasCurso.Size = New System.Drawing.Size(833, 435)
        Me.rtxtbox_NotasCurso.TabIndex = 73
        Me.rtxtbox_NotasCurso.Text = ""
        '
        'NotasCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 658)
        Me.Controls.Add(Me.rtxtbox_NotasCurso)
        Me.Controls.Add(Me.cmb_Curso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.lbl_1)
        Me.Name = "NotasCurso"
        Me.Text = "NotasCurso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents lbl_1 As Label
    Friend WithEvents cmb_Curso As ComboBox
    Friend WithEvents rtxtbox_NotasCurso As RichTextBox
End Class
