Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DATOS DE PRUEBA
        'coleccionDVD.Add(New DVD("1", "AHS1", 30), "1")
        'coleccionDVD.Add(New DVD("2", "AHS2", 30), "2")
        'coleccionDVD.Add(New DVD("3", "AHS3", 30), "3")

    End Sub


    Private Sub ConsultaDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTADVDToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el codigo/titulo del DVD a consultar")

        If opcion <> "" Then

            If coleccionDVD.Contains(opcion) Or ifExisteTitulo(opcion) Then

                If coleccionDVD.Contains(opcion) Then
                    Me.Hide()
                    ConsultaDVD.Show()
                    mostrarDvdPorCodigo(opcion)
                Else
                    Me.Hide()
                    ConsultaDVD.Show()
                    mostrarDvdPorTitulo(opcion)
                End If
            Else
                MessageBox.Show("No existe el codigo/titulo", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub


    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTACLIENTESToolStripMenuItem.Click

        For i As Integer = 1 To 3
            Dim aux As String = "C" & i
            coleccionClientes.Add(New Clientes(aux, "calle nueva", 56898956, "jlescribano@net.com"), aux)
        Next

        MsgBox("Se han dado de alta 3 clientes")

    End Sub


    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALQUILARToolStripMenuItem.Click
        Me.Hide()
        AlquilarDVD.Show()

    End Sub


    Private Sub ListadosConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOSCONSULTASToolStripMenuItem.Click
        Me.Hide()
        Listados.Show()
    End Sub


    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVOLVERToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el codigo del dvd a devolver")
        Dim diasTranscurridos As Integer

        If opcion <> "" Then

            Dim boolDevol As Boolean = False

            For i As Integer = 0 To arrayDvd.Length - 1
                If arrayDvd(i).codDvdAlqui = opcion Then

                    boolDevol = True

                    'DevolverDVD.indice = i
                    'arrayDvd(i).fechaDevolucion = Today.Date

                    DevolverDVD.txtDevCodCliente.Text = arrayDvd(i).codClienAlqui
                    DevolverDVD.txtDevCodDVD.Text = arrayDvd(i).codDvdAlqui
                    DevolverDVD.txtDevFechaAlquiler.Text = arrayDvd(i).fechaAlquiler
                    DevolverDVD.txtDevFechaDevol.Text = arrayDvd(i).fechaDevolucion = Today.Date

                    coleccionDVD(opcion).GetSet_AlquiladoDvd() = False
                    coleccionClientes(arrayDvd(i).codClienAlqui).GetSet_alquileresCli() -= 1

                    arrayDvd(i).codClienAlqui = "0"

                    diasTranscurridos = DateDiff(DateInterval.Day, arrayDvd(i).fechaAlquiler, arrayDvd(i).fechaDevolucion)
                    DevolverDVD.txtDevDiasTrans.Text = diasTranscurridos

                End If
            Next

            If boolDevol Then
                If diasTranscurridos > coleccionDVD(opcion).GetSet_DiasAlquilerDvd() Then
                    Me.Hide()
                    DevolverDVD.Show()
                    MsgBox("DVD devuelto.")
                    MsgBox("Ha superado el plazo en " & diasTranscurridos & " dias. Debe abonar " & diasTranscurridos & "€")
                Else
                    Me.Hide()
                    DevolverDVD.Show()
                    MsgBox("DVD devuelto.Gracias")
                End If

            Else
                MessageBox.Show("No se encuentra el DVD", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub


    Private Sub CONSULTACLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTACLIENTESToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduzca el codigo del cliente")

        If opcion <> "" Then
            If coleccionClientes.Contains(opcion) Then
                MsgBox("Código cliente: " & coleccionClientes(opcion).GetSet_codigoCli() & vbCrLf &
                       "Dirección cliente: " & coleccionClientes(opcion).GetSet_direccionCli() & vbCrLf &
                       "Teléfono cliente: " & coleccionClientes(opcion).GetSet_telefonoCli() & vbCrLf &
                       "Email cliente: " & coleccionClientes(opcion).GetSet_emailCli() & vbCrLf &
                       "Alquiler del cliente: " & coleccionClientes(opcion).GetSet_alquileresCli())
            Else
                MessageBox.Show("No existe el código del cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub


    Private Sub ALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALToolStripMenuItem.Click

        Me.Hide()
        AltaDvd.Show()
        AltaDvd.txtCodigoDVD.Focus()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
