'Question 1
'If correct, increment the user's score
Public Class quizQuestion1
    'Go on to the next question and increment score. All all questions except 10 are the same
    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton3.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q2 As New quizQuestion2
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q2)
    End Sub
End Class
