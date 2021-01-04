<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grade10_L1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grade10_L1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.backButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.quadVertexFormButton = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 87)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'backButton
        '
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.Gold
        Me.backButton.Location = New System.Drawing.Point(374, 421)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(147, 58)
        Me.backButton.TabIndex = 3
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Properties of Quadratic Relations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(478, 288)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'quadVertexFormButton
        '
        Me.quadVertexFormButton.BackgroundImage = CType(resources.GetObject("quadVertexFormButton.BackgroundImage"), System.Drawing.Image)
        Me.quadVertexFormButton.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quadVertexFormButton.ForeColor = System.Drawing.Color.Gold
        Me.quadVertexFormButton.Location = New System.Drawing.Point(28, 417)
        Me.quadVertexFormButton.Name = "quadVertexFormButton"
        Me.quadVertexFormButton.Size = New System.Drawing.Size(147, 58)
        Me.quadVertexFormButton.TabIndex = 6
        Me.quadVertexFormButton.Text = "Vertex Form"
        Me.quadVertexFormButton.UseVisualStyleBackColor = True
        '
        'grade10_L1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.Controls.Add(Me.quadVertexFormButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "grade10_L1"
        Me.Size = New System.Drawing.Size(524, 482)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents quadVertexFormButton As System.Windows.Forms.Button

End Class
