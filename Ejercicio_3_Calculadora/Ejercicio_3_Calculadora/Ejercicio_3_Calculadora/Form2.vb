Public Class Form2

    Public Function AreaCuadrado(Base As Single)
        AreaCuadrado = Base * Base

    End Function

    Public Function AreaTriangulo(Base As Single, Altura As Single)
        AreaTriangulo = Base * Altura / 2

    End Function

    Public Function AreaRectangulo(Base As Single, Altura As Single)
        AreaRectangulo = (Base * Altura)

    End Function


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub rbtnTriangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTriangulo.CheckedChanged
        txtAltura.Visible = True
        If (txtBase.Text = "" Or txtAltura.Text = "") Then
            MsgBox("Antes debe introducir base y altura")
        Else
            txtArea.Text = AreaTriangulo(Base:=txtBase.Text, Altura:=txtAltura.Text)
        End If

    End Sub

    Private Sub rbtnCuadrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCuadrado.CheckedChanged
        txtAltura.Visible = False
        If (txtBase.Text = "") Then
            MsgBox("Antes debe introducir base")
        Else
            txtArea.Text = AreaCuadrado(Base:=txtBase.Text)
        End If

    End Sub

    Private Sub rbtnRectangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRectangulo.CheckedChanged
        txtAltura.Visible = True
        If (txtBase.Text = "" Or txtAltura.Text = "") Then
            MsgBox("Antes debe introducir base y altura")
        Else
            txtArea.Text = AreaRectangulo(Base:=txtBase.Text, Altura:=txtAltura.Text)
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class