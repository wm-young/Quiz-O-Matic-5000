<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grade9_recall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grade9_recall))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.backButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.exponentReviewButton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(193, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 84)
        Me.PictureBox1.TabIndex = 0
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
        Me.backButton.TabIndex = 1
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Functions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(503, 304)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(226, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*Note - y(x) is the general notation used to describe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a function that takes in a" & _
            "ny x value. "
        '
        'exponentReviewButton
        '
        Me.exponentReviewButton.BackgroundImage = CType(resources.GetObject("exponentReviewButton.BackgroundImage"), System.Drawing.Image)
        Me.exponentReviewButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exponentReviewButton.ForeColor = System.Drawing.Color.Gold
        Me.exponentReviewButton.Location = New System.Drawing.Point(17, 439)
        Me.exponentReviewButton.Name = "exponentReviewButton"
        Me.exponentReviewButton.Size = New System.Drawing.Size(190, 58)
        Me.exponentReviewButton.TabIndex = 5
        Me.exponentReviewButton.Text = "Exponent Review"
        Me.exponentReviewButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(358, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'grade9_recall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exponentReviewButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "grade9_recall"
        Me.Size = New System.Drawing.Size(550, 500)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exponentReviewButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
