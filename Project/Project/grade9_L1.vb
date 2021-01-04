Public Class grade9_L1

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim LS As New lessonScreen
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(LS)
    End Sub

    Private Sub expandEquationsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expandEquationsButton.Click
        Dim expE As New expandEquations
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(expE)
    End Sub
End Class
