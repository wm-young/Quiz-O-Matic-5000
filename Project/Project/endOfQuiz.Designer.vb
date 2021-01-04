<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class endOfQuiz
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(endOfQuiz))
        Me.Label1 = New System.Windows.Forms.Label
        Me.scoreLabel = New System.Windows.Forms.Label
        Me.playAgainButton = New System.Windows.Forms.Button
        Me.quitButton = New System.Windows.Forms.Button
        Me.commentLabel = New System.Windows.Forms.Label
        Me.outputPanel = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "You're score was"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.ForeColor = System.Drawing.Color.Fuchsia
        Me.scoreLabel.Location = New System.Drawing.Point(176, 322)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(8, 16)
        Me.scoreLabel.TabIndex = 2
        Me.scoreLabel.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'playAgainButton
        '
        Me.playAgainButton.BackColor = System.Drawing.Color.Goldenrod
        Me.playAgainButton.BackgroundImage = CType(resources.GetObject("playAgainButton.BackgroundImage"), System.Drawing.Image)
        Me.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.playAgainButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playAgainButton.ForeColor = System.Drawing.Color.Gold
        Me.playAgainButton.Location = New System.Drawing.Point(161, 352)
        Me.playAgainButton.Name = "playAgainButton"
        Me.playAgainButton.Size = New System.Drawing.Size(147, 58)
        Me.playAgainButton.TabIndex = 4
        Me.playAgainButton.Text = "Play Again"
        Me.playAgainButton.UseVisualStyleBackColor = False
        '
        'quitButton
        '
        Me.quitButton.BackColor = System.Drawing.Color.Goldenrod
        Me.quitButton.BackgroundImage = CType(resources.GetObject("quitButton.BackgroundImage"), System.Drawing.Image)
        Me.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.quitButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitButton.ForeColor = System.Drawing.Color.Gold
        Me.quitButton.Location = New System.Drawing.Point(161, 416)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(147, 58)
        Me.quitButton.TabIndex = 5
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'commentLabel
        '
        Me.commentLabel.AutoSize = True
        Me.commentLabel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentLabel.Location = New System.Drawing.Point(202, 322)
        Me.commentLabel.Name = "commentLabel"
        Me.commentLabel.Size = New System.Drawing.Size(8, 16)
        Me.commentLabel.TabIndex = 6
        Me.commentLabel.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'outputPanel
        '
        Me.outputPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.outputPanel.Location = New System.Drawing.Point(130, 3)
        Me.outputPanel.Name = "outputPanel"
        Me.outputPanel.Size = New System.Drawing.Size(258, 297)
        Me.outputPanel.TabIndex = 7
        '
        'endOfQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.Controls.Add(Me.outputPanel)
        Me.Controls.Add(Me.commentLabel)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.playAgainButton)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "endOfQuiz"
        Me.Size = New System.Drawing.Size(524, 482)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents playAgainButton As System.Windows.Forms.Button
    Friend WithEvents quitButton As System.Windows.Forms.Button
    Friend WithEvents commentLabel As System.Windows.Forms.Label
    Friend WithEvents outputPanel As System.Windows.Forms.Panel

End Class
