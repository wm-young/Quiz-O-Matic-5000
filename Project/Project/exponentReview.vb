Public Class exponentReview

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim recall As New grade9_recall
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(recall)
    End Sub
End Class
