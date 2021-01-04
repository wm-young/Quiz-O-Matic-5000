'Question 5
'If correct, increment the user's score
Public Class quizQuestion5

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton4.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q6 As New quizQuestion6
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q6)
    End Sub
End Class
