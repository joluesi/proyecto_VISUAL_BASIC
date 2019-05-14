Public Class Form1
    Private Sub AltaDeDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeDVDToolStripMenuItem.Click
        AltaDVD.Show()
        Me.Hide()


    End Sub

    Private Sub AltaDeCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeCLIENTEToolStripMenuItem.Click
        For i As Integer = 1 To 3
            Dim aux As String = "C" & i
            coleccionCLIENTES.Add(New Class_CLIENTES(aux, "calle nueva, " & i, 56898956, "jlescribano@net.com"), aux)
        Next

        MsgBox("Se han dado de alta 3 clientes")
    End Sub

    Private Sub ConsultaDeDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDVDToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el codigo/titulo del DVD a consultar")

        Dim encontrado As Boolean = False

        If opcion <> "" Then
            For Each dvd In coleccionDVD  'primero busco el título en la colección, (recorro colección xq título no es clave). 
                'Si lo encuentro pongo en true y relleno casilleros

                If dvd.P_TituloDvd = opcion Then
                    encontrado = True

                    Consulta_DVD.Show()
                    Consulta_DVD.txtConsultaCodigoDVD.Text = dvd.P_CodigoDvd
                    Consulta_DVD.txtConsultaTituloDVD.Text = dvd.P_TituloDvd
                    Consulta_DVD.txtConsultaDiasAlquiler.Text = dvd.P_DiasAlquilerDvd
                    Consulta_DVD.txtConsultaAlquilado.Text = dvd.P_AlquiladoDvd

                End If
            Next

            If coleccionDVD.Contains(opcion) Then 'segundo busco si la coleccción contiene la opción (que sería la clave código). 
                'Si la contiente relleno casilleros. Si no la contiene y el título tampoco ha sido encontrado (encontrado = false), informo con mensaje.

                Consulta_DVD.Show()
                Consulta_DVD.txtConsultaCodigoDVD.Text = coleccionDVD(opcion).P_CodigoDvd
                Consulta_DVD.txtConsultaTituloDVD.Text = coleccionDVD(opcion).P_TituloDvd
                Consulta_DVD.txtConsultaDiasAlquiler.Text = coleccionDVD(opcion).P_DiasAlquilerDvd
                Consulta_DVD.txtConsultaAlquilado.Text = coleccionDVD(opcion).P_AlquiladoDvd

            ElseIf encontrado = False Then
                MsgBox("Código/Título de DVD no encontrado.")
            End If

        Else
            MsgBox("Antes debe introducir codigo/titulo en inputbox")
        End If

    End Sub

    Private Sub ConsultaDeCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeCLIENTEToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el código del cliente a consultar")

        'Dim encontrado As Boolean = False

        If coleccionCLIENTES.Contains(opcion) Then

            MsgBox("Código de cliente: " & opcion & vbCrLf &
                   "Dirección: " & coleccionCLIENTES(opcion).P_DireccionCli & vbCrLf &
                   "Teléfono: " & coleccionCLIENTES(opcion).P_TelefonoCli & vbCrLf &
                   "Email: " & coleccionCLIENTES(opcion).P_EmailCli & vbCrLf &
                   "Alquileres: " & coleccionCLIENTES(opcion).P_AlquileresCli & vbCrLf)

        Else
            MsgBox("No existe ese código de cliente")

        End If


    End Sub

    Private Sub AlquilarDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarDVDToolStripMenuItem.Click
        AlquilarDVD.Show()

    End Sub

    Private Sub DevolverDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverDVDToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el código del DVD a devolver")

        Dim encontrado As Boolean = False
        Dim diastrans As Integer

        If opcion <> "" Then

            If coleccionDVD.Contains(opcion) Then

                For i = 0 To arrayDVD.Length - 1
                    If arrayDVD(i).codDvdAlqui = opcion Then

                        encontrado = True

                        arrayDVD(i).fechaDevolucion = Today.Date
                        DevolverDVD.txtDevCodDVD.Text = arrayDVD(i).codDvdAlqui
                        DevolverDVD.txtDevCodCliente.Text = arrayDVD(i).codClienAlqui
                        DevolverDVD.txtDevFechaAlquiler.Text = arrayDVD(i).fechaAlquiler
                        DevolverDVD.txtDevFechaDevol.Text = arrayDVD(i).fechaDevolucion

                        coleccionDVD(opcion).P_AlquiladoDvd = False
                        coleccionCLIENTES(arrayDVD(i).codClienAlqui).P_AlquileresCli -= 1

                        diastrans = DateDiff(DateInterval.Day, arrayDVD(i).fechaAlquiler, arrayDVD(i).fechaDevolucion)
                        DevolverDVD.txtDevDiasTrans.Text = diastrans

                    End If

                Next

            Else
                MsgBox("Ese DVD no existe o no se encuentra alquilado")

            End If

            If encontrado Then
                If diastrans > coleccionDVD(opcion).P_DiasAlquilerDvd Then
                    DevolverDVD.Show()
                    MsgBox("DVD devuelto. Gracias.")
                    MsgBox("Ha superado el plazo de alquiler. Debe pagar adicionalmente " & diastrans & " euros. Gracias.")

                Else
                    DevolverDVD.Show()
                    MsgBox("DVD devuelto. Gracias.")

                End If

            End If

        Else
            MsgBox("Introduzca código de DVD a devolver")

        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosToolStripMenuItem.Click
        Listados.Show()


    End Sub


End Class
