'The lesson screen is where the user can choose which lessons he or she
' wnats to learn more about. 
Public Class lessonScreen

    Private Sub grade9_lesson1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade9_lesson1Button.Click
        Dim L1 As New grade9_L1
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(L1)
    End Sub

    Private Sub grade9_lesson2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade9_lesson2Button.Click
        Dim L2 As New grade9_L2
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(L2)
    End Sub

    Private Sub grade10_lesson1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade10_lesson1Button.Click
        Dim L1 As New grade10_L1
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(L1)
    End Sub


    Private Sub grade10_lesson2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade10_lesson2Button.Click
        Dim L2 As New grade10_L2
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(L2)
    End Sub


    Private Sub grade9_recallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade9_recallButton.Click
        Dim recall As New grade9_recall
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(recall)
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        LessonsForm.Close()
    End Sub

    Private Sub grade10_recallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grade10_recallButton.Click
        Dim recall As New grade10_recall
        LessonsForm.lessonsPanel.Controls.Clear()
        LessonsForm.lessonsPanel.Controls.Add(recall)
    End Sub
End Class
