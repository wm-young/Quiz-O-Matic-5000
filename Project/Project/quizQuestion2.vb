'Question 2
'If correct, increment the user's score
Public Class quizQuestion2

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton2.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q3 As New quizQuestion3
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q3)
    End Sub
End Class
