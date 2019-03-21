Public Class Listados
    Private Sub btnListadoXCliente_Click(sender As Object, e As EventArgs) Handles btnListadoXCliente.Click

        Dim opcion As String = InputBox("Introduzca el código del cliente")
        Dim cadenaDVD As String = ""
        Dim boolDVD As Boolean = True

        If opcion <> "" Then
            If ifExisteCodCliEnColeccionClientes(opcion) Then

                For i As Integer = 0 To arrayDvd.Length - 1

                    If arrayDvd(i).codClienAlqui = opcion Then
                        cadenaDVD += coleccionDVD(arrayDvd(i).codDvdAlqui).GetSet_TituloDvd() & vbCrLf
                        boolDVD = False
                    End If
                Next


                If boolDVD Then
                    MessageBox.Show("El cliente no tiene alquilado ningun DVD", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox(cadenaDVD)
                End If
            Else
                MessageBox.Show("No existe ese cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub btnListadoTodosDVD_Click(sender As Object, e As EventArgs) Handles btnListadoTodosDVD.Click

        Dim cadenaDVDAlquilados As String = "DVD´s ALQUILADOS: " & vbCrLf
        Dim boolDVD As Boolean = False

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).GetSet_AlquiladoDvd() Then
                boolDVD = True
                cadenaDVDAlquilados += coleccionDVD(i).GetSet_TituloDvd() & vbCrLf
            End If
        Next

        If boolDVD Then
            MsgBox(cadenaDVDAlquilados)
        Else
            MessageBox.Show("No hay DVD´s alquilados actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnListadoDVD_NO_ALQUI_Click(sender As Object, e As EventArgs) Handles btnListadoDVD_NO_ALQUI.Click

        Dim cadenaDVD_NO_Alquilados As String = "DVD´s DISPONIBLES PARA ALQUILER: " & vbCrLf
        Dim bool As Boolean = False

        For i As Integer = 1 To coleccionDVD.Count
            If coleccionDVD(i).GetSet_AlquiladoDvd() = False Then
                bool = True
                cadenaDVD_NO_Alquilados += coleccionDVD(i).GetSet_TituloDvd() & vbCrLf
            End If
        Next

        If bool Then
            MsgBox(cadenaDVD_NO_Alquilados)
        Else
            MessageBox.Show("Todos los DVD´s están alquilados actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnListadoClienteDVD_Click(sender As Object, e As EventArgs) Handles btnListadoClienteDVD.Click

        Dim opcion As String = InputBox("Introduzca el codigo del DVD")
        Dim boolCli As Boolean = True

        If opcion <> "" Then
            If ifExisteCodDvdEnColeccionDvd(opcion) Then
                For i As Integer = 1 To coleccionDVD.Count
                    If coleccionDVD(i).GetSet_AlquiladoDvd() Then

                        For j As Integer = 0 To arrayDvd.Length - 1
                            If arrayDvd(j).codDvdAlqui = opcion Then
                                MsgBox("El cliente que tiene alquilado el DVD " & coleccionDVD(opcion).GetSet_TituloDvd() & " es " & arrayDvd(j).codClienAlqui)
                                boolCli = False
                            End If
                        Next

                    End If
                Next

            Else
                MessageBox.Show("El DVD no existe", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

        If boolCli Then
            MessageBox.Show("El DVD no se encuentra alquilado actualmente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class