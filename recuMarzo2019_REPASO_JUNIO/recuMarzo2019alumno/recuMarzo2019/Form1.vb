Public Class Form1

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'Alta Comprascliente        
        GroupBox1.Show()

        SeleccionaCombobox(cmbCodVendedor)

        txtCodCliente.Text = cont_cod_cliente
        cont_cod_cliente += 1

        'otra opción para recorrer la colección Vendedores (SIN FUNCIÓN)
        'creamos ComboBox con los códigos de vendedor de la colección Vendedores        
        'For i As Integer = 1 To colecVendedor.Count
        '    If Not (cmbCodVendedor.Items.Contains(txtCodVendedor.Text)) Then
        '        cmbCodVendedor.Items.Add(colecVendedor(i).Pcod_vendedor())
        '    End If
        'Next

    End Sub

    'array ComprasMes
    Private Sub AltaArrayComprasMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaArrayComprasMesToolStripMenuItem.Click
        comprasMes = {{1, 100}, {1, 200}, {2, 300}, {2, 1000}, {2, 500}}
        MsgBox("Array comprasMes creado")
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        'Alta Vendedor
        GroupBox2.Show()
        'cmbCodVendedor.Items.Clear()

    End Sub

    Private Sub butSalirV_Click(sender As Object, e As EventArgs) Handles butSalirV.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub TratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoToolStripMenuItem.Click
        'Actualizar campo compras_mes de colecComprasCliente con array ComprasMes
        For i = 0 To comprasMes.GetLength(0) - 1  'Array Bidimensional. con GetLength(0) le digo que sólo me coja una dimensión (columna 0: códigos de clientes)
            If colecComprasCliente.Contains(comprasMes(i, 0)) Then
                Dim codCliente = comprasMes(i, 0)  'codCliente es una variable auxiliar prescindible
                colecComprasCliente(codCliente).Pcompras_mes() += comprasMes(i, 1)
            Else
                MsgBox("No existe ese cliente")
            End If
        Next

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Inicializar campo compras_mes de colecComprasCliente
        For Each clien In colecComprasCliente
            'colecComprasCliente(clien).Pcompras_mes() = 0
            clien.Pcompras_mes() = 0
        Next

    End Sub
    
    Private Sub ComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisiónToolStripMenuItem.Click
        'Calcular y mostrar el total de ventas, %comisión y cantidad a cobrar del vendedor seleccionado 
        'creamos ComboBox con los códigos de vendedor de la colección Vendedores
        grbComision.Visible = True

        SeleccionaCombobox(cmbVend)

        'cmbVend.Items.Clear()

        'For i As Integer = 1 To colecVendedor.Count
        '    If Not (cmbVend.Items.Contains(txtCodVendedor.Text)) Then
        '        cmbVend.Items.Add(colecVendedor(i).Pcod_vendedor())
        '    End If
        'Next

    End Sub

    Private Sub VentaTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaTotalToolStripMenuItem.Click
        'ventas totales de cada uno de los vendedores, 1 por linea y en la última linea el total ventas de todos los vendedores
        Form3.Visible = True

        Dim totalVentasVendedor = 0
        Dim totalVentasConjuntas = 0

        For Each clien In colecComprasCliente
            For Each vende In colecVendedor
                If clien.PcodVendedorCli() = vende.Pcod_vendedor() Then
                    totalVentasVendedor = 0
                    totalVentasVendedor += clien.Pcompras_mes()
                    Form3.rtbVentas.Text += "Vendedor " & vende.Pcod_vendedor() & ": Tiene un total ventas de: " & totalVentasVendedor & " €" & vbNewLine
                    totalVentasConjuntas += totalVentasVendedor
                End If
            Next
        Next

        Form3.rtbVentas.Text += "Total ventas conjuntas: " & totalVentasConjuntas & " €"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butGuardarV_Click(sender As Object, e As EventArgs) Handles butGuardarV.Click

        Try
            If isNumeric(txtCodVendedor.Text) And CobZona.Text <> "" And isNumeric(txtComision.Text) Then

                If colecVendedor.Count = 0 Then
                    colecVendedor.Add(New Vendedor(txtCodVendedor.Text, CobZona.Text, txtComision.Text), txtCodVendedor.Text)
                    MsgBox("Vendedor dado de alta.")
                    Si_o_No_V()

                Else
                    If colecVendedor.Contains(txtCodVendedor.Text) Then
                        MsgBox("Ya existe ese vendedor")
                        txtCodVendedor.Text = ""
                        CobZona.Text = ""
                        txtComision.Text = ""
                    Else
                        colecVendedor.Add(New Vendedor(txtCodVendedor.Text, CobZona.Text, txtComision.Text), txtCodVendedor.Text)
                        MsgBox("Vendedor dado de alta.")
                        Si_o_No_V()

                    End If

                End If

            Else
                MessageBox.Show("Ingrese datos correctos", "Registro de Altas de vendedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub butGuardarC_Click(sender As Object, e As EventArgs) Handles butGuardarC.Click

        Try
            If cmbCodVendedor.Text <> "" Then

                If colecComprasCliente.Count = 0 Then
                    colecComprasCliente.Add(New Cliente(txtCodCliente.Text, cmbCodVendedor.Text), txtCodCliente.Text)
                    MsgBox("Cliente dado de alta.")
                    Si_o_No_C()

                Else
                    If colecComprasCliente.Contains(txtCodCliente.Text) Then
                        MsgBox("Ya existe ese Cliente")
                        txtCodCliente.Text = ""
                        cmbCodVendedor.Text = ""

                    Else
                        colecComprasCliente.Add(New Cliente(txtCodCliente.Text, cmbCodVendedor.Text), txtCodCliente.Text)
                        MsgBox("Cliente dado de alta.")
                        Si_o_No_C()

                    End If

                End If

            Else
                MessageBox.Show("Ingrese datos correctos", "Registro de Altas de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub butSalirC_Click(sender As Object, e As EventArgs) Handles butSalirC.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub butCalcular_Click(sender As Object, e As EventArgs) Handles butCalcular.Click

        Dim totalVentas = 0
        Dim comision = 0
        Dim comisionesTotales = 0

        'For Each clien In colecComprasCliente
        '    If clien.PcodVendedorCli() = cmbVend.Text Then
        '        totalVentas += clien.Pcompras_mes()
        '        For Each vende In colecVendedor
        '            If vende.Pcod_vendedor() = clien.PcodVendedorCli() Then
        '                comision = vende.Pcomision()
        '                comisionesTotales = (totalVentas * comision) / 100
        '            End If
        '        Next

        '    End If
        'Next

        'MessageBox.Show("El Vendedor " & cmbVend.Text & " ha vendido por valor de: " & totalVentas & " €" & ", con comisión de: " & comision & "%, y total a cobrar por comisiones: " & comisionesTotales & " €")

        'otra opción (aprovechando que el codigo vendedor es la clave en colección vendedores)
        Dim claveVendedorBusco As String
        claveVendedorBusco = cmbVend.Text
        For Each clien In colecComprasCliente
            If clien.PcodVendedorCli() = claveVendedorBusco Then
                totalVentas += clien.Pcompras_mes()
                If colecVendedor.Contains(claveVendedorBusco) Then
                    comision = colecVendedor(claveVendedorBusco).Pcomision()
                    comisionesTotales = (totalVentas * comision) / 100
                End If

            End If
        Next

        MessageBox.Show("El Vendedor " & cmbVend.Text & " ha vendido por valor de: " & totalVentas & " €" & ", con comisión de: " & comision & "%, y total a cobrar por comisiones: " & comisionesTotales & " €")


    End Sub

    Private Sub butSalirComi_Click(sender As Object, e As EventArgs) Handles butSalirComi.Click
        grbComision.Visible = False

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Me.Close()

    End Sub


End Class
