<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARTICULOS
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
        Me.rdDoce = New System.Windows.Forms.RadioButton()
        Me.bttContinuar = New System.Windows.Forms.Button()
        Me.bttCalculo = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.rdSeis = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdOtra = New System.Windows.Forms.RadioButton()
        Me.selectArticulos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdDoce
        '
        Me.rdDoce.AutoSize = True
        Me.rdDoce.Location = New System.Drawing.Point(46, 80)
        Me.rdDoce.Name = "rdDoce"
        Me.rdDoce.Size = New System.Drawing.Size(37, 17)
        Me.rdDoce.TabIndex = 1
        Me.rdDoce.TabStop = True
        Me.rdDoce.Text = "12"
        Me.rdDoce.UseVisualStyleBackColor = True
        '
        'bttContinuar
        '
        Me.bttContinuar.Location = New System.Drawing.Point(230, 213)
        Me.bttContinuar.Name = "bttContinuar"
        Me.bttContinuar.Size = New System.Drawing.Size(96, 39)
        Me.bttContinuar.TabIndex = 36
        Me.bttContinuar.Tag = "V"
        Me.bttContinuar.Text = "CONTINUAR"
        Me.bttContinuar.UseVisualStyleBackColor = True
        '
        'bttCalculo
        '
        Me.bttCalculo.Location = New System.Drawing.Point(15, 213)
        Me.bttCalculo.Name = "bttCalculo"
        Me.bttCalculo.Size = New System.Drawing.Size(96, 39)
        Me.bttCalculo.TabIndex = 35
        Me.bttCalculo.Text = "CALCULO"
        Me.bttCalculo.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(15, 115)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(148, 20)
        Me.txtPrecio.TabIndex = 34
        Me.txtPrecio.Text = "(Ingrese Precio Unitario)"
        '
        'rdSeis
        '
        Me.rdSeis.AutoSize = True
        Me.rdSeis.Location = New System.Drawing.Point(46, 42)
        Me.rdSeis.Name = "rdSeis"
        Me.rdSeis.Size = New System.Drawing.Size(31, 17)
        Me.rdSeis.TabIndex = 0
        Me.rdSeis.TabStop = True
        Me.rdSeis.Text = "6"
        Me.rdSeis.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdOtra)
        Me.GroupBox2.Controls.Add(Me.rdDoce)
        Me.GroupBox2.Controls.Add(Me.rdSeis)
        Me.GroupBox2.Location = New System.Drawing.Point(199, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 154)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UNIDADES"
        '
        'rdOtra
        '
        Me.rdOtra.AutoSize = True
        Me.rdOtra.Location = New System.Drawing.Point(46, 117)
        Me.rdOtra.Name = "rdOtra"
        Me.rdOtra.Size = New System.Drawing.Size(55, 17)
        Me.rdOtra.TabIndex = 2
        Me.rdOtra.TabStop = True
        Me.rdOtra.Text = "OTRA"
        Me.rdOtra.UseVisualStyleBackColor = True
        '
        'selectArticulos
        '
        Me.selectArticulos.FormattingEnabled = True
        Me.selectArticulos.Items.AddRange(New Object() {"(Carga por Diseño)", "BLOCK LISO ", "BLOCK RAYADO", "CARPETA", "CUADERNO", "LAPICERA", "LAPIZ NEGRO"})
        Me.selectArticulos.Location = New System.Drawing.Point(15, 52)
        Me.selectArticulos.Name = "selectArticulos"
        Me.selectArticulos.Size = New System.Drawing.Size(148, 21)
        Me.selectArticulos.TabIndex = 32
        Me.selectArticulos.Text = "Seleccione Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ARTICULOS:"
        '
        'ARTICULOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 299)
        Me.Controls.Add(Me.bttContinuar)
        Me.Controls.Add(Me.bttCalculo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.selectArticulos)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ARTICULOS"
        Me.Text = "ARTICULOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdDoce As System.Windows.Forms.RadioButton
    Friend WithEvents bttContinuar As System.Windows.Forms.Button
    Friend WithEvents bttCalculo As System.Windows.Forms.Button
    Friend WithEvents txtPrecio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rdSeis As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents selectArticulos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdOtra As System.Windows.Forms.RadioButton
End Class
