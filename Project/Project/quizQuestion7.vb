'Question 7
'If correct, increment the user's score
Public Class quizQuestion7

    Private Sub question2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles question2Button.Click
        If (RadioButton3.Checked) Then
            QuizForm.incrementScore()
        End If
        Dim q8 As New quizQuestion8
        QuizForm.quizPanel.Controls.Clear()
        QuizForm.quizPanel.Controls.Add(q8)
    End Sub
End Class
