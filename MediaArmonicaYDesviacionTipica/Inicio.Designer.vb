<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextSerieNumeros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextResultMediaArmonica = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextResulDesviacionTipica = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextSerieNumeros
        '
        Me.TextSerieNumeros.Location = New System.Drawing.Point(403, 125)
        Me.TextSerieNumeros.Multiline = True
        Me.TextSerieNumeros.Name = "TextSerieNumeros"
        Me.TextSerieNumeros.Size = New System.Drawing.Size(395, 36)
        Me.TextSerieNumeros.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de números a calcular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Media armónica"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Desviación típica"
        '
        'TextResultMediaArmonica
        '
        Me.TextResultMediaArmonica.Location = New System.Drawing.Point(219, 213)
        Me.TextResultMediaArmonica.Multiline = True
        Me.TextResultMediaArmonica.Name = "TextResultMediaArmonica"
        Me.TextResultMediaArmonica.Size = New System.Drawing.Size(230, 36)
        Me.TextResultMediaArmonica.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(722, 44)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "La media armónica y desviación típica"
        '
        'TextResulDesviacionTipica
        '
        Me.TextResulDesviacionTipica.Location = New System.Drawing.Point(253, 278)
        Me.TextResulDesviacionTipica.Multiline = True
        Me.TextResulDesviacionTipica.Name = "TextResulDesviacionTipica"
        Me.TextResulDesviacionTipica.Size = New System.Drawing.Size(230, 36)
        Me.TextResulDesviacionTipica.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Cascadia Mono", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(630, 249)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(168, 56)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 390)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.TextResulDesviacionTipica)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextResultMediaArmonica)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextSerieNumeros)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media armónica y desviación típica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextSerieNumeros As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextResultMediaArmonica As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextResulDesviacionTipica As TextBox
    Friend WithEvents btnCalcular As Button
End Class
