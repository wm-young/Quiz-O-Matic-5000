Public Class grade10_recall

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim LS As New lessonScreen
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(LS)
    End Sub
End Class
