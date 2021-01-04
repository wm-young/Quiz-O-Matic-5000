'Bonus question I decided to add in. If the user got it right
'the score is incremented again so it's possible to get 11/10 now.
Public Class quizBonusQuestion

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        MessageBox.Show("It's a forest moon. :)")
    End Sub

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton3.Checked) Then
            QuizForm.incrementScore()
            Dim ewokPic As New ewokWin
        End If
        Dim endQuiz As New endOfQuiz
        Dim score
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(endQuiz)
        score = QuizForm.getScore
        endQuiz.scoreLabel.Text = score
        'Check to see which picture to display
        If (RadioButton3.Checked) Then
            Dim ewokPic As New ewokWin
            endQuiz.outputPanel.Controls.Add(ewokPic)
        Else
            Dim normalPic As New normalWin
            endQuiz.outputPanel.Controls.Add(normalPic)
        End If

        'Different output depending on score
        If (score >= 10) Then
            endQuiz.commentLabel.Text = "out of 10   :) WOW great work! "
        End If
        If (score > 6 And score < 10) Then
            endQuiz.commentLabel.Text = "out of 10   :) Nice work!"
        ElseIf (score > 3 And score < 7) Then
            endQuiz.commentLabel.Text = "out of 10   :| Not bad, keep practicing."
        ElseIf (score < 4) Then
            endQuiz.commentLabel.Text = "out of 10   :( Perhaps review the material again."
        End If

        QuizForm.resetScore()
    End Sub

End Class
