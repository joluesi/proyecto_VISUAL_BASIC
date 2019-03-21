Module Module1

    Structure Cliente
        Dim codCli As String
        Dim nombreCli As String
        Dim bloqueoCli As Boolean
        Dim claveCli As Integer ' 4 digitos maximo usando la propiedad maxLength
        Dim saldoCli As Double

    End Structure

    'creamos array de clientes
    Public array(4) As Cliente
    Public bool As Boolean
    Public bool2 As Boolean
    Public existe As Boolean
    Public cont As Integer
    Public cont2 As Integer
    Public auxiliarClave As String
    Public bool3 As Boolean ' para el form4

    'funccion para comprobar si existe o no
    Public Function ifExiste(nombre As String) As Boolean

        For Each z As Cliente In array

            If (z.nombreCli = nombre) Then
                Return True 'Clave existe
            End If

        Next
        'cClave no existe
        Return False


    End Function

    'funccion para comprobar si esta bloqueado o no
    Public Function ifBloqueado(nombre As String) As Boolean

        For Each z As Cliente In array

            If (z.nombreCli = nombre) Then
                If (z.bloqueoCli = True) Then
                    Return True ' esta bloqueado
                End If

            End If

        Next
        'cliente NO esta bloqueado
        Return False


    End Function

    Public Function comprobarClave(clave As Integer, nombre As String) As Boolean

        For Each z As Cliente In array

            If (z.nombreCli = nombre) Then
                If (z.claveCli = clave) Then
                    Return True ' clave correcta
                End If

            End If

        Next
        'clave incorrecta
        Return False


    End Function

    Public Function comprobarSaldo(cantidad As Double, nombre As String) As Boolean

        For Each z As Cliente In array

            If (z.nombreCli = nombre) Then
                If (z.saldoCli >= cantidad) Then
                    Return True  ' Reintegro posible
                End If

            End If

        Next
        'no tiene suficiente saldo
        Return False


    End Function

    Public Function mostrarSaldo(nombre As String) As String

        For Each z As Cliente In array

            If (z.nombreCli = nombre) Then
                Return "" & z.saldoCli
            End If

        Next
        'no tiene suficiente saldo
        Return -1


    End Function

    Public Function devolverIndice(nombre As String) As String

        For Each z As Cliente In array

            If (z.nombreCli = nombre) Then
                Return z.codCli
            End If

        Next
        'no tiene suficiente saldo
        Return -1


    End Function

    'Public Function buscarPorIndice(nombre As String) As String

    '    For Each z As Cliente In array

    '        If (z.nombreCli = nombre) Then
    '            Return z.saldoCli
    '        End If

    '    Next
    '    'no tiene suficiente saldo
    '    Return -1


    'End Function


End Module
