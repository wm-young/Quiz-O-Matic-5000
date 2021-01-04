<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.StartButton = New System.Windows.Forms.Button
        Me.InstructionButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.function_funButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Goldenrod
        Me.StartButton.BackgroundImage = CType(resources.GetObject("StartButton.BackgroundImage"), System.Drawing.Image)
        Me.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.Gold
        Me.StartButton.Location = New System.Drawing.Point(189, 217)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(147, 58)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Quiz"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'InstructionButton
        '
        Me.InstructionButton.BackColor = System.Drawing.Color.Transparent
        Me.InstructionButton.BackgroundImage = CType(resources.GetObject("InstructionButton.BackgroundImage"), System.Drawing.Image)
        Me.InstructionButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.InstructionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.InstructionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.InstructionButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionButton.ForeColor = System.Drawing.Color.Gold
        Me.InstructionButton.Location = New System.Drawing.Point(189, 281)
        Me.InstructionButton.Name = "InstructionButton"
        Me.InstructionButton.Size = New System.Drawing.Size(147, 58)
        Me.InstructionButton.TabIndex = 4
        Me.InstructionButton.Text = "Lessons"
        Me.InstructionButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.Transparent
        Me.QuitButton.BackgroundImage = CType(resources.GetObject("QuitButton.BackgroundImage"), System.Drawing.Image)
        Me.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.QuitButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.ForeColor = System.Drawing.Color.Gold
        Me.QuitButton.Location = New System.Drawing.Point(189, 409)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(147, 58)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'function_funButton
        '
        Me.function_funButton.BackColor = System.Drawing.Color.Transparent
        Me.function_funButton.BackgroundImage = CType(resources.GetObject("function_funButton.BackgroundImage"), System.Drawing.Image)
        Me.function_funButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.function_funButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.function_funButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.function_funButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.function_funButton.ForeColor = System.Drawing.Color.Gold
        Me.function_funButton.Location = New System.Drawing.Point(189, 345)
        Me.function_funButton.Name = "function_funButton"
        Me.function_funButton.Size = New System.Drawing.Size(147, 58)
        Me.function_funButton.TabIndex = 6
        Me.function_funButton.Text = "Function Fun"
        Me.function_funButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 186)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 482)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.function_funButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.InstructionButton)
        Me.Controls.Add(Me.StartButton)
        Me.Name = "StartForm"
        Me.Text = "Learning Object - Grade 9 Mathematics"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents InstructionButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents function_funButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
