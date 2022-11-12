Public Class ARTICULOS
    Dim NombreArticulo As String
    Dim res, calculo As Integer

    Private Sub ARTICULOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Hide()
    End Sub

    Private Sub bttCalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCalculo.Click
        Dim precio, aux As Integer
        'Obtenemos el Nombre
        NombreArticulo = selectArticulos.Text
        aux = Convert.ToInt32(txtPrecio.Text)

        'Caso de Ser Efectivo
        If Login.rdEfectivo.Checked = True Then
            'Cantidad 6
            If rdSeis.Checked = True Then
                precio = (aux * 6) * 0.15
            End If

            'Cantidad 12
            If rdDoce.Checked = True Then
                precio = (aux * 12) * 0.15
            End If

            'Cantidad OTRA
            If rdOtra.Checked = True Then
                res = InputBox("Cantidad:")
                precio = (aux * res) * 0.15
            End If


            LISTAS.listEfectivo.Items.Add(NombreArticulo, ":")
            LISTAS.listEfectivo.Items.Add(precio)

        End If

        'Caso de Ser Cuotas
        If Login.rdCuotas.Checked = True Then
            'Cantidad 6
            If rdSeis.Checked = True Then
                precio = (aux * 6) / 0.15
            End If

            'Cantidad 12
            If rdSeis.Checked = True Then
                precio = (aux * 12) / 0.15
            End If

            'Cantidad OTRA
            If rdOtra.Checked = True Then
                res = InputBox("Cantidad:")
                precio = (aux * res) / 0.15
            End If



            LISTAS.listCuotas.Items.Add(NombreArticulo, ":")
            LISTAS.listCuotas.Items.Add(aux)
            '6
            If rdSeis.Checked = True Then
                LISTAS.listCuotas.Items.Add("6")
            End If

            '12
            If rdDoce.Checked = True Then
                LISTAS.listCuotas.Items.Add("12")
            End If

        End If

        'Enviamos el Nombre del Articulo
        LIQUIDACION.resArticulo.Text = selectArticulos.Text

        'Enviamos CANTIDAD
        '6
        If rdSeis.Checked = True Then
            LIQUIDACION.resCantidad.Text = "6"
        End If

        '12
        If rdDoce.Checked = True Then
            LIQUIDACION.resCantidad.Text = "12"
        End If

        'Otra   

        If rdOtra.Checked = True Then
            LIQUIDACION.resCantidad.Text = res
        End If


        'Enviamos PRECIO
        LIQUIDACION.resPrecio.Text = aux

        'Eviamos TOTAL
        LIQUIDACION.resTotal.Text = precio


        MsgBox("Cargado!")
        calculo = 1
    End Sub

    Private Sub bttContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttContinuar.Click
        If calculo <> 1 Then
            bttContinuar.Enabled = False
        Else
            txtPrecio.Text = "(Ingrese Precio Unitario)"
            rdSeis.Checked = False
            rdDoce.Checked = False
            rdOtra.Checked = False
            selectArticulos.SelectedIndex = -1
            LIQUIDACION.Show()
        End If

    End Sub

    Private Sub txtPrecio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.Click
        txtPrecio.Text = ""
    End Sub
End Class