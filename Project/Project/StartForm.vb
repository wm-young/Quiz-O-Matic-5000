'This form displays the opening quiz screen where the user
' is prompted to make a selection in the menu.
Public Class StartForm


    Private Sub QuitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        Dim qStart As New quizStart
        QuizForm.quizPanel.Controls.Add(qStart)
        QuizForm.Show()
    End Sub

    Private Sub InstructionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionButton.Click
        Dim lessonStart As New lessonScreen
        LessonsForm.lessonsPanel.Controls.Add(lessonStart)
        LessonsForm.Show()
    End Sub

    Private Sub function_funButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles function_funButton.Click
        FunctionFunForm.Show()
    End Sub
End Class
