Public Class grade9_recall

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim LS As New lessonScreen
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(LS)
    End Sub

    Private Sub exponentReviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exponentReviewButton.Click
        Dim eR As New exponentReview
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(eR)
    End Sub
End Class
