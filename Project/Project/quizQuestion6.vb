'Question 6
'If correct, increment the user's score
Public Class quizQuestion6

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton1.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q7 As New quizQuestion7
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q7)
    End Sub
End Class
