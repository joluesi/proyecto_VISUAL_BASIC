Public Class Form1


    Dim cont As Integer
    Private Sub mItemCrearArray_Click(sender As Object, e As EventArgs) Handles mItemCrearArray.Click
        For i = 0 To 4
            ReDim Preserve clientes(i)
            clientes(i).codCli = i
            clientes(i).nombreCli = "Alejandro" & i
            clientes(i).bloqueoCli = False
            clientes(i).claveCli = 4320 + i
            clientes(i).saldoCli = 0
        Next
        For i = 0 To 4
            MsgBox("-Cod:" & clientes(i).codCli & "  -Nombre: " & clientes(i).nombreCli & "  -Bloqueo: " & clientes(i).bloqueoCli & "  -Clave: " & clientes(i).claveCli & "  -Saldo: " & clientes(i).saldoCli)
        Next


    End Sub

    Private Sub mItemCajero_Click(sender As Object, e As EventArgs) Handles mItemCajero.Click
        gpbCliente.Visible = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim encontrado As Boolean = False
        Dim bloqueado As Boolean = False
        For i = 0 To 4
            If txtCliente.Text.ToString.Equals(clientes(i).nombreCli) Then
                encontrado = True
                If clientes(i).bloqueoCli = True Then
                    bloqueado = True
                Else
                    bloqueado = False
                    clienteActivo = clientes(i)
                    cont = 0
                End If
            End If
        Next
        If encontrado = False Then
            MsgBox("No se encuentra el usuario. Vuelve a intentarlo")
            txtCliente.Text = ""
        Else
            If bloqueado = True Then
                MsgBox("Usuario bloqueado")
                txtCliente.Text = ""
            Else
                grbBotones.Visible = True
            End If

        End If

    End Sub

    Private Function EscribeNum(ByVal text As String)
        Dim texto As String = txtClave.Text
        txtClave.Text = texto & text
        txtClave.Text = txtClave.Text & text

    End Function

    Private Sub ButNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click,
            btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim esteBoton As Button = CType(sender, Button)
        EscribeNum(esteBoton.Text)
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If cont >= 2 Then
            MsgBox("Número de intentos excedido. Usuario bloqueado")
            For i = 0 To 4 'Actualiza array
                If clienteActivo.codCli.Equals(clientes(i).codCli) Then
                    clientes(i).bloqueoCli = True
                End If
            Next
            grbBotones.Visible = False

        Else
            If txtClave.Text.Length = 4 Then

                If txtClave.Text.ToString.Equals(clienteActivo.claveCli.ToString) Then
                    'Clave Correcta
                    cont = 0
                    Me.Hide()
                    Cajero.Show()
                Else
                    MsgBox("Clave Incorrecta")
                    txtClave.Text = ""
                    cont = cont + 1
                End If
            Else
                MsgBox("Introduce la clave de 4 digitos")
                cont = cont + 1
                txtClave.Text = ""
            End If

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpbCliente.Visible = False
        grbBotones.Visible = False
        gpbDesbloqueo.Visible = False
    End Sub

    Private Sub mItemDesbloquear_Click(sender As Object, e As EventArgs) Handles mItemDesbloquear.Click
        Dim encontrado As Boolean = False
        For i = 0 To 4
            If clientes(i).codCli.Equals(txtCodigo.Text.ToString) Then
                If clientes(i).claveCli.Equals(txtClav.Text.ToString) Then
                    encontrado = True
                    If clientes(i).bloqueoCli = True Then
                        clientes(i).bloqueoCli = False
                    Else
                        MsgBox("La cuenta de este cliente no esta bloqueada")
                    End If
                End If
            End If
        Next
        If encontrado = True Then
            MsgBox("El cliente no ha sido encontrado o la clave es incorrecta")

        End If
    End Sub

    Private Sub mItemAcercaDe_Click(sender As Object, e As EventArgs) Handles mItemAcercaDe.Click
        MsgBox("Alejandro Motellón Martínez, Nº 23")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Close()

    End Sub
End Class
