<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lessonScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lessonScreen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grade10_lesson2Button = New System.Windows.Forms.Button
        Me.grade10_lesson1Button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grade9_recallButton = New System.Windows.Forms.Button
        Me.grade9_lesson1Button = New System.Windows.Forms.Button
        Me.grade9_lesson2Button = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.backButton = New System.Windows.Forms.Button
        Me.grade10_recallButton = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 112)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grade10_recallButton)
        Me.GroupBox2.Controls.Add(Me.grade10_lesson2Button)
        Me.GroupBox2.Controls.Add(Me.grade10_lesson1Button)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(283, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 269)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grade 10"
        '
        'grade10_lesson2Button
        '
        Me.grade10_lesson2Button.BackgroundImage = CType(resources.GetObject("grade10_lesson2Button.BackgroundImage"), System.Drawing.Image)
        Me.grade10_lesson2Button.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade10_lesson2Button.ForeColor = System.Drawing.Color.Gold
        Me.grade10_lesson2Button.Location = New System.Drawing.Point(49, 183)
        Me.grade10_lesson2Button.Name = "grade10_lesson2Button"
        Me.grade10_lesson2Button.Size = New System.Drawing.Size(163, 67)
        Me.grade10_lesson2Button.TabIndex = 5
        Me.grade10_lesson2Button.Text = "Lesson 2: Solving Quadratic Equations"
        Me.grade10_lesson2Button.UseVisualStyleBackColor = True
        '
        'grade10_lesson1Button
        '
        Me.grade10_lesson1Button.BackgroundImage = CType(resources.GetObject("grade10_lesson1Button.BackgroundImage"), System.Drawing.Image)
        Me.grade10_lesson1Button.ForeColor = System.Drawing.Color.Gold
        Me.grade10_lesson1Button.Location = New System.Drawing.Point(49, 110)
        Me.grade10_lesson1Button.Name = "grade10_lesson1Button"
        Me.grade10_lesson1Button.Size = New System.Drawing.Size(163, 67)
        Me.grade10_lesson1Button.TabIndex = 5
        Me.grade10_lesson1Button.Text = "Lesson1: Properties of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quadratic Relations"
        Me.grade10_lesson1Button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grade9_recallButton)
        Me.GroupBox1.Controls.Add(Me.grade9_lesson1Button)
        Me.GroupBox1.Controls.Add(Me.grade9_lesson2Button)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(19, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 269)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade 9"
        '
        'grade9_recallButton
        '
        Me.grade9_recallButton.BackgroundImage = CType(resources.GetObject("grade9_recallButton.BackgroundImage"), System.Drawing.Image)
        Me.grade9_recallButton.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade9_recallButton.ForeColor = System.Drawing.Color.Gold
        Me.grade9_recallButton.Location = New System.Drawing.Point(54, 37)
        Me.grade9_recallButton.Name = "grade9_recallButton"
        Me.grade9_recallButton.Size = New System.Drawing.Size(163, 67)
        Me.grade9_recallButton.TabIndex = 4
        Me.grade9_recallButton.Text = "Recall"
        Me.grade9_recallButton.UseVisualStyleBackColor = True
        '
        'grade9_lesson1Button
        '
        Me.grade9_lesson1Button.BackgroundImage = CType(resources.GetObject("grade9_lesson1Button.BackgroundImage"), System.Drawing.Image)
        Me.grade9_lesson1Button.ForeColor = System.Drawing.Color.Gold
        Me.grade9_lesson1Button.Location = New System.Drawing.Point(54, 110)
        Me.grade9_lesson1Button.Name = "grade9_lesson1Button"
        Me.grade9_lesson1Button.Size = New System.Drawing.Size(163, 67)
        Me.grade9_lesson1Button.TabIndex = 3
        Me.grade9_lesson1Button.Text = "Lesson1: Expressions and Equations"
        Me.grade9_lesson1Button.UseVisualStyleBackColor = True
        '
        'grade9_lesson2Button
        '
        Me.grade9_lesson2Button.BackgroundImage = CType(resources.GetObject("grade9_lesson2Button.BackgroundImage"), System.Drawing.Image)
        Me.grade9_lesson2Button.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade9_lesson2Button.ForeColor = System.Drawing.Color.Gold
        Me.grade9_lesson2Button.Location = New System.Drawing.Point(54, 183)
        Me.grade9_lesson2Button.Name = "grade9_lesson2Button"
        Me.grade9_lesson2Button.Size = New System.Drawing.Size(163, 67)
        Me.grade9_lesson2Button.TabIndex = 2
        Me.grade9_lesson2Button.Text = "Lesson 2: Equation of a Line"
        Me.grade9_lesson2Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(191, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 65)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'backButton
        '
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.Gold
        Me.backButton.Location = New System.Drawing.Point(400, 439)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(147, 58)
        Me.backButton.TabIndex = 13
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'grade10_recallButton
        '
        Me.grade10_recallButton.BackgroundImage = CType(resources.GetObject("grade10_recallButton.BackgroundImage"), System.Drawing.Image)
        Me.grade10_recallButton.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade10_recallButton.ForeColor = System.Drawing.Color.Gold
        Me.grade10_recallButton.Location = New System.Drawing.Point(49, 37)
        Me.grade10_recallButton.Name = "grade10_recallButton"
        Me.grade10_recallButton.Size = New System.Drawing.Size(163, 67)
        Me.grade10_recallButton.TabIndex = 5
        Me.grade10_recallButton.Text = "Recall"
        Me.grade10_recallButton.UseVisualStyleBackColor = True
        '
        'lessonScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "lessonScreen"
        Me.Size = New System.Drawing.Size(550, 500)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grade9_lesson1Button As System.Windows.Forms.Button
    Friend WithEvents grade9_lesson2Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grade9_recallButton As System.Windows.Forms.Button
    Friend WithEvents grade10_lesson1Button As System.Windows.Forms.Button
    Friend WithEvents grade10_lesson2Button As System.Windows.Forms.Button
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents grade10_recallButton As System.Windows.Forms.Button

End Class
