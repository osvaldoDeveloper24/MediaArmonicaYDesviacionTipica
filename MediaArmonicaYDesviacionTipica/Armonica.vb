Public Class Armonica

    Private Shared instanceArmonica As Armonica
    Private Sub New()
    End Sub

    Public Shared Function ObtenerArmonica() As Armonica
        If (instanceArmonica Is Nothing) Then
            instanceArmonica = New Armonica()
        End If
        Return instanceArmonica
    End Function

    Public Function calcularMediaArmonica(serieNumeros As String)
        Dim suma As Double
        Dim numero As Double
        Dim listaNumeros() As String = serieNumeros.Split(",")
        For Each numeroString As String In listaNumeros
            numero = Convert.ToDouble(numeroString)
            suma += 1 / numero
        Next
        Return Math.Round(listaNumeros.Length / suma, 2)
    End Function

End Class
