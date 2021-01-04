<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizForm
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
        Me.quizPanel = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'quizPanel
        '
        Me.quizPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quizPanel.Location = New System.Drawing.Point(0, 0)
        Me.quizPanel.Name = "quizPanel"
        Me.quizPanel.Size = New System.Drawing.Size(524, 482)
        Me.quizPanel.TabIndex = 0
        '
        'QuizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 482)
        Me.Controls.Add(Me.quizPanel)
        Me.Name = "QuizForm"
        Me.Text = "QuizStartForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents quizPanel As System.Windows.Forms.Panel
End Class
