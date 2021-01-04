'Question 3
'If correct, increment the user's score
Public Class quizQuestion3

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton1.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q4 As New quizQuestion4
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q4)
    End Sub
End Class
