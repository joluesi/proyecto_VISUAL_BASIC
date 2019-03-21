Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bool = True
        bool2 = False
    End Sub


    Private Sub CrearArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearArrayToolStripMenuItem.Click

        If (bool) Then
            ' creamos un bucle que nos llene el array
            For i As Integer = 0 To array.Length - 1 Step 1

                array(i).codCli = i
                array(i).nombreCli = "Cliente" & i
                array(i).bloqueoCli = False
                array(i).claveCli = i * 1000
                array(i).saldoCli = 0

            Next
            bool = False

            MsgBox("Clientes creados satisfactoriamente. Esta opcion quedará bloqueada")
        End If

        If (bool2) Then
            MsgBox("Opcion invalida, ya estan creados los clientes")
        End If

        bool2 = True


        'For Each z As Cliente In array
        '    MsgBox("" & z.codCli & ", " & z.nombreCli & ", " & z.bloqueoCli & ", " & z.claveCli & ", " & z.saldoCli)
        'Next

    End Sub



    Private Sub CajeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajeroToolStripMenuItem.Click

        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

    End Sub
End Class
