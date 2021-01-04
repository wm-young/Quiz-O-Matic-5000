'Question 9
'If correct, increment the user's score
Public Class quizQuestion9

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton2.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q10 As New quizQuestion10
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q10)
    End Sub
End Class
