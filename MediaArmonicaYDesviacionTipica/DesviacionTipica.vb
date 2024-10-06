Imports System.Reflection

Public Class DesviacionTipica

    Private Shared instance As DesviacionTipica
    Private Sub New()
    End Sub

    Public Shared Function ObtenerDeviacionTipica() As DesviacionTipica
        If (instance Is Nothing) Then
            instance = New DesviacionTipica()
        End If
        Return instance
    End Function

    Public Function calcularDesviacionTipica(serieNumeros As String) As Double
        Dim listaNumeros() As String = serieNumeros.Split(",")
        Dim suma As Double = 0
        Dim media As Double
        Dim numero As Double

        ' Calcular la suma de los números
        For Each numeroString As String In listaNumeros
            numero = Convert.ToDouble(numeroString)
            suma += numero
        Next

        ' Calcular la media
        media = suma / listaNumeros.Length

        ' Inicializar las variables para la varianza
        Dim sumaVarianza As Double = 0
        Dim varianza As Double


        For Each numeroString As String In listaNumeros
            numero = Convert.ToDouble(numeroString)
            sumaVarianza += Math.Pow(numero - media, 2)
        Next

        ' Calcular la varianza
        varianza = sumaVarianza / listaNumeros.Length

        ' Calcular la desviación estándar (raíz cuadrada de la varianza)
        Dim desviacionTipica As Double = Math.Sqrt(varianza)
        Return Math.Round(desviacionTipica, 2)

        Console.WriteLine("Mensaje de prueba")

    End Function





End Class
