Public Class FrmCanciones
    Dim tiempo, libre, todos, cristal As String
    Dim service, maquinas, nena As String
    Dim no, quizas, logre As String
    Private Sub BtnVerificar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar1.Click
        tiempo = TxtTiempo.Text
        libre = TxtLibre.Text
        todos = TxtTodos.Text
        cristal = TxtCristal.Text

        If tiempo = "tiempo" And libre = "libre" And todos = "todos" And cristal = "cristal" Then
            MsgBox("Hubo un tiempo que fue hermoso," & vbNewLine & "y fui libre de verdad." & vbNewLine & "Guardaba todos mis sueños," & vbNewLine & "en castillos de cristal." & vbNewLine & "♪ ♫ ♫", , "Canción para mi muerte")
        Else
            MsgBox("Corregir las palabras", MsgBoxStyle.Critical, "Canción para mi muerte")
        End If
    End Sub
    Private Sub BtnVerificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar2.Click
        service = TxtService.Text
        maquinas = TxtMaquinas.Text
        nena = TxtNena.Text

        If service = "service" And maquinas = "maquinas" And nena = "nena" Then
            MsgBox("Decidí hacer un service y llame a mi amiga Viví," & vbNewLine & "que de maquinas entiende un 'vagón'," & vbNewLine & "desde entonces, nena, saco a pasear a las dos." & vbNewLine & "♪ ♫ ♫", , "Mi maquina mecánica")
        Else
            MsgBox("Corregir las palabras", MsgBoxStyle.Critical, "Mi maquina mecánica")
        End If
    End Sub
    Private Sub BtnVerificar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificar3.Click
        no = TxtNo.Text
        quizas = TxtQuizas.Text
        logre = TxtLogre.Text

        If no = "No" And quizas = "quizás" And logre = "logre" Then
            MsgBox("No llores más, dame la mano contame tu suerte" & vbNewLine & "de esta manera quizás no sea la muerte," & vbNewLine & "la que nos logre apagar el dolor." & vbNewLine & "♪ ♫ ♫", , "El final es en donde partí")
        Else
            MsgBox("Corregir las palabras", MsgBoxStyle.Critical, "El final es en donde partí")
        End If
    End Sub

    Private Sub BtnLimpiar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar1.Click
        TxtTiempo.Clear()
        TxtLibre.Clear()
        TxtTodos.Clear()
        TxtCristal.Clear()
    End Sub
    Private Sub BtnLimpiar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar2.Click
        TxtService.Clear()
        TxtMaquinas.Clear()
        TxtNena.Clear()
    End Sub
    Private Sub BtnLimpiar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar3.Click
        TxtNo.Clear()
        TxtQuizas.Clear()
        TxtLogre.Clear()
    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnterior.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class