Public Class Listados
    Private Sub btnListadoXCliente_Click(sender As Object, e As EventArgs) Handles btnListadoXCliente.Click

        Dim opcion As String = InputBox("Introduzca el código del cliente")
        Dim listado As String = "Dvd's alquilados por el cliente: " & opcion & vbCrLf
        Dim encontrado As Boolean = True

        If opcion <> "" Then
            If coleccionCLIENTES.Contains(opcion) Then
                For i = 0 To arrayDVD.Length - 1
                    If arrayDVD(i).codClienAlqui = opcion And coleccionCLIENTES(opcion).P_AlquileresCli > 0 And coleccionDVD(arrayDVD(i).codDvdAlqui).P_AlquiladoDvd = True Then
                        listado += coleccionDVD(arrayDVD(i).codDvdAlqui).P_TituloDvd & vbCrLf
                        encontrado = False
                    End If
                Next

                If encontrado Then
                    MsgBox("Este cliente no tiene alquileres")
                Else
                    MsgBox(listado)
                End If

            Else
                MsgBox("No existe ese cliente")
            End If
        Else
            MsgBox("Antes introduzca código de cliente")
        End If

    End Sub

    Private Sub btnListadoTodosDVD_Click(sender As Object, e As EventArgs) Handles btnListadoTodosDVD.Click

        Dim listado As String = "Listado de todos los DVD´S que se encuentran alquilados: " & vbCrLf

        If coleccionDVD.Count > 0 Then

            For Each dvd In coleccionDVD
                If dvd.P_AlquiladoDvd = True Then
                    listado += dvd.P_TituloDvd & vbCrLf
                End If
            Next
            MsgBox(listado)

        Else
            MsgBox("No existen DVD´S en la colección")

        End If

    End Sub

    Private Sub btnListadoDVD_NO_ALQUI_Click(sender As Object, e As EventArgs) Handles btnListadoDVD_NO_ALQUI.Click

        Dim listado As String = "Listado de todos los DVD´S NO alquilados: " & vbCrLf

        If coleccionDVD.Count > 0 Then

            For Each dvd In coleccionDVD
                If dvd.P_AlquiladoDvd = False Then
                    listado += dvd.P_TituloDvd & vbCrLf
                End If
            Next
            MsgBox(listado)

        Else
            MsgBox("No existen DVD´S en la colección")

        End If

    End Sub

    Private Sub btnListadoClienteDVD_Click(sender As Object, e As EventArgs) Handles btnListadoClienteDVD.Click

        Dim opcion As String = InputBox("Introduzca el código del DVD")
        Dim listado As String = "El Dvd " & opcion & " se encuentra alquilado al cliente: " & vbCrLf
        Dim encontrado As Boolean = True

        If opcion <> "" Then
            If coleccionDVD.Contains(opcion) Then
                For i = 0 To arrayDVD.Length - 1
                    If arrayDVD(i).codDvdAlqui = opcion And coleccionDVD(opcion).P_AlquiladoDvd = True Then
                        listado += coleccionCLIENTES(arrayDVD(i).codClienAlqui).P_CodigoCli & vbCrLf
                        encontrado = False
                    End If
                Next

                If encontrado Then
                    MsgBox("Este DVD no se encuentra alquilado")
                Else
                    MsgBox(listado)
                End If

            Else
                MsgBox("No existe ese DVD")
            End If
        Else
            MsgBox("Antes introduzca código de DVD")
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class