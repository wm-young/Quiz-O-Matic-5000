'This classes is where the user can play around with the values
' and see the corresponding graph on the right.
Public Class FunctionFunForm

    Dim xMax, xMin, yMax, yMin, func
    Dim state, Initial, Line, QuadVert, QuadStand As Integer
    Private Sub lineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lineButton.Click
        Dim lineP As New lineParameters
        state = 1
        Me.parameterPanel.Controls.Clear()
        Me.parameterPanel.Controls.Add(lineP)
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub graphButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graphButton.Click
        Dim g As Graphics
        Dim blackPen As New Pen(Color.Black)
        Dim bluePen As New Pen(Color.Blue)
        Dim redPen As New Pen(Color.Red)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim stepCount, j, m, a, b, c, h, k As Double

        g = functionDisplay.CreateGraphics
        g.Clear(Color.White)
        yMax = 10
        yMin = -5
        xMax = 5
        xMin = -5

        'Draw axis
        g.DrawLine(bluePen, xc(xMin), yc(0), xc(xMax), yc(0))
        g.DrawLine(bluePen, xc(0), yc(yMin), xc(0), yc(yMax))

        If (state = 1) Then
            Dim line As New lineParameters
            line = parameterPanel.Controls(0)
            m = line.slopeTextBox.Text
            b = line.bTextBox.Text
            'Draw Line
            stepCount = 0.001
            For j = -5 To 5 Step stepCount
                g.DrawLine(blackPen, xc(j), yc(lineEquation(j, m, b)), xc(j + stepCount), yc(lineEquation((j + stepCount), m, b)))
            Next
        ElseIf (state = 2) Then
            Dim quadStand As New quadStandardParameters
            quadStand = parameterPanel.Controls(0)
            a = quadStand.aTextBox.Text
            b = quadStand.bTextBox.Text
            c = quadStand.cTextBox.Text
            'Draw parabola
            stepCount = 0.001
            For j = -5 To 5 Step stepCount
                g.DrawLine(blackPen, xc(j), yc(quadraticStandard(j, a, b, c)), xc(j + stepCount), yc(quadraticStandard((j + stepCount), a, b, c)))
            Next
        ElseIf (state = 3) Then
            Dim quadVertex As New quadVertexParameters
            quadVertex = parameterPanel.Controls(0)
            a = quadVertex.aTextBox.Text
            h = quadVertex.hTextBox.Text
            k = quadVertex.kTextBox.Text

            'Draw parabola
            stepCount = 0.001
            For j = -5 To 5 Step stepCount
                g.DrawLine(blackPen, xc(j), yc(quadraticVertex(j, a, h, k)), xc(j + stepCount), yc(quadraticVertex((j + stepCount), a, h, k)))
            Next
        End If

        'Initial Point
        'g.FillEllipse(redBrush, xc(startVal) - 2, yc(startVal) - 2, 4, 4)
    End Sub

    'Converts x coords to the picture box
    Function xc(ByVal x As Double) As Integer
        Return Int(459 * (x - xMin) / (xMax - xMin))
    End Function

    'Converts y coords to the picture box
    Function yc(ByVal y As Double) As Integer
        Return Int(390 - 390 * (y - yMin) / (yMax - yMin))
    End Function
    'Equation of a line y=m*x+b
    Function lineEquation(ByVal x As Double, ByVal m As Double, ByVal b As Double) As Double
        Return m * x + b
    End Function
    'Quadratic Equation in standard form y=a*x^2+b*x+c
    Function quadraticStandard(ByVal x As Double, ByVal a As Double, ByVal b As Double, ByVal c As Double) As Double
        Return a * x ^ 2 + b * x + c
    End Function
    'Quadratic Equation in vertex form y=a*(x-h)^2+k.
    Function quadraticVertex(ByVal x As Double, ByVal a As Double, ByVal h As Double, ByVal k As Double) As Double
        Return a * (x - h) ^ 2 + k
    End Function

    Private Sub quadStandardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quadStandardButton.Click
        Dim quadStand As New quadStandardParameters
        state = 2
        Me.parameterPanel.Controls.Clear()
        Me.parameterPanel.Controls.Add(quadStand)
    End Sub

    Private Sub quadVertexButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quadVertexButton.Click
        Dim quadVertex As New quadVertexParameters
        state = 3
        Me.parameterPanel.Controls.Clear()
        Me.parameterPanel.Controls.Add(quadVertex)
    End Sub

    'Clear all the fields
    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        Dim g As Graphics
        Dim bluePen As New Pen(Color.Blue)
        g = functionDisplay.CreateGraphics
        g.Clear(Color.White)

        yMax = 10
        yMin = -5
        xMax = 5
        xMin = -5

        'Find out which fields to clear
        If (state = 1) Then
            Dim line As New lineParameters
            line = parameterPanel.Controls(0)

            line.slopeTextBox.Clear()
            line.bTextBox.Clear()
        ElseIf (state = 2) Then
            Dim quadStand As New quadStandardParameters
            quadStand = parameterPanel.Controls(0)

            quadStand.aTextBox.Clear()
            quadStand.bTextBox.Clear()
            quadStand.cTextBox.Clear()
        ElseIf (state = 3) Then
            Dim quadVertex As New quadVertexParameters
            quadVertex = parameterPanel.Controls(0)

            quadVertex.aTextBox.Clear()
            quadVertex.hTextBox.Clear()
            quadVertex.kTextBox.Clear()
        End If
        'Draw axis
        g.DrawLine(bluePen, xc(xMin), yc(0), xc(xMax), yc(0))
        g.DrawLine(bluePen, xc(0), yc(yMin), xc(0), yc(yMax))
    End Sub

    'Display the instructions form when the user clicks the label
    Private Sub instructionsLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instructionsLabel.Click
        FunctionInstructionsForm.Show()
    End Sub
End Class