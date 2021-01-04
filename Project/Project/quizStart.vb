Public Class quizStart

    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitButton.Click
        QuizForm.Close()
    End Sub

    Private Sub quizInstructionsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quizInstructionsButton.Click
        Dim QI As New quizInstructionsForm
        QI.Show()
    End Sub

    Private Sub quizStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quizStartButton.Click
        Dim q1 As New quizQuestion1
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q1)
    End Sub
End Class
