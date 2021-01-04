'Question 8
'If correct, increment the user's score
Public Class quizQuestion8

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton1.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q9 As New quizQuestion9
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q9)
    End Sub
End Class
