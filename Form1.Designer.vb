<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.bttFin = New System.Windows.Forms.Button()
        Me.bttSiguiente = New System.Windows.Forms.Button()
        Me.bttListas = New System.Windows.Forms.Button()
        Me.bttCargar = New System.Windows.Forms.Button()
        Me.rdCuotas = New System.Windows.Forms.RadioButton()
        Me.rdEfectivo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttFin
        '
        Me.bttFin.Location = New System.Drawing.Point(136, 276)
        Me.bttFin.Name = "bttFin"
        Me.bttFin.Size = New System.Drawing.Size(96, 39)
        Me.bttFin.TabIndex = 38
        Me.bttFin.Text = "FIN"
        Me.bttFin.UseVisualStyleBackColor = True
        '
        'bttSiguiente
        '
        Me.bttSiguiente.Location = New System.Drawing.Point(252, 218)
        Me.bttSiguiente.Name = "bttSiguiente"
        Me.bttSiguiente.Size = New System.Drawing.Size(96, 39)
        Me.bttSiguiente.TabIndex = 37
        Me.bttSiguiente.Text = "SIGUIENTE"
        Me.bttSiguiente.UseVisualStyleBackColor = True
        '
        'bttListas
        '
        Me.bttListas.Location = New System.Drawing.Point(136, 218)
        Me.bttListas.Name = "bttListas"
        Me.bttListas.Size = New System.Drawing.Size(96, 39)
        Me.bttListas.TabIndex = 36
        Me.bttListas.Text = "VER LISTAS"
        Me.bttListas.UseVisualStyleBackColor = True
        '
        'bttCargar
        '
        Me.bttCargar.Location = New System.Drawing.Point(21, 218)
        Me.bttCargar.Name = "bttCargar"
        Me.bttCargar.Size = New System.Drawing.Size(96, 39)
        Me.bttCargar.TabIndex = 35
        Me.bttCargar.Text = "CARGA"
        Me.bttCargar.UseVisualStyleBackColor = True
        '
        'rdCuotas
        '
        Me.rdCuotas.AutoSize = True
        Me.rdCuotas.Location = New System.Drawing.Point(178, 145)
        Me.rdCuotas.Name = "rdCuotas"
        Me.rdCuotas.Size = New System.Drawing.Size(74, 17)
        Me.rdCuotas.TabIndex = 34
        Me.rdCuotas.TabStop = True
        Me.rdCuotas.Text = "En Cuotas"
        Me.rdCuotas.UseVisualStyleBackColor = True
        '
        'rdEfectivo
        '
        Me.rdEfectivo.AutoSize = True
        Me.rdEfectivo.Location = New System.Drawing.Point(178, 122)
        Me.rdEfectivo.Name = "rdEfectivo"
        Me.rdEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rdEfectivo.TabIndex = 33
        Me.rdEfectivo.TabStop = True
        Me.rdEfectivo.Text = "Efectivo"
        Me.rdEfectivo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "FORMA DE PAGO:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(104, 53)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "NOMBRE DEL CLIENTE"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 338)
        Me.Controls.Add(Me.bttFin)
        Me.Controls.Add(Me.bttSiguiente)
        Me.Controls.Add(Me.bttListas)
        Me.Controls.Add(Me.bttCargar)
        Me.Controls.Add(Me.rdCuotas)
        Me.Controls.Add(Me.rdEfectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Login"
        Me.Text = "Cargar Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttFin As System.Windows.Forms.Button
    Friend WithEvents bttSiguiente As System.Windows.Forms.Button
    Friend WithEvents bttListas As System.Windows.Forms.Button
    Friend WithEvents bttCargar As System.Windows.Forms.Button
    Friend WithEvents rdCuotas As System.Windows.Forms.RadioButton
    Friend WithEvents rdEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
