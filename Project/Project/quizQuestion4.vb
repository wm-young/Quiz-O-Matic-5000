'Question 4
'If correct, increment the user's score
Public Class quizQuestion4

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton2.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q5 As New quizQuestion5
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q5)
    End Sub
End Class
