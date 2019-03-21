Public Class Listados
    Private Sub btnListadoXCliente_Click(sender As Object, e As EventArgs) Handles btnListadoXCliente.Click

        Dim opcion As String = InputBox("Introduce codigo del cliente")
        Dim cadenaDVD As String = ""
        Dim boolDVD As Boolean = True

        If opcion <> "" Then
            If ifExisteCodCliEnColeccionClientes(opcion) Then 'comprobamos que existe el cliente

                For i As Integer = 0 To arrayDvd.Length - 1
                    ' si el codigo cliente del array es igual que el codigo cliente introducido, significa que el cliente tiene alquilado
                    ' algun dvd. No olvidar que si el cliente devuelve un DVD, la propiedad "codClienAlqui" del array se pone a 0, indicando
                    ' que el dvd ha sido devuelto (por lo que al estar en 0, significa que no tiene ningun cliente asociado a ese dvd)
                    If arrayDvd(i).codClienAlqui = opcion Then
                        cadenaDVD += coleccionDVD(arrayDvd(i).codDvdAlqui).GetSet_TituloDvd() & vbNewLine
                        boolDVD = False
                    End If
                Next


                If boolDVD Then
                    MessageBox.Show("El cliente no tiene alquilado ningun DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox(cadenaDVD)
                End If
            Else
                MessageBox.Show("No existe el cliente introducido", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub

    Private Sub btnListadoTodosDVD_Click(sender As Object, e As EventArgs) Handles btnListadoTodosDVD.Click

        Dim cadenaDVDAlquilados As String = "DVD´s ALQUILADOS" & vbNewLine
        Dim boolDVD As Boolean = False

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).GetSet_AlquiladoDvd() Then
                boolDVD = True
                cadenaDVDAlquilados += coleccionDVD(i).GetSet_TituloDvd() & vbNewLine
            End If
        Next

        If boolDVD Then
            MsgBox(cadenaDVDAlquilados)
        Else
            MessageBox.Show("No hay DVD´s alquilados actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnListadoDVD_NO_ALQUI_Click(sender As Object, e As EventArgs) Handles btnListadoDVD_NO_ALQUI.Click

        Dim cadenaDVD_NO_Alquilados As String = "DVD´s DISPONIBLES PARA ALQUILER" & vbNewLine
        Dim bool As Boolean = False

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).GetSet_AlquiladoDvd() = False Then
                bool = True
                cadenaDVD_NO_Alquilados += coleccionDVD(i).GetSet_TituloDvd() & vbNewLine
            End If
        Next

        If bool Then
            MsgBox(cadenaDVD_NO_Alquilados)
        Else
            MessageBox.Show("Todos los DVD´s estan alquilados actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnListadoClienteDVD_Click(sender As Object, e As EventArgs) Handles btnListadoClienteDVD.Click

        Dim opcion As String = InputBox("Introduce el codigo de la pelicula")
        Dim boolCli As Boolean = True

        If opcion <> "" Then
            If ifExisteCodDvdEnColeccionDvd(opcion) Then 'si el codigo escrito es correcto o no, para ello buscamos en la coleccionDVD
                'si hemos llegado aqui, significa que el codigo escrito es correcto (esta en coleccionDVD)
                'recorremos con un for el array de dvd alquilado para buscar el codigo de la pelicula en el array
                'pueden darse 3 casos
                '1. Que no exista el codigo dvd en el array de dvd, significa que nadie lo ha alquilado todavia, no entramos al if
                '2. que exista pero que ya haya sido devuelto, por lo que el codigo cli del array estaría en 0 (lo ha devuelto), no entramos
                '3. que exista y que el cod cliente sea distinto de 0, significa que sigue alquilado, por lo que entrariamos al if
                For i As Integer = 0 To arrayDvd.Length - 1
                    If arrayDvd(i).codDvdAlqui = opcion And arrayDvd(i).codClienAlqui <> "0" Then
                        MsgBox("El cliente que tiene alquilado el DVD " & coleccionDVD(opcion).GetSet_TituloDvd() & " es " & arrayDvd(i).codClienAlqui)
                        boolCli = False
                    End If
                Next

            Else 'Si entra al else, es que ha escrito el codigo mal, no existe en la base de datos (coleccionDVD)
                boolCli = False 'ponemos bool en false para que mas abajo no entre en el if (linea 99)
                MessageBox.Show("Codigo escrito incorrecto, no existe dicho codigo de DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


        If boolCli Then
            MessageBox.Show("El DVD no se encuentra alquilado actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class