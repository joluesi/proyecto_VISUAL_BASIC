Module Module1
    Public Function Depura(ByVal numero1 As String, ByVal numero2 As String, ByVal numeroAux As String, ByVal contador As String, ByVal operacion As String, ByVal operacionAux As String) As String
        Dim texto As String = ("num1: " & numero1 & vbCrLf & "num2: " & numero2 & vbCrLf & "numAux: " & numeroAux & vbCrLf & "cont: " & contador & vbCrLf & "oper: " & operacion & vbCrLf & "operAux: " & operacionAux & vbCrLf)
        Return texto
    End Function


    Public Function Suma(ByVal num1 As String, ByVal num2 As String) As String
        Dim resultado As String = ""
        Try
            Dim suma1 As Double = CDbl(num1)
            Dim suma2 As Double = CDbl(num2)
            Dim result As Double = suma1 + suma2
            resultado = CStr(result)
        Catch ex As Exception
            resultado = "0"
        End Try
        Return resultado
    End Function

    Public Function Resta(ByVal num1 As String, ByVal num2 As String) As String
        Dim resultado As String = ""
        Try
            Dim suma1 As Double = CDbl(num1)
            Dim suma2 As Double = CDbl(num2)
            Dim result As Double = suma1 - suma2
            resultado = CStr(result)
        Catch ex As Exception
            resultado = "0"
        End Try
        Return resultado
    End Function

    Public Function Multiplica(ByVal num1 As String, ByVal num2 As String) As String
        Dim resultado As String = ""
        Dim suma1 As Double = CDbl(num1)
        Dim suma2 As Double = CDbl(num2)
        Dim result As Double = suma1 * suma2
        resultado = CStr(result)

        Return resultado
    End Function

    Public Function Divide(ByVal num1 As String, ByVal num2 As String) As String
        Dim resultado As String = ""
        Try
            Dim suma1 As Double = CDbl(num1)
            If num2 = 0 Then
                resultado = "0"
                Return resultado
            Else
                Dim suma2 As Double = CDbl(num2)
                Dim result As Double = suma1 / suma2
                resultado = CStr(result)
                Return resultado
            End If
        Catch ex As Exception
            resultado = "0"
            Return resultado
        End Try


    End Function

    Public Function CambiaSigno(ByVal num As String) As String
        Dim resultado As String = ""
        Try
            Dim numero As Double = CDbl(num)
            Dim result As Double = numero * (-1)
            resultado = CStr(result)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Module
