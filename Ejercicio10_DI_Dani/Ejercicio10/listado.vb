Public Class listado
    Private Sub btnComprobarCodigo_Click(sender As Object, e As EventArgs) Handles btnComprobarCodigo.Click

        Dim opcion As String = InputBox("Introduce codigo del cliente")
        Dim cadenaPeliculas As String = ""
        Dim bool As Boolean = True

        If opcion <> "" Then
            If ifExisteCodCliEnColeccionClientes(opcion) Then 'comprobamos que existe el cliente

                For i As Integer = 0 To array.Length - 1
                    ' si el codigo cliente del array es igual que el codigo cliente introducido, significa que el cliente tiene alquilado
                    ' algun dvd. No olvidar que si el cliente devuelve un DVD, la propiedad "codClienAlqui" del array se pone a 0, indicando
                    ' que el dvd ha sido devuelto (por lo que al estar en 0, significa que no tiene ningun cliente asociado a ese dvd)
                    If array(i).codClienAlqui = opcion Then
                        cadenaPeliculas += coleccionDVD(array(i).codDvdAlqui).DvdTitulo() & vbNewLine
                        bool = False
                    End If
                Next


                If bool Then
                    MessageBox.Show("El cliente no tiene alquilado ningun DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox(cadenaPeliculas)
                End If
            Else
                MessageBox.Show("No existe el cliente introducido", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If


    End Sub

    Private Sub btnTodosAlquilados_Click(sender As Object, e As EventArgs) Handles btnTodosAlquilados.Click

        Dim cadenaPeliculasAlquiladas As String = "PELICULAS ALQUILADAS" & vbNewLine
        Dim bool As Boolean = False

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).DvdAlquilado Then
                bool = True
                cadenaPeliculasAlquiladas += coleccionDVD(i).DvdTitulo() & vbNewLine
            End If
        Next

        If bool Then
            MsgBox(cadenaPeliculasAlquiladas)
        Else
            MessageBox.Show("No hay peliculas alquiladas actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnVolverListado_Click(sender As Object, e As EventArgs) Handles btnVolverListado.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnTodosNoAlquilados_Click(sender As Object, e As EventArgs) Handles btnTodosNoAlquilados.Click

        Dim cadenaPeliculasNoAlquiladas As String = "PELICULAS DISPONIBLES PARA ALQUILER" & vbNewLine
        Dim bool As Boolean = False

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).DvdAlquilado = False Then
                bool = True
                cadenaPeliculasNoAlquiladas += coleccionDVD(i).DvdTitulo() & vbNewLine
            End If
        Next

        If bool Then
            MsgBox(cadenaPeliculasNoAlquiladas)
        Else
            MessageBox.Show("Todas las peliculas estan alquiladas actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim opcion As String = InputBox("Introduce el codigo de la pelicula")
        Dim bool As Boolean = True

        If opcion <> "" Then
            If ifExisteCodDvdEnColeccionDvd(opcion) Then 'si el codigo escrito es correcto o no, para ello buscamos en la coleccionDVD
                'si hemos llegado aqui, significa que el codigo escrito es correcto (esta en coleccionDVD)
                'recorremos con un for el array de dvd alquilado para buscar el codigo de la pelicula en el array
                'pueden darse 3 casos
                '1. Que no exista el codigo dvd en el array de dvd, significa que nadie lo ha alquilado todavia, no entramos al if
                '2. que exista pero que ya haya sido devuelto, por lo que el codigo cli del array estaría en 0 (lo ha devuelto), no entramos
                '3. que exista y que el cod cliente sea distinto de 0, significa que sigue alquilado, por lo que entrariamos al if
                For i As Integer = 0 To array.Length - 1
                    If array(i).codDvdAlqui = opcion And array(i).codClienAlqui <> "0" Then
                        MsgBox("El cliente que tiene alquilado el DVD " & coleccionDVD(opcion).DvdTitulo & " es " & array(i).codClienAlqui)
                        bool = False
                    End If
                Next

            Else 'Si entra al else, es que ha escrito el codigo mal, no existe en la base de datos (coleccionDVD)
                bool = False 'ponemos bool en false para que mas abajo no entre en el if (linea 99)
                MessageBox.Show("Codigo escrito incorrecto, no existe dicho codigo de DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


        If bool Then
            MessageBox.Show("El DVD no se encuentra alquilado a nadie actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class