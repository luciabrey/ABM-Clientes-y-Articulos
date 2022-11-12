Public Class LISTAS
    Dim si As Integer

    Private Sub LISTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LIQUIDACION.Hide()
        Login.Hide()
    End Sub

    Public Sub bttVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttVolver.Click
        si = 1
        Login.Show()
    End Sub
End Class