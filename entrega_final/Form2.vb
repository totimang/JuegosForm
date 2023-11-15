Public Class FrmEjercicios

    Private Sub BtnExamen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExamen.Click
        FrmCiudades.Show()

    End Sub

    Private Sub BtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInicio.Click
        FrmInicio.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAritmetica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAritmetica.Click
        FrmAritmetica.Show()
    End Sub

    Private Sub BtnAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnimales.Click
        FrmAnimales.Show()
    End Sub
    Private Sub BtnCanciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCanciones.Click
        FrmCanciones.Show()
    End Sub
End Class