Imports System.Threading

Public Class Inicio
    Dim desviacionTipica As DesviacionTipica = DesviacionTipica.ObtenerDeviacionTipica()
    Dim mediaArmonica As Armonica = Armonica.ObtenerArmonica()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim serie As String = TextSerieNumeros.Text

        Try
            If (String.IsNullOrWhiteSpace(serie)) Then
                MessageBox.Show("Ingrese una serie de números separados por comas.", "MEDIA ARMÓNICA Y DESVIACIÓN TÍPICA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (serie < 0) Then
                MessageBox.Show("Ingrese números positivos.", "MEDIA ARMÓNICA Y DESVIACIÓN TÍPICA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim desvTipica As Double = desviacionTipica.calcularDesviacionTipica(serie)
                TextResulDesviacionTipica.Text = desvTipica
                Dim mediaArmon As Double = mediaArmonica.calcularMediaArmonica(serie)
                TextResultMediaArmonica.Text = mediaArmon
            End If

        Catch ex As Exception
            MessageBox.Show("No se puede calcular la media armónica. SOLO NÚMEROS POSITIVOS", "MEDIA ARMÓNICA Y DESVIACIÓN TÍPICA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
