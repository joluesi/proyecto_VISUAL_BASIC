Public Class Form1

    Dim num1 As String = "0"
    Dim num2 As String = "0"
    Dim numAux As String = "0"
    Dim oper As String
    Dim opeAux As String
    Dim cont As Integer = 1
    Dim sinCalcular As Boolean = False

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        If (cont = 1) Then
            'Procedimiento NORMAL
            num2 = txtPantalla.Text
            If oper.Equals("+") Then
                txtPantalla.Text = Suma(num1, num2)
                numAux = num2
                opeAux = "+"
                cont = 0

            ElseIf oper.Equals("-") Then
                txtPantalla.Text = Resta(num1, num2)
                numAux = num2
                opeAux = "-"
                cont = 0

            ElseIf oper.Equals("*") Then
                txtPantalla.Text = Multiplica(num1, num2)
                numAux = num2
                opeAux = "*"
                cont = 0

            ElseIf oper.Equals("/") Then
                txtPantalla.Text = Divide(num1, num2)
                numAux = num2
                opeAux = "/"
                cont = 0
            End If

        Else
            'Resultado recursivo
            numAux = num2
            num1 = txtPantalla.Text
            If oper.Equals("+") Then
                txtPantalla.Text = Suma(num1, numAux)
                opeAux = "+"
                cont = 0
            ElseIf oper.Equals("-") Then
                txtPantalla.Text = Resta(num1, numAux)
                opeAux = "-"
                cont = 0
            ElseIf oper.Equals("*") Then
                txtPantalla.Text = Multiplica(num1, numAux)
                opeAux = "*"
                cont = 0
            ElseIf oper.Equals("/") Then
                txtPantalla.Text = Divide(num1, numAux)
                opeAux = "/"
                cont = 0

            End If
        End If
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
       If num2.Equals("") Then
            If cont=0 Then
                oper = "/"
            Else
                CalcularAnterior
                oper = "/"
            End If
        Else
             'Procedimiento normal
              num2 = ""
            num1 = txtPantalla.Text
            oper = "/"
            opeAux = "/"
            cont = 0
        End If
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)
    End Sub


    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click

       If num2.Equals("") Then
            If cont=0 Then
                oper = "*"
            Else
                CalcularAnterior
                oper = "*"
            End If
        Else
            'Procedimiento normal
            num2 = ""
            num1 = txtPantalla.Text
            oper = "*"
            opeAux = "*"
            cont = 0
        End If
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click

        If num2.Equals("") Then
            If cont=0 Then
                oper = "-"
            Else
                CalcularAnterior
                oper = "-"
            End If
        Else
            'Procedimiento normal
            num2 = ""
            num1 = txtPantalla.Text
            oper = "-"
            opeAux = "-"
            cont = 0
        End If
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        If num2.Equals("") Then
            If cont=0 Then
                oper = "+"
            Else
                CalcularAnterior
                oper = "+"
            End If
        Else
            'Procedimiento normal
            num2 = ""
            num1 = txtPantalla.Text
            oper = "+"
            opeAux = "+"
            cont = 0
        End If


        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)

    End Sub

    Private Function CalcularAnterior()
         If (txtPantalla.Text.Equals("")) Then
                txtPantalla.Text = 0
            Else
                numAux = txtPantalla.Text
                Select Case oper
                    Case "+"
                        txtPantalla.Text = Suma(num1, numAux)
                    Case "-"
                        txtPantalla.Text = Resta(num1, numAux)
                    Case "*"
                        txtPantalla.Text = Multiplica(num1, numAux)
                    Case "/"
                        txtPantalla.Text = Divide(num1, numAux)
                End Select
                num1 = txtPantalla.Text              
                cont = 0
            End If
    End Function

    Private Function EscribeNum(ByVal text As String)
        If cont = 1 Then
            Dim texto As String = txtPantalla.Text           
            txtPantalla.Text = texto  & text
        Else
            txtPantalla.Text = text
            cont = 1
        End If
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)
    End Function

    Private Sub ButNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click,
            btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

               Dim esteBoton As Button = CType(sender, Button)
                EscribeNum(esteBoton.Text)
        End Sub


    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If cont = 1 Then
            Dim texto As String = txtPantalla.Text       
            txtPantalla.Text = texto & "0"       
        Else
            txtPantalla.Text = "0"
            cont = 1
        End If
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        Me.Hide()
        Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        num1 = "0"
        num2 = "0"
        numAux = "0"
        oper = " "
        opeAux = " "
        cont = 1
        txtPantalla.Text = ""
        txtDepurar.Text = Depura(num1, num2, numAux, CStr(cont), oper, opeAux)
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If txtPantalla.Text.Equals("") Then
            txtPantalla.Text = "0,"
        Else
            If txtPantalla.Text.Contains(",") Then
            Else
                Dim texto As String = txtPantalla.Text
                txtPantalla.Text = texto & ","
            End If
        End If
    End Sub

    Private Sub btnSigno_Click(sender As Object, e As EventArgs) Handles btnSigno.Click
        If txtPantalla.Text.Equals("") Then
        Else
            Dim texto As String = txtPantalla.Text
            txtPantalla.Text = CambiaSigno(texto)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then
            EscribeNum("1")
        End If
        If e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then
            EscribeNum("2")
        End If
        If e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then
            EscribeNum("3")
        End If
        If e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then
            EscribeNum("4")
        End If
        If e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then
            EscribeNum("5")
        End If
        If e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then
            EscribeNum("6")
        End If
        If e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then
            EscribeNum("7")
        End If
        If e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then
            EscribeNum("8")
        End If
        If e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then
            EscribeNum("9")
        End If
        If e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.Oemcomma Then
            btnPunto.PerformClick()
        End If
        If e.KeyCode = Keys.Multiply Then
            btnMultiplicar.PerformClick()
        End If
        If e.KeyCode = Keys.Divide Then
            btnDividir.PerformClick()
        End If
        If e.KeyCode = Keys.Oemplus Or e.KeyCode = Keys.Add Then
            btnSuma.PerformClick()
        End If
        If e.KeyCode = Keys.OemMinus Or e.KeyCode = Keys.Subtract Then
            btnResta.PerformClick()
        End If
        If e.KeyCode = Keys.End Or e.KeyCode = Keys.Enter Then
            btnResultado.PerformClick()
        End If
        If e.KeyCode = Keys.Home Then
            btnApagar.PerformClick()
        End If
        If e.KeyCode = Keys.Delete Then
            btnBorrar.PerformClick()
        End If

        If Control.ModifierKeys = Keys.Shift Then
            If e.KeyCode = Keys.Oemplus Then
                btnMultiplicar.PerformClick()
            End If
            If e.KeyCode = Keys.D7 Then
                btnDividir.PerformClick()
            End If
            If e.KeyCode = Keys.D0 Then
                btnDividir.PerformClick()
            End If
        End If



    End Sub
End Class