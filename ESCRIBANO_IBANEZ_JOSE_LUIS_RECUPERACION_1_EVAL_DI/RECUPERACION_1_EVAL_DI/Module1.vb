Module Module1

    Public Structure DVD
        Public codDvd As Integer
        Public tituloDvd As String
        Public diasDvd As Integer
        Public codCliAlquila As Integer
        Public fechaAlquila As Date
        Public fechaDevuelve As Date

    End Structure

    Public arrayDvd() As DVD

    Public cont As Integer = 0

    Public dvdencontrado As Boolean = False

End Module
