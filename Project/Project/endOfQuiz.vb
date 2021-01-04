Public Class endOfQuiz

    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitButton.Click
        QuizForm.Close()
    End Sub

    Private Sub playAgainButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playAgainButton.Click
        Dim qStart As New quizStart
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(qStart)
    End Sub
End Class
