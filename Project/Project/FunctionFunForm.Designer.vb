<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FunctionFunForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FunctionFunForm))
        Me.functionDisplay = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.clearButton = New System.Windows.Forms.Button
        Me.graphButton = New System.Windows.Forms.Button
        Me.parameterPanel = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lineButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.quadStandardButton = New System.Windows.Forms.Button
        Me.quadVertexButton = New System.Windows.Forms.Button
        Me.backButton = New System.Windows.Forms.Button
        Me.instructionsLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.functionDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'functionDisplay
        '
        Me.functionDisplay.BackColor = System.Drawing.Color.White
        Me.functionDisplay.Location = New System.Drawing.Point(272, 120)
        Me.functionDisplay.Name = "functionDisplay"
        Me.functionDisplay.Size = New System.Drawing.Size(459, 390)
        Me.functionDisplay.TabIndex = 0
        Me.functionDisplay.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(205, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(288, 55)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 450)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.clearButton)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.graphButton)
        Me.GroupBox3.Controls.Add(Me.parameterPanel)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 273)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parameters"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(94, 244)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'graphButton
        '
        Me.graphButton.Location = New System.Drawing.Point(7, 244)
        Me.graphButton.Name = "graphButton"
        Me.graphButton.Size = New System.Drawing.Size(75, 23)
        Me.graphButton.TabIndex = 2
        Me.graphButton.Text = "Graph"
        Me.graphButton.UseVisualStyleBackColor = True
        '
        'parameterPanel
        '
        Me.parameterPanel.Location = New System.Drawing.Point(6, 19)
        Me.parameterPanel.Name = "parameterPanel"
        Me.parameterPanel.Size = New System.Drawing.Size(229, 180)
        Me.parameterPanel.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SplitContainer1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 145)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Functions"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(11, 18)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lineButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.quadStandardButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.quadVertexButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(224, 121)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "y(x) = m*x + b"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Equation of a Line:"
        '
        'lineButton
        '
        Me.lineButton.Location = New System.Drawing.Point(6, 16)
        Me.lineButton.Name = "lineButton"
        Me.lineButton.Size = New System.Drawing.Size(66, 23)
        Me.lineButton.TabIndex = 0
        Me.lineButton.Text = "Line"
        Me.lineButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "y(x) = a(x-h)^2 + k"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quadratic Equation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "y(x) = a*x^2+b*x+c"
        '
        'quadStandardButton
        '
        Me.quadStandardButton.Location = New System.Drawing.Point(6, 16)
        Me.quadStandardButton.Name = "quadStandardButton"
        Me.quadStandardButton.Size = New System.Drawing.Size(110, 23)
        Me.quadStandardButton.TabIndex = 1
        Me.quadStandardButton.Text = "Standard Form"
        Me.quadStandardButton.UseVisualStyleBackColor = True
        '
        'quadVertexButton
        '
        Me.quadVertexButton.Location = New System.Drawing.Point(6, 45)
        Me.quadVertexButton.Name = "quadVertexButton"
        Me.quadVertexButton.Size = New System.Drawing.Size(110, 23)
        Me.quadVertexButton.TabIndex = 2
        Me.quadVertexButton.Text = "Vertex Form"
        Me.quadVertexButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.Gold
        Me.backButton.Location = New System.Drawing.Point(584, 516)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(147, 58)
        Me.backButton.TabIndex = 3
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'instructionsLabel
        '
        Me.instructionsLabel.AutoSize = True
        Me.instructionsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.instructionsLabel.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionsLabel.ForeColor = System.Drawing.Color.Blue
        Me.instructionsLabel.Location = New System.Drawing.Point(273, 516)
        Me.instructionsLabel.Name = "instructionsLabel"
        Me.instructionsLabel.Size = New System.Drawing.Size(106, 23)
        Me.instructionsLabel.TabIndex = 4
        Me.instructionsLabel.Text = "Instructions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Domain: {-5<= X <= 5}"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(124, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Range: {-5 <= Y <=10}"
        '
        'FunctionFunForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(734, 582)
        Me.Controls.Add(Me.instructionsLabel)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.functionDisplay)
        Me.Name = "FunctionFunForm"
        Me.Text = "FunctionFunForm"
        CType(Me.functionDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents functionDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents parameterPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents quadStandardButton As System.Windows.Forms.Button
    Friend WithEvents lineButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents quadVertexButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents graphButton As System.Windows.Forms.Button
    Friend WithEvents instructionsLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
