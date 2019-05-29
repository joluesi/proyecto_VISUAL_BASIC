Public Class Form1


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'Alta Comprascliente
        GroupBox1.Visible = True

        txtCodCliente.Text = cont_cliente
        cont_cliente += 1

        comboVendedores(cobCodVendedor)


    End Sub
    'array ComprasMes
    Private Sub AltaArrayComprasMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaArrayComprasMesToolStripMenuItem.Click
        comprasMes = {{1, 100}, {1, 200}, {2, 300}, {2, 1000}, {2, 500}}
        MsgBox("Array comprasMes creado")
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        'Alta Vendedor
        GroupBox2.Visible = True

    End Sub

    Private Sub butSalirV_Click(sender As Object, e As EventArgs) Handles butSalirV.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub TratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoToolStripMenuItem.Click
        'Actualizar campo compras_mes de colecComprasCliente con array ComprasMes
        For i = 0 To comprasMes.GetLength(0) - 1 'con GetLength(0) le digo que sólo me coja la dimensión de las filas
            If colecComprasCliente.Contains(comprasMes(i, 0)) Then 'comprasMes(i, 0) --> es el código de cliente
                colecComprasCliente(comprasMes(i, 0)).Pcompras_mes() += comprasMes(i, 1)
            Else
                MsgBox("No existe ese cliente")
            End If
        Next

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Inicializar campo compras_mes de colecComprasCliente
        For Each cliente In colecComprasCliente
            cliente.Pcompras_mes() = 0
        Next

    End Sub
    
    Private Sub ComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisiónToolStripMenuItem.Click
        'Calcular y mostrar el total de ventas, %comisión y cantidad a cobrar del vendedor seleccionado 
        grbComision.Visible = True
        comboVendedores(cmbVend)

    End Sub

    Private Sub VentaTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaTotalToolStripMenuItem.Click
        'ventas totales de cada uno de los vendedores, 1 por linea y en la última linea el total ventas de todos los vendedores
        Form3.Visible = True

        'Dim totalVentasVendedor = 0
        'Dim totalVentasConjuntas = 0

        'For Each cliente In colecComprasCliente
        '    For Each vendedor In colecVendedor
        '        If cliente.PcodVendedorCli() = vendedor.Pcod_vendedor() Then
        '            totalVentasVendedor = 0
        '            totalVentasVendedor += cliente.Pcompras_mes()
        '            Form3.rtbVentas.Text += "Vendedor " & vendedor.Pcod_vendedor() & " tiene unas ventas de " & totalVentasVendedor & " €" & vbNewLine
        '            totalVentasConjuntas += totalVentasVendedor
        '        End If
        '    Next
        'Next
        'Form3.rtbVentas.Text += "Total Ventas conjuntas " & totalVentasConjuntas & " €"


        'otra forma para obtener lo mismo
        Dim totalVentasVendedor = 0
        Dim totalVentasConjuntas = 0

        For Each cliente In colecComprasCliente
            totalVentasVendedor = 0
            totalVentasVendedor += cliente.Pcompras_mes()
            If colecVendedor.Contains(cliente.PcodVendedorCli()) Then
                Form3.rtbVentas.Text += "Vendedor " & cliente.PcodVendedorCli() & " tiene unas ventas de " & totalVentasVendedor & " €" & vbNewLine
                totalVentasConjuntas += totalVentasVendedor
            End If

        Next
        Form3.rtbVentas.Text += "Total Ventas conjuntas " & totalVentasConjuntas & " €"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butGuardarV_Click(sender As Object, e As EventArgs) Handles butGuardarV.Click
        Try
            If txtCodVendedor.Text <> "" And CobZona.Text <> "" And txtComision.Text <> "" Then

                If colecVendedor.Contains(txtCodVendedor.Text) Then
                    MsgBox("Ese vendedor ya existe")
                Else
                    colecVendedor.Add(New Vendedor(txtCodVendedor.Text, CobZona.Text, txtComision.Text), txtCodVendedor.Text)
                    MsgBox("Añadido vendedor")
                    AnadirVendedor()

                End If

            Else
                MsgBox("Rellene casilleros de forma correcta")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub butGuardarC_Click(sender As Object, e As EventArgs) Handles butGuardarC.Click
        Try
            If txtCodCliente.Text <> "" And cobCodVendedor.Text <> "" Then

                If colecComprasCliente.Contains(txtCodCliente.Text) Then
                    MsgBox("Ese Cliente ya existe")
                Else
                    colecComprasCliente.Add(New Cliente(txtCodCliente.Text, cobCodVendedor.Text), txtCodCliente.Text)
                    MsgBox("Añadido cliente")
                    AnadirCliente()

                End If

            Else
                MsgBox("Rellene casilleros de forma correcta")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub butCalcular_Click(sender As Object, e As EventArgs) Handles butCalcular.Click

        Dim totalVentas As Double = 0
        Dim comision As Double = 0
        Dim comisionesTotal As Double = 0

        For Each cliente In colecComprasCliente
            If cliente.PcodVendedorCli() = cmbVend.Text Then
                totalVentas += cliente.Pcompras_mes()
                If colecVendedor.Contains(cmbVend.Text) Then
                    comision = colecVendedor(cmbVend.Text).Pcomision()
                    comisionesTotal = (totalVentas * comision) / 100
                End If
            End If
        Next

        MsgBox("El vendedor " & cmbVend.Text & " ha vendido por valor de: " & totalVentas & " con comisión de " & comision & " %, y ha obtenido un total x comisiones de " & comisionesTotal)

    End Sub

    Private Sub butSalirComi_Click(sender As Object, e As EventArgs) Handles butSalirComi.Click
        grbComision.Visible = False

    End Sub

    Private Sub butSalirC_Click(sender As Object, e As EventArgs) Handles butSalirC.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
