Public Class Inicio
    Dim desviacionTipica As DesviacionTipica = DesviacionTipica.ObtenerDeviacionTipica()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim serie As String = TextSerieNumeros.Text

        Try
            Dim desvTipica As Double = desviacionTipica.calcularDesviacionTipica(serie)
            TextResulDesviacionTipica.Text = desvTipica
        Catch ex As Exception
            MsgBox("No se puede realizar el calculo")
        End Try


    End Sub
End Class
