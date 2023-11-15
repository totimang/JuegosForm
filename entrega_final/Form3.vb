Public Class FrmCiudades
    Dim correctas As Integer
    Dim incorrectas As Integer

    Private Sub BtnVerificar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar1.Click

        If RbCorrecto1.Checked Then
            correctas = correctas + 1
            LblCorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            LblIncorrecta.Text = incorrectas
        End If
        GroupBox1.Enabled = False
    End Sub

    Private Sub BtnVerificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar2.Click

        If RbCorrecto2.Checked Then
            correctas = correctas + 1
            LblCorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            LblIncorrecta.Text = incorrectas
        End If
        GroupBox2.Enabled = False
    End Sub

    Private Sub BtnVerificar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar3.Click

        If RbCorrecta3.Checked Then
            correctas = correctas + 1
            LblCorrecta.Text = correctas
        Else
            incorrectas = incorrectas + 1
            LblIncorrecta.Text = incorrectas
        End If
        GroupBox3.Enabled = False
    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnterior.Click
        Me.Close()
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class