Public Class Login
    Dim Nombre As Label
    Dim Presionado As Integer

    Private Sub bttListas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttListas.Click
        bttCargar.Enabled = True
        LISTAS.Show()

    End Sub

    Private Sub bttSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSiguiente.Click
        If Presionado <> 1 Then
            Do
                MsgBox("Presione CARGAR, para continuar")
            Loop While Presionado = 1
        Else
            bttCargar.Enabled = True
            ARTICULOS.Show()
        End If


    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LISTAS.Hide()
    End Sub

    Private Sub bttCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCargar.Click

        'Enviamos el Nombre al Form LIQUIDACION
        LIQUIDACION.resNombre.Text = txtNombre.Text

        If rdCuotas.Checked = True Or rdEfectivo.Checked = True Then
            bttCargar.Enabled = False
        End If

        Presionado = 1
    End Sub

    Private Sub bttFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttFin.Click
        End
    End Sub
End Class
