﻿Public Class Form1


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'Alta Comprascliente        
        GroupBox1.Show()

        txtCodCliente.Text = CStr(cont_cod_cliente)
        'creamos combobox con los códigos de vendedor de la colección Vendedores
        For i As Integer = 1 To colecVendedor.Count
            cobCodVendedor.Items.Add(colecVendedor(i).Pcod_vendedor())
        Next

        cont_cod_cliente += 1

        'otra opción para recorrer la colección Vendedores
        'For Each vend In colecVendedor
        '    cobCodVendedor.Items.Add(vend.Pcod_vendedor())
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
        txtCodVendedor.Text = cobCodVendedor.SelectedItem

    End Sub

    Private Sub butSalirV_Click(sender As Object, e As EventArgs) Handles butSalirV.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub TratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoToolStripMenuItem.Click
        'Actualizar campo compras_mes de colecComprasCliente con array ComprasMes
        
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Inicializar campo compras_mes de colecComprasCliente
        
    End Sub
    
    Private Sub ComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisiónToolStripMenuItem.Click
        'Calcular y mostrar el total de ventas, %comisión y cantidad a cobrar del vendedor seleccionado 


    End Sub

    Private Sub VentaTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaTotalToolStripMenuItem.Click
        'ventas totales de cada uno de los vendedores, 1 por linea y en la última linea el total ventas de todos los vendedores

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub butGuardarV_Click(sender As Object, e As EventArgs) Handles butGuardarV.Click
        Try
            If IsNumeric(txtCodVendedor.Text) And CobZona.SelectedItem <> "" And IsNumeric(txtComision.Text) Then

                If colecVendedor.Count = 0 Then
                    MsgBox("Vendedor dado de alta.")
                    colecVendedor.Add(New Vendedor(txtCodVendedor.Text, CobZona.SelectedItem.Text, txtComision.Text), txtCodVendedor.Text)
                    Si_o_No()

                Else
                    If colecVendedor.Contains(txtCodVendedor.Text) Then
                        MsgBox("Ya existe ese vendedor")
                        txtCodVendedor.Text = ""
                        CobZona.SelectedItem = ""
                        txtComision.Text = ""
                    Else
                        MsgBox("Vendedor dado de alta.")
                        colecVendedor.Add(New Vendedor(txtCodVendedor.Text, CobZona.SelectedItem.Text, txtComision.Text), txtCodVendedor.Text)
                        Si_o_No()

                    End If

                End If

            Else
                MessageBox.Show("Ingrese datos correctos", "Registro de Altas de vendedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class