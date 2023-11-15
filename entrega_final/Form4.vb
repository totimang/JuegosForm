Public Class FrmAritmetica

    Dim Num1, Num2, Res As Double
    Dim Base, Altura, Hip, Area, Perim As Double
    Dim lado1, lado2, AreaRect, PerimRect As Double
    Dim AreaCuad, PerimCuad As Double
    Dim radio, diametro, AreaCirc, PerimCirc As Double

    Private Sub BtnSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuma.Click
        Num1 = TxtNumero1.Text
        Num2 = TxtNumero2.Text

        Res = Num1 + Num2

        TxtResultado.Text = Res
    End Sub

    Private Sub BtnResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResta.Click
        Num1 = TxtNumero1.Text
        Num2 = TxtNumero2.Text

        Res = Num1 - Num2

        TxtResultado.Text = Res
    End Sub

    Private Sub BtnProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProducto.Click
        Num1 = TxtNumero1.Text
        Num2 = TxtNumero2.Text

        Res = Num1 * Num2

        TxtResultado.Text = Res
    End Sub

    Private Sub BtnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDivision.Click
        Num1 = TxtNumero1.Text
        Num2 = TxtNumero2.Text

        If Num2 <> 0 Then
            Res = Num1 / Num2
            TxtResultado.Text = Res
        Else
            MsgBox("El número 2 no puede ser '0' ", MsgBoxStyle.Exclamation, "División")
        End If
    End Sub

    Private Sub BtnLimpiar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar1.Click
        TxtNumero1.Clear()
        TxtNumero2.Clear()
        TxtResultado.Clear()

    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Base = TxtBase.Text
        Altura = TxtAltura.Text


        If Base > 0 And Altura > 0 Then
            Hip = Math.Sqrt(Base ^ 2 + Altura ^ 2)
            TxtHipotenusa.Text = Hip

            Area = (Base * Altura) / 2
            TxtArea.Text = Area

            Perim = Base + Altura + Hip
            TxtPerimetro.Text = Perim
        Else
            MsgBox("La base ó la altura no pueden ser '0' ", MsgBoxStyle.Exclamation, "Triangulo")
        End If


        
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TxtBase.Clear()
        TxtAltura.Clear()
        TxtHipotenusa.Clear()
        TxtArea.Clear()
        TxtPerimetro.Clear()
    End Sub

    Private Sub BtnCalcularRect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcularRect.Click
        lado1 = TxtLado1.Text
        lado2 = TxtLado2.Text


        If lado1 > 0 And lado2 > 0 And lado1 <> lado2 Then
            AreaRect = lado1 * lado2
            TxtAreaRec.Text = AreaRect

            PerimRect = (lado1 * 2) + (lado2 * 2)
            TxtPerimRect.Text = PerimRect
        ElseIf lado1 <= 0 Or lado2 <= 0 Then
            MsgBox("El lado 1 ó lado 2 no pueden ser '0' ", MsgBoxStyle.Exclamation, "Rectangulo")
        Else
            MsgBox("Los lados no deben ser iguales", MsgBoxStyle.Exclamation, "Rectangulo")
        End If

        
    End Sub

    Private Sub BtnLimpiarRect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarRect.Click
        TxtLado1.Clear()
        TxtLado2.Clear()
        TxtAreaRec.Clear()
        TxtPerimRect.Clear()
    End Sub
    Private Sub BtnCalcularCuad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcularCuad.Click
        lado1 = TxtLadoCuadrado.Text


        If lado1 > 0 Then
            AreaCuad = lado1 * 2
            TxtAreaCuad.Text = AreaCuad

            PerimCuad = lado1 * 4
            TxtPerimCuad.Text = PerimCuad
        Else
            MsgBox("El lado no puede ser '0' ", MsgBoxStyle.Exclamation, "Cuadrado")
        End If
        
    End Sub
    Private Sub BtnLimpiarCuad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarCuad.Click
        TxtLadoCuadrado.Clear()
        TxtAreaCuad.Clear()
        TxtPerimCuad.Clear()
    End Sub
    Private Sub BtnCalcularCirc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcularCirc.Click
        radio = TxtRadio.Text


        If radio > 0 Then
            diametro = 2 * radio
            TxtDiametro.Text = diametro

            AreaCirc = (Math.PI) * (radio ^ 2)
            TxtAreaCirc.Text = AreaCirc

            PerimCirc = Math.PI * diametro
            TxtPerimCirc.Text = PerimCirc
        Else
            MsgBox("El radio no puede ser '0' ", MsgBoxStyle.Exclamation, "Circulo")
        End If

        
    End Sub
    Private Sub BtnLimpiarCirc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarCirc.Click
        TxtRadio.Clear()
        TxtDiametro.Clear()
        TxtAreaCirc.Clear()
        TxtPerimCirc.Clear()
    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnterior.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class