Public Class Form1


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'Alta Comprascliente
        gbxCliente.Visible = True
        SeleccionaCombobox(cmbxCodVendedor)

        txtCodCliente.Text = cont_cliente
        cont_cliente += 1

    End Sub
    'array ComprasMes
    Private Sub AltaArrayComprasMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaArrayComprasMesToolStripMenuItem.Click
        comprasMes = {{1, 100}, {1, 200}, {2, 300}, {2, 1000}, {2, 500}}
        MsgBox("Array comprasMes creado")
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        'Alta Vendedor
        gbxVendedor.Visible = True

    End Sub

    Private Sub butSalirV_Click(sender As Object, e As EventArgs) Handles butSalirV.Click
        gbxVendedor.Visible = False
    End Sub

    Private Sub TratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoToolStripMenuItem.Click
        'Actualizar campo compras_mes de colecComprasCliente con array ComprasMes
        For i = 0 To comprasMes.GetLength(0) - 1
            For Each cliente In colecCLIENTE
                If cliente.P_codcliente = comprasMes(i, 0) Then
                    colecCLIENTE(comprasMes(i, 0)).P_compras_mes += comprasMes(i, 1)
                End If
            Next
        Next

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Inicializar campo compras_mes de colecComprasCliente
        For Each cliente In colecCLIENTE
            cliente.P_compras_mes = 0
        Next

    End Sub
    
    Private Sub ComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisiónToolStripMenuItem.Click
        'Calcular y mostrar el total de ventas, %comisión y cantidad a cobrar del vendedor seleccionado
        gbxComision.Visible = True
        SeleccionaCombobox(cmbVendComis)



    End Sub

    Private Sub VentaTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaTotalToolStripMenuItem.Click
        'ventas totales de cada uno de los vendedores, 1 por linea y en la última linea el total ventas de todos los vendedores
        Form3.Visible = True

        Dim ventasParciales As Double = 0
        Dim totalVentas As Double = 0

        For Each vende In colecVENDEDOR
            For Each cliente In colecCLIENTE
                If vende.P_cod_vendedor = cliente.P_codVendedorCli Then
                    ventasParciales = 0
                    Form3.rtbVentas.Text += "Vendedor con código " & vende.P_cod_vendedor & vbNewLine
                    ventasParciales += cliente.P_compras_mes
                    Form3.rtbVentas.Text += "Tiene unas ventas totales de " & CStr(ventasParciales) & vbNewLine
                    totalVentas += ventasParciales
                End If
            Next

        Next
        Form3.rtbVentas.Text += "TOTAL VENTAS: " & CStr(totalVentas)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butGuardarV_Click(sender As Object, e As EventArgs) Handles butGuardarV.Click

        If txtCodVendedor.Text <> "" And cmbxZona.Text <> "" And txtComision.Text <> "" Then
            If colecVENDEDOR.Contains(txtCodVendedor.Text) Then
                MsgBox("Ya existe ese vendedor")
            Else
                colecVENDEDOR.Add(New Vendedor(txtCodVendedor.Text, cmbxZona.Text, txtComision.Text), txtCodVendedor.Text)
                MsgBox("Añadido vendedor a colección")
                Si_o_No_V()

            End If

        Else
            MsgBox("Antes rellene de forma correcta todos los casilleros")
        End If

    End Sub

    Private Sub butGuardarC_Click(sender As Object, e As EventArgs) Handles butGuardarC.Click

        If txtCodCliente.Text <> "" And cmbxCodVendedor.Text <> "" Then
            If colecCLIENTE.Contains(txtCodCliente.Text) Then
                MsgBox("Ya existe ese cliente")
            Else
                colecCLIENTE.Add(New Cliente(txtCodCliente.Text, cmbxCodVendedor.SelectedItem, txtComprasMes.Text), txtCodCliente.Text)
                MsgBox("Añadido cliente a colección")
                Si_o_No_C()

            End If

        Else
            MsgBox("Antes rellene de forma correcta todos los casilleros")
        End If

    End Sub

    Private Sub butCalcular_Click(sender As Object, e As EventArgs) Handles butCalcular.Click

        Dim ventasParciales As Double = 0
        Dim comisionParcial As Double = 0
        Dim comisionTotal As Double = 0

        If cmbVendComis.Text <> "" Then
            For Each cliente In colecCLIENTE
                If cliente.P_codVendedorCli = cmbVendComis.Text Then
                    ventasParciales += cliente.P_compras_mes
                End If
            Next

            comisionParcial = colecVENDEDOR(cmbVendComis.Text).P_comision
            comisionTotal = ventasParciales * (comisionParcial / 100)

            MsgBox("El vendedor " & cmbVendComis.Text & " ha vendido por valor de " & CStr(ventasParciales) & " con comision del " &
                   CStr(comisionParcial) & "%, y comisión total por ventas de " & CStr(comisionTotal))

        End If



    End Sub
End Class
