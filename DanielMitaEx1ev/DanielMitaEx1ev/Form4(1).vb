Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bool3 = True
    End Sub


    ' botones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn20.Click
        bool3 = True
        txtCantidad.Text = 20
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn50.Click
        bool3 = True
        txtCantidad.Text = 50
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn100.Click
        bool3 = True
        txtCantidad.Text = 100
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn200.Click
        bool3 = True
        txtCantidad.Text = 200
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub


    Private Sub txtCantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyUp
        If (bool3) Then
            txtCantidad.Text = ""
            bool3 = False
        End If

        If (e.KeyValue >= 48 And e.KeyValue <= 57) Then
            txtCantidad.Text += Chr(e.KeyValue)
        End If

    End Sub

    Private Sub btnReintegro_Click(sender As Object, e As EventArgs) Handles btnReintegro.Click


        If (txtCantidad.Text <> String.Empty) Then
            Dim cantidad As Double = Val(txtCantidad.Text)
            Dim nombre As String = Form2.txtNombre.Text

            If (comprobarSaldo(cantidad, nombre)) Then

                Dim pos As Integer = Val(devolverIndice(nombre))
                array(pos).saldoCli -= cantidad
                MsgBox("Operacion realizada con exito")
                Me.Hide()
                Form1.Show()
            Else
                Dim s As String = mostrarSaldo(nombre)
                MsgBox("no tienes saldo suficiente. Actualmente, tienes " & s & "€. Introduce una cantidad valida")

            End If
        Else
            MsgBox("Tiene que introducir una cantidad")
        End If



        txtCantidad.Text = ""


    End Sub

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click
        Dim nombre As String = Form2.txtNombre.Text
        txtCantidad.Text = mostrarSaldo(nombre)

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim nombre As String = Form2.txtNombre.Text
        Dim pos As Integer = Val(devolverIndice(nombre))

        If (txtCantidad.Text <> String.Empty) Then
            array(pos).saldoCli += Val(txtCantidad.Text)
            Dim s As String = mostrarSaldo(nombre)
            MsgBox("Felicidades, ahora su cuenta tiene " & s)
        Else
            MsgBox("Error, tiene que introducir una cantidad")
            txtCantidad.Text = ""
        End If

        txtCantidad.Text = ""

    End Sub

    Private Sub btnCancelar4_Click(sender As Object, e As EventArgs) Handles btnCancelar4.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class