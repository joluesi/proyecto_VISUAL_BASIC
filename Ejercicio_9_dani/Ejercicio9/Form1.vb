Public Class Form1


    Public articulo1 As Articulo



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        articulo1 = New Articulo("1", "monitor", "A", 150.0, 11)
        TextBox1.Text = articulo1.nombre
        articulo1.nombre = "ulala"
        TextBox1.Text = articulo1.nombre
    End Sub
End Class
