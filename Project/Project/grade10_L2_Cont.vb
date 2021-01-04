Public Class grade10_L2_Cont

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        Dim L2 As New grade10_L2
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(L2)
    End Sub
End Class
