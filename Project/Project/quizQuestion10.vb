Public Class quizQuestion10

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton3.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim bonus As New quizBonusQuestion
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(bonus)
    End Sub
End Class
