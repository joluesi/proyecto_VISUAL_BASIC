'AUTOR: Daniel Mita

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DATOS DE PRUEBA
        coleccionDVD.Add(New DVD("1", "Inception", 30), "1")
        coleccionDVD.Add(New DVD("2", "Soy Leyenda", 30), "2")
        coleccionDVD.Add(New DVD("3", "Focus", 30), "3")

    End Sub

    Private Sub AltaDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDVDToolStripMenuItem.Click

        Me.Hide()
        AltaDVD.Show()
        AltaDVD.txtCodigoDVD.Focus()

    End Sub




    Private Sub ConsultaDVDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDVDToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el codigo/titulo del DVD a consultar")

        If opcion <> "" Then

            If coleccionDVD.Contains(opcion) Or ifExisteTitulo(opcion) Then
                'otro if para saber si se ha introducido codigo o titulo
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




    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click

        For i As Integer = 1 To 3
            Dim aux As String = "C" & i
            coleccionClientes.Add(New Clientes(aux, "carril enera", 888888888, "daniel@"), aux)
        Next

        MsgBox("Se han dado de alta satisfactoriamente 3 clientes")

    End Sub




    Private Sub ConsultaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaClienteToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el codigo del cliente")

        If opcion <> "" Then
            If coleccionClientes.Contains(opcion) Then
                MsgBox("Codigo cliente: " & coleccionClientes(opcion).CliCodigo() & vbNewLine &
                       "Direccion cliente: " & coleccionClientes(opcion).CliDireccion() & vbNewLine &
                       "Telefono cliente: " & coleccionClientes(opcion).CliTelefono() & vbNewLine &
                       "Email cliente: " & coleccionClientes(opcion).CliEmail() & vbNewLine &
                       "Alquieler del cliente: " & coleccionClientes(opcion).CliAlquileres())
            Else
                MessageBox.Show("No existe el codigo del cliente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub



    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarToolStripMenuItem.Click
        Me.Hide()
        Alquiler.Show()

    End Sub



    Private Sub ListadosConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosConsultasToolStripMenuItem.Click
        Me.Hide()
        listado.Show()
    End Sub




    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click

        Dim opcion As String = InputBox("Introduce el codigo del dvd a devolver")
        Dim diasTranscurridos As Integer

        If opcion <> "" Then

            Dim bool As Boolean = False

            For i As Integer = 0 To array.Length - 1
                If array(i).codDvdAlqui = opcion Then

                    bool = True

                    Devolucion.indice = i
                    array(i).fechaDevolucion = Today.Date

                    Devolucion.txtCodCliDev.Text = array(i).codClienAlqui
                    Devolucion.txtCodDvdDev.Text = array(i).codDvdAlqui
                    Devolucion.txtFechaAlquiler.Text = array(i).fechaAlquiler
                    Devolucion.txtFechaDevolucion.Text = array(i).fechaDevolucion

                    coleccionDVD(opcion).DvdAlquilado() = False
                    coleccionClientes(array(i).codClienAlqui).CliAlquileres() -= 1

                    'Lo de poner el codClienAlqui a 0 cuando se devuelve el DVD no se menciona, pero entiendo que cuando se 
                    'devuelve algo, ya no esta asociado a ese cliente.
                    array(i).codClienAlqui = "0"

                    diasTranscurridos = DateDiff(DateInterval.Day, array(i).fechaAlquiler, array(i).fechaDevolucion)
                    Devolucion.txtTranscurridos.Text = diasTranscurridos

                End If
            Next

            If bool Then
                If diasTranscurridos > coleccionDVD(opcion).DvdDiasAlquiler() Then
                    Me.Hide()
                    Devolucion.Show()
                    MsgBox("DVD devuelto satisfactoriamente")
                    MsgBox("Pero te has pasado " & diasTranscurridos & " dias. Debes pagar " & diasTranscurridos & "€")
                Else
                    Me.Hide()
                    Devolucion.Show()
                    MsgBox("DVD devuelto satisfactoriamente")
                End If

            Else
                MessageBox.Show("No se encuentra el DVD", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub
End Class
