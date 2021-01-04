Public Class grade9_L2

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim LS As New lessonScreen
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(LS)
    End Sub

    Private Sub equationOfLineContButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equationOfLineContButton.Click
        Dim L2_C As New grade9_L2_Cont
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(L2_C)
    End Sub
End Class
