Public Class grade10_L1

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim LS As New lessonScreen
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(LS)
    End Sub

    Private Sub quadVertexFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quadVertexFormButton.Click
        Dim quadVertex As New grade10_L1_Cont
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(quadVertex)
    End Sub
End Class
