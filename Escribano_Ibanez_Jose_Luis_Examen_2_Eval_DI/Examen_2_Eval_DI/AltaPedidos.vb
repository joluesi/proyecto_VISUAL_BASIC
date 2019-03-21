Imports System.ComponentModel

Public Class AltaPedidos

    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click

        Try
            If Me.ValidateChildren And txtCodPedido.Text <> String.Empty And IsNumeric(txtCodPedido.Text) And CInt(txtClientePedido.Text) <> String.Empty And txtFechaPedido.Text <> String.Empty And txtDirecPedido.Text <> String.Empty Then

                If coleccionPEDIDOS.Count = 0 Then
                    MsgBox("Pedido dado de alta.")

                    coleccionPEDIDOS.Add(New Pedido(CInt(txtCodPedido.Text), CInt(txtClientePedido.Text), Today.Date, "dirección destino"), CInt(txtCodPedido.Text))
                    DarOtraAlta()

                Else
                    If coleccionPEDIDOS.Contains(txtCodPedido.Text) Then
                        MsgBox("Ya existe ese pedido")
                        borrarTextAlta()
                    Else
                        MsgBox("Pedido dado de alta.")
                        coleccionPEDIDOS.Add(New Pedido(CInt(txtCodPedido.Text), CInt(txtClientePedido.Text), Today.Date, "dirección destino"), CInt(txtCodPedido.Text))
                        DarOtraAlta()

                    End If

                End If

            Else
                MessageBox.Show("Ingrese datos correctos", "Altas de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Form1.Show()
        borrarTextAlta()

    End Sub

    Private Sub AltaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ToolTipCodigo = New ToolTip
        Dim ToolTipCliente = New ToolTip
        Dim ToolTipFecha = New ToolTip
        Dim ToolTipDireccion = New ToolTip

        ToolTipCodigo.SetToolTip(Me.txtCodPedido, "tipo String")
        ToolTipCliente.SetToolTip(Me.txtClientePedido, "tipo Entero")
        ToolTipFecha.SetToolTip(Me.txtFechaPedido, "tipo Fecha(Date)")
        ToolTipDireccion.SetToolTip(Me.txtDirecPedido, "tipo String")

    End Sub


    Private Sub txtCodPedido_Validating(sender As Object, e As CancelEventArgs) Handles txtCodPedido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo String")
        End If

    End Sub

    Private Sub txtClientePedido_Validating(sender As Object, e As CancelEventArgs) Handles txtClientePedido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo entero")
        End If

    End Sub

    Private Sub txtFechaPedido_Validating(sender As Object, e As CancelEventArgs) Handles txtFechaPedido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo Fecha(Date)")
        End If

    End Sub


    Private Sub txtDirecPedido_Validating(sender As Object, e As CancelEventArgs) Handles txtDirecPedido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "campo obligatorio, tipo string")
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim boolPedido As Boolean = False
        For i = 1 To coleccionPEDIDOS.Count
            If txtcodped_detal.Text = txtCodPedido.Text Then
                boolPedido = True

                txtcodped_detal.Text = txtCodPedido.Text
                txtcodprod_detal.Text = coleccionPRODUCTOS(i).GetSet_codProducto()
                txtUnidades.Text = coleccionPRODUCTOS(i).GetSet_stockProducto()
                txtDescuento.Text = ""

            End If

        Next

    End Sub

    Private Sub btnVolver_detal_Click(sender As Object, e As EventArgs) Handles btnVolver_detal.Click
        gbdetallePedido.Visible = False
        Form1.Show()

    End Sub
End Class