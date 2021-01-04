'This form handles keeping track of the score and displaying the final score
' at the end of the quiz
Public Class QuizForm
    Dim score As Integer

    Public Sub incrementScore()
        score = score + 1
    End Sub

    Private Sub QuizForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        score = 0
    End Sub

    Function getScore()
        Return score
    End Function

    Public Sub resetScore()
        score = 0
    End Sub
End Class