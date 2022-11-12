<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIQUIDACION
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
        Me.resTotal = New System.Windows.Forms.Label()
        Me.resPrecio = New System.Windows.Forms.Label()
        Me.resCantidad = New System.Windows.Forms.Label()
        Me.resArticulo = New System.Windows.Forms.Label()
        Me.resNombre = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resTotal
        '
        Me.resTotal.AutoSize = True
        Me.resTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resTotal.Location = New System.Drawing.Point(149, 238)
        Me.resTotal.Name = "resTotal"
        Me.resTotal.Size = New System.Drawing.Size(19, 13)
        Me.resTotal.TabIndex = 27
        Me.resTotal.Text = "..."
        '
        'resPrecio
        '
        Me.resPrecio.AutoSize = True
        Me.resPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resPrecio.Location = New System.Drawing.Point(224, 176)
        Me.resPrecio.Name = "resPrecio"
        Me.resPrecio.Size = New System.Drawing.Size(19, 13)
        Me.resPrecio.TabIndex = 26
        Me.resPrecio.Text = "..."
        '
        'resCantidad
        '
        Me.resCantidad.AutoSize = True
        Me.resCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resCantidad.Location = New System.Drawing.Point(111, 176)
        Me.resCantidad.Name = "resCantidad"
        Me.resCantidad.Size = New System.Drawing.Size(19, 13)
        Me.resCantidad.TabIndex = 25
        Me.resCantidad.Text = "..."
        '
        'resArticulo
        '
        Me.resArticulo.AutoSize = True
        Me.resArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resArticulo.Location = New System.Drawing.Point(119, 115)
        Me.resArticulo.Name = "resArticulo"
        Me.resArticulo.Size = New System.Drawing.Size(19, 13)
        Me.resArticulo.TabIndex = 24
        Me.resArticulo.Text = "..."
        '
        'resNombre
        '
        Me.resNombre.AutoSize = True
        Me.resNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resNombre.Location = New System.Drawing.Point(119, 54)
        Me.resNombre.Name = "resNombre"
        Me.resNombre.Size = New System.Drawing.Size(19, 13)
        Me.resNombre.TabIndex = 23
        Me.resNombre.Text = "..."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(89, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 39)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "VER LISTAS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TOTAL ABONAR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "PRECIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CANTIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NOMBRE DEL ARTICULO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NOMBRE DEL CLIENTE"
        '
        'LIQUIDACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 387)
        Me.Controls.Add(Me.resTotal)
        Me.Controls.Add(Me.resPrecio)
        Me.Controls.Add(Me.resCantidad)
        Me.Controls.Add(Me.resArticulo)
        Me.Controls.Add(Me.resNombre)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LIQUIDACION"
        Me.Text = "LIQUIDACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resTotal As System.Windows.Forms.Label
    Friend WithEvents resPrecio As System.Windows.Forms.Label
    Friend WithEvents resCantidad As System.Windows.Forms.Label
    Friend WithEvents resArticulo As System.Windows.Forms.Label
    Friend WithEvents resNombre As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
