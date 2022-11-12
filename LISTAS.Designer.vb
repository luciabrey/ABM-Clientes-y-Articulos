<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTAS
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
        Me.bttVolver = New System.Windows.Forms.Button()
        Me.listCuotas = New System.Windows.Forms.ListView()
        Me.listEfectivo = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttVolver
        '
        Me.bttVolver.Location = New System.Drawing.Point(126, 299)
        Me.bttVolver.Name = "bttVolver"
        Me.bttVolver.Size = New System.Drawing.Size(96, 39)
        Me.bttVolver.TabIndex = 14
        Me.bttVolver.Text = "VOLVER"
        Me.bttVolver.UseVisualStyleBackColor = True
        '
        'listCuotas
        '
        Me.listCuotas.Location = New System.Drawing.Point(198, 56)
        Me.listCuotas.Name = "listCuotas"
        Me.listCuotas.Size = New System.Drawing.Size(129, 225)
        Me.listCuotas.TabIndex = 13
        Me.listCuotas.UseCompatibleStateImageBehavior = False
        '
        'listEfectivo
        '
        Me.listEfectivo.Location = New System.Drawing.Point(15, 56)
        Me.listEfectivo.Name = "listEfectivo"
        Me.listEfectivo.Size = New System.Drawing.Size(129, 225)
        Me.listEfectivo.TabIndex = 12
        Me.listEfectivo.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PAGO EN CUOTAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PAGO EFECTIVO"
        '
        'LISTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 364)
        Me.Controls.Add(Me.bttVolver)
        Me.Controls.Add(Me.listCuotas)
        Me.Controls.Add(Me.listEfectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LISTAS"
        Me.Text = "LISTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttVolver As System.Windows.Forms.Button
    Friend WithEvents listCuotas As System.Windows.Forms.ListView
    Friend WithEvents listEfectivo As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
