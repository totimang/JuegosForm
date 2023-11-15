Public Class FrmAnimales
    Dim OsoPolar, Pingüino, Caballo, Aguila, Ballena As String
    Private Sub BtnVerificar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar1.Click
        OsoPolar = TxtOsoPolar.Text

        If OsoPolar = "Oso polar" Then
            TxtRes1.Text = OsoPolar
        ElseIf OsoPolar = "oso Polar" Or OsoPolar = "Oso Polar" Then
            MsgBox("Escribir bien la letra mayuscula", MsgBoxStyle.Exclamation, "Animal N°1")
        ElseIf OsoPolar = "oso polar" Then
            MsgBox("Escribir con letra mayuscula", MsgBoxStyle.Exclamation, "Animal N°1")
        ElseIf OsoPolar = "osopolar" Or OsoPolar = "osoPolar" Or OsoPolar = "OsoPolar" Then
            MsgBox("Respetar los espacios", MsgBoxStyle.Exclamation, "Animal N°1")
        Else
            MsgBox("Animal inconrrecto", MsgBoxStyle.Critical, "Animal N°1")
        End If
    End Sub
    Private Sub BtnVerificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar2.Click
        Pingüino = TxtPingüino.Text

        If Pingüino = "Pingüino" Then
            TxtRes2.Text = Pingüino
        ElseIf Pingüino = "pingüino" Then
            MsgBox("Escribir con letra mayuscula", MsgBoxStyle.Exclamation, "Animal N°2")
        Else
            MsgBox("Animal inconrrecto", MsgBoxStyle.Critical, "Animal N°2")
        End If
    End Sub
    Private Sub BtnVerificar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar3.Click
        Caballo = TxtCaballo.Text

        If Caballo = "Caballo" Then
            TxtRes3.Text = Caballo
        ElseIf Caballo = "caballo" Then
            MsgBox("Escribir con letra mayuscula", MsgBoxStyle.Exclamation, "Animal N°3")
        Else
            MsgBox("Animal inconrrecto", MsgBoxStyle.Critical, "Animal N°3")
        End If
    End Sub
    Private Sub BtnVerificar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar4.Click
        Aguila = TxtAguila.Text

        If Aguila = "Águila" Then
            TxtRes4.Text = Aguila
        ElseIf Aguila = "águila" Then
            MsgBox("Escribir con letra mayuscula", MsgBoxStyle.Exclamation, "Animal N°4")
        ElseIf Aguila = "Aguila" Then
            MsgBox("Falta el acento", MsgBoxStyle.Exclamation, "Animal N°4")
        ElseIf Aguila = "aguila" Then
            MsgBox("Escribir con letra mayuscula y con acento", MsgBoxStyle.Exclamation, "Animal N°4")
        Else
            MsgBox("Animal inconrrecto", MsgBoxStyle.Critical, "Animal N°4")
        End If
    End Sub
    Private Sub BtnVerificar5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar5.Click
        Ballena = TxtBallena.Text

        If Ballena = "Ballena" Then
            TxtRes5.Text = Ballena
        ElseIf Ballena = "ballena" Then
            MsgBox("Escribir con letra mayuscula", MsgBoxStyle.Exclamation, "Animal N°5")
        Else
            MsgBox("Animal inconrrecto", MsgBoxStyle.Critical, "Animal N°5")
        End If
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TxtOsoPolar.Clear()
        TxtPingüino.Clear()
        TxtCaballo.Clear()
        TxtAguila.Clear()
        TxtBallena.Clear()
        TxtRes1.Clear()
        TxtRes2.Clear()
        TxtRes3.Clear()
        TxtRes4.Clear()
        TxtRes5.Clear()
    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnterior.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class