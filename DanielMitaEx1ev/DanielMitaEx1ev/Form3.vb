Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cont = 0
        cont2 = 0

    End Sub


    Private Sub Botones_Click(sender As Object, e As EventArgs) Handles btnUno.Click, btnDos.Click, btnTres.Click,
            btnCuatro.Click, btnCinco.Click, btnSeis.Click, btnSiete.Click, btnOcho.Click, btnNueve.Click, btnCero.Click

        Dim botonPulsado As Button = CType(sender, Button)

        If (cont < 4 And cont >= 0) Then

            txtClave.Text += botonPulsado.Text
            auxiliarClave += botonPulsado.Text
            cont += 1

        End If

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'reseteamos cont para que nos permita seguir pulsando
        cont = 0
        txtClave.Clear()
        'aumentamos cont2 para que nos permita realizar solo 3 intentos
        cont2 += 1

        Dim nombre As String = Form2.txtNombre.Text
        Dim clave As Integer = Val(auxiliarClave)

        'comprobamos que no hemos superado los 3 intentos
        If (cont2 < 3 And cont2 >= 0) Then

            If (comprobarClave(clave, nombre)) Then
                Me.Hide()
                Form4.Show()
            Else
                MsgBox("Incorrecto, vuelve ha introducir la clave")
            End If

        Else
            MsgBox("Ha realizado demasiados intentos. Adios")
            'bloqueamos cliente, me falta desbloquear, no me ha dado tiempo, aunque se hace igual
            Dim pos As Integer = Val(devolverIndice(Form2.txtNombre.Text))
            array(pos).bloqueoCli = True
            Me.Hide()
            Form1.Show()
        End If

        'Reseteamos el auxiliar ya que si no, se produce desbordamiento
        auxiliarClave = ""


    End Sub

    Private Sub btnCancelar3_Click(sender As Object, e As EventArgs) Handles btnCancelar3.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class