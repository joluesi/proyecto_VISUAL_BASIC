Module Module1

    Public Structure Cliente
        Public codCli As String
        Public nombreCli As String
        Public bloqueocli As Boolean
        Public claveCli As Integer
        Public saldocli As Double

    End Structure

    Public arrayCliente(5) As Cliente
    Public cont As Integer
    Public numOrden As Integer
    Public contClave As Integer = 0
    Public intentos As Integer = 3
    Public saldo As Double
    Public reintegro As Double
    Public ingreso As Double
    Public display As String



End Module
