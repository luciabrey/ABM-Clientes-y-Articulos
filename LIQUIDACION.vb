Public Class LIQUIDACION

    Private Sub LIQUIDACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Hide()
        ARTICULOS.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Pregunta As String
        Pregunta = MsgBox("¿DESEA ABANDONAR SU CUENTA?", vbYesNo)
        If Pregunta = vbYes Then
            'Vaciamos todo
            Login.txtNombre.Text = ""
            LISTAS.listEfectivo.Refresh()
            LISTAS.listCuotas.Refresh()
            Login.rdEfectivo.Checked = False
            Login.rdCuotas.Checked = False
            ARTICULOS.rdSeis.Checked = False
            ARTICULOS.rdDoce.Checked = False
            ARTICULOS.rdOtra.Checked = False
        End If
        LISTAS.Show()
    End Sub
End Class