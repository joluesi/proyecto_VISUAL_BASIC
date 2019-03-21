Module Module1
    Public Structure Cliente
        Public codCli As String
        Public nombreCli As String
        Public bloqueoCli As Boolean
        Public claveCli As Integer
        Public saldoCli As Double
    End Structure

    Public clientes() As Cliente
    Public clienteActivo As Cliente
End Module
