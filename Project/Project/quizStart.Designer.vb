<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quizStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quizStart))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.quizStartButton = New System.Windows.Forms.Button
        Me.quizInstructionsButton = New System.Windows.Forms.Button
        Me.quitButton = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 88)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'quizStartButton
        '
        Me.quizStartButton.BackColor = System.Drawing.Color.Goldenrod
        Me.quizStartButton.BackgroundImage = CType(resources.GetObject("quizStartButton.BackgroundImage"), System.Drawing.Image)
        Me.quizStartButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.quizStartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.quizStartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.quizStartButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quizStartButton.ForeColor = System.Drawing.Color.Gold
        Me.quizStartButton.Location = New System.Drawing.Point(191, 172)
        Me.quizStartButton.Name = "quizStartButton"
        Me.quizStartButton.Size = New System.Drawing.Size(147, 58)
        Me.quizStartButton.TabIndex = 4
        Me.quizStartButton.Text = "Start"
        Me.quizStartButton.UseVisualStyleBackColor = False
        '
        'quizInstructionsButton
        '
        Me.quizInstructionsButton.BackColor = System.Drawing.Color.Goldenrod
        Me.quizInstructionsButton.BackgroundImage = CType(resources.GetObject("quizInstructionsButton.BackgroundImage"), System.Drawing.Image)
        Me.quizInstructionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.quizInstructionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.quizInstructionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.quizInstructionsButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quizInstructionsButton.ForeColor = System.Drawing.Color.Gold
        Me.quizInstructionsButton.Location = New System.Drawing.Point(191, 257)
        Me.quizInstructionsButton.Name = "quizInstructionsButton"
        Me.quizInstructionsButton.Size = New System.Drawing.Size(147, 58)
        Me.quizInstructionsButton.TabIndex = 5
        Me.quizInstructionsButton.Text = "Instructions"
        Me.quizInstructionsButton.UseVisualStyleBackColor = False
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
        Me.quitButton.Location = New System.Drawing.Point(191, 345)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(147, 58)
        Me.quitButton.TabIndex = 6
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'quizStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.quizInstructionsButton)
        Me.Controls.Add(Me.quizStartButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "quizStart"
        Me.Size = New System.Drawing.Size(524, 482)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents quizStartButton As System.Windows.Forms.Button
    Friend WithEvents quizInstructionsButton As System.Windows.Forms.Button
    Friend WithEvents quitButton As System.Windows.Forms.Button

End Class
