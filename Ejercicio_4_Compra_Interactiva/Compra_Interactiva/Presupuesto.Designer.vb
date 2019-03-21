<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presupuesto
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
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.rtbPresu = New System.Windows.Forms.RichTextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(42, 46)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(101, 13)
        Me.lblPresupuesto.TabIndex = 0
        Me.lblPresupuesto.Text = "Su presupuesto es: "
        '
        'rtbPresu
        '
        Me.rtbPresu.Location = New System.Drawing.Point(45, 78)
        Me.rtbPresu.Name = "rtbPresu"
        Me.rtbPresu.Size = New System.Drawing.Size(701, 254)
        Me.rtbPresu.TabIndex = 1
        Me.rtbPresu.Text = ""
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(333, 370)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(119, 37)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.rtbPresu)
        Me.Controls.Add(Me.lblPresupuesto)
        Me.Name = "Presupuesto"
        Me.Text = "Presupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPresupuesto As Label
    Friend WithEvents rtbPresu As RichTextBox
    Friend WithEvents btnVolver As Button
End Class
